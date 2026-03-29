#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

curl -o openapi.yaml \
  https://raw.githubusercontent.com/algolia/api-clients-automation/main/specs/bundled/search.yml

# Fix auth: Algolia uses dual apiKey headers (x-algolia-application-id + x-algolia-api-key).
# Replace with http/bearer for constructor generation; we'll set the actual headers
# in an Authorized partial hook at runtime.
# Also replace templated server URL {appId}.algolia.net with a placeholder base URL
# (users set the real base URL with their application ID at runtime).
yq -i '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}] |
  .servers = [{"url": "https://ALGOLIA_APPLICATION_ID.algolia.net"}]
' openapi.yaml

# Fix browseParamsObject → browseParamsConfig to avoid C# naming collision:
# The oneOf union generates a property named "Object" (from browseParamsObject)
# which collides with the auto-generated "object? Object" getter in the union struct.
sed -i '' 's/browseParamsObject/browseParamsConfig/g' openapi.yaml

# Fix searchForFacetsOptions/searchForHitsOptions → *Settings to avoid C# naming collision:
# The allOf union generates local variables named "options" which shadow the
# JsonSerializerOptions method parameter in generated JsonConverter code.
sed -i '' 's/searchForFacetsOptions/searchForFacetsSettings/g' openapi.yaml
sed -i '' 's/searchForHitsOptions/searchForHitsSettings/g' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Algolia \
  --clientClassName AlgoliaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# --- Recommend API ---
curl -o recommend-openapi.yaml \
  https://raw.githubusercontent.com/algolia/api-clients-automation/main/specs/bundled/recommend.yml

# Fix auth: same dual-header auth as Search API
yq -i '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}] |
  .servers = [{"url": "https://ALGOLIA_APPLICATION_ID.algolia.net"}]
' recommend-openapi.yaml

# Generate Recommend client in sub-namespace with its own models.
# The Recommend spec shares ~127 schemas with the Search spec; the unique Recommend
# schemas (~44) require full model generation in the Recommend namespace.
autosdk generate recommend-openapi.yaml \
  --namespace Algolia.Recommend \
  --clientClassName AlgoliaRecommendClient \
  --targetFramework net10.0 \
  --output Generated/Recommend \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --json-serializer-context RecommendSourceGenerationContext

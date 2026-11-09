#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection

rm -rf Generated

fetch_spec -o openapi.yaml \
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

# Portable sed -i (GNU vs BSD differ in -i syntax)
sed_inplace() { if sed --version >/dev/null 2>&1; then sed -i "$@"; else sed -i '' "$@"; fi; }

# Fix browseParamsObject → browseParamsConfig to avoid C# naming collision:
# The oneOf union generates a property named "Object" (from browseParamsObject)
# which collides with the auto-generated "object? Object" getter in the union struct.
sed_inplace 's/browseParamsObject/browseParamsConfig/g' openapi.yaml

# Fix searchForFacetsOptions/searchForHitsOptions → *Settings to avoid C# naming collision:
# The allOf union generates local variables named "options" which shadow the
# JsonSerializerOptions method parameter in generated JsonConverter code.
sed_inplace 's/searchForFacetsOptions/searchForFacetsSettings/g' openapi.yaml
sed_inplace 's/searchForHitsOptions/searchForHitsSettings/g' openapi.yaml

# Fix operation parameters named requestOptions colliding with AutoSDKRequestOptions.
sed_inplace 's/name: requestOptions/name: algoliaRequestOptions/g' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Algolia \
  --clientClassName AlgoliaClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# --- Recommend API ---
fetch_spec -o recommend-openapi.yaml \
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
  --reject-unknown-enum-values \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --json-serializer-context RecommendSourceGenerationContext

rm -rf ../../cli/Algolia.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Algolia.CLI \
  --sdk-project ../../libs/Algolia/Algolia.csproj \
  --targetFramework net10.0 \
  --namespace Algolia \
  --clientClassName AlgoliaClient \
  --package-id Algolia.CLI \
  --tool-command-name algolia \
  --user-secrets-id Algolia.CLI \
  --api-key-env-var ALGOLIA_API_KEY \
  --base-url-env-var ALGOLIA_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

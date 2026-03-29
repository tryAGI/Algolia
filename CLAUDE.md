# CLAUDE.md -- Algolia SDK

## Overview

Auto-generated C# SDK for [Algolia](https://www.algolia.com/) -- AI-powered search, recommendations, and analytics platform. Covers the full Search API (78 endpoints) and Recommend API (11 endpoints) including search, browse, indices, records, rules, synonyms, API keys, dictionary management, and AI-powered recommendations (frequently bought together, related products, trending items, looking similar).

## Build & Test

```bash
dotnet build Algolia.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Algolia uses dual-header auth (`x-algolia-application-id` + `x-algolia-api-key`):

```csharp
// Search API
using var client = new AlgoliaClient(apiKey);
client.WithApplicationId(applicationId);

// Recommend API
using var recommendClient = new Algolia.Recommend.AlgoliaRecommendClient(apiKey);
recommendClient.WithApplicationId(applicationId);
```

**How it works:**
- `--security-scheme Http:Header:Bearer` generates the constructor with `apiKey` parameter
- `Authorized` partial hook captures the API key from Bearer auth
- `PrepareRequest` partial hook removes the Bearer Authorization header and adds Algolia-specific `x-algolia-application-id` and `x-algolia-api-key` headers on every request
- `WithApplicationId()` also updates the base URL to `https://{applicationId}.algolia.net`
- Both `AlgoliaClient` and `AlgoliaRecommendClient` use the same auth pattern

## Key Files

- `src/libs/Algolia/openapi.yaml` -- Downloaded from Algolia's `api-clients-automation` repo (bundled search spec)
- `src/libs/Algolia/recommend-openapi.yaml` -- Downloaded from Algolia's `api-clients-automation` repo (bundled recommend spec)
- `src/libs/Algolia/generate.sh` -- Regeneration script with auth/spec fixes for both Search and Recommend APIs
- `src/libs/Algolia/Generated/` -- **Never edit** -- auto-generated Search API code
- `src/libs/Algolia/Generated/Recommend/` -- **Never edit** -- auto-generated Recommend API code
- `src/libs/Algolia/Extensions/AlgoliaClient.Auth.cs` -- Dual-header auth hook for Search client (`WithApplicationId()` + `PrepareRequest`)
- `src/libs/Algolia/Extensions/AlgoliaClient.Tools.cs` -- Search MEAI AIFunction tools (AsSearchTool, AsGetObjectTool, AsListIndicesTool, AsBrowseTool)
- `src/libs/Algolia/Extensions/AlgoliaRecommendClient.Auth.cs` -- Dual-header auth hook for Recommend client (`WithApplicationId()` + `PrepareRequest`)
- `src/libs/Algolia/Extensions/AlgoliaRecommendClient.Tools.cs` -- Recommend MEAI AIFunction tools (AsFrequentlyBoughtTogetherTool, AsRelatedProductsTool, AsTrendingItemsTool, AsLookingSimilarTool)
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Architecture

The SDK generates two clients from two separate OpenAPI specs:

1. **Search API** (`Algolia` namespace): `AlgoliaClient` with `client.Search.*` sub-client accessor
2. **Recommend API** (`Algolia.Recommend` namespace): `AlgoliaRecommendClient` with `client.Recommend.*` sub-client accessor

The Recommend spec shares ~127 schemas with the Search spec. They are generated as separate namespaces with their own models to avoid cross-namespace complications. The `--json-serializer-context RecommendSourceGenerationContext` option ensures the Recommend client has its own serialization context.

## Spec Notes

The `generate.sh` applies these fixes:

**Search API:**
1. **Auth conversion:** `yq` replaces Algolia's dual `apiKey` security schemes with `http/bearer`
2. **Server URL:** Replaces templated `{appId}.algolia.net` with a placeholder (users set the real URL via `WithApplicationId()`)
3. **browseParamsObject rename:** `sed` renames to `browseParamsConfig` to avoid C# property name collision (`Object` vs `object? Object`)
4. **searchForFacetsOptions/searchForHitsOptions rename:** `sed` renames to `*Settings` to avoid C# local variable `options` shadowing the `JsonSerializerOptions` method parameter

**Recommend API:**
1. **Auth conversion:** Same `yq` fix as Search API
2. **Server URL:** Same placeholder as Search API

## Endpoints

### Search API (78 endpoints)

Organized via sub-client accessor `client.Search.*`:

| Category | Examples |
|----------|----------|
| Search | `SearchSingleIndexAsync`, `SearchAsync`, `SearchForFacetValuesAsync`, `BrowseAsync` |
| Records | `GetObjectAsync`, `GetObjectsAsync`, `AddOrUpdateObjectAsync`, `DeleteObjectAsync`, `BatchAsync` |
| Indices | `ListIndicesAsync`, `DeleteIndexAsync`, `OperationIndexAsync`, `GetSettingsAsync`, `SetSettingsAsync` |
| Rules | `GetRuleAsync`, `SaveRuleAsync`, `SaveRulesAsync`, `SearchRulesAsync`, `ClearRulesAsync`, `DeleteRuleAsync` |
| Synonyms | `GetSynonymAsync`, `SaveSynonymAsync`, `SearchSynonymsAsync`, `ClearSynonymsAsync` |
| API Keys | `ListApiKeysAsync`, `AddApiKeyAsync`, `GetApiKeyAsync`, `UpdateApiKeyAsync`, `DeleteApiKeyAsync` |
| Dictionary | `BatchDictionaryEntriesAsync`, `SearchDictionaryEntriesAsync`, `GetDictionaryLanguagesAsync` |

### Recommend API (11 endpoints)

Organized via sub-client accessor `client.Recommend.*`:

| Category | Examples |
|----------|----------|
| Recommendations | `GetRecommendationsAsync` (supports: Frequently Bought Together, Related Products, Trending Items, Trending Facets, Looking Similar) |
| Rules | `GetRecommendRuleAsync`, `DeleteRecommendRuleAsync`, `SearchRecommendRulesAsync`, `BatchRecommendRulesAsync` |
| Status | `GetRecommendStatusAsync` |

## MEAI Integration

- **Interface:** `AIFunction` tools (no standard MEAI interface like IChatClient/IEmbeddingGenerator)

**Search tools:**
- `AsSearchTool()`, `AsGetObjectTool()`, `AsListIndicesTool()`, `AsBrowseTool()`

**Recommend tools:**
- `AsFrequentlyBoughtTogetherTool()` -- Get products frequently bought with a given item
- `AsRelatedProductsTool()` -- Get products similar to a given item
- `AsTrendingItemsTool()` -- Get currently trending items (no objectID required)
- `AsLookingSimilarTool()` -- Get visually similar items based on image attributes

**Usage:** Pass tools to any `IChatClient` via `ChatOptions.Tools`

## Known Issues

- **Deeply nested allOf union types:** The Algolia spec uses extensive `allOf` composition, producing deeply nested union structs in generated code (e.g., `SearchParamsObject` = allOf(`BaseSearchParams`, `IndexSettingsAsSearchParams`), where `BaseSearchParams` = allOf(`SearchParamsQuery`, `BaseSearchParamsWithoutQuery`)). The MEAI tools use `SearchParamsString` (query string format) as a pragmatic workaround.
- **Recommend query union types:** Some Recommend query types (e.g., `TrendingItemsQuery`, `LookingSimilarQuery`) use generic `Value1`/`Value2` parameter names instead of descriptive names due to allOf composition.

# CLAUDE.md -- Algolia SDK

## Overview

Auto-generated C# SDK for [Algolia](https://www.algolia.com/) -- AI-powered search, recommendations, and analytics platform. Covers the full Search API (78 endpoints) including search, browse, indices, records, rules, synonyms, API keys, and dictionary management.

## Build & Test

```bash
dotnet build Algolia.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Algolia uses dual-header auth (`x-algolia-application-id` + `x-algolia-api-key`):

```csharp
using var client = new AlgoliaClient(apiKey);
client.WithApplicationId(applicationId);
```

**How it works:**
- `--security-scheme Http:Header:Bearer` generates the constructor with `apiKey` parameter
- `Authorized` partial hook captures the API key from Bearer auth
- `PrepareRequest` partial hook removes the Bearer Authorization header and adds Algolia-specific `x-algolia-application-id` and `x-algolia-api-key` headers on every request
- `WithApplicationId()` also updates the base URL to `https://{applicationId}.algolia.net`

## Key Files

- `src/libs/Algolia/openapi.yaml` -- Downloaded from Algolia's `api-clients-automation` repo (bundled search spec)
- `src/libs/Algolia/generate.sh` -- Regeneration script with auth/spec fixes
- `src/libs/Algolia/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Algolia/Extensions/AlgoliaClient.Auth.cs` -- Dual-header auth hook (`WithApplicationId()` + `PrepareRequest`)
- `src/libs/Algolia/Extensions/AlgoliaClient.Tools.cs` -- MEAI AIFunction tools (AsSearchTool, AsGetObjectTool, AsListIndicesTool, AsBrowseTool)
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies these fixes:

1. **Auth conversion:** `yq` replaces Algolia's dual `apiKey` security schemes with `http/bearer`
2. **Server URL:** Replaces templated `{appId}.algolia.net` with a placeholder (users set the real URL via `WithApplicationId()`)
3. **browseParamsObject rename:** `sed` renames to `browseParamsConfig` to avoid C# property name collision (`Object` vs `object? Object`)
4. **searchForFacetsOptions/searchForHitsOptions rename:** `sed` renames to `*Settings` to avoid C# local variable `options` shadowing the `JsonSerializerOptions` method parameter

## Endpoints

78 endpoints organized via sub-client accessor `client.Search.*`:

| Category | Examples |
|----------|----------|
| Search | `SearchSingleIndexAsync`, `SearchAsync`, `SearchForFacetValuesAsync`, `BrowseAsync` |
| Records | `GetObjectAsync`, `GetObjectsAsync`, `AddOrUpdateObjectAsync`, `DeleteObjectAsync`, `BatchAsync` |
| Indices | `ListIndicesAsync`, `DeleteIndexAsync`, `OperationIndexAsync`, `GetSettingsAsync`, `SetSettingsAsync` |
| Rules | `GetRuleAsync`, `SaveRuleAsync`, `SaveRulesAsync`, `SearchRulesAsync`, `ClearRulesAsync`, `DeleteRuleAsync` |
| Synonyms | `GetSynonymAsync`, `SaveSynonymAsync`, `SearchSynonymsAsync`, `ClearSynonymsAsync` |
| API Keys | `ListApiKeysAsync`, `AddApiKeyAsync`, `GetApiKeyAsync`, `UpdateApiKeyAsync`, `DeleteApiKeyAsync` |
| Dictionary | `BatchDictionaryEntriesAsync`, `SearchDictionaryEntriesAsync`, `GetDictionaryLanguagesAsync` |

## MEAI Integration

- **Interface:** `AIFunction` tools (no standard MEAI interface like IChatClient/IEmbeddingGenerator)
- **Tools:** `AsSearchTool()`, `AsGetObjectTool()`, `AsListIndicesTool()`, `AsBrowseTool()`
- **Usage:** Pass tools to any `IChatClient` via `ChatOptions.Tools`

## Known Issues

- **Deeply nested allOf union types:** The Algolia spec uses extensive `allOf` composition, producing deeply nested union structs in generated code (e.g., `SearchParamsObject` = allOf(`BaseSearchParams`, `IndexSettingsAsSearchParams`), where `BaseSearchParams` = allOf(`SearchParamsQuery`, `BaseSearchParamsWithoutQuery`)). The MEAI tools use `SearchParamsString` (query string format) as a pragmatic workaround.

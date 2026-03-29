# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Algolia SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Algolia's search, browse, record retrieval, and AI-powered recommendation capabilities.

## Installation

```bash
dotnet add package Algolia
```

## Available Tools

### Search Tools (AlgoliaClient)

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchTool(indexName)` | `AlgoliaSearch` | Searches an Algolia index for matching records |
| `AsGetObjectTool(indexName)` | `AlgoliaGetObject` | Retrieves a single record by object ID |
| `AsListIndicesTool()` | `AlgoliaListIndices` | Lists all indices with record counts and update times |
| `AsBrowseTool(indexName)` | `AlgoliaBrowse` | Browses records without ranking (useful for data export) |

### Recommend Tools (AlgoliaRecommendClient)

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsFrequentlyBoughtTogetherTool(indexName)` | `AlgoliaFrequentlyBoughtTogether` | Gets products frequently bought with a given item |
| `AsRelatedProductsTool(indexName)` | `AlgoliaRelatedProducts` | Gets products related to a given item |
| `AsTrendingItemsTool(indexName)` | `AlgoliaTrendingItems` | Gets currently trending items |
| `AsLookingSimilarTool(indexName)` | `AlgoliaLookingSimilar` | Gets visually similar items based on image attributes |

## Usage

```csharp
using Algolia;
using Microsoft.Extensions.AI;

var algoliaClient = new AlgoliaClient(
    apiKey: Environment.GetEnvironmentVariable("ALGOLIA_API_KEY")!);
algoliaClient.WithApplicationId(
    Environment.GetEnvironmentVariable("ALGOLIA_APP_ID")!);

var options = new ChatOptions
{
    Tools =
    [
        algoliaClient.AsSearchTool(indexName: "products"),
        algoliaClient.AsGetObjectTool(indexName: "products"),
        algoliaClient.AsListIndicesTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Search for 'wireless headphones' in the products index."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

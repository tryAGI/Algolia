/* order: 20, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Algolia.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// The Algolia SDK provides AIFunction tools that can be used with any
    //// `IChatClient` from Microsoft.Extensions.AI. These tools enable
    //// AI agents to search Algolia indices, retrieve records, list indices,
    //// and browse index data.

    [TestMethod]
    public void CreateSearchTool()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ALGOLIA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException(
                    "ALGOLIA_API_KEY environment variable is not found.");

        var applicationId =
            Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID") is { Length: > 0 } appIdValue
                ? appIdValue
                : throw new AssertInconclusiveException(
                    "ALGOLIA_APPLICATION_ID environment variable is not found.");

        var indexName =
            Environment.GetEnvironmentVariable("ALGOLIA_INDEX_NAME") is { Length: > 0 } indexValue
                ? indexValue
                : "test-index";

        using var client = new AlgoliaClient(apiKey);
        client.WithApplicationId(applicationId);

        //// Create search and browse tools for use with any IChatClient.
        AIFunction searchTool = client.AsSearchTool(indexName);
        AIFunction getObjectTool = client.AsGetObjectTool(indexName);
        AIFunction listIndicesTool = client.AsListIndicesTool();
        AIFunction browseTool = client.AsBrowseTool(indexName);

        searchTool.Should().NotBeNull();
        searchTool.Name.Should().Be("AlgoliaSearch");
        getObjectTool.Should().NotBeNull();
        getObjectTool.Name.Should().Be("AlgoliaGetObject");
        listIndicesTool.Should().NotBeNull();
        listIndicesTool.Name.Should().Be("AlgoliaListIndices");
        browseTool.Should().NotBeNull();
        browseTool.Name.Should().Be("AlgoliaBrowse");
    }
}

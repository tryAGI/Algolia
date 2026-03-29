/* order: 15, title: Recommend API, slug: recommend */

using Algolia.Recommend;
using Microsoft.Extensions.AI;

namespace Algolia.IntegrationTests.Examples;

[TestClass]
public class Recommend
{
    //// The Algolia Recommend API provides AI-powered product recommendations.
    //// It supports multiple models: Frequently Bought Together, Related Products,
    //// Trending Items, and Looking Similar.

    [TestMethod]
    public void CreateRecommendClient()
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

        //// Create an AlgoliaRecommendClient with the same dual-header auth as the Search client.
        using var client = new AlgoliaRecommendClient(apiKey);
        client.WithApplicationId(applicationId);

        client.Should().NotBeNull();
    }

    [TestMethod]
    public void CreateRecommendTools()
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
                : "products";

        using var client = new AlgoliaRecommendClient(apiKey);
        client.WithApplicationId(applicationId);

        //// Create recommendation tools for use with any IChatClient.
        AIFunction fbtTool = client.AsFrequentlyBoughtTogetherTool(indexName);
        AIFunction relatedTool = client.AsRelatedProductsTool(indexName);
        AIFunction trendingTool = client.AsTrendingItemsTool(indexName);
        AIFunction lookingSimilarTool = client.AsLookingSimilarTool(indexName);

        fbtTool.Should().NotBeNull();
        fbtTool.Name.Should().Be("AlgoliaFrequentlyBoughtTogether");

        relatedTool.Should().NotBeNull();
        relatedTool.Name.Should().Be("AlgoliaRelatedProducts");

        trendingTool.Should().NotBeNull();
        trendingTool.Name.Should().Be("AlgoliaTrendingItems");

        lookingSimilarTool.Should().NotBeNull();
        lookingSimilarTool.Name.Should().Be("AlgoliaLookingSimilar");
    }
}

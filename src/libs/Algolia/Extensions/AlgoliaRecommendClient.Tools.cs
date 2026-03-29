using Microsoft.Extensions.AI;

namespace Algolia.Recommend;

/// <summary>
/// Extensions for using AlgoliaRecommendClient as MEAI tools with any IChatClient.
/// </summary>
public static class AlgoliaRecommendToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves "frequently bought together"
    /// recommendations for a given object ID, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia Recommend client to use.</param>
    /// <param name="indexName">The index name to get recommendations from.</param>
    /// <param name="maxRecommendations">Maximum number of recommendations to return (default: 5).</param>
    /// <param name="threshold">Minimum recommendation score threshold (default: 0).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsFrequentlyBoughtTogetherTool(
        this AlgoliaRecommendClient client,
        string indexName,
        int maxRecommendations = 5,
        double threshold = 0)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string objectId, CancellationToken cancellationToken) =>
            {
                var query = new BoughtTogetherQuery(
                    baseRecommendRequest: new BaseRecommendRequest
                    {
                        IndexName = indexName,
                        Threshold = threshold,
                        MaxRecommendations = maxRecommendations,
                    },
                    frequently: new FrequentlyBoughtTogether
                    {
                        ObjectID = objectId,
                        Model = FbtModel.BoughtTogether,
                    });

                var response = await client.Recommend.GetRecommendationsAsync(
                    requests: [query],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRecommendationsResponse(response, "Frequently Bought Together", indexName, objectId);
            },
            name: "AlgoliaFrequentlyBoughtTogether",
            description: $"Gets products frequently bought together with a given item from the Algolia index '{indexName}'. Requires an object ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves "related products"
    /// recommendations for a given object ID, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia Recommend client to use.</param>
    /// <param name="indexName">The index name to get recommendations from.</param>
    /// <param name="maxRecommendations">Maximum number of recommendations to return (default: 5).</param>
    /// <param name="threshold">Minimum recommendation score threshold (default: 0).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRelatedProductsTool(
        this AlgoliaRecommendClient client,
        string indexName,
        int maxRecommendations = 5,
        double threshold = 0)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string objectId, CancellationToken cancellationToken) =>
            {
                var query = new RelatedQuery(
                    baseRecommendRequest: new BaseRecommendRequest
                    {
                        IndexName = indexName,
                        Threshold = threshold,
                        MaxRecommendations = maxRecommendations,
                    },
                    products: new RelatedProducts
                    {
                        ObjectID = objectId,
                        Model = RelatedModel.RelatedProducts,
                    });

                var response = await client.Recommend.GetRecommendationsAsync(
                    requests: [query],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRecommendationsResponse(response, "Related Products", indexName, objectId);
            },
            name: "AlgoliaRelatedProducts",
            description: $"Gets products related to a given item from the Algolia index '{indexName}'. Similarity is based on user interactions and attributes. Requires an object ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves "trending items"
    /// recommendations, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia Recommend client to use.</param>
    /// <param name="indexName">The index name to get trending items from.</param>
    /// <param name="maxRecommendations">Maximum number of trending items to return (default: 5).</param>
    /// <param name="threshold">Minimum recommendation score threshold (default: 0).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTrendingItemsTool(
        this AlgoliaRecommendClient client,
        string indexName,
        int maxRecommendations = 5,
        double threshold = 0)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var query = new TrendingItemsQuery(
                    value1: new BaseRecommendRequest
                    {
                        IndexName = indexName,
                        Threshold = threshold,
                        MaxRecommendations = maxRecommendations,
                    },
                    value2: new TrendingItems
                    {
                        Model = TrendingItemsModel.TrendingItems,
                    });

                var response = await client.Recommend.GetRecommendationsAsync(
                    requests: [query],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRecommendationsResponse(response, "Trending Items", indexName, objectId: null);
            },
            name: "AlgoliaTrendingItems",
            description: $"Gets currently trending items from the Algolia index '{indexName}'. No object ID required.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves "looking similar"
    /// recommendations for a given object ID, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia Recommend client to use.</param>
    /// <param name="indexName">The index name to get recommendations from.</param>
    /// <param name="maxRecommendations">Maximum number of recommendations to return (default: 5).</param>
    /// <param name="threshold">Minimum recommendation score threshold (default: 0).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsLookingSimilarTool(
        this AlgoliaRecommendClient client,
        string indexName,
        int maxRecommendations = 5,
        double threshold = 0)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string objectId, CancellationToken cancellationToken) =>
            {
                var query = new LookingSimilarQuery(
                    value1: new BaseRecommendRequest
                    {
                        IndexName = indexName,
                        Threshold = threshold,
                        MaxRecommendations = maxRecommendations,
                    },
                    value2: new LookingSimilar
                    {
                        ObjectID = objectId,
                        Model = LookingSimilarModel.LookingSimilar,
                    });

                var response = await client.Recommend.GetRecommendationsAsync(
                    requests: [query],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRecommendationsResponse(response, "Looking Similar", indexName, objectId);
            },
            name: "AlgoliaLookingSimilar",
            description: $"Gets visually similar items to a given item from the Algolia index '{indexName}'. Based on visual similarity of product images. Requires an object ID.");
    }

    private static string FormatRecommendationsResponse(
        GetRecommendationsResponse response,
        string modelName,
        string indexName,
        string? objectId)
    {
        var parts = new List<string>();

        if (objectId != null)
        {
            parts.Add($"{modelName} recommendations for '{objectId}' in index '{indexName}':");
        }
        else
        {
            parts.Add($"{modelName} from index '{indexName}':");
        }

        if (response.Results is { Count: > 0 })
        {
            foreach (var result in response.Results)
            {
                var hits = result.Hits;
                if (hits?.Hits is { Count: > 0 })
                {
                    parts.Add($"Found {hits.Hits.Count} recommendations:");
                    foreach (var hit in hits.Hits)
                    {
                        var recommendHit = hit.Recommend;
                        if (recommendHit != null)
                        {
                            var entry = $"- ObjectID: {recommendHit.ObjectID}";
                            if (recommendHit.Score.HasValue)
                            {
                                entry += $" (score: {recommendHit.Score:F2})";
                            }
                            parts.Add(entry);
                        }

                        var trendingHit = hit.TrendingFacetHit;
                        if (trendingHit != null)
                        {
                            var entry = $"- Facet: {trendingHit.FacetName}={trendingHit.FacetValue}";
                            parts.Add(entry);
                        }
                    }
                }
                else
                {
                    parts.Add("No recommendations found.");
                }
            }
        }
        else
        {
            parts.Add("No results returned.");
        }

        return string.Join("\n", parts);
    }
}

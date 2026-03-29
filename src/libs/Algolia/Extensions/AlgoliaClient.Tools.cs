using Microsoft.Extensions.AI;

namespace Algolia;

/// <summary>
/// Extensions for using AlgoliaClient as MEAI tools with any IChatClient.
/// </summary>
public static class AlgoliaToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Algolia's search API,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia client to use for searches.</param>
    /// <param name="indexName">The default index name to search.</param>
    /// <param name="hitsPerPage">Maximum number of hits to return per page (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchTool(
        this AlgoliaClient client,
        string indexName,
        int hitsPerPage = 5)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                // Use SearchParamsString (query string format) to avoid deeply nested allOf union types.
                var searchParams = new SearchParamsString(
                    @params: $"query={Uri.EscapeDataString(query)}&hitsPerPage={hitsPerPage}");

                var response = await client.Search.SearchSingleIndexAsync(
                    indexName: indexName,
                    request: searchParams,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response, indexName);
            },
            name: "AlgoliaSearch",
            description: $"Searches the Algolia index '{indexName}' for matching records. Returns search hits with their attributes and highlights.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a single record by object ID,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia client to use.</param>
    /// <param name="indexName">The index to retrieve the record from.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetObjectTool(
        this AlgoliaClient client,
        string indexName)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string objectId, CancellationToken cancellationToken) =>
            {
                var result = await client.Search.GetObjectAsync(
                    indexName: indexName,
                    objectID: objectId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result;
            },
            name: "AlgoliaGetObject",
            description: $"Retrieves a single record from the Algolia index '{indexName}' by its object ID. Returns the full record as JSON.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all indices in the Algolia application,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListIndicesTool(
        this AlgoliaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Search.ListIndicesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListIndicesResponse(response);
            },
            name: "AlgoliaListIndices",
            description: "Lists all indices in the Algolia application with their names, record counts, and last update times.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that browses an index to retrieve records,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Algolia client to use.</param>
    /// <param name="indexName">The index to browse.</param>
    /// <param name="hitsPerPage">Maximum number of records to return per page (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsBrowseTool(
        this AlgoliaClient client,
        string indexName,
        int hitsPerPage = 10)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(indexName);

        return AIFunctionFactory.Create(
            async (string? query, CancellationToken cancellationToken) =>
            {
                // Use SearchParamsString format to avoid deeply nested allOf union types.
                var paramsStr = $"hitsPerPage={hitsPerPage}";
                if (!string.IsNullOrWhiteSpace(query))
                {
                    paramsStr = $"query={Uri.EscapeDataString(query)}&{paramsStr}";
                }

                var browseParams = new SearchParamsString(@params: paramsStr);

                var response = await client.Search.BrowseAsync(
                    indexName: indexName,
                    request: browseParams,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatBrowseResponse(response, indexName);
            },
            name: "AlgoliaBrowse",
            description: $"Browses records in the Algolia index '{indexName}'. Unlike search, browse retrieves all matching records without ranking. Useful for data export and bulk inspection.");
    }

    private static string FormatSearchResponse(SearchResponse response, string indexName)
    {
        var parts = new List<string> { $"Search results from index '{indexName}':" };

        var pagination = response.Pagination;
        if (pagination != null)
        {
            if (pagination.NbHits.HasValue)
            {
                parts.Add($"Total hits: {pagination.NbHits}");
            }
        }

        var baseResponse = response.Base;
        if (baseResponse != null)
        {
            if (baseResponse.ProcessingTimeMS.HasValue)
            {
                parts.Add($"Processing time: {baseResponse.ProcessingTimeMS}ms");
            }
        }

        var hitsResponse = response.Hits;
        if (hitsResponse?.Hits is { Count: > 0 })
        {
            parts.Add($"Showing {hitsResponse.Hits.Count} hits:");
            foreach (var hit in hitsResponse.Hits)
            {
                var entry = $"- ObjectID: {hit.ObjectID}";
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No hits found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatListIndicesResponse(ListIndicesResponse response)
    {
        var parts = new List<string> { "Indices:" };

        if (response.Items is { Count: > 0 })
        {
            foreach (var index in response.Items)
            {
                var entry = $"- {index.Name} ({index.Entries} records)";
                if (!string.IsNullOrWhiteSpace(index.UpdatedAt))
                {
                    entry += $" [updated: {index.UpdatedAt}]";
                }
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No indices found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatBrowseResponse(BrowseResponse response, string indexName)
    {
        var parts = new List<string> { $"Browse results from index '{indexName}':" };

        var pagination = response.Pagination;
        if (pagination != null)
        {
            if (pagination.NbHits.HasValue)
            {
                parts.Add($"Total records: {pagination.NbHits}");
            }
        }

        var cursor = response.Cursor;
        if (cursor != null)
        {
            if (!string.IsNullOrWhiteSpace(cursor.Cursor1))
            {
                parts.Add($"Cursor for next page: {cursor.Cursor1}");
            }
        }

        var hitsResponse = response.SearchHits;
        if (hitsResponse?.Hits is { Count: > 0 })
        {
            parts.Add($"Showing {hitsResponse.Hits.Count} records:");
            foreach (var hit in hitsResponse.Hits)
            {
                var entry = $"- ObjectID: {hit.ObjectID}";
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No records found.");
        }

        return string.Join("\n", parts);
    }
}

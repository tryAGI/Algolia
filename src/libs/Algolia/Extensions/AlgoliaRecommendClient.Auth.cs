#nullable enable

namespace Algolia.Recommend;

public sealed partial class AlgoliaRecommendClient
{
    private string? _applicationId;
    private string? _algoliaApiKey;

    /// <summary>
    /// Sets the Algolia Application ID and updates the base URL accordingly.
    /// Must be called before making any API requests.
    /// </summary>
    /// <param name="applicationId">Your Algolia Application ID.</param>
    /// <returns>The client instance for fluent chaining.</returns>
    public AlgoliaRecommendClient WithApplicationId(string applicationId)
    {
        ArgumentNullException.ThrowIfNull(applicationId);

        _applicationId = applicationId;
        HttpClient.BaseAddress = new Uri($"https://{applicationId}.algolia.net");
        return this;
    }

    // Capture the API key from the Bearer auth constructor parameter.
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Name: "Bearer" })
            {
                _algoliaApiKey = auth.Value;
            }
        }
    }

    // Set Algolia's custom auth headers on every request,
    // replacing the standard Bearer Authorization header.
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request)
    {
        // Remove the standard Authorization header (Bearer)
        request.Headers.Authorization = null;

        // Add Algolia-specific auth headers
        if (_applicationId is { Length: > 0 })
        {
            request.Headers.Remove("x-algolia-application-id");
            request.Headers.Add("x-algolia-application-id", _applicationId);
        }

        if (_algoliaApiKey is { Length: > 0 })
        {
            request.Headers.Remove("x-algolia-api-key");
            request.Headers.Add("x-algolia-api-key", _algoliaApiKey);
        }
    }
}

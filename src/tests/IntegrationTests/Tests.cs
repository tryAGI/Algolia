namespace Algolia.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AlgoliaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ALGOLIA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ALGOLIA_API_KEY environment variable is not found.");

        var client = new AlgoliaClient(apiKey);
        
        return client;
    }
}

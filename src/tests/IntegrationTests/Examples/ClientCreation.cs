/* order: 10, title: Client Creation, slug: client-creation */

namespace Algolia.IntegrationTests.Examples;

[TestClass]
public class ClientCreation
{
    //// Creating an AlgoliaClient requires both an API key and an Application ID.
    //// The Application ID is set via the `WithApplicationId()` fluent method,
    //// which also configures the correct base URL for API requests.

    [TestMethod]
    public void CreateClient()
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

        using var client = new AlgoliaClient(apiKey);
        client.WithApplicationId(applicationId);

        client.Should().NotBeNull();
    }
}

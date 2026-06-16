#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchGenerateSecuredApiKeyCommandApiCommand
{
    private static Option<string> ParentApiKey { get; } = new(
        name: @"--parent-api-key")
    {
        Description = @"API key from which the secured API key will inherit its restrictions.",
        Required = true,
    };

    private static Option<global::Algolia.SecuredApiKeyRestrictions> Restrictions { get; } = new(
        name: @"--restrictions")
    {
        Description = @"Restrictions to add to the API key.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-secured-api-key", @"Create secured API keys
Generates a secured API key without any requests to Algolia's servers.

Secured API keys are API keys that you generate on your server without any API request to Algolia.
Use secured API keys when you can't update client-side code, such as in mobile apps,
or when you need to restrict access to part of an index for each user.

When users start searching, your app requests a short-lived secured API key from your server instead of using the Search API key.
Your server uses this method to generate the secured API key with restrictions such as filters, index access restrictions,
or expiration times, and returns it to your app. The API key gets longer as you add restrictions.

You can't create secured API keys from other secured API keys or from your Admin API key.
The generated API key can have the same restrictions as the parent API key, or be more restrictive.
");
                        command.Options.Add(ParentApiKey);
                        command.Options.Add(Restrictions);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var parentApiKey = parseResult.GetRequiredValue(ParentApiKey);
                        var restrictions = parseResult.GetRequiredValue(Restrictions);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.GenerateSecuredApiKeyAsync(
                                    parentApiKey: parentApiKey,
                                    restrictions: restrictions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Algolia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}
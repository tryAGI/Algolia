#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchAddApiKeyCommandApiCommand
{
    private static readonly ApiKeyOptionSet ApiKeyOptionSetOptions = ApiKeyOptionSet.Create();
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.AddApiKeyResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.AddApiKeyResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"add-api-key", @"Create an API key
Creates a new API key with specific permissions and restrictions.");
                        command.Options.Add(ApiKeyOptionSetOptions.Acl);
                        command.Options.Add(ApiKeyOptionSetOptions.DescriptionOption);
                        command.Options.Add(ApiKeyOptionSetOptions.Indexes);
                        command.Options.Add(ApiKeyOptionSetOptions.MaxHitsPerQuery);
                        command.Options.Add(ApiKeyOptionSetOptions.MaxQueriesPerIPPerHour);
                        command.Options.Add(ApiKeyOptionSetOptions.QueryParameters);
                        command.Options.Add(ApiKeyOptionSetOptions.Referers);
                        command.Options.Add(ApiKeyOptionSetOptions.Validity);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.ApiKey>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);                        var acl = parseResult.GetRequiredValue(ApiKeyOptionSetOptions.Acl);
                        var description = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.DescriptionOption) ? parseResult.GetValue(ApiKeyOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var indexes = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.Indexes) ? parseResult.GetValue(ApiKeyOptionSetOptions.Indexes) : (__requestBase is { } __IndexesBaseValue ? __IndexesBaseValue.Indexes : default);
                        var maxHitsPerQuery = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.MaxHitsPerQuery) ? parseResult.GetValue(ApiKeyOptionSetOptions.MaxHitsPerQuery) : (__requestBase is { } __MaxHitsPerQueryBaseValue ? __MaxHitsPerQueryBaseValue.MaxHitsPerQuery : default);
                        var maxQueriesPerIPPerHour = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.MaxQueriesPerIPPerHour) ? parseResult.GetValue(ApiKeyOptionSetOptions.MaxQueriesPerIPPerHour) : (__requestBase is { } __MaxQueriesPerIPPerHourBaseValue ? __MaxQueriesPerIPPerHourBaseValue.MaxQueriesPerIPPerHour : default);
                        var queryParameters = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.QueryParameters) ? parseResult.GetValue(ApiKeyOptionSetOptions.QueryParameters) : (__requestBase is { } __QueryParametersBaseValue ? __QueryParametersBaseValue.QueryParameters : default);
                        var referers = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.Referers) ? parseResult.GetValue(ApiKeyOptionSetOptions.Referers) : (__requestBase is { } __ReferersBaseValue ? __ReferersBaseValue.Referers : default);
                        var validity = CliRuntime.WasSpecified(parseResult, ApiKeyOptionSetOptions.Validity) ? parseResult.GetValue(ApiKeyOptionSetOptions.Validity) : (__requestBase is { } __ValidityBaseValue ? __ValidityBaseValue.Validity : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.AddApiKeyAsync(
                                    acl: acl,
                                    description: description,
                                    indexes: indexes,
                                    maxHitsPerQuery: maxHitsPerQuery,
                                    maxQueriesPerIPPerHour: maxQueriesPerIPPerHour,
                                    queryParameters: queryParameters,
                                    referers: referers,
                                    validity: validity,
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
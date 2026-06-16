#nullable enable

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal sealed record ApiKeyOptionSet(
    Option<global::System.Collections.Generic.IList<global::Algolia.Acl>> Acl,
                     Option<string?> DescriptionOption,
                     Option<global::System.Collections.Generic.IList<string>?> Indexes,
                     Option<int?> MaxHitsPerQuery,
                     Option<int?> MaxQueriesPerIPPerHour,
                     Option<string?> QueryParameters,
                     Option<global::System.Collections.Generic.IList<string>?> Referers,
                     Option<int?> Validity)
{
    public static ApiKeyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ApiKeyOptionSet(
                        Acl: new Option<global::System.Collections.Generic.IList<global::Algolia.Acl>>($"--{normalizedPrefix}acl")
                {
                    Description = @"Permissions that determine the type of API requests this key can make.
The required ACL is listed in each endpoint's reference.
For more information, see [access control list](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl).
",
                    Required = true,
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"Description of an API key to help you identify this API key.",
                },
                Indexes: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}indexes")
                {
                    Description = @"Index names or patterns that this API key can access.
By default, an API key can access all indices in the same application.

You can use leading and trailing wildcard characters (`*`):

- `dev_*` matches all indices starting with ""dev_""
- `*_dev` matches all indices ending with ""_dev""
- `*_products_*` matches all indices containing ""_products_"".
",
                },
                MaxHitsPerQuery: new Option<int?>($"--{normalizedPrefix}max-hits-per-query")
                {
                    Description = @"Maximum number of results this API key can retrieve in one query.
By default, there's no limit.
",
                },
                MaxQueriesPerIPPerHour: new Option<int?>($"--{normalizedPrefix}max-queries-per-ipper-hour")
                {
                    Description = @"Maximum number of API requests allowed per IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken) per hour.

If this limit is reached, the API returns an error with status code `429`.
By default, there's no limit.
",
                },
                QueryParameters: new Option<string?>($"--{normalizedPrefix}query-parameters")
                {
                    Description = @"Query parameters to add when making API requests with this API key.

To restrict this API key to specific IP addresses, add the `restrictSources` parameter.
You can only add a single source, but you can provide a range of IP addresses.

Creating an API key fails if the request is made from an IP address outside the restricted range.
",
                },
                Referers: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}referers")
                {
                    Description = @"Allowed HTTP referrers for this API key.

By default, all referrers are allowed.
You can use leading and trailing wildcard characters (`*`):

- `https://algolia.com/*` allows all referrers starting with ""https://algolia.com/""
- `*.algolia.com` allows all referrers ending with "".algolia.com""
- `*algolia.com*` allows all referrers in the domain ""algolia.com"".

Like all HTTP headers, referrers can be spoofed. Don't rely on them to secure your data.
For more information, see [HTTP referrer restrictions](https://www.algolia.com/doc/guides/security/security-best-practices/#http-referrers-restrictions).
",
                },
                Validity: new Option<int?>($"--{normalizedPrefix}validity")
                {
                    Description = @"Duration (in seconds) after which the API key expires.
By default, API keys don't expire.
",
                }
        );
    }
}

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Effect of the rule.<br/>
    /// For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
    /// </summary>
    public sealed partial class Consequence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.ConsequenceParamsJsonConverter))]
        public global::Algolia.ConsequenceParams? Params { get; set; }

        /// <summary>
        /// Records you want to pin to a specific position in the search results.<br/>
        /// You can promote up to 300 records, either individually, or as groups of up to 100 records each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promote")]
        public global::System.Collections.Generic.IList<global::Algolia.Promote>? Promote { get; set; }

        /// <summary>
        /// Determines whether promoted records must also match active filters for the consequence to apply.<br/>
        /// This ensures user-applied filters take priority and irrelevant matches aren't shown.<br/>
        /// For example, if you promote a record with `color: red` but the user filters for `color: blue`,<br/>
        /// the "red" record won't be shown.<br/>
        /// &gt; In the Algolia dashboard, when you use the **Pin an item** consequence, `filterPromotes` appears as the checkbox: **Pinned items must match active filters to be displayed.** For examples, see [Promote results with rules](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/promote-hits/#promote-results-matching-active-filters).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterPromotes")]
        public bool? FilterPromotes { get; set; }

        /// <summary>
        /// Records you want to hide from the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide")]
        public global::System.Collections.Generic.IList<global::Algolia.ConsequenceHideItem>? Hide { get; set; }

        /// <summary>
        /// Redirect to a virtual replica index.<br/>
        /// This consequence is only valid for rules with `scope: redirect`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Algolia.ConsequenceRedirect? Redirect { get; set; }

        /// <summary>
        /// A JSON object with custom data that will be appended to the `userData` array in the response.<br/>
        /// This object isn't interpreted by the API and is limited to 1&amp;nbsp;kB of minified JSON.<br/>
        /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
        /// </summary>
        /// <example>{"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userData")]
        public object? UserData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Consequence" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="promote">
        /// Records you want to pin to a specific position in the search results.<br/>
        /// You can promote up to 300 records, either individually, or as groups of up to 100 records each.
        /// </param>
        /// <param name="filterPromotes">
        /// Determines whether promoted records must also match active filters for the consequence to apply.<br/>
        /// This ensures user-applied filters take priority and irrelevant matches aren't shown.<br/>
        /// For example, if you promote a record with `color: red` but the user filters for `color: blue`,<br/>
        /// the "red" record won't be shown.<br/>
        /// &gt; In the Algolia dashboard, when you use the **Pin an item** consequence, `filterPromotes` appears as the checkbox: **Pinned items must match active filters to be displayed.** For examples, see [Promote results with rules](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/promote-hits/#promote-results-matching-active-filters).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hide">
        /// Records you want to hide from the search results.
        /// </param>
        /// <param name="redirect">
        /// Redirect to a virtual replica index.<br/>
        /// This consequence is only valid for rules with `scope: redirect`.
        /// </param>
        /// <param name="userData">
        /// A JSON object with custom data that will be appended to the `userData` array in the response.<br/>
        /// This object isn't interpreted by the API and is limited to 1&amp;nbsp;kB of minified JSON.<br/>
        /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Consequence(
            global::Algolia.ConsequenceParams? @params,
            global::System.Collections.Generic.IList<global::Algolia.Promote>? promote,
            bool? filterPromotes,
            global::System.Collections.Generic.IList<global::Algolia.ConsequenceHideItem>? hide,
            global::Algolia.ConsequenceRedirect? redirect,
            object? userData)
        {
            this.Params = @params;
            this.Promote = promote;
            this.FilterPromotes = filterPromotes;
            this.Hide = hide;
            this.Redirect = redirect;
            this.UserData = userData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Consequence" /> class.
        /// </summary>
        public Consequence()
        {
        }
    }
}
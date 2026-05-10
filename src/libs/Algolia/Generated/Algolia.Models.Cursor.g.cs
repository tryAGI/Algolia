
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cursor
    {
        /// <summary>
        /// Cursor to get the next page of the response.<br/>
        /// The parameter must match the value returned in the response of a previous request.<br/>
        /// The last page of the response does not return a `cursor` attribute.<br/>
        /// Example: jMDY3M2MwM2QwMWUxMmQwYWI0ZTN
        /// </summary>
        /// <example>jMDY3M2MwM2QwMWUxMmQwYWI0ZTN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cursor" /> class.
        /// </summary>
        /// <param name="cursor1">
        /// Cursor to get the next page of the response.<br/>
        /// The parameter must match the value returned in the response of a previous request.<br/>
        /// The last page of the response does not return a `cursor` attribute.<br/>
        /// Example: jMDY3M2MwM2QwMWUxMmQwYWI0ZTN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cursor(
            string? cursor1)
        {
            this.Cursor1 = cursor1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cursor" /> class.
        /// </summary>
        public Cursor()
        {
        }

    }
}
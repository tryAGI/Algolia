
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLogsResponseLog
    {
        /// <summary>
        /// Date and time of the API request, in RFC 3339 format.<br/>
        /// Example: 2023-03-08T12:34:56Z
        /// </summary>
        /// <example>2023-03-08T12:34:56Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// HTTP method of the request.<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// HTTP status code of the response.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnswerCode { get; set; }

        /// <summary>
        /// Request body.<br/>
        /// Example: {\n \"requests\": [\n  {\n   \"indexName\": \"best_buy\",\n   \"params\": \"query=&amp;hitsPerPage=10&amp;page=0&amp;attributesToRetrieve=*&amp;highlightPreTag=%3Cais-highlight-0000000000%3E&amp;highlightPostTag=%3C%2Fais-highlight-0000000000%3E&amp;getRankingInfo=1&amp;facets=%5B%22brand%22%2C%22categories%22%2C%22free_shipping%22%2C%22type%22%5D&amp;tagFilters=\"\n  }\n ]\n}\n
        /// </summary>
        /// <example>{\n \"requests\": [\n  {\n   \"indexName\": \"best_buy\",\n   \"params\": \"query=&amp;hitsPerPage=10&amp;page=0&amp;attributesToRetrieve=*&amp;highlightPreTag=%3Cais-highlight-0000000000%3E&amp;highlightPostTag=%3C%2Fais-highlight-0000000000%3E&amp;getRankingInfo=1&amp;facets=%5B%22brand%22%2C%22categories%22%2C%22free_shipping%22%2C%22type%22%5D&amp;tagFilters=\"\n  }\n ]\n}\n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryBody { get; set; }

        /// <summary>
        /// Response body.<br/>
        /// Example: 'n{\n "results": [\n  {\n   "hits": [\n    {\n     "name": "Amazon - Fire TV Stick",\n     "description": "Amazon Fire TV Stick connects to your TV's HDMI port. Just grab and go to enjoy Netflix, Prime Instant Video, Hulu Plus, YouTube.com, music, and much more.",\n     "brand": "Amazon",\n     "categories": [\n      "TV &amp; Home Theater",\n      "Streaming Media Players"\n     ],\n     "hierarchicalCategories": {\n      "lvl0": "TV &amp; Home Theater",\n      "lvl1": "TV &amp; Home Theater &gt; Streaming Media Players"\n     },\n     "type": "Streaming media player",\n     "price": 39.99,\n     "price_range": "1 }\n   ]\n  }\n ]\n}'
        /// </summary>
        /// <example>'n{\n "results": [\n  {\n   "hits": [\n    {\n     "name": "Amazon - Fire TV Stick",\n     "description": "Amazon Fire TV Stick connects to your TV's HDMI port. Just grab and go to enjoy Netflix, Prime Instant Video, Hulu Plus, YouTube.com, music, and much more.",\n     "brand": "Amazon",\n     "categories": [\n      "TV &amp; Home Theater",\n      "Streaming Media Players"\n     ],\n     "hierarchicalCategories": {\n      "lvl0": "TV &amp; Home Theater",\n      "lvl1": "TV &amp; Home Theater &gt; Streaming Media Players"\n     },\n     "type": "Streaming media player",\n     "price": 39.99,\n     "price_range": "1 }\n   ]\n  }\n ]\n}'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// URL of the API endpoint.<br/>
        /// Example: /1/indexes
        /// </summary>
        /// <example>/1/indexes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// IP address of the client that performed the request.<br/>
        /// Example: 93.184.216.34
        /// </summary>
        /// <example>93.184.216.34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        /// Request headers (API keys are obfuscated).<br/>
        /// Example: User-Agent: curl/7.24.0 (x86_64-apple-darwin12.0) libcurl/7.24.0 OpenSSL/0.9.8x zlib/1.2.5\nHost: example.com\nAccept: */*\nContent-Type: application/json; charset=utf-8\nX-Algolia-API-Key: 20f***************************\nX-Algolia-Application-Id: MyApplicationID\n
        /// </summary>
        /// <example>User-Agent: curl/7.24.0 (x86_64-apple-darwin12.0) libcurl/7.24.0 OpenSSL/0.9.8x zlib/1.2.5\nHost: example.com\nAccept: */*\nContent-Type: application/json; charset=utf-8\nX-Algolia-API-Key: 20f***************************\nX-Algolia-Application-Id: MyApplicationID\n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryHeaders { get; set; }

        /// <summary>
        /// SHA1 signature of the log entry.<br/>
        /// Example: 26c53bd7e38ca71f4741b71994cd94a600b7ac68
        /// </summary>
        /// <example>26c53bd7e38ca71f4741b71994cd94a600b7ac68</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha1 { get; set; }

        /// <summary>
        /// Number of API requests.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_api_calls")]
        public string? NbApiCalls { get; set; }

        /// <summary>
        /// Processing time for the query in milliseconds.<br/>
        /// This doesn't include latency due to the network.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcessingTimeMs { get; set; }

        /// <summary>
        /// Index targeted by the query.<br/>
        /// Example: products
        /// </summary>
        /// <example>products</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public string? Index { get; set; }

        /// <summary>
        /// Query parameters sent with the request.<br/>
        /// Example: query=georgia&amp;attributesToRetrieve=name,city,country
        /// </summary>
        /// <example>query=georgia&amp;attributesToRetrieve=name,city,country</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params")]
        public string? QueryParams { get; set; }

        /// <summary>
        /// Number of search results (hits) returned for the query.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_nb_hits")]
        public string? QueryNbHits { get; set; }

        /// <summary>
        /// Queries performed for the given request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inner_queries")]
        public global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLogInnerQuerie>? InnerQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseLog" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Date and time of the API request, in RFC 3339 format.<br/>
        /// Example: 2023-03-08T12:34:56Z
        /// </param>
        /// <param name="method">
        /// HTTP method of the request.<br/>
        /// Example: GET
        /// </param>
        /// <param name="answerCode">
        /// HTTP status code of the response.<br/>
        /// Example: 200
        /// </param>
        /// <param name="queryBody">
        /// Request body.<br/>
        /// Example: {\n \"requests\": [\n  {\n   \"indexName\": \"best_buy\",\n   \"params\": \"query=&amp;hitsPerPage=10&amp;page=0&amp;attributesToRetrieve=*&amp;highlightPreTag=%3Cais-highlight-0000000000%3E&amp;highlightPostTag=%3C%2Fais-highlight-0000000000%3E&amp;getRankingInfo=1&amp;facets=%5B%22brand%22%2C%22categories%22%2C%22free_shipping%22%2C%22type%22%5D&amp;tagFilters=\"\n  }\n ]\n}\n
        /// </param>
        /// <param name="answer">
        /// Response body.<br/>
        /// Example: 'n{\n "results": [\n  {\n   "hits": [\n    {\n     "name": "Amazon - Fire TV Stick",\n     "description": "Amazon Fire TV Stick connects to your TV's HDMI port. Just grab and go to enjoy Netflix, Prime Instant Video, Hulu Plus, YouTube.com, music, and much more.",\n     "brand": "Amazon",\n     "categories": [\n      "TV &amp; Home Theater",\n      "Streaming Media Players"\n     ],\n     "hierarchicalCategories": {\n      "lvl0": "TV &amp; Home Theater",\n      "lvl1": "TV &amp; Home Theater &gt; Streaming Media Players"\n     },\n     "type": "Streaming media player",\n     "price": 39.99,\n     "price_range": "1 }\n   ]\n  }\n ]\n}'
        /// </param>
        /// <param name="url">
        /// URL of the API endpoint.<br/>
        /// Example: /1/indexes
        /// </param>
        /// <param name="ip">
        /// IP address of the client that performed the request.<br/>
        /// Example: 93.184.216.34
        /// </param>
        /// <param name="queryHeaders">
        /// Request headers (API keys are obfuscated).<br/>
        /// Example: User-Agent: curl/7.24.0 (x86_64-apple-darwin12.0) libcurl/7.24.0 OpenSSL/0.9.8x zlib/1.2.5\nHost: example.com\nAccept: */*\nContent-Type: application/json; charset=utf-8\nX-Algolia-API-Key: 20f***************************\nX-Algolia-Application-Id: MyApplicationID\n
        /// </param>
        /// <param name="sha1">
        /// SHA1 signature of the log entry.<br/>
        /// Example: 26c53bd7e38ca71f4741b71994cd94a600b7ac68
        /// </param>
        /// <param name="processingTimeMs">
        /// Processing time for the query in milliseconds.<br/>
        /// This doesn't include latency due to the network.<br/>
        /// Example: 2
        /// </param>
        /// <param name="nbApiCalls">
        /// Number of API requests.<br/>
        /// Example: 1
        /// </param>
        /// <param name="index">
        /// Index targeted by the query.<br/>
        /// Example: products
        /// </param>
        /// <param name="queryParams">
        /// Query parameters sent with the request.<br/>
        /// Example: query=georgia&amp;attributesToRetrieve=name,city,country
        /// </param>
        /// <param name="queryNbHits">
        /// Number of search results (hits) returned for the query.<br/>
        /// Example: 1
        /// </param>
        /// <param name="innerQueries">
        /// Queries performed for the given request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLogsResponseLog(
            string timestamp,
            string method,
            string answerCode,
            string queryBody,
            string answer,
            string url,
            string ip,
            string queryHeaders,
            string sha1,
            string processingTimeMs,
            string? nbApiCalls,
            string? index,
            string? queryParams,
            string? queryNbHits,
            global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLogInnerQuerie>? innerQueries)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.AnswerCode = answerCode ?? throw new global::System.ArgumentNullException(nameof(answerCode));
            this.QueryBody = queryBody ?? throw new global::System.ArgumentNullException(nameof(queryBody));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.QueryHeaders = queryHeaders ?? throw new global::System.ArgumentNullException(nameof(queryHeaders));
            this.Sha1 = sha1 ?? throw new global::System.ArgumentNullException(nameof(sha1));
            this.NbApiCalls = nbApiCalls;
            this.ProcessingTimeMs = processingTimeMs ?? throw new global::System.ArgumentNullException(nameof(processingTimeMs));
            this.Index = index;
            this.QueryParams = queryParams;
            this.QueryNbHits = queryNbHits;
            this.InnerQueries = innerQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseLog" /> class.
        /// </summary>
        public GetLogsResponseLog()
        {
        }

    }
}
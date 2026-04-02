#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetApiKeyResponse : global::System.IEquatable<GetApiKeyResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseGetApiKeyResponse? Base { get; init; }
#else
        public global::Algolia.BaseGetApiKeyResponse? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// API key object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.ApiKey? ApiKey { get; init; }
#else
        public global::Algolia.ApiKey? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetApiKeyResponse(global::Algolia.BaseGetApiKeyResponse value) => new GetApiKeyResponse((global::Algolia.BaseGetApiKeyResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseGetApiKeyResponse?(GetApiKeyResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GetApiKeyResponse(global::Algolia.BaseGetApiKeyResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetApiKeyResponse(global::Algolia.ApiKey value) => new GetApiKeyResponse((global::Algolia.ApiKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.ApiKey?(GetApiKeyResponse @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public GetApiKeyResponse(global::Algolia.ApiKey? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetApiKeyResponse(
            global::Algolia.BaseGetApiKeyResponse? @base,
            global::Algolia.ApiKey? apiKey
            )
        {
            Base = @base;
            ApiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiKey as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ApiKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseGetApiKeyResponse?, TResult>? @base = null,
            global::System.Func<global::Algolia.ApiKey?, TResult>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseGetApiKeyResponse?>? @base = null,
            global::System.Action<global::Algolia.ApiKey?>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Algolia.BaseGetApiKeyResponse),
                ApiKey,
                typeof(global::Algolia.ApiKey),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GetApiKeyResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseGetApiKeyResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.ApiKey?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetApiKeyResponse obj1, GetApiKeyResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetApiKeyResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetApiKeyResponse obj1, GetApiKeyResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetApiKeyResponse o && Equals(o);
        }
    }
}

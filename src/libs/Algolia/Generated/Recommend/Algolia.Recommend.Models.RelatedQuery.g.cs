#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RelatedQuery : global::System.IEquatable<RelatedQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseRecommendRequest))]
#endif
        public bool IsBaseRecommendRequest => BaseRecommendRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseRecommendRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            value = BaseRecommendRequest;
            return IsBaseRecommendRequest;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RelatedProducts? Products { get; init; }
#else
        public global::Algolia.Recommend.RelatedProducts? Products { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Products))]
#endif
        public bool IsProducts => Products != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProducts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RelatedProducts? value)
        {
            value = Products;
            return IsProducts;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RelatedQuery(global::Algolia.Recommend.BaseRecommendRequest value) => new RelatedQuery((global::Algolia.Recommend.BaseRecommendRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendRequest?(RelatedQuery @this) => @this.BaseRecommendRequest;

        /// <summary>
        /// 
        /// </summary>
        public RelatedQuery(global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            BaseRecommendRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RelatedQuery(global::Algolia.Recommend.RelatedProducts value) => new RelatedQuery((global::Algolia.Recommend.RelatedProducts?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RelatedProducts?(RelatedQuery @this) => @this.Products;

        /// <summary>
        /// 
        /// </summary>
        public RelatedQuery(global::Algolia.Recommend.RelatedProducts? value)
        {
            Products = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RelatedQuery(
            global::Algolia.Recommend.BaseRecommendRequest? baseRecommendRequest,
            global::Algolia.Recommend.RelatedProducts? products
            )
        {
            BaseRecommendRequest = baseRecommendRequest;
            Products = products;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Products as object ??
            BaseRecommendRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseRecommendRequest?.ToString() ??
            Products?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseRecommendRequest && IsProducts;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendRequest, TResult>? baseRecommendRequest = null,
            global::System.Func<global::Algolia.Recommend.RelatedProducts, TResult>? products = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest && baseRecommendRequest != null)
            {
                return baseRecommendRequest(BaseRecommendRequest!);
            }
            else if (IsProducts && products != null)
            {
                return products(Products!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,

            global::System.Action<global::Algolia.Recommend.RelatedProducts>? products = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsProducts)
            {
                products?.Invoke(Products!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,
            global::System.Action<global::Algolia.Recommend.RelatedProducts>? products = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsProducts)
            {
                products?.Invoke(Products!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseRecommendRequest,
                typeof(global::Algolia.Recommend.BaseRecommendRequest),
                Products,
                typeof(global::Algolia.Recommend.RelatedProducts),
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
        public bool Equals(RelatedQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendRequest?>.Default.Equals(BaseRecommendRequest, other.BaseRecommendRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RelatedProducts?>.Default.Equals(Products, other.Products) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RelatedQuery obj1, RelatedQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RelatedQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RelatedQuery obj1, RelatedQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RelatedQuery o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Filter the search by values of the special `_tags` attribute.<br/>
    /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
    /// Different from regular facets, `_tags` can only be used for filtering (including or excluding records).<br/>
    /// You won't get a facet count.<br/>
    /// The same combination and escaping rules apply as for `facetFilters`.<br/>
    /// Example: [[Book, Movie], SciFi]
    /// </summary>
    public readonly partial struct TagFilters : global::System.IEquatable<TagFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>? TagFiltersVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>? TagFiltersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagFiltersVariant1))]
#endif
        public bool IsTagFiltersVariant1 => TagFiltersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTagFiltersVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>? value)
        {
            value = TagFiltersVariant1;
            return IsTagFiltersVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters> PickTagFiltersVariant1() => IsTagFiltersVariant1
            ? TagFiltersVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TagFiltersVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TagFiltersVariant2 { get; init; }
#else
        public string? TagFiltersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagFiltersVariant2))]
#endif
        public bool IsTagFiltersVariant2 => TagFiltersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTagFiltersVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TagFiltersVariant2;
            return IsTagFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickTagFiltersVariant2() => IsTagFiltersVariant2
            ? TagFiltersVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TagFiltersVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TagFilters(string value) => new TagFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(TagFilters @this) => @this.TagFiltersVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TagFilters(string? value)
        {
            TagFiltersVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TagFilters FromTagFiltersVariant2(string? value) => new TagFilters(value);

        /// <summary>
        /// 
        /// </summary>
        public TagFilters(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>? tagFiltersVariant1,
            string? tagFiltersVariant2
            )
        {
            TagFiltersVariant1 = tagFiltersVariant1;
            TagFiltersVariant2 = tagFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TagFiltersVariant2 as object ??
            TagFiltersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TagFiltersVariant1?.ToString() ??
            TagFiltersVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTagFiltersVariant1 && !IsTagFiltersVariant2 || !IsTagFiltersVariant1 && IsTagFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>, TResult>? tagFiltersVariant1 = null,
            global::System.Func<string, TResult>? tagFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTagFiltersVariant1 && tagFiltersVariant1 != null)
            {
                return tagFiltersVariant1(TagFiltersVariant1!);
            }
            else if (IsTagFiltersVariant2 && tagFiltersVariant2 != null)
            {
                return tagFiltersVariant2(TagFiltersVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>>? tagFiltersVariant1 = null,

            global::System.Action<string>? tagFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTagFiltersVariant1)
            {
                tagFiltersVariant1?.Invoke(TagFiltersVariant1!);
            }
            else if (IsTagFiltersVariant2)
            {
                tagFiltersVariant2?.Invoke(TagFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>>? tagFiltersVariant1 = null,
            global::System.Action<string>? tagFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTagFiltersVariant1)
            {
                tagFiltersVariant1?.Invoke(TagFiltersVariant1!);
            }
            else if (IsTagFiltersVariant2)
            {
                tagFiltersVariant2?.Invoke(TagFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TagFiltersVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>),
                TagFiltersVariant2,
                typeof(string),
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
        public bool Equals(TagFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>?>.Default.Equals(TagFiltersVariant1, other.TagFiltersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TagFiltersVariant2, other.TagFiltersVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TagFilters obj1, TagFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TagFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TagFilters obj1, TagFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TagFilters o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DictionaryLanguage : global::System.IEquatable<DictionaryLanguage>
    {
        /// <summary>
        /// Dictionary type. If `null`, this dictionary type isn't supported for the language.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.DictionaryLanguageVariant1? DictionaryLanguageVariant1 { get; init; }
#else
        public global::Algolia.DictionaryLanguageVariant1? DictionaryLanguageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DictionaryLanguageVariant1))]
#endif
        public bool IsDictionaryLanguageVariant1 => DictionaryLanguageVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDictionaryLanguageVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.DictionaryLanguageVariant1? value)
        {
            value = DictionaryLanguageVariant1;
            return IsDictionaryLanguageVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.DictionaryLanguageVariant1 PickDictionaryLanguageVariant1() => IsDictionaryLanguageVariant1
            ? DictionaryLanguageVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DictionaryLanguageVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DictionaryLanguageVariant2 { get; init; }
#else
        public object? DictionaryLanguageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DictionaryLanguageVariant2))]
#endif
        public bool IsDictionaryLanguageVariant2 => DictionaryLanguageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDictionaryLanguageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DictionaryLanguageVariant2;
            return IsDictionaryLanguageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickDictionaryLanguageVariant2() => IsDictionaryLanguageVariant2
            ? DictionaryLanguageVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DictionaryLanguageVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DictionaryLanguage(global::Algolia.DictionaryLanguageVariant1 value) => new DictionaryLanguage((global::Algolia.DictionaryLanguageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.DictionaryLanguageVariant1?(DictionaryLanguage @this) => @this.DictionaryLanguageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DictionaryLanguage(global::Algolia.DictionaryLanguageVariant1? value)
        {
            DictionaryLanguageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DictionaryLanguage FromDictionaryLanguageVariant1(global::Algolia.DictionaryLanguageVariant1? value) => new DictionaryLanguage(value);

        /// <summary>
        /// 
        /// </summary>
        public DictionaryLanguage(
            global::Algolia.DictionaryLanguageVariant1? dictionaryLanguageVariant1,
            object? dictionaryLanguageVariant2
            )
        {
            DictionaryLanguageVariant1 = dictionaryLanguageVariant1;
            DictionaryLanguageVariant2 = dictionaryLanguageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DictionaryLanguageVariant2 as object ??
            DictionaryLanguageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DictionaryLanguageVariant1?.ToString() ??
            DictionaryLanguageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDictionaryLanguageVariant1 && !IsDictionaryLanguageVariant2 || !IsDictionaryLanguageVariant1 && IsDictionaryLanguageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.DictionaryLanguageVariant1, TResult>? dictionaryLanguageVariant1 = null,
            global::System.Func<object, TResult>? dictionaryLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDictionaryLanguageVariant1 && dictionaryLanguageVariant1 != null)
            {
                return dictionaryLanguageVariant1(DictionaryLanguageVariant1!);
            }
            else if (IsDictionaryLanguageVariant2 && dictionaryLanguageVariant2 != null)
            {
                return dictionaryLanguageVariant2(DictionaryLanguageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.DictionaryLanguageVariant1>? dictionaryLanguageVariant1 = null,

            global::System.Action<object>? dictionaryLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDictionaryLanguageVariant1)
            {
                dictionaryLanguageVariant1?.Invoke(DictionaryLanguageVariant1!);
            }
            else if (IsDictionaryLanguageVariant2)
            {
                dictionaryLanguageVariant2?.Invoke(DictionaryLanguageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.DictionaryLanguageVariant1>? dictionaryLanguageVariant1 = null,
            global::System.Action<object>? dictionaryLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDictionaryLanguageVariant1)
            {
                dictionaryLanguageVariant1?.Invoke(DictionaryLanguageVariant1!);
            }
            else if (IsDictionaryLanguageVariant2)
            {
                dictionaryLanguageVariant2?.Invoke(DictionaryLanguageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DictionaryLanguageVariant1,
                typeof(global::Algolia.DictionaryLanguageVariant1),
                DictionaryLanguageVariant2,
                typeof(object),
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
        public bool Equals(DictionaryLanguage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.DictionaryLanguageVariant1?>.Default.Equals(DictionaryLanguageVariant1, other.DictionaryLanguageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DictionaryLanguageVariant2, other.DictionaryLanguageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DictionaryLanguage obj1, DictionaryLanguage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DictionaryLanguage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DictionaryLanguage obj1, DictionaryLanguage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DictionaryLanguage o && Equals(o);
        }
    }
}

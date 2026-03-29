
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// ISO code for a supported language.
    /// </summary>
    public enum SupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Az,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cy,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Eo,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Fa,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fo,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// 
        /// </summary>
        Gl,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Hy,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Kk,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ku,
        /// <summary>
        /// 
        /// </summary>
        Ky,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mi,
        /// <summary>
        /// 
        /// </summary>
        Mn,
        /// <summary>
        /// 
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Mt,
        /// <summary>
        /// 
        /// </summary>
        Nb,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Ns,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Ps,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        Qu,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sq,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tn,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Tt,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Uz,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLanguage value)
        {
            return value switch
            {
                SupportedLanguage.Af => "af",
                SupportedLanguage.Ar => "ar",
                SupportedLanguage.Az => "az",
                SupportedLanguage.Bg => "bg",
                SupportedLanguage.Bn => "bn",
                SupportedLanguage.Ca => "ca",
                SupportedLanguage.Cs => "cs",
                SupportedLanguage.Cy => "cy",
                SupportedLanguage.Da => "da",
                SupportedLanguage.De => "de",
                SupportedLanguage.El => "el",
                SupportedLanguage.En => "en",
                SupportedLanguage.Eo => "eo",
                SupportedLanguage.Es => "es",
                SupportedLanguage.Et => "et",
                SupportedLanguage.Eu => "eu",
                SupportedLanguage.Fa => "fa",
                SupportedLanguage.Fi => "fi",
                SupportedLanguage.Fo => "fo",
                SupportedLanguage.Fr => "fr",
                SupportedLanguage.Ga => "ga",
                SupportedLanguage.Gl => "gl",
                SupportedLanguage.He => "he",
                SupportedLanguage.Hi => "hi",
                SupportedLanguage.Hu => "hu",
                SupportedLanguage.Hy => "hy",
                SupportedLanguage.Id => "id",
                SupportedLanguage.Is => "is",
                SupportedLanguage.It => "it",
                SupportedLanguage.Ja => "ja",
                SupportedLanguage.Ka => "ka",
                SupportedLanguage.Kk => "kk",
                SupportedLanguage.Ko => "ko",
                SupportedLanguage.Ku => "ku",
                SupportedLanguage.Ky => "ky",
                SupportedLanguage.Lt => "lt",
                SupportedLanguage.Lv => "lv",
                SupportedLanguage.Mi => "mi",
                SupportedLanguage.Mn => "mn",
                SupportedLanguage.Mr => "mr",
                SupportedLanguage.Ms => "ms",
                SupportedLanguage.Mt => "mt",
                SupportedLanguage.Nb => "nb",
                SupportedLanguage.Nl => "nl",
                SupportedLanguage.No => "no",
                SupportedLanguage.Ns => "ns",
                SupportedLanguage.Pl => "pl",
                SupportedLanguage.Ps => "ps",
                SupportedLanguage.Pt => "pt",
                SupportedLanguage.PtBr => "pt-br",
                SupportedLanguage.Qu => "qu",
                SupportedLanguage.Ro => "ro",
                SupportedLanguage.Ru => "ru",
                SupportedLanguage.Sk => "sk",
                SupportedLanguage.Sq => "sq",
                SupportedLanguage.Sv => "sv",
                SupportedLanguage.Sw => "sw",
                SupportedLanguage.Ta => "ta",
                SupportedLanguage.Te => "te",
                SupportedLanguage.Th => "th",
                SupportedLanguage.Tl => "tl",
                SupportedLanguage.Tn => "tn",
                SupportedLanguage.Tr => "tr",
                SupportedLanguage.Tt => "tt",
                SupportedLanguage.Uk => "uk",
                SupportedLanguage.Ur => "ur",
                SupportedLanguage.Uz => "uz",
                SupportedLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => SupportedLanguage.Af,
                "ar" => SupportedLanguage.Ar,
                "az" => SupportedLanguage.Az,
                "bg" => SupportedLanguage.Bg,
                "bn" => SupportedLanguage.Bn,
                "ca" => SupportedLanguage.Ca,
                "cs" => SupportedLanguage.Cs,
                "cy" => SupportedLanguage.Cy,
                "da" => SupportedLanguage.Da,
                "de" => SupportedLanguage.De,
                "el" => SupportedLanguage.El,
                "en" => SupportedLanguage.En,
                "eo" => SupportedLanguage.Eo,
                "es" => SupportedLanguage.Es,
                "et" => SupportedLanguage.Et,
                "eu" => SupportedLanguage.Eu,
                "fa" => SupportedLanguage.Fa,
                "fi" => SupportedLanguage.Fi,
                "fo" => SupportedLanguage.Fo,
                "fr" => SupportedLanguage.Fr,
                "ga" => SupportedLanguage.Ga,
                "gl" => SupportedLanguage.Gl,
                "he" => SupportedLanguage.He,
                "hi" => SupportedLanguage.Hi,
                "hu" => SupportedLanguage.Hu,
                "hy" => SupportedLanguage.Hy,
                "id" => SupportedLanguage.Id,
                "is" => SupportedLanguage.Is,
                "it" => SupportedLanguage.It,
                "ja" => SupportedLanguage.Ja,
                "ka" => SupportedLanguage.Ka,
                "kk" => SupportedLanguage.Kk,
                "ko" => SupportedLanguage.Ko,
                "ku" => SupportedLanguage.Ku,
                "ky" => SupportedLanguage.Ky,
                "lt" => SupportedLanguage.Lt,
                "lv" => SupportedLanguage.Lv,
                "mi" => SupportedLanguage.Mi,
                "mn" => SupportedLanguage.Mn,
                "mr" => SupportedLanguage.Mr,
                "ms" => SupportedLanguage.Ms,
                "mt" => SupportedLanguage.Mt,
                "nb" => SupportedLanguage.Nb,
                "nl" => SupportedLanguage.Nl,
                "no" => SupportedLanguage.No,
                "ns" => SupportedLanguage.Ns,
                "pl" => SupportedLanguage.Pl,
                "ps" => SupportedLanguage.Ps,
                "pt" => SupportedLanguage.Pt,
                "pt-br" => SupportedLanguage.PtBr,
                "qu" => SupportedLanguage.Qu,
                "ro" => SupportedLanguage.Ro,
                "ru" => SupportedLanguage.Ru,
                "sk" => SupportedLanguage.Sk,
                "sq" => SupportedLanguage.Sq,
                "sv" => SupportedLanguage.Sv,
                "sw" => SupportedLanguage.Sw,
                "ta" => SupportedLanguage.Ta,
                "te" => SupportedLanguage.Te,
                "th" => SupportedLanguage.Th,
                "tl" => SupportedLanguage.Tl,
                "tn" => SupportedLanguage.Tn,
                "tr" => SupportedLanguage.Tr,
                "tt" => SupportedLanguage.Tt,
                "uk" => SupportedLanguage.Uk,
                "ur" => SupportedLanguage.Ur,
                "uz" => SupportedLanguage.Uz,
                "zh" => SupportedLanguage.Zh,
                _ => null,
            };
        }
    }
}
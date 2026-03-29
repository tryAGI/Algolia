
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Access control list permissions.
    /// </summary>
    public enum Acl
    {
        /// <summary>
        /// 
        /// </summary>
        AddObject,
        /// <summary>
        /// 
        /// </summary>
        Analytics,
        /// <summary>
        /// 
        /// </summary>
        Browse,
        /// <summary>
        /// 
        /// </summary>
        DeleteIndex,
        /// <summary>
        /// 
        /// </summary>
        DeleteObject,
        /// <summary>
        /// 
        /// </summary>
        EditSettings,
        /// <summary>
        /// 
        /// </summary>
        Inference,
        /// <summary>
        /// 
        /// </summary>
        ListIndexes,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        NluPrediction,
        /// <summary>
        /// 
        /// </summary>
        NluReadAnswers,
        /// <summary>
        /// 
        /// </summary>
        NluReadEntity,
        /// <summary>
        /// 
        /// </summary>
        NluReadIntent,
        /// <summary>
        /// 
        /// </summary>
        NluReadProject,
        /// <summary>
        /// 
        /// </summary>
        NluWriteEntity,
        /// <summary>
        /// 
        /// </summary>
        NluWriteIntent,
        /// <summary>
        /// 
        /// </summary>
        NluWriteProject,
        /// <summary>
        /// 
        /// </summary>
        Personalization,
        /// <summary>
        /// 
        /// </summary>
        Recommendation,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        SeeUnretrievableAttributes,
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Acl value)
        {
            return value switch
            {
                Acl.AddObject => "addObject",
                Acl.Analytics => "analytics",
                Acl.Browse => "browse",
                Acl.DeleteIndex => "deleteIndex",
                Acl.DeleteObject => "deleteObject",
                Acl.EditSettings => "editSettings",
                Acl.Inference => "inference",
                Acl.ListIndexes => "listIndexes",
                Acl.Logs => "logs",
                Acl.NluPrediction => "nluPrediction",
                Acl.NluReadAnswers => "nluReadAnswers",
                Acl.NluReadEntity => "nluReadEntity",
                Acl.NluReadIntent => "nluReadIntent",
                Acl.NluReadProject => "nluReadProject",
                Acl.NluWriteEntity => "nluWriteEntity",
                Acl.NluWriteIntent => "nluWriteIntent",
                Acl.NluWriteProject => "nluWriteProject",
                Acl.Personalization => "personalization",
                Acl.Recommendation => "recommendation",
                Acl.Search => "search",
                Acl.SeeUnretrievableAttributes => "seeUnretrievableAttributes",
                Acl.Settings => "settings",
                Acl.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Acl? ToEnum(string value)
        {
            return value switch
            {
                "addObject" => Acl.AddObject,
                "analytics" => Acl.Analytics,
                "browse" => Acl.Browse,
                "deleteIndex" => Acl.DeleteIndex,
                "deleteObject" => Acl.DeleteObject,
                "editSettings" => Acl.EditSettings,
                "inference" => Acl.Inference,
                "listIndexes" => Acl.ListIndexes,
                "logs" => Acl.Logs,
                "nluPrediction" => Acl.NluPrediction,
                "nluReadAnswers" => Acl.NluReadAnswers,
                "nluReadEntity" => Acl.NluReadEntity,
                "nluReadIntent" => Acl.NluReadIntent,
                "nluReadProject" => Acl.NluReadProject,
                "nluWriteEntity" => Acl.NluWriteEntity,
                "nluWriteIntent" => Acl.NluWriteIntent,
                "nluWriteProject" => Acl.NluWriteProject,
                "personalization" => Acl.Personalization,
                "recommendation" => Acl.Recommendation,
                "search" => Acl.Search,
                "seeUnretrievableAttributes" => Acl.SeeUnretrievableAttributes,
                "settings" => Acl.Settings,
                "usage" => Acl.Usage,
                _ => null,
            };
        }
    }
}
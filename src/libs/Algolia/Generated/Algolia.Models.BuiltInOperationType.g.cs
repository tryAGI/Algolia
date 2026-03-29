
#nullable enable

namespace Algolia
{
    /// <summary>
    /// How to change the attribute.
    /// </summary>
    public enum BuiltInOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        AddUnique,
        /// <summary>
        /// 
        /// </summary>
        Decrement,
        /// <summary>
        /// 
        /// </summary>
        Increment,
        /// <summary>
        /// 
        /// </summary>
        IncrementFrom,
        /// <summary>
        /// 
        /// </summary>
        IncrementSet,
        /// <summary>
        /// 
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuiltInOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuiltInOperationType value)
        {
            return value switch
            {
                BuiltInOperationType.Add => "Add",
                BuiltInOperationType.AddUnique => "AddUnique",
                BuiltInOperationType.Decrement => "Decrement",
                BuiltInOperationType.Increment => "Increment",
                BuiltInOperationType.IncrementFrom => "IncrementFrom",
                BuiltInOperationType.IncrementSet => "IncrementSet",
                BuiltInOperationType.Remove => "Remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuiltInOperationType? ToEnum(string value)
        {
            return value switch
            {
                "Add" => BuiltInOperationType.Add,
                "AddUnique" => BuiltInOperationType.AddUnique,
                "Decrement" => BuiltInOperationType.Decrement,
                "Increment" => BuiltInOperationType.Increment,
                "IncrementFrom" => BuiltInOperationType.IncrementFrom,
                "IncrementSet" => BuiltInOperationType.IncrementSet,
                "Remove" => BuiltInOperationType.Remove,
                _ => null,
            };
        }
    }
}
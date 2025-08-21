namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains helper methods for numeric operations.
/// </summary>
public static class Numeric
{
    /// <summary>
    ///     Returns true if the passed-in type is numeric.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>Trfue, if numeric.</returns>
    public static bool IsNumericType(Type type)
    {
        return NumericTypes.Contains(type) || NumericTypes.Contains(type.BaseType!) ||
               NumericTypes.Contains(Nullable.GetUnderlyingType(type)!);
    }

    private static readonly HashSet<Type> NumericTypes =
    [
        typeof(int),
        typeof(uint),
        typeof(double),
        typeof(Single),
        typeof(Int64),
        typeof(Int32),
        typeof(Int16),
        typeof(UInt64),
        typeof(UInt32),
        typeof(UInt16),
        typeof(SByte),
        typeof(Byte)
    ];
}

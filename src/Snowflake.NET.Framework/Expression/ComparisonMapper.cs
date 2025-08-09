namespace Snowflake.NET.Framework.Expression;

/// <summary>
///     Maps .Net text comparison descriptions to the actual operator.
/// </summary>
public static class ComparisonMapper
{
    /// <summary>
    ///     Maps the passed-in comparison description to the actual operator.
    /// </summary>
    /// <param name="comparisonName">The comparison description to map.</param>
    /// <returns>The operator as a string.</returns>
    /// <exception cref="ArgumentException">Thrown if a unknown description is given.</exception>
    public static string Map(string comparisonName) => comparisonName.ToUpperInvariant() switch
    {
        "EQUAL" => "=",
        "NOTEQUAL" => "!=",
        "LESSTHAN" => "<",
        "LESSTHANEQUAL" => "<=",
        "GREATERTHAN" => ">",
        "GREATERTHANEQUAL" => ">=",
        _ => throw new ArgumentException($"{comparisonName} is not a known comparison type name.")
    };
}

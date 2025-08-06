using System.Text;

namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains methods for handling default database labels in .NET.
/// </summary>
public static class Transforms
{
    /// <summary>
    ///     Transforms database object labels into .NET friendly values.
    /// </summary>
    /// <param name="value">The value to transform.</param>
    /// <returns>A transformed label value.</returns>
    public static string TransformLabel(string value)
    {
        const char splitChar = '_';

        var sb = new StringBuilder();
        if (!string.IsNullOrWhiteSpace(value))
        {
                
            foreach (var elm in value.Split(splitChar))
            {
                for (var indx = 0; indx < elm.Length; indx++)
                {
#pragma warning disable CA1308 // Normalize strings to uppercase
                    sb.Append(indx == 0 ? elm[indx].ToString().ToUpperInvariant() : elm[indx].ToString().ToLowerInvariant());
#pragma warning restore CA1308 // Normalize strings to uppercase
                }
            }
        }

        return sb.ToString();
    }
}
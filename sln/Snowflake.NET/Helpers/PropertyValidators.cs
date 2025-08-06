namespace Snowflake.NET.Validation;

/// <summary>
///     Contains methods for validating properties.
/// </summary>
public static class PropertyValidators
{
    /// <summary>
    ///     Returns 'true' is the passed-in object is not null, otherwise throws a ArgumentNullException.
    /// </summary>
    /// <typeparam name="T">The object type parameter.</typeparam>
    /// <param name="value">The value to be validated.</param>
    /// <returns>True, if not null.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
    public static bool ValidateArgument<T>(T value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return true;
    }
}

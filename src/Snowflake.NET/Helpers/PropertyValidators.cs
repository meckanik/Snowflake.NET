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
        ArgumentNullException.ThrowIfNullOrEmpty(nameof(value));

        return true;
    }

    /// <summary>
    ///     Returns 'true' is the passed-in object is not null, otherwise throws a ArgumentNullException.
    /// </summary>
    /// <typeparam name="T">The object type parameter.</typeparam>
    /// <param name="value">The value to be validated.</param>
    /// <returns>True, if not null.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the value is null or empty.</exception>
    public static bool ValidateArgument<T>(IEnumerable<T> value)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(nameof(value));

        if (!value.Any())
        {
            throw new ArgumentNullException("Array was empty.");
        }

        return true;
    }
}

namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains null-check helper methods.
/// </summary>
public static class NullCheck
{
    /// <summary>
    ///     Throws a <see cref="ArgumentNullException"/> if the value is null.
    /// </summary>
    /// <param name="value">The object to validate.</param>
    /// <returns>True, if not null.</returns>
    public static bool Argument(object? value)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(nameof(value));

        return true;
    }

    /// <summary>
    ///     Throws a <see cref="ArgumentNullException"/> if the value is null.
    /// </summary>
    /// <param name="value">The object to validate.</param>
    /// <returns>True, if not null.</returns>
    public static bool Value(object? value)
    {
        if (value is null)
        {
            throw new InvalidOperationException("Value was null.");
        }

        return true;
    }
}

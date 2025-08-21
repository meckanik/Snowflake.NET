using System.Collections.Frozen;

namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains helper methods for using Reflection with objects.
/// </summary>
public static class ReflectionHelpers
{
    /// <summary>
    ///     Returns a <see cref="FrozenDictionary"/> of properties and values
    ///     from the passed-in class.
    /// </summary>
    /// <typeparam name="T">The class type.</typeparam>
    /// <param name="value">The class value.</param>
    /// <returns><see cref="FrozenDictionary{string, object}"/></returns>
    public static FrozenDictionary<string, object?> GetPropertyValues<T>(T value) where T : class
    {
        var result = new Dictionary<string, object?>();
        foreach (var prop in typeof(T).GetProperties().ToList())
        {
            result.TryAdd(prop.Name, prop.GetValue(value));
        }

        return result.ToFrozenDictionary();
    }
}

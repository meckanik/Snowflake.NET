namespace Snowflake.NET.Models;

/// <summary>
///     Property class for schema data.
/// </summary>
public class SchemaData
{
    /// <summary>
    ///     Gets or sets the SchemaName value.
    /// </summary>
    public string SchemaName { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the SchemaContextName value.
    /// </summary>
    public string SchemaContextName { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the TableNameList value.
    /// </summary>
    public List<KeyValuePair<string, string>> TableNameList { get; set; } = [];
}

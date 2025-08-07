namespace Snowflake.NET.Models.DAO;

/// <summary>
///     Property class for INFORMATION_SCHEMA table.
/// </summary>
public class InformationTable
{
#pragma warning disable CA1707 // Identifiers should not contain underscores
    /// <summary>
    ///     Gets or sets the TABLE_CATALOG value.
    /// </summary>
    public string? TABLE_CATALOG { get; set; }

    /// <summary>
    ///     Gets or sets the TABLE_SCHEMA value.
    /// </summary>
    public string? TABLE_SCHEMA { get; set; }

    /// <summary>
    ///     Gets or sets the TABLE_NAME value.
    /// </summary>
    public string? TABLE_NAME { get; set; }

    /// <summary>
    ///     Gets or sets the TABLE_TYPE value.
    /// </summary>
    public string? TABLE_TYPE { get; set; }
#pragma warning restore CA1707 // Identifiers should not contain underscores
}

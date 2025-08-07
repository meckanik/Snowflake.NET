namespace Snowflake.NET.Models.DAO;

/// <summary>
///     Property class for INFORMATION_SCHEMA table.
/// </summary>
public class InformationColumn
{
#pragma warning disable CA1707 // Identifiers should not contain underscores
    /// <summary>
    ///     Gets or sets the TABLE_CATALOG value.
    /// </summary>
    public string? TABLE_CATALOG {  get; set; }

    /// <summary>
    ///     Gets or sets the TABLE_SCHEMA value.
    /// </summary>
    public string? TABLE_SCHEMA { get; set; }

    /// <summary>
    ///     Gets or sets the TABLE_NAME value.
    /// </summary>
    public string? TABLE_NAME { get; set; }

    /// <summary>
    ///     Gets or sets the COLUMN_NAME value.
    /// </summary>
    public string? COLUMN_NAME { get; set; }

    /// <summary>
    ///     Gets or sets the ORDINAL_POSITION value.
    /// </summary>
    public int? ORDINAL_POSITION { get; set; }

    /// <summary>
    ///     Gets or sets the IS_NULLABLE value.
    /// </summary>
    public string? IS_NULLABLE { get; set; }

    /// <summary>
    ///     Gets or sets the DATA_TYPE value.
    /// </summary>
    public string? DATA_TYPE { get; set; }
#pragma warning restore CA1707 // Identifiers should not contain underscores
}

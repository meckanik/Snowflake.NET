namespace Snowflake.NET.Models.DAO;

/// <summary>
///     Property class for INFORMATION_SCHEMA table.
/// </summary>
public class InformationDatabase
{
#pragma warning disable CA1707 // Identifiers should not contain underscores
    /// <summary>
    ///     Gets or sets the DATABASE_NAME value.
    /// </summary>
    public string? DATABASE_NAME { get; set; }

    /// <summary>
    ///     Gets or sets the DATABASE_OWNER value.
    /// </summary>
    public string? DATABASE_OWNER { get; set; }

    /// <summary>
    ///     Gets or sets the IS_TRANSIENT value.
    /// </summary>
    public bool? IS_TRANSIENT { get; set; }

    /// <summary>
    ///     Gets or sets the COMMENT value.
    /// </summary>
    public string? COMMENT { get; set; }

    /// <summary>
    ///     Gets or sets the CREATED value.
    /// </summary>
    public TimeSpan? CREATED { get; set; }

    /// <summary>
    ///     Gets or sets the LAST_ALTERED value.
    /// </summary>
    public TimeSpan? LAST_ALTERED { get; set; }

    /// <summary>
    ///     Gets or sets the RETENTION_TIME value.
    /// </summary>
    public int? RETENTION_TIME { get; set; }

    /// <summary>
    ///     Gets or sets the TYPE value.
    /// </summary>
    public string? TYPE { get; set; }

    /// <summary>
    ///     Gets or sets the REPLICABLE_WITH_FAILOVER_GROUPS value.
    /// </summary>
    public string? REPLICABLE_WITH_FAILOVER_GROUPS { get; set; }

    /// <summary>
    ///     Gets or sets the OWNER_ROLE_TYPE value.
    /// </summary>
    public string? OWNER_ROLE_TYPE { get; set; }
#pragma warning restore CA1707 // Identifiers should not contain underscores
}

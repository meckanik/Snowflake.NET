using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the REASON table.
/// </summary>
[TableName("TPCDS_SF10TCL.REASON")]
public class Reason
{
	/// <summary>
	///	Gets or sets the R_REASON_DESC value.
	/// </summary>
	[PropertyName("R_REASON_DESC")]
	public String? RReasonDesc  { get; set; }

	/// <summary>
	///	Gets or sets the R_REASON_ID value.
	/// </summary>
	[PropertyName("R_REASON_ID")]
	public String? RReasonId  { get; set; }

	/// <summary>
	///	Gets or sets the R_REASON_SK value.
	/// </summary>
	[PropertyName("R_REASON_SK")]
	public Int32? RReasonSk  { get; set; }
}

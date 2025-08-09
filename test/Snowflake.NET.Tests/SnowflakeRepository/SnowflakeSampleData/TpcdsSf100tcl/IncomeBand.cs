using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the INCOME_BAND table.
/// </summary>
[TableName("TPCDS_SF100TCL.INCOME_BAND")]
public class IncomeBand
{
	/// <summary>
	///	Gets or sets the IB_LOWER_BOUND value.
	/// </summary>
	[PropertyName("IB_LOWER_BOUND")]
	public Int32? IbLowerBound  { get; set; }

	/// <summary>
	///	Gets or sets the IB_UPPER_BOUND value.
	/// </summary>
	[PropertyName("IB_UPPER_BOUND")]
	public Int32? IbUpperBound  { get; set; }

	/// <summary>
	///	Gets or sets the IB_INCOME_BAND_SK value.
	/// </summary>
	[PropertyName("IB_INCOME_BAND_SK")]
	public Int32? IbIncomeBandSk  { get; set; }
}

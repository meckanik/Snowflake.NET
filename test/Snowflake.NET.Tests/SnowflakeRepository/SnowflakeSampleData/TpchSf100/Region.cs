using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf100;

/// <summary>
///		Property class for the REGION table.
/// </summary>
[TableName("TPCH_SF100.REGION")]
public class Region
{
	/// <summary>
	///	Gets or sets the R_REGIONKEY value.
	/// </summary>
	[PropertyName("R_REGIONKEY")]
	public Int32? RRegionkey  { get; set; }

	/// <summary>
	///	Gets or sets the R_COMMENT value.
	/// </summary>
	[PropertyName("R_COMMENT")]
	public String? RComment  { get; set; }

	/// <summary>
	///	Gets or sets the R_NAME value.
	/// </summary>
	[PropertyName("R_NAME")]
	public String? RName  { get; set; }
}

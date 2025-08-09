using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf10;

/// <summary>
///		Property class for the PARTSUPP table.
/// </summary>
[TableName("TPCH_SF10.PARTSUPP")]
public class Partsupp
{
	/// <summary>
	///	Gets or sets the PS_AVAILQTY value.
	/// </summary>
	[PropertyName("PS_AVAILQTY")]
	public Int32? PsAvailqty  { get; set; }

	/// <summary>
	///	Gets or sets the PS_SUPPLYCOST value.
	/// </summary>
	[PropertyName("PS_SUPPLYCOST")]
	public Decimal? PsSupplycost  { get; set; }

	/// <summary>
	///	Gets or sets the PS_SUPPKEY value.
	/// </summary>
	[PropertyName("PS_SUPPKEY")]
	public Int32? PsSuppkey  { get; set; }

	/// <summary>
	///	Gets or sets the PS_COMMENT value.
	/// </summary>
	[PropertyName("PS_COMMENT")]
	public String? PsComment  { get; set; }

	/// <summary>
	///	Gets or sets the PS_PARTKEY value.
	/// </summary>
	[PropertyName("PS_PARTKEY")]
	public Int32? PsPartkey  { get; set; }
}

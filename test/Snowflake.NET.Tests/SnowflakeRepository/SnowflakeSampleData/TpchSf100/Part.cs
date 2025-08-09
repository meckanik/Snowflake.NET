using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf100;

/// <summary>
///		Property class for the PART table.
/// </summary>
[TableName("TPCH_SF100.PART")]
public class Part
{
	/// <summary>
	///	Gets or sets the P_COMMENT value.
	/// </summary>
	[PropertyName("P_COMMENT")]
	public String? PComment  { get; set; }

	/// <summary>
	///	Gets or sets the P_RETAILPRICE value.
	/// </summary>
	[PropertyName("P_RETAILPRICE")]
	public Decimal? PRetailprice  { get; set; }

	/// <summary>
	///	Gets or sets the P_NAME value.
	/// </summary>
	[PropertyName("P_NAME")]
	public String? PName  { get; set; }

	/// <summary>
	///	Gets or sets the P_BRAND value.
	/// </summary>
	[PropertyName("P_BRAND")]
	public String? PBrand  { get; set; }

	/// <summary>
	///	Gets or sets the P_PARTKEY value.
	/// </summary>
	[PropertyName("P_PARTKEY")]
	public Int32? PPartkey  { get; set; }

	/// <summary>
	///	Gets or sets the P_MFGR value.
	/// </summary>
	[PropertyName("P_MFGR")]
	public String? PMfgr  { get; set; }

	/// <summary>
	///	Gets or sets the P_SIZE value.
	/// </summary>
	[PropertyName("P_SIZE")]
	public Int32? PSize  { get; set; }

	/// <summary>
	///	Gets or sets the P_CONTAINER value.
	/// </summary>
	[PropertyName("P_CONTAINER")]
	public String? PContainer  { get; set; }

	/// <summary>
	///	Gets or sets the P_TYPE value.
	/// </summary>
	[PropertyName("P_TYPE")]
	public String? PType  { get; set; }
}

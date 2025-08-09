using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1000;

/// <summary>
///		Property class for the ORDERS table.
/// </summary>
[TableName("TPCH_SF1000.ORDERS")]
public class Orders
{
	/// <summary>
	///	Gets or sets the O_CUSTKEY value.
	/// </summary>
	[PropertyName("O_CUSTKEY")]
	public Int32? OCustkey  { get; set; }

	/// <summary>
	///	Gets or sets the O_CLERK value.
	/// </summary>
	[PropertyName("O_CLERK")]
	public String? OClerk  { get; set; }

	/// <summary>
	///	Gets or sets the O_TOTALPRICE value.
	/// </summary>
	[PropertyName("O_TOTALPRICE")]
	public Decimal? OTotalprice  { get; set; }

	/// <summary>
	///	Gets or sets the O_SHIPPRIORITY value.
	/// </summary>
	[PropertyName("O_SHIPPRIORITY")]
	public Int32? OShippriority  { get; set; }

	/// <summary>
	///	Gets or sets the O_ORDERDATE value.
	/// </summary>
	[PropertyName("O_ORDERDATE")]
	public DateTime? OOrderdate  { get; set; }

	/// <summary>
	///	Gets or sets the O_ORDERKEY value.
	/// </summary>
	[PropertyName("O_ORDERKEY")]
	public Int32? OOrderkey  { get; set; }

	/// <summary>
	///	Gets or sets the O_COMMENT value.
	/// </summary>
	[PropertyName("O_COMMENT")]
	public String? OComment  { get; set; }

	/// <summary>
	///	Gets or sets the O_ORDERSTATUS value.
	/// </summary>
	[PropertyName("O_ORDERSTATUS")]
	public String? OOrderstatus  { get; set; }

	/// <summary>
	///	Gets or sets the O_ORDERPRIORITY value.
	/// </summary>
	[PropertyName("O_ORDERPRIORITY")]
	public String? OOrderpriority  { get; set; }
}

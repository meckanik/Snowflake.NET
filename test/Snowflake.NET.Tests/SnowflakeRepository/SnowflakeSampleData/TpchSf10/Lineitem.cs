using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf10;

/// <summary>
///		Property class for the LINEITEM table.
/// </summary>
[TableName("LINEITEM")]
public class Lineitem
{
	/// <summary>
	///	Gets or sets the L_ORDERKEY value.
	/// </summary>
	[PropertyName("L_ORDERKEY")]
	public Int32? LOrderkey  { get; set; }

	/// <summary>
	///	Gets or sets the L_TAX value.
	/// </summary>
	[PropertyName("L_TAX")]
	public Int32? LTax  { get; set; }

	/// <summary>
	///	Gets or sets the L_SHIPINSTRUCT value.
	/// </summary>
	[PropertyName("L_SHIPINSTRUCT")]
	public String? LShipinstruct  { get; set; }

	/// <summary>
	///	Gets or sets the L_SHIPMODE value.
	/// </summary>
	[PropertyName("L_SHIPMODE")]
	public String? LShipmode  { get; set; }

	/// <summary>
	///	Gets or sets the L_LINESTATUS value.
	/// </summary>
	[PropertyName("L_LINESTATUS")]
	public String? LLinestatus  { get; set; }

	/// <summary>
	///	Gets or sets the L_EXTENDEDPRICE value.
	/// </summary>
	[PropertyName("L_EXTENDEDPRICE")]
	public Int32? LExtendedprice  { get; set; }

	/// <summary>
	///	Gets or sets the L_PARTKEY value.
	/// </summary>
	[PropertyName("L_PARTKEY")]
	public Int32? LPartkey  { get; set; }

	/// <summary>
	///	Gets or sets the L_SUPPKEY value.
	/// </summary>
	[PropertyName("L_SUPPKEY")]
	public Int32? LSuppkey  { get; set; }

	/// <summary>
	///	Gets or sets the L_RETURNFLAG value.
	/// </summary>
	[PropertyName("L_RETURNFLAG")]
	public String? LReturnflag  { get; set; }

	/// <summary>
	///	Gets or sets the L_COMMITDATE value.
	/// </summary>
	[PropertyName("L_COMMITDATE")]
	public DateTime? LCommitdate  { get; set; }

	/// <summary>
	///	Gets or sets the L_DISCOUNT value.
	/// </summary>
	[PropertyName("L_DISCOUNT")]
	public Int32? LDiscount  { get; set; }

	/// <summary>
	///	Gets or sets the L_LINENUMBER value.
	/// </summary>
	[PropertyName("L_LINENUMBER")]
	public Int32? LLinenumber  { get; set; }

	/// <summary>
	///	Gets or sets the L_RECEIPTDATE value.
	/// </summary>
	[PropertyName("L_RECEIPTDATE")]
	public DateTime? LReceiptdate  { get; set; }

	/// <summary>
	///	Gets or sets the L_QUANTITY value.
	/// </summary>
	[PropertyName("L_QUANTITY")]
	public Int32? LQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the L_COMMENT value.
	/// </summary>
	[PropertyName("L_COMMENT")]
	public String? LComment  { get; set; }

	/// <summary>
	///	Gets or sets the L_SHIPDATE value.
	/// </summary>
	[PropertyName("L_SHIPDATE")]
	public DateTime? LShipdate  { get; set; }
}

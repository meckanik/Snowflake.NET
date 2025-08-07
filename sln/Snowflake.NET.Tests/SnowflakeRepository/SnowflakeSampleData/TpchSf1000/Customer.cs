using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1000;

/// <summary>
///		Property class for the CUSTOMER table.
/// </summary>
[TableName("CUSTOMER")]
public class Customer
{
	/// <summary>
	///	Gets or sets the C_ACCTBAL value.
	/// </summary>
	[PropertyName("C_ACCTBAL")]
	public Int32? CAcctbal  { get; set; }

	/// <summary>
	///	Gets or sets the C_COMMENT value.
	/// </summary>
	[PropertyName("C_COMMENT")]
	public String? CComment  { get; set; }

	/// <summary>
	///	Gets or sets the C_PHONE value.
	/// </summary>
	[PropertyName("C_PHONE")]
	public String? CPhone  { get; set; }

	/// <summary>
	///	Gets or sets the C_ADDRESS value.
	/// </summary>
	[PropertyName("C_ADDRESS")]
	public String? CAddress  { get; set; }

	/// <summary>
	///	Gets or sets the C_NAME value.
	/// </summary>
	[PropertyName("C_NAME")]
	public String? CName  { get; set; }

	/// <summary>
	///	Gets or sets the C_NATIONKEY value.
	/// </summary>
	[PropertyName("C_NATIONKEY")]
	public Int32? CNationkey  { get; set; }

	/// <summary>
	///	Gets or sets the C_MKTSEGMENT value.
	/// </summary>
	[PropertyName("C_MKTSEGMENT")]
	public String? CMktsegment  { get; set; }

	/// <summary>
	///	Gets or sets the C_CUSTKEY value.
	/// </summary>
	[PropertyName("C_CUSTKEY")]
	public Int32? CCustkey  { get; set; }
}

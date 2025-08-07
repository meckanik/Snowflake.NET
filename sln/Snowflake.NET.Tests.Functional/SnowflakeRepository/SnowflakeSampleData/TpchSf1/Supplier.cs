using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1;

/// <summary>
///		Property class for the SUPPLIER table.
/// </summary>
[TableName("SUPPLIER")]
public class Supplier
{
	/// <summary>
	///	Gets or sets the S_NAME value.
	/// </summary>
	[PropertyName("S_NAME")]
	public String? SName  { get; set; }

	/// <summary>
	///	Gets or sets the S_ACCTBAL value.
	/// </summary>
	[PropertyName("S_ACCTBAL")]
	public Int32? SAcctbal  { get; set; }

	/// <summary>
	///	Gets or sets the S_SUPPKEY value.
	/// </summary>
	[PropertyName("S_SUPPKEY")]
	public Int32? SSuppkey  { get; set; }

	/// <summary>
	///	Gets or sets the S_NATIONKEY value.
	/// </summary>
	[PropertyName("S_NATIONKEY")]
	public Int32? SNationkey  { get; set; }

	/// <summary>
	///	Gets or sets the S_COMMENT value.
	/// </summary>
	[PropertyName("S_COMMENT")]
	public String? SComment  { get; set; }

	/// <summary>
	///	Gets or sets the S_PHONE value.
	/// </summary>
	[PropertyName("S_PHONE")]
	public String? SPhone  { get; set; }

	/// <summary>
	///	Gets or sets the S_ADDRESS value.
	/// </summary>
	[PropertyName("S_ADDRESS")]
	public String? SAddress  { get; set; }
}

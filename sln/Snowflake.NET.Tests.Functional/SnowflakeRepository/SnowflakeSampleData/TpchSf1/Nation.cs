using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1;

/// <summary>
///		Property class for the NATION table.
/// </summary>
[TableName("NATION")]
public class Nation
{
	/// <summary>
	///	Gets or sets the N_NATIONKEY value.
	/// </summary>
	[PropertyName("N_NATIONKEY")]
	public Int32? NNationkey  { get; set; }

	/// <summary>
	///	Gets or sets the N_NAME value.
	/// </summary>
	[PropertyName("N_NAME")]
	public String? NName  { get; set; }

	/// <summary>
	///	Gets or sets the N_REGIONKEY value.
	/// </summary>
	[PropertyName("N_REGIONKEY")]
	public Int32? NRegionkey  { get; set; }

	/// <summary>
	///	Gets or sets the N_COMMENT value.
	/// </summary>
	[PropertyName("N_COMMENT")]
	public String? NComment  { get; set; }
}

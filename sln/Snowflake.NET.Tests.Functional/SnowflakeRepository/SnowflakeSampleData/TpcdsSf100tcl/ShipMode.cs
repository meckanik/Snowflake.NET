using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the SHIP_MODE table.
/// </summary>
[TableName("SHIP_MODE")]
public class ShipMode
{
	/// <summary>
	///	Gets or sets the SM_TYPE value.
	/// </summary>
	[PropertyName("SM_TYPE")]
	public String? SmType  { get; set; }

	/// <summary>
	///	Gets or sets the SM_SHIP_MODE_SK value.
	/// </summary>
	[PropertyName("SM_SHIP_MODE_SK")]
	public Int32? SmShipModeSk  { get; set; }

	/// <summary>
	///	Gets or sets the SM_CONTRACT value.
	/// </summary>
	[PropertyName("SM_CONTRACT")]
	public String? SmContract  { get; set; }

	/// <summary>
	///	Gets or sets the SM_CARRIER value.
	/// </summary>
	[PropertyName("SM_CARRIER")]
	public String? SmCarrier  { get; set; }

	/// <summary>
	///	Gets or sets the SM_SHIP_MODE_ID value.
	/// </summary>
	[PropertyName("SM_SHIP_MODE_ID")]
	public String? SmShipModeId  { get; set; }

	/// <summary>
	///	Gets or sets the SM_CODE value.
	/// </summary>
	[PropertyName("SM_CODE")]
	public String? SmCode  { get; set; }
}

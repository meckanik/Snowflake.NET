using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the INVENTORY table.
/// </summary>
[TableName("TPCDS_SF10TCL.INVENTORY")]
public class Inventory
{
	/// <summary>
	///	Gets or sets the INV_QUANTITY_ON_HAND value.
	/// </summary>
	[PropertyName("INV_QUANTITY_ON_HAND")]
	public Int32? InvQuantityOnHand  { get; set; }

	/// <summary>
	///	Gets or sets the INV_DATE_SK value.
	/// </summary>
	[PropertyName("INV_DATE_SK")]
	public Int32? InvDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the INV_ITEM_SK value.
	/// </summary>
	[PropertyName("INV_ITEM_SK")]
	public Int32? InvItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the INV_WAREHOUSE_SK value.
	/// </summary>
	[PropertyName("INV_WAREHOUSE_SK")]
	public Int32? InvWarehouseSk  { get; set; }
}

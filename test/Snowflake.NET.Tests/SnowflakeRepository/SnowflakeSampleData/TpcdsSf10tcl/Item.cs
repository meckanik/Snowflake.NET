using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the ITEM table.
/// </summary>
[TableName("TPCDS_SF10TCL.ITEM")]
public class Item
{
	/// <summary>
	///	Gets or sets the I_CATEGORY_ID value.
	/// </summary>
	[PropertyName("I_CATEGORY_ID")]
	public Int32? ICategoryId  { get; set; }

	/// <summary>
	///	Gets or sets the I_BRAND value.
	/// </summary>
	[PropertyName("I_BRAND")]
	public String? IBrand  { get; set; }

	/// <summary>
	///	Gets or sets the I_CLASS_ID value.
	/// </summary>
	[PropertyName("I_CLASS_ID")]
	public Int32? IClassId  { get; set; }

	/// <summary>
	///	Gets or sets the I_FORMULATION value.
	/// </summary>
	[PropertyName("I_FORMULATION")]
	public String? IFormulation  { get; set; }

	/// <summary>
	///	Gets or sets the I_MANUFACT value.
	/// </summary>
	[PropertyName("I_MANUFACT")]
	public String? IManufact  { get; set; }

	/// <summary>
	///	Gets or sets the I_CURRENT_PRICE value.
	/// </summary>
	[PropertyName("I_CURRENT_PRICE")]
	public Decimal? ICurrentPrice  { get; set; }

	/// <summary>
	///	Gets or sets the I_PRODUCT_NAME value.
	/// </summary>
	[PropertyName("I_PRODUCT_NAME")]
	public String? IProductName  { get; set; }

	/// <summary>
	///	Gets or sets the I_ITEM_ID value.
	/// </summary>
	[PropertyName("I_ITEM_ID")]
	public String? IItemId  { get; set; }

	/// <summary>
	///	Gets or sets the I_CLASS value.
	/// </summary>
	[PropertyName("I_CLASS")]
	public String? IClass  { get; set; }

	/// <summary>
	///	Gets or sets the I_COLOR value.
	/// </summary>
	[PropertyName("I_COLOR")]
	public String? IColor  { get; set; }

	/// <summary>
	///	Gets or sets the I_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("I_WHOLESALE_COST")]
	public Decimal? IWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the I_REC_START_DATE value.
	/// </summary>
	[PropertyName("I_REC_START_DATE")]
	public DateTime? IRecStartDate  { get; set; }

	/// <summary>
	///	Gets or sets the I_ITEM_DESC value.
	/// </summary>
	[PropertyName("I_ITEM_DESC")]
	public String? IItemDesc  { get; set; }

	/// <summary>
	///	Gets or sets the I_UNITS value.
	/// </summary>
	[PropertyName("I_UNITS")]
	public String? IUnits  { get; set; }

	/// <summary>
	///	Gets or sets the I_REC_END_DATE value.
	/// </summary>
	[PropertyName("I_REC_END_DATE")]
	public DateTime? IRecEndDate  { get; set; }

	/// <summary>
	///	Gets or sets the I_SIZE value.
	/// </summary>
	[PropertyName("I_SIZE")]
	public String? ISize  { get; set; }

	/// <summary>
	///	Gets or sets the I_MANUFACT_ID value.
	/// </summary>
	[PropertyName("I_MANUFACT_ID")]
	public Int32? IManufactId  { get; set; }

	/// <summary>
	///	Gets or sets the I_MANAGER_ID value.
	/// </summary>
	[PropertyName("I_MANAGER_ID")]
	public Int32? IManagerId  { get; set; }

	/// <summary>
	///	Gets or sets the I_ITEM_SK value.
	/// </summary>
	[PropertyName("I_ITEM_SK")]
	public Int32? IItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the I_CONTAINER value.
	/// </summary>
	[PropertyName("I_CONTAINER")]
	public String? IContainer  { get; set; }

	/// <summary>
	///	Gets or sets the I_BRAND_ID value.
	/// </summary>
	[PropertyName("I_BRAND_ID")]
	public Int32? IBrandId  { get; set; }

	/// <summary>
	///	Gets or sets the I_CATEGORY value.
	/// </summary>
	[PropertyName("I_CATEGORY")]
	public String? ICategory  { get; set; }
}

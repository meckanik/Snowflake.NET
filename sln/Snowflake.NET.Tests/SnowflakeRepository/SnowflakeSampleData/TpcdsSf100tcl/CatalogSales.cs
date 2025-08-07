using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the CATALOG_SALES table.
/// </summary>
[TableName("CATALOG_SALES")]
public class CatalogSales
{
	/// <summary>
	///	Gets or sets the CS_SHIP_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_CUSTOMER_SK")]
	public Int32? CsShipCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_WAREHOUSE_SK value.
	/// </summary>
	[PropertyName("CS_WAREHOUSE_SK")]
	public Int32? CsWarehouseSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SHIP_MODE_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_MODE_SK")]
	public Int32? CsShipModeSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_BILL_HDEMO_SK value.
	/// </summary>
	[PropertyName("CS_BILL_HDEMO_SK")]
	public Int32? CsBillHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_SALES_PRICE value.
	/// </summary>
	[PropertyName("CS_EXT_SALES_PRICE")]
	public Int32? CsExtSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SHIP_DATE_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_DATE_SK")]
	public Int32? CsShipDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_PROMO_SK value.
	/// </summary>
	[PropertyName("CS_PROMO_SK")]
	public Int32? CsPromoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_LIST_PRICE value.
	/// </summary>
	[PropertyName("CS_EXT_LIST_PRICE")]
	public Int32? CsExtListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_SHIP_COST value.
	/// </summary>
	[PropertyName("CS_EXT_SHIP_COST")]
	public Int32? CsExtShipCost  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_TAX value.
	/// </summary>
	[PropertyName("CS_EXT_TAX")]
	public Int32? CsExtTax  { get; set; }

	/// <summary>
	///	Gets or sets the CS_NET_PAID_INC_TAX value.
	/// </summary>
	[PropertyName("CS_NET_PAID_INC_TAX")]
	public Int32? CsNetPaidIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the CS_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("CS_WHOLESALE_COST")]
	public Int32? CsWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("CS_EXT_WHOLESALE_COST")]
	public Int32? CsExtWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SALES_PRICE value.
	/// </summary>
	[PropertyName("CS_SALES_PRICE")]
	public Int32? CsSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the CS_BILL_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("CS_BILL_CUSTOMER_SK")]
	public Int32? CsBillCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_NET_PAID_INC_SHIP_TAX value.
	/// </summary>
	[PropertyName("CS_NET_PAID_INC_SHIP_TAX")]
	public Int32? CsNetPaidIncShipTax  { get; set; }

	/// <summary>
	///	Gets or sets the CS_BILL_CDEMO_SK value.
	/// </summary>
	[PropertyName("CS_BILL_CDEMO_SK")]
	public Int32? CsBillCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_LIST_PRICE value.
	/// </summary>
	[PropertyName("CS_LIST_PRICE")]
	public Int32? CsListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SOLD_TIME_SK value.
	/// </summary>
	[PropertyName("CS_SOLD_TIME_SK")]
	public Int32? CsSoldTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SOLD_DATE_SK value.
	/// </summary>
	[PropertyName("CS_SOLD_DATE_SK")]
	public Int32? CsSoldDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_NET_PAID_INC_SHIP value.
	/// </summary>
	[PropertyName("CS_NET_PAID_INC_SHIP")]
	public Int32? CsNetPaidIncShip  { get; set; }

	/// <summary>
	///	Gets or sets the CS_QUANTITY value.
	/// </summary>
	[PropertyName("CS_QUANTITY")]
	public Int32? CsQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the CS_NET_PAID value.
	/// </summary>
	[PropertyName("CS_NET_PAID")]
	public Int32? CsNetPaid  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SHIP_CDEMO_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_CDEMO_SK")]
	public Int32? CsShipCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_ORDER_NUMBER value.
	/// </summary>
	[PropertyName("CS_ORDER_NUMBER")]
	public Int32? CsOrderNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CS_BILL_ADDR_SK value.
	/// </summary>
	[PropertyName("CS_BILL_ADDR_SK")]
	public Int32? CsBillAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_NET_PROFIT value.
	/// </summary>
	[PropertyName("CS_NET_PROFIT")]
	public Int32? CsNetProfit  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SHIP_ADDR_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_ADDR_SK")]
	public Int32? CsShipAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_CALL_CENTER_SK value.
	/// </summary>
	[PropertyName("CS_CALL_CENTER_SK")]
	public Int32? CsCallCenterSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_EXT_DISCOUNT_AMT value.
	/// </summary>
	[PropertyName("CS_EXT_DISCOUNT_AMT")]
	public Int32? CsExtDiscountAmt  { get; set; }

	/// <summary>
	///	Gets or sets the CS_ITEM_SK value.
	/// </summary>
	[PropertyName("CS_ITEM_SK")]
	public Int32? CsItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_CATALOG_PAGE_SK value.
	/// </summary>
	[PropertyName("CS_CATALOG_PAGE_SK")]
	public Int32? CsCatalogPageSk  { get; set; }

	/// <summary>
	///	Gets or sets the CS_COUPON_AMT value.
	/// </summary>
	[PropertyName("CS_COUPON_AMT")]
	public Int32? CsCouponAmt  { get; set; }

	/// <summary>
	///	Gets or sets the CS_SHIP_HDEMO_SK value.
	/// </summary>
	[PropertyName("CS_SHIP_HDEMO_SK")]
	public Int32? CsShipHdemoSk  { get; set; }
}

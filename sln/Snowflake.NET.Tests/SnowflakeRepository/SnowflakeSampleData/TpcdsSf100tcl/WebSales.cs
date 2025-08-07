using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the WEB_SALES table.
/// </summary>
[TableName("WEB_SALES")]
public class WebSales
{
	/// <summary>
	///	Gets or sets the WS_WEB_SITE_SK value.
	/// </summary>
	[PropertyName("WS_WEB_SITE_SK")]
	public Int32? WsWebSiteSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_QUANTITY value.
	/// </summary>
	[PropertyName("WS_QUANTITY")]
	public Int32? WsQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_CDEMO_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_CDEMO_SK")]
	public Int32? WsShipCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_SHIP_COST value.
	/// </summary>
	[PropertyName("WS_EXT_SHIP_COST")]
	public Int32? WsExtShipCost  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_TAX value.
	/// </summary>
	[PropertyName("WS_EXT_TAX")]
	public Int32? WsExtTax  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_ADDR_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_ADDR_SK")]
	public Int32? WsShipAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SALES_PRICE value.
	/// </summary>
	[PropertyName("WS_SALES_PRICE")]
	public Int32? WsSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_MODE_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_MODE_SK")]
	public Int32? WsShipModeSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_NET_PAID value.
	/// </summary>
	[PropertyName("WS_NET_PAID")]
	public Int32? WsNetPaid  { get; set; }

	/// <summary>
	///	Gets or sets the WS_NET_PAID_INC_SHIP value.
	/// </summary>
	[PropertyName("WS_NET_PAID_INC_SHIP")]
	public Int32? WsNetPaidIncShip  { get; set; }

	/// <summary>
	///	Gets or sets the WS_BILL_ADDR_SK value.
	/// </summary>
	[PropertyName("WS_BILL_ADDR_SK")]
	public Int32? WsBillAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_COUPON_AMT value.
	/// </summary>
	[PropertyName("WS_COUPON_AMT")]
	public Int32? WsCouponAmt  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("WS_EXT_WHOLESALE_COST")]
	public Int32? WsExtWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_DATE_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_DATE_SK")]
	public Int32? WsShipDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_DISCOUNT_AMT value.
	/// </summary>
	[PropertyName("WS_EXT_DISCOUNT_AMT")]
	public Int32? WsExtDiscountAmt  { get; set; }

	/// <summary>
	///	Gets or sets the WS_BILL_HDEMO_SK value.
	/// </summary>
	[PropertyName("WS_BILL_HDEMO_SK")]
	public Int32? WsBillHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_WAREHOUSE_SK value.
	/// </summary>
	[PropertyName("WS_WAREHOUSE_SK")]
	public Int32? WsWarehouseSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_ORDER_NUMBER value.
	/// </summary>
	[PropertyName("WS_ORDER_NUMBER")]
	public Int32? WsOrderNumber  { get; set; }

	/// <summary>
	///	Gets or sets the WS_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("WS_WHOLESALE_COST")]
	public Int32? WsWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_SALES_PRICE value.
	/// </summary>
	[PropertyName("WS_EXT_SALES_PRICE")]
	public Int32? WsExtSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SOLD_TIME_SK value.
	/// </summary>
	[PropertyName("WS_SOLD_TIME_SK")]
	public Int32? WsSoldTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_ITEM_SK value.
	/// </summary>
	[PropertyName("WS_ITEM_SK")]
	public Int32? WsItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_BILL_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("WS_BILL_CUSTOMER_SK")]
	public Int32? WsBillCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_PROMO_SK value.
	/// </summary>
	[PropertyName("WS_PROMO_SK")]
	public Int32? WsPromoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_HDEMO_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_HDEMO_SK")]
	public Int32? WsShipHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SHIP_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("WS_SHIP_CUSTOMER_SK")]
	public Int32? WsShipCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_BILL_CDEMO_SK value.
	/// </summary>
	[PropertyName("WS_BILL_CDEMO_SK")]
	public Int32? WsBillCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_LIST_PRICE value.
	/// </summary>
	[PropertyName("WS_LIST_PRICE")]
	public Int32? WsListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the WS_EXT_LIST_PRICE value.
	/// </summary>
	[PropertyName("WS_EXT_LIST_PRICE")]
	public Int32? WsExtListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the WS_NET_PAID_INC_SHIP_TAX value.
	/// </summary>
	[PropertyName("WS_NET_PAID_INC_SHIP_TAX")]
	public Int32? WsNetPaidIncShipTax  { get; set; }

	/// <summary>
	///	Gets or sets the WS_NET_PAID_INC_TAX value.
	/// </summary>
	[PropertyName("WS_NET_PAID_INC_TAX")]
	public Int32? WsNetPaidIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the WS_NET_PROFIT value.
	/// </summary>
	[PropertyName("WS_NET_PROFIT")]
	public Int32? WsNetProfit  { get; set; }

	/// <summary>
	///	Gets or sets the WS_WEB_PAGE_SK value.
	/// </summary>
	[PropertyName("WS_WEB_PAGE_SK")]
	public Int32? WsWebPageSk  { get; set; }

	/// <summary>
	///	Gets or sets the WS_SOLD_DATE_SK value.
	/// </summary>
	[PropertyName("WS_SOLD_DATE_SK")]
	public Int32? WsSoldDateSk  { get; set; }
}

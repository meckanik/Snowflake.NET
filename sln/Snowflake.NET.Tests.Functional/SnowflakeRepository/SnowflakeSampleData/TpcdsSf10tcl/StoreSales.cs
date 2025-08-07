using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the STORE_SALES table.
/// </summary>
[TableName("STORE_SALES")]
public class StoreSales
{
	/// <summary>
	///	Gets or sets the SS_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("SS_WHOLESALE_COST")]
	public Int32? SsWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_SALES_PRICE value.
	/// </summary>
	[PropertyName("SS_EXT_SALES_PRICE")]
	public Int32? SsExtSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_PROMO_SK value.
	/// </summary>
	[PropertyName("SS_PROMO_SK")]
	public Int32? SsPromoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_QUANTITY value.
	/// </summary>
	[PropertyName("SS_QUANTITY")]
	public Int32? SsQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_DISCOUNT_AMT value.
	/// </summary>
	[PropertyName("SS_EXT_DISCOUNT_AMT")]
	public Int32? SsExtDiscountAmt  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SOLD_DATE_SK value.
	/// </summary>
	[PropertyName("SS_SOLD_DATE_SK")]
	public Int32? SsSoldDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_CDEMO_SK value.
	/// </summary>
	[PropertyName("SS_CDEMO_SK")]
	public Int32? SsCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SOLD_TIME_SK value.
	/// </summary>
	[PropertyName("SS_SOLD_TIME_SK")]
	public Int32? SsSoldTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_STORE_SK value.
	/// </summary>
	[PropertyName("SS_STORE_SK")]
	public Int32? SsStoreSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_HDEMO_SK value.
	/// </summary>
	[PropertyName("SS_HDEMO_SK")]
	public Int32? SsHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_LIST_PRICE value.
	/// </summary>
	[PropertyName("SS_EXT_LIST_PRICE")]
	public Int32? SsExtListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PROFIT value.
	/// </summary>
	[PropertyName("SS_NET_PROFIT")]
	public Int32? SsNetProfit  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PAID_INC_TAX value.
	/// </summary>
	[PropertyName("SS_NET_PAID_INC_TAX")]
	public Int32? SsNetPaidIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the SS_ADDR_SK value.
	/// </summary>
	[PropertyName("SS_ADDR_SK")]
	public Int32? SsAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_TAX value.
	/// </summary>
	[PropertyName("SS_EXT_TAX")]
	public Int32? SsExtTax  { get; set; }

	/// <summary>
	///	Gets or sets the SS_COUPON_AMT value.
	/// </summary>
	[PropertyName("SS_COUPON_AMT")]
	public Int32? SsCouponAmt  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PAID value.
	/// </summary>
	[PropertyName("SS_NET_PAID")]
	public Int32? SsNetPaid  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("SS_EXT_WHOLESALE_COST")]
	public Int32? SsExtWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SALES_PRICE value.
	/// </summary>
	[PropertyName("SS_SALES_PRICE")]
	public Int32? SsSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_TICKET_NUMBER value.
	/// </summary>
	[PropertyName("SS_TICKET_NUMBER")]
	public Int32? SsTicketNumber  { get; set; }

	/// <summary>
	///	Gets or sets the SS_LIST_PRICE value.
	/// </summary>
	[PropertyName("SS_LIST_PRICE")]
	public Int32? SsListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_ITEM_SK value.
	/// </summary>
	[PropertyName("SS_ITEM_SK")]
	public Int32? SsItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("SS_CUSTOMER_SK")]
	public Int32? SsCustomerSk  { get; set; }
}

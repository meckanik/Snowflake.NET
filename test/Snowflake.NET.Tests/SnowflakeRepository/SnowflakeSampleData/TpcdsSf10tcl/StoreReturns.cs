using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the STORE_RETURNS table.
/// </summary>
[TableName("TPCDS_SF10TCL.STORE_RETURNS")]
public class StoreReturns
{
	/// <summary>
	///	Gets or sets the SR_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("SR_CUSTOMER_SK")]
	public Int32? SrCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURNED_DATE_SK value.
	/// </summary>
	[PropertyName("SR_RETURNED_DATE_SK")]
	public Int32? SrReturnedDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_REVERSED_CHARGE value.
	/// </summary>
	[PropertyName("SR_REVERSED_CHARGE")]
	public Decimal? SrReversedCharge  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_AMT_INC_TAX value.
	/// </summary>
	[PropertyName("SR_RETURN_AMT_INC_TAX")]
	public Decimal? SrReturnAmtIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the SR_REASON_SK value.
	/// </summary>
	[PropertyName("SR_REASON_SK")]
	public Int32? SrReasonSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_TICKET_NUMBER value.
	/// </summary>
	[PropertyName("SR_TICKET_NUMBER")]
	public Int32? SrTicketNumber  { get; set; }

	/// <summary>
	///	Gets or sets the SR_NET_LOSS value.
	/// </summary>
	[PropertyName("SR_NET_LOSS")]
	public Decimal? SrNetLoss  { get; set; }

	/// <summary>
	///	Gets or sets the SR_ITEM_SK value.
	/// </summary>
	[PropertyName("SR_ITEM_SK")]
	public Int32? SrItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_AMT value.
	/// </summary>
	[PropertyName("SR_RETURN_AMT")]
	public Decimal? SrReturnAmt  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_TAX value.
	/// </summary>
	[PropertyName("SR_RETURN_TAX")]
	public Decimal? SrReturnTax  { get; set; }

	/// <summary>
	///	Gets or sets the SR_REFUNDED_CASH value.
	/// </summary>
	[PropertyName("SR_REFUNDED_CASH")]
	public Decimal? SrRefundedCash  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_QUANTITY value.
	/// </summary>
	[PropertyName("SR_RETURN_QUANTITY")]
	public Int32? SrReturnQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the SR_FEE value.
	/// </summary>
	[PropertyName("SR_FEE")]
	public Decimal? SrFee  { get; set; }

	/// <summary>
	///	Gets or sets the SR_STORE_CREDIT value.
	/// </summary>
	[PropertyName("SR_STORE_CREDIT")]
	public Decimal? SrStoreCredit  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_SHIP_COST value.
	/// </summary>
	[PropertyName("SR_RETURN_SHIP_COST")]
	public Decimal? SrReturnShipCost  { get; set; }

	/// <summary>
	///	Gets or sets the SR_STORE_SK value.
	/// </summary>
	[PropertyName("SR_STORE_SK")]
	public Int32? SrStoreSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_ADDR_SK value.
	/// </summary>
	[PropertyName("SR_ADDR_SK")]
	public Int32? SrAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_RETURN_TIME_SK value.
	/// </summary>
	[PropertyName("SR_RETURN_TIME_SK")]
	public Int32? SrReturnTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_HDEMO_SK value.
	/// </summary>
	[PropertyName("SR_HDEMO_SK")]
	public Int32? SrHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SR_CDEMO_SK value.
	/// </summary>
	[PropertyName("SR_CDEMO_SK")]
	public Int32? SrCdemoSk  { get; set; }
}

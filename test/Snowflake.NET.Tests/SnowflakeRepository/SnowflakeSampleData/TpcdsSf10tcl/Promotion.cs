using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the PROMOTION table.
/// </summary>
[TableName("PROMOTION")]
public class Promotion
{
	/// <summary>
	///	Gets or sets the P_CHANNEL_EMAIL value.
	/// </summary>
	[PropertyName("P_CHANNEL_EMAIL")]
	public String? PChannelEmail  { get; set; }

	/// <summary>
	///	Gets or sets the P_PROMO_ID value.
	/// </summary>
	[PropertyName("P_PROMO_ID")]
	public String? PPromoId  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_DEMO value.
	/// </summary>
	[PropertyName("P_CHANNEL_DEMO")]
	public String? PChannelDemo  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_DETAILS value.
	/// </summary>
	[PropertyName("P_CHANNEL_DETAILS")]
	public String? PChannelDetails  { get; set; }

	/// <summary>
	///	Gets or sets the P_END_DATE_SK value.
	/// </summary>
	[PropertyName("P_END_DATE_SK")]
	public Int32? PEndDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_EVENT value.
	/// </summary>
	[PropertyName("P_CHANNEL_EVENT")]
	public String? PChannelEvent  { get; set; }

	/// <summary>
	///	Gets or sets the P_ITEM_SK value.
	/// </summary>
	[PropertyName("P_ITEM_SK")]
	public Int32? PItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the P_RESPONSE_TARGET value.
	/// </summary>
	[PropertyName("P_RESPONSE_TARGET")]
	public Int32? PResponseTarget  { get; set; }

	/// <summary>
	///	Gets or sets the P_COST value.
	/// </summary>
	[PropertyName("P_COST")]
	public Int32? PCost  { get; set; }

	/// <summary>
	///	Gets or sets the P_PROMO_NAME value.
	/// </summary>
	[PropertyName("P_PROMO_NAME")]
	public String? PPromoName  { get; set; }

	/// <summary>
	///	Gets or sets the P_DISCOUNT_ACTIVE value.
	/// </summary>
	[PropertyName("P_DISCOUNT_ACTIVE")]
	public String? PDiscountActive  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_DMAIL value.
	/// </summary>
	[PropertyName("P_CHANNEL_DMAIL")]
	public String? PChannelDmail  { get; set; }

	/// <summary>
	///	Gets or sets the P_PROMO_SK value.
	/// </summary>
	[PropertyName("P_PROMO_SK")]
	public Int32? PPromoSk  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_PRESS value.
	/// </summary>
	[PropertyName("P_CHANNEL_PRESS")]
	public String? PChannelPress  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_TV value.
	/// </summary>
	[PropertyName("P_CHANNEL_TV")]
	public String? PChannelTv  { get; set; }

	/// <summary>
	///	Gets or sets the P_START_DATE_SK value.
	/// </summary>
	[PropertyName("P_START_DATE_SK")]
	public Int32? PStartDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_CATALOG value.
	/// </summary>
	[PropertyName("P_CHANNEL_CATALOG")]
	public String? PChannelCatalog  { get; set; }

	/// <summary>
	///	Gets or sets the P_CHANNEL_RADIO value.
	/// </summary>
	[PropertyName("P_CHANNEL_RADIO")]
	public String? PChannelRadio  { get; set; }

	/// <summary>
	///	Gets or sets the P_PURPOSE value.
	/// </summary>
	[PropertyName("P_PURPOSE")]
	public String? PPurpose  { get; set; }
}

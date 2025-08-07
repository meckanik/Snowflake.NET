using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the CATALOG_PAGE table.
/// </summary>
[TableName("CATALOG_PAGE")]
public class CatalogPage
{
	/// <summary>
	///	Gets or sets the CP_CATALOG_PAGE_NUMBER value.
	/// </summary>
	[PropertyName("CP_CATALOG_PAGE_NUMBER")]
	public Int32? CpCatalogPageNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CP_START_DATE_SK value.
	/// </summary>
	[PropertyName("CP_START_DATE_SK")]
	public Int32? CpStartDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CP_CATALOG_PAGE_SK value.
	/// </summary>
	[PropertyName("CP_CATALOG_PAGE_SK")]
	public Int32? CpCatalogPageSk  { get; set; }

	/// <summary>
	///	Gets or sets the CP_CATALOG_PAGE_ID value.
	/// </summary>
	[PropertyName("CP_CATALOG_PAGE_ID")]
	public String? CpCatalogPageId  { get; set; }

	/// <summary>
	///	Gets or sets the CP_END_DATE_SK value.
	/// </summary>
	[PropertyName("CP_END_DATE_SK")]
	public Int32? CpEndDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CP_TYPE value.
	/// </summary>
	[PropertyName("CP_TYPE")]
	public String? CpType  { get; set; }

	/// <summary>
	///	Gets or sets the CP_DEPARTMENT value.
	/// </summary>
	[PropertyName("CP_DEPARTMENT")]
	public String? CpDepartment  { get; set; }

	/// <summary>
	///	Gets or sets the CP_CATALOG_NUMBER value.
	/// </summary>
	[PropertyName("CP_CATALOG_NUMBER")]
	public Int32? CpCatalogNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CP_DESCRIPTION value.
	/// </summary>
	[PropertyName("CP_DESCRIPTION")]
	public String? CpDescription  { get; set; }
}

using Snowflake.NET.Framework.Context;
using Snowflake.NET.Tests.SnowflakeRepository;

namespace Snowflake.NET.Tests.Functional;

[TestFixture]
public class SFQueryTests
{
    public TestContext? TestContext { get; set; }

    private static SnowflakeSampleDataContext _dataContext;

    [SetUp]
    public void Setup()
    {
        var conn = TestContext.Parameters["ConnectionString"]!;
        var sfc = new SFContext(conn);
        _dataContext = new SnowflakeSampleDataContext(sfc);
    }

    [Test]
    public void Test_ExecuteBasicLinqQuery()
    {
        var result = _dataContext.TpcdsSf100tcl?.WebSites?.Find(web => web.WebName == "site_0");
    }
}

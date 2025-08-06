using Snowflake.NET.Scaffold.Scaffolding;

namespace Snowflake.NET.Tests.Functional
{
    [TestFixture]
    public class ScaffoldTests
    {
        public TestContext? TestContext { get; set; }

        private static string _connectionSettings;

        [SetUp]
        public void Setup()
        {
            _connectionSettings = TestContext.Parameters["ConnectionString"]!;
        }

        [Test]
        public void Test_ScaffoldDatabase()
        {
            var status = new Scaffolder(
                _connectionSettings, 
                "MultiORM.Snowflake", 
                @"C:\development\MultiORM\MultiORM.Snowflake").ScaffoldDatabase();

            Assert.Equals(status, true);
        }
    }
}
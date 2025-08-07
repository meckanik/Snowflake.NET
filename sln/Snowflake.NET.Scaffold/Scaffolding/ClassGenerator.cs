using System.Globalization;
using Snowflake.NET.Models;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Scaffold.Scaffolding;

internal class ClassGenerator
{
    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    internal static void Generate(
        string repositoryPath,
        string repositoryNamespace,
        IEnumerable<TableData> dbInfo)
    {
        PropertyValidators.ValidateArgument(dbInfo);

        // generate the POCOs
        PocoGenerator.Generate(repositoryPath, repositoryNamespace, dbInfo);
        // generate the context classes
        ContextGenerator.Generate(repositoryPath, repositoryNamespace, dbInfo);
    }
}

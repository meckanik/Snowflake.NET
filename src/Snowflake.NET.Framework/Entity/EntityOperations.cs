using Snowflake.NET.Attributes;
using Snowflake.NET.Interfaces;
using Snowflake.NET.Models;

namespace Snowflake.NET.Framework.Entity;

internal class EntityOperations
{
    internal static TableModelMetadata GetTableName(Type type)
    {
        var attribute = type.CustomAttributes.FirstOrDefault(att => att.AttributeType == typeof(TableNameAttribute));
        var data = attribute?.ConstructorArguments?.FirstOrDefault().Value?.ToString()?.Split('.');

        return new TableModelMetadata { SchemaName = data![0], TableName = data[1] };
    }

    internal static string GetColumnName<T>(T entity, string propertyName)
    {
        var property =
            typeof(T).GetProperties().FirstOrDefault(prop => string.Equals(prop.Name, propertyName, StringComparison.OrdinalIgnoreCase));
        property!.CustomAttributes.FirstOrDefault(att => att.AttributeType == typeof(IPropertyNameAttribute));

        return ((IPropertyNameAttribute)property).PropertyName;
    }
}

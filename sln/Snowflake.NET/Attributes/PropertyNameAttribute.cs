using Snowflake.NET.Interfaces;

namespace Snowflake.NET.Attributes
{
    /// <summary>
    ///     Allows the .NET-unfriendly database property name to be
    ///     retrieved by the Framework classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class PropertyNameAttribute : Attribute, IPropertyNameAttribute
    {
        private readonly string _propertyName;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PropertyNameAttribute"/> class.
        /// </summary>
        /// <param name="tableName">The name of the table.</param>
        public PropertyNameAttribute(string propertyName) => _propertyName = propertyName;

        /// <inheritdoc />
        public string PropertyName => _propertyName;
    }
}

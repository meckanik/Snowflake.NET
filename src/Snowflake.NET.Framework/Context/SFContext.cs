using System.Data;
using Snowflake.Data.Client;
using Snowflake.Data.Core;
using Snowflake.NET.Framework.Snowflake;

namespace Snowflake.NET.Framework.Context;

/// <summary>
///     Contains an instance of the Snowflake .Net connector.
/// </summary>
public class SFContext : IDisposable
{
    private readonly IDbConnection _connection;
    private bool disposedValue;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SFContext"/> class.
    /// </summary>
    /// <param name="connection">The Snowflake connection string.</param>
    public SFContext(string connection)
    {
        _connection = new SnowflakeDbConnection();

        _connection.ConnectionString = connection;
        _connection.Open();

        using (var cmd = _connection.CreateCommand())
        {
            cmd.CommandText = $"alter session set DOTNET_QUERY_RESULT_FORMAT = {ResultFormat.JSON}";
            cmd.ExecuteNonQuery();
        }
    }

    /// <summary>
    ///     Executes a command against the specified table.
    /// </summary>
    /// <typeparam name="TEntity">The entity type parameter.</typeparam>
    /// <param name="sql">The sql command to execute.</param>
    /// <param name="options">The sql execution objections object.</param>
    /// <returns></returns>
    public IEnumerable<TEntity> Execute<TEntity>(string sql, object[]? options = null)
    {
        var result = Enumerable.Empty<TEntity>();
        using (var cmd = _connection.CreateCommand())
        {
            // if options = transaction then...
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            result = SnowflakeReader.Read<TEntity>(cmd);
        }

        return result;
    }


    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                _connection.Close();
                _connection.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~SFContext()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    /// <summary>
    ///     Call to dispose the object.
    /// </summary>
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

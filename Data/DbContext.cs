using Npgsql;
using System.Data;

public class DbContext
{
    private readonly IConfiguration _config;

    public DbContext(IConfiguration config)
    {
        _config = config;
    }

    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));
    }
}
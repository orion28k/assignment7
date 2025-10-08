namespace DBConnector;

public class PostgresConnector : IDBConnector
{
    public async Task<bool> ping(bool result)
    {
        return result;
    }
}
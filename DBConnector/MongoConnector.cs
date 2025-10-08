using MongoDB.Bson;
using MongoDB.Driver;

namespace DBConnector;

public class MongoConnector : IDBConnector
{
    private string m_connectionString;

    public MongoConnector(string connectionString)
    {
        m_connectionString = connectionString;
    }

    public async Task<bool> ping(bool result)
    {
        // In stub mode, just return the passed-in result
        return result;
    }
}

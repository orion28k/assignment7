using DBConnector;

namespace DBConnector.Tests;

public class MongoConnectorTests
{
    [Fact]
    public async Task should_ping_db_successfully()
    {
        // Using fake connector to simulate success without real DB or docker.
        IDBConnector connector = new FakeConnector(true);
        Assert.True(await connector.ping());
    }

    [Fact]
    public async Task should_fail_missing_db()
    {
        IDBConnector connector = new FakeConnector(false);
        Assert.False(await connector.ping());
    }
}

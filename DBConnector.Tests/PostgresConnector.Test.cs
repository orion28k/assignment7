using DBConnector;

namespace DBConnector.Tests;

public class PostgresConnectorTests
{
    [Fact]
    public async Task should_ping_db_successfully()
    {
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


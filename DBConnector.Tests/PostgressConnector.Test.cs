namespace DBConnector.Tests;

public class PostgresConnectorTest
{
    [Fact]
    public async Task Test1()
    {
        // Arrange: create the connector
        var connector = new PostgresConnector();

        // Act: call the method under test and await it
        bool result = await connector.ping(true);

        // Assert: verify the outcome
        Assert.True(result);
    }
    
    [Fact]
    public async Task Test2()
    {
        // Arrange: create the connector
        var connector = new PostgresConnector();

        // Act: call the method under test and await it
        bool result = await connector.ping(false);

        // Assert: verify the outcome
        Assert.False(result);
    }
}

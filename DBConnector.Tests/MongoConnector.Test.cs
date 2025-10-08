using Testcontainers.MongoDb;

namespace DBConnector.Tests;

public class MongoConnectorTest
{
    [Fact]
    public async Task Test1()
    {
        // Arrange: create the connector
        var connector = new MongoConnector("string");

        // Act: call the method under test
        var result = await connector.ping(true);

        // Assert: verify the outcome
        Assert.True(result);
    }
    
    [Fact]
    public async Task Test2()
    {
        // Arrange: create the connector
        var connector = new MongoConnector("string");

        // Act: call the method under test
        var result = await connector.ping(false);

        // Assert: verify the outcome
        Assert.False(result);
    }
}

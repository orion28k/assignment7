namespace DBConnector.Tests;

public class PostgresConnectorTest
{
    [Fact]
    public void Test1()
    {
        // Arrange: create the connector
        var connector = new PostgresConnector();

        // Act: call the method under test
        var result = connector.ping(true);

        // Assert: verify the outcome
        Assert.True(result);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange: create the connector
        var connector = new PostgresConnector();

        // Act: call the method under test
        var result = connector.ping(false);

        // Assert: verify the outcome
        Assert.False(result);
    }
}

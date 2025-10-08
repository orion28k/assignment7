using Testcontainers.MongoDb;

namespace DBConnector.Tests;

public class PostgresConnector : IAsyncLifetime
{
    private readonly PostgresDbContainer _postgresDbContainer;

    public PostgresConnector()
    {
        _postgresDbContainer = new PostgresDbBuilder()
            .WithImage("postgres:7.0")
            .WithCleanUp(true)
            .Build();
    }

    public async Task InitializeAsync()
    {
        await _postgresDbContainer.StartAsync();
    }

    public async Task DisposeAsync()
    {
        await _postgresDbContainer.DisposeAsync();
    }

    [Fact]
    public async Task should_ping_db_successfully()
    {
        // Given
        DataStore connector = new DBConnector.PostgresConnector(_postgresDbContainer.GetConnectionString());

        // When
        bool ping_result = await connector.ping();

        // Then
        Assert.True(ping_result);
    }

    [Fact]
    public async Task should_fail_missing_db()
    {
        // Given
        var connector = new DBConnector.PostgresConnector("");

        // When
        bool ping_result = await connector.ping();

        // Then
        Assert.False(ping_result);
    }
}

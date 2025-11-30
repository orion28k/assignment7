using System.Threading.Tasks;
using DBConnector;

namespace DBConnector.Tests;

public class FakeConnector : IDBConnector
{
    private readonly bool _result;
    public FakeConnector(bool result) => _result = result;
    public Task<bool> ping() => Task.FromResult(_result);
}
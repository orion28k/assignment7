using Microsoft.VisualBasic;

namespace DBConnector;

public interface IDBConnector
{
    public Task<bool> ping(bool result);
}
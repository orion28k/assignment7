using Microsoft.VisualBasic;

namespace DBConnector;

public interface IDBConnector
{
    Task<bool> ping(bool result);
}
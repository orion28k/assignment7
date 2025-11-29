using System;
using System.Threading.Tasks;
using DBConnector;

class Program
{
    static async Task<int> Main(string[] args)
    {
        Console.WriteLine("DBConnector REPL");
        Console.WriteLine("Type 'exit' at any prompt to quit.");

        while (true)
        {
            Console.Write("Choose DB (mongo/postgres): ");
            var dbType = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(dbType)) continue;
            if (dbType == "exit") break;

            if (dbType != "mongo" && dbType != "postgres")
            {
                Console.WriteLine("Invalid choice. Please enter 'mongo' or 'postgres'.");
                continue;
            }

            Console.Write("Enter connection string: ");
            var connString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(connString))
            {
                Console.WriteLine("Empty connection string — will attempt and expect failure.");
            }
            if (connString?.Trim().ToLower() == "exit") break;

            IDBConnector connector;
            try
            {
                if (dbType == "mongo")
                {
                    connector = new MongoConnector(connString ?? "");
                }
                else
                {
                    connector = new PostgresConnector(connString ?? "");
                }

                Console.WriteLine("Pinging database...");
                bool ok = await connector.ping();
                Console.WriteLine(ok ? "Ping successful." : "Ping failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye.");
        return 0;
    }
}
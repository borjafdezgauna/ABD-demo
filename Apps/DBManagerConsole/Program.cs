using System;
using DBManager;

namespace DBManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DBManager console client");

            bool databaseLoaded = false;
            string databaseName = null, username = null, password = null;

            Database database = new Database();

            while (!databaseLoaded)
            {
                Console.Write("Database: ");
                databaseName = Console.ReadLine();
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();

                databaseLoaded= database.Load(databaseName, username, password);
            }
            

            Console.WriteLine("Database loaded. Press Enter after each MiniSQL query to see the result");
            while (true)
            {
                Console.Write($"{databaseName}> ");
                string query = Console.ReadLine();
                string result = database.ExecuteMiniSQLQuery(query);
                Console.WriteLine(result);
            }
        }
    }
}

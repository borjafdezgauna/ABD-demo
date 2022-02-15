using System;
using System.Collections.Generic;
using DBManager;

namespace ConsoleParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MiniSQL Console Parser. Enter MiniSQL queries and press enter");

            while (true)
            {
                Console.Write("MiniSQL parser> ");
                string query = Console.ReadLine();

                MiniSQLQuery parsedQuery = MiniSQLParser.Parse(query);

                if (parsedQuery == null)
                {
                    Console.WriteLine("Could not parse query");
                }
                else
                {
                    string className = parsedQuery.GetType().Name;
                    Console.WriteLine($"Query: {className}");

                    Dictionary<string, string> parameters = parsedQuery.Parameters();
                    foreach (string name in parameters.Keys)
                    {
                        Console.WriteLine($"Parameter \"{name}\" : {parameters[name]}");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Database
    {
        List<Table> Tables = new List<Table>();
        public Database()
        { }

        public bool Load(string databaseFilename, string username, string password)
        {
            //TODO: Load database from file, return true if success, else return false
            return true;
        }

        public bool Save()
        {
            //TODO: Upd database from file, return true if success, else return false
            return true;
        }

        public string Select(string table, List<string> columns)
        {
            //Do whatever you have to do
            return null;
        }
        public string Insert(string table, List<string> columns, List<string> values)
        {
            //Do whatever you have to do
            return null;
        }

        public string ExecuteMiniSQLQuery(string query)
        {
            //Parse the query
            MiniSQLQuery miniSQLQuery = MiniSQLParser.Parse(query);

            if (miniSQLQuery == null)
                return "Error";

            return miniSQLQuery.Execute(this);
        }
    }
}

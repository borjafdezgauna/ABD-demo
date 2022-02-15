using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Select: MiniSQLQuery
    {
        public string Table = null;
        public List<string> Columns = null;

        public Select(string table, List<string> columns)
        {
            Table = table;
            Columns = columns;
        }

        public string Execute(Database database)
        {
            return database.Select(Table, Columns);
        }

        public Dictionary<string, string> Parameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Table"] = Table;
            if (Columns != null)
            {
                int index = 1;
                foreach (string column in Columns)
                {
                    parameters[$"Column[{index}]"] = column;
                    index++;
                }
            }
            return parameters;
        }
    }
}

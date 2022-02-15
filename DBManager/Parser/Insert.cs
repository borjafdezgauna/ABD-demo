using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Insert: MiniSQLQuery
    {
        public string Table= null;
        public List<string> Columns = null;
        public List<string> Values = null;

        public Insert(string table, List<string> columns, List<string> values)
        {
            Table = table;
            Columns = columns;
            Values = values;
        }

        public string Execute(Database database)
        {
            return database.Insert(Table, Columns, Values);
        }

        public Dictionary<string, string> Parameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Table"] = Table;
            int index = 1;
            foreach (string column in Columns)
            {
                parameters[$"Column[{index}]"] = column;
                index++;
            }

            index = 1;
            foreach (string val in Values)
            {
                parameters[$"Value[{index}]"] = val;
                index++;
            }
            return parameters;
        }
    }
}

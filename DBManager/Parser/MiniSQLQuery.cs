using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public interface MiniSQLQuery
    {
        Dictionary<string,string> Parameters();
        string Execute(Database database);
    }
}

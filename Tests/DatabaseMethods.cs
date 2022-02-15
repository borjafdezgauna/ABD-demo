using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Xunit;

namespace UnitTests
{
    public class DatabaseMethods
    {
        Database CreateTestDatabase()
        {
            //TODO
            //initialize it using code or loading it from file

            return null;
        }
        [Fact]
        public void Select()
        {
            Database database = CreateTestDatabase();

            string result = database.Select("People", new List<string>() { "Name", "Age", "Height" });
            Assert.Equal("{'Name','Age','Height'}...", result);
        }

        [Fact]
        public void ParseAndSelect()
        {
            Database database = CreateTestDatabase();

            string result = database.ExecuteMiniSQLQuery("SELECT ...");
            Assert.Equal("{'Name','Age','Height'}...", result);
        }
    }
}

using System;
using Xunit;
using DBManager;

namespace UnitTests
{
    public class Parser
    {
        [Fact]
        public void Select()
        {
            MiniSQLQuery query = MiniSQLParser.Parse("SELECT Name, Age, Height FROM People;");
            Select selectQuery = query as Select;
            Assert.Contains("Name", selectQuery.Columns);
            Assert.Contains("Age", selectQuery.Columns);
            Assert.Contains("Height", selectQuery.Columns);
            Assert.Equal("People", selectQuery.Table);
        }
    }
}

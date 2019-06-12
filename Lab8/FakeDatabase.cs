using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class FakeDatabase
    {
        public FakeDatabase()
        {
            DataBase = new List<StringValue>{new StringValue("Lab3txt"), new StringValue("Lab3csv"), new StringValue("Chrome"), new StringValue("Word")};
        }

        public List<StringValue> DataBase { get; }
    }
}

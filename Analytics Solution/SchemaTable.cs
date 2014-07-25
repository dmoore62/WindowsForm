using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics_Solution
{
    public class SchemaTable
    {
        public String name { get; set; }
        public List<String> columns { get; set; }

        public SchemaTable(String name) {
            this.name = name;
            this.columns = new List<String>();
        }
    }
}

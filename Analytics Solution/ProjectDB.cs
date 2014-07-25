using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics_Solution
{
    public class ProjectDB
    {
        List<SchemaTable> tables { get; set; }
        List<String> simpleList { get; set; }
        public ProjectDB(List<String> list)
        {
            this.simpleList = list;
            string thisTblName;
            string thisColName;
            this.tables = new List<SchemaTable>();
            String tblName = "";
            foreach (String el in list) {
                Debug.WriteLine(el);
                string[] els = el.Split('.').ToArray();
                thisTblName = els[0];
                thisColName = els[1];
                if (thisTblName != tblName) {
                    tblName = thisTblName;
                    SchemaTable tbl = new SchemaTable(tblName);
                    Debug.WriteLine("Created Table " + tblName);
                    this.tables.Add(tbl);
                }
                this.tables[this.tables.Count - 1].columns.Add(thisColName);
                Debug.WriteLine("Added Column "+ thisColName +" to " +this.tables[this.tables.Count - 1].name);
            }
        }

        public List<String> getTableList() {
            List<String> retVal = new List<String>();
            foreach (SchemaTable t in this.tables) {
                retVal.Add(t.name);
            }

            return retVal;
        }

        public List<String> getColumnListForTable(String table) {
            List<String> retVal = new List<String>();

            foreach(SchemaTable t in this.tables){
                if (t.name == table) {
                    foreach (String col in t.columns) {
                        retVal.Add(col);
                    }
                }
            }

            return retVal;
        }
    }
}

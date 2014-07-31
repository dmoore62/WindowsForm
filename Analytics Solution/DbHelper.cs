using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analytics_Solution
{
    class DbHelper
    {
        public DbHelper() { 
        
        }//end constructor

        public List<String> getAvailableDBServers() {
            List<String> retVal = new List<String>();

            String myServer = Environment.MachineName;

            

            return retVal;
        }
    }
}

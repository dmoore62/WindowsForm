using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Diagnostics;

namespace Analytics_Solution
{
    class SqliteHelper
    {
        public String dbConnection;
        public String ConStr = ConfigurationManager.ConnectionStrings["SQLITE"].ToString();
        public SQLiteConnection conn = new SQLiteConnection();

        public SqliteHelper() {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLITE"].ToString();
        }

        public bool testConnection() {
            bool isError = false;

            try
            {
                this.conn.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                isError = true;
            }
            finally
            {
                this.conn.Close();
            }

            return isError;
        }
    }
}

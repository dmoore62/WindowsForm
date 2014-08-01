using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;

namespace Analytics_Solution
{
    class SqlDBhelper
    {
        SQLiteConnection conn;

        public SqlDBhelper() {
            SQLiteConnection.CreateFile("pandera_metadata.sqlite");

            conn = new SQLiteConnection("Data Source=pandera_metadata.sqlite;Version=3;");
        }

        public bool testConnection() {
            bool isConnected = false;

            try {
                this.conn.Open();
                isConnected = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            finally {
                this.conn.Close();
            }

            return isConnected;
        }
    }
}

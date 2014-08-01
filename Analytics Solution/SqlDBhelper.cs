﻿using System;
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
            SQLiteConnection.CreateFile("../../AppData/pandera_metadata.sqlite");

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

        public bool isEmpty() {
            bool isEmpty;
            int results;

            try
            {
                this.conn.Open();
                String sql = "SELECT COUNT(*) FROM sqlite_master WHERE type='table'";
                SQLiteCommand cmd = new SQLiteCommand(sql, this.conn);

                results = (int)cmd.ExecuteScalar();
                if (results > 0)
                {
                    isEmpty = false;
                }
                else {
                    isEmpty = true;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine("DB Problems: " + ex.Message);
                isEmpty = true;
            }
            finally {
                this.conn.Close();
            }

            return isEmpty;
        }
    }
}

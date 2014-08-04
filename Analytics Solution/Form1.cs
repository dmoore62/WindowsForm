﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Data.SqlClient;
using System.IO;
using System.Data.SQLite;
using Analytics_Solution.Properties;

namespace Analytics_Solution
{
    public partial class Form1 : Form
    {
        public ProjectDB projectDb;
        public List<String> dataSchema = new List<string>();
        public XmlWriter writer;
        public String WriteConStr;
        public String WriteConnection;
        public String projectName;

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine("Starting XML");
            this.writer = XmlWriter.Create("test.xml");
            this.writer.WriteStartDocument();
        }

        private void btnNewAttr_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
            Form2 inForm = new Form2(this);
            inForm.Show();
        }

        internal void addToTable(AttributeRow attr_row) {
            Debug.WriteLine("Referenced Form1");
            Debug.WriteLine(this.dataGridViewAttributes.RowCount-1);
            DataGridViewRow row = (DataGridViewRow)this.dataGridViewAttributes.Rows[this.dataGridViewAttributes.RowCount-1].Clone();
            row.Cells[0].Value = attr_row.name;
            row.Cells[1].Value = attr_row.num_forms;
            row.Cells[2].Value = attr_row.num_children;
            row.Cells[3].Value = attr_row.num_parents;
            row.Cells[4].Value = attr_row.comments;
            this.dataGridViewAttributes.Rows.Add(row);
        }

        public void CreateSimpleXML() { 
        
        }

        public List<String> getSchema() {
            return dataSchema;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlDBhelper db = new SqlDBhelper();
            if (db.testConnection())
            {
                Debug.WriteLine("Yep");
                if (db.isEmpty())
                {
                    Debug.WriteLine("Empty");
                    db.Insert_Table();
                }
                else
                {
                    Debug.WriteLine("Not Empty");
                }
            }
            else
            {
                Debug.WriteLine("Nope");
            }
        }

        private void btnImportTables_Click(object sender, EventArgs e)
        {
            Label lblError = (Label)this.lblDbError;
            String descStr;

            //Check for text in input
            if (dlgDatabaseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                String fileName = dlgDatabaseFile.FileName;
                String conStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + fileName + ";Integrated Security=True;Connect Timeout=30";
                //String conStr1 = Properties.Settings.Default.connection;
                
                Debug.WriteLine(conStr);

                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                try {
                    Cursor.Current = Cursors.WaitCursor;
                    con.Open();
                    String sql = "SELECT * FROM information_schema.columns";
                    cmd.Connection = con;
                    cmd.CommandText = sql;

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            descStr = reader["TABLE_NAME"]+"."+reader["COLUMN_NAME"];
                            dataSchema.Add(descStr);
                            //Debug.WriteLine(descStr);
                        }
                    }
                }
                catch (Exception ex) {
                    lblError.Text = ex.Message;
                    throw new Exception("DB problems: " + ex.Message);
                }
                finally {
                    con.Close();
                    Cursor.Current = Cursors.Arrow;
                }
                if (dataSchema.Count > 0)
                {
                    lblDbError.ForeColor = Color.Green;
                    lblDbError.Text = "Schema Uploaded - " + fileName;
                    projectDb = new ProjectDB(dataSchema);
                    //launch new project name window
                    //NewProjectForm newForm = new NewProjectForm(this);
                    //newForm.Show();

                    //lets try a save Dialog instead
                    dlgSaveProject.DefaultExt = "sqlite";
                    dlgSaveProject.AddExtension = true;
                    dlgSaveProject.Filter = "Sqlite file|*.sqlite";
                    dlgSaveProject.Title = "Create New Project File";
                    dlgSaveProject.ShowDialog();

                    if (dlgSaveProject.FileName != "") {
                        String file = dlgSaveProject.FileName;
                        Debug.WriteLine(file);
                        Cursor.Current = Cursors.WaitCursor;
                        this.projectName = file;
                        createNewDB(file);
                        Cursor.Current = Cursors.Arrow;
                    }
                }
                else {
                    lblDbError.ForeColor = Color.Red;
                    lblDbError.Text = "ERROR: Could not attach schema";
                }
            }
        }

        public bool checkForDB() {
            bool is_there = false;
            String DBname = "pandera_metadata";
            String conStr = this.WriteConStr;
            SqlConnection conn = new SqlConnection(conStr);

            try {
                conn.Open();

                String sql = "SELECT COUNT(*) FROM sys.sysdatabases WHERE name = @dbname";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@dbname", DBname);

                int results = (int)cmd.ExecuteScalar();

                if (results > 0) {
                    is_there = true;
                }
            }
            catch (Exception ex) {
                throw new Exception("DB problems: " + ex.Message);
            }
            finally {
                conn.Close();
            }

            return is_there;
        }

        public void createDB() {
            String conStr = this.WriteConStr;
            SqlConnection conn = new SqlConnection(conStr);

            try {
                conn.Open();

                String sql = Resources.master_script;

                //sb = new StringBuilder();

                //using (StreamReader sr = new StreamReader(Resources.master_script))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)
                //    {
                //        sb.AppendLine(line);
                //    }
                //}
                Debug.WriteLine(sql);

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                
                this.WriteConStr = conStr += ";database=pandera_metadata";
            }
            catch (Exception ex) {
                throw new Exception("DB Create Problems: "+ ex.Message);
            }
            finally {
                conn.Close();
            }
        }

        public void createNewDB(String fileName) {
            String conStr = "data source=" + fileName;
            Debug.WriteLine(fileName);
            SQLiteConnection.CreateFile(fileName);
            using (SQLiteConnection con = new SQLiteConnection(conStr)) {
                using (SQLiteCommand cmd = new SQLiteCommand(con)) {
                    try {
                        con.Open();
                        cmd.CommandText = Resources.master_sqlite;
                        cmd.ExecuteNonQuery();
                        this.WriteConnection = fileName;
                        this.WriteConStr = conStr;
                        this.Text = this.Text + " - " + fileName;
                    }
                    catch (Exception ex) {
                        throw new Exception("Error creating DB: " + ex.Message);
                    }
                    finally {
                        con.Close();
                    }                
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateDataBase_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("Clicked");
            //DBConnForm inputform = new DBConnForm(this);
            //inputform.Show();

            //lets try this with a dialog box instead
            dlgDatabaseFile.Multiselect = false;
            if (dlgDatabaseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Debug.WriteLine(dlgDatabaseFile.FileName);
                //set project connections
                if (dlgDatabaseFile.FileName.ToLower().EndsWith(".sqlite"))
                {
                    this.WriteConnection = dlgDatabaseFile.FileName;
                    this.WriteConStr = "data source=" + dlgDatabaseFile.FileName;
                    //reverse engineer projectDB object from datasource table
                    populateProjectDB();
                }
                else {
                    ErrorForm ef = new ErrorForm("Error on Import", "An invalid file type was selected");
                    ef.Show();
                }
            }
        }

        private void populateProjectDB() { 
            String conStr = this.WriteConStr;
            String sql;
            List<String> objVals = new List<String>();
            //pull all records from sqlite file
            using (SQLiteConnection con = new SQLiteConnection(conStr)) {
                using (SQLiteCommand cmd = new SQLiteCommand(con)) {
                    try {
                        con.Open();
                        sql = "SELECT * FROM table_reference";

                        cmd.CommandText = sql;
                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    objVals.Add(reader["description"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex) {
                        throw new Exception("Error cannot populate db object: " + ex.Message);
                    }
                    finally {
                        con.Close();
                    }
                }
            }

            //create DB object
            this.projectDb = new ProjectDB(objVals);

            this.Text = this.Text + " - " + this.WriteConnection;
            Label lblImport = (Label)this.lblImportStatus;
            lblImport.ForeColor = Color.Green;
            lblImport.Text = "Imported - " + this.WriteConnection;

        }
    }
}

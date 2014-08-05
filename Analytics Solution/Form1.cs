using System;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace Analytics_Solution
{
    public partial class Form1 : Form
    {
        public ProjectDB projectDb;
        public List<String> dataSchema = new List<string>();
        public XmlWriter writer;
        public String OriginalConnection;
        public String WriteConStr;
        public String WriteConnection;
        public String projectName;

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine("Starting XML");
            this.writer = XmlWriter.Create("test.xml");
            this.writer.WriteStartDocument();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e) {
            Debug.WriteLine("Closing");
            try
            {
                if (this.OriginalConnection != "" && this.WriteConnection != "" && this.WriteConnection.EndsWith("pandera_metadata.sqlite"))
                {
                    File.Delete(this.WriteConnection);
                    Debug.WriteLine("File Deleted");
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnNewAttr_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
            Form2 inForm = new Form2(this);
            inForm.Show();
        }

        internal void addToTable(AttributeRow attr_row) {
            Debug.WriteLine("Referenced Form1");
            Label lblAttr = (Label)this.lblAttributesVal;
            int counter;
            Debug.WriteLine(this.dataGridViewAttributes.RowCount-1);
            DataGridViewRow row = (DataGridViewRow)this.dataGridViewAttributes.Rows[this.dataGridViewAttributes.RowCount-1].Clone();
            row.Cells[0].Value = attr_row.name;
            row.Cells[1].Value = attr_row.id;
            row.Cells[2].Value = attr_row.num_forms;
            row.Cells[3].Value = attr_row.num_children;
            row.Cells[4].Value = attr_row.num_parents;
            row.Cells[5].Value = attr_row.comments;
            this.dataGridViewAttributes.Rows.Add(row);
            counter = Convert.ToInt32(lblAttr.Text);
            counter++;
            lblAttr.Text = counter.ToString();
            lblAttr.Refresh();
        }

        internal void updateTable(AttributeRow attr_row) {
            var table = this.dataGridViewAttributes;
            for (int i = 0; i < table.RowCount; ++i) {
                if (Convert.ToInt32(table.Rows[i].Cells[1].Value) == attr_row.id) {
                    DataGridViewRow row = table.Rows[i];
                    row.Cells[0].Value = attr_row.name;
                    row.Cells[2].Value = attr_row.num_forms;
                    row.Cells[3].Value = attr_row.num_children;
                    row.Cells[4].Value = attr_row.num_parents;
                    row.Cells[5].Value = attr_row.comments;
                }
            }
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
                        
                        //Need to write schema to local db
                        populateSchemaReference();
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
                    importData();
                }
                else {
                    ErrorForm ef = new ErrorForm("Error on Import", "An invalid file type was selected");
                    ef.Show();
                }
            }
        }

        private void importData() {
            populateProjectDB();
            createWorkingCopy();
            populateAttrGridView();
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

        private void createWorkingCopy() { 
            //create file in reference directory
            this.OriginalConnection = this.WriteConnection;
            int index = this.WriteConnection.LastIndexOf('\\');
            String docRoot = this.WriteConnection.Substring(0, index + 1);
            this.WriteConnection = docRoot + "pandera_metadata.sqlite";
            this.WriteConStr = "data source=" + this.WriteConnection;

            File.Copy(this.OriginalConnection, this.WriteConnection, true);
            Debug.WriteLine("File Copied");
        }

        private void populateAttrGridView() {
            var rows = getAttrRows();
            var table = this.dataGridViewAttributes;
            Label lblAttr = (Label)this.lblAttributesVal;
            int counter;

            foreach (var attr_row in rows) {
                Debug.WriteLine("should insert row");
                DataGridViewRow row = (DataGridViewRow)table.Rows[table.RowCount - 1].Clone();
                row.Cells[0].Value = attr_row.name;
                row.Cells[1].Value = attr_row.id;
                row.Cells[2].Value = attr_row.num_forms;
                row.Cells[3].Value = attr_row.num_children;
                row.Cells[4].Value = attr_row.num_parents;
                row.Cells[5].Value = attr_row.comments;
                table.Rows.Add(row);
                counter = Convert.ToInt32(lblAttr.Text);
                counter++;
                lblAttr.Text = counter.ToString();
                lblAttr.Refresh();
            }
        }

        private List<AttributeRow> getAttrRows() { 
            //create list of attribute rows
            String conStr = this.WriteConStr;
            String sql;
            List<AttributeRow> rows = new List<AttributeRow>();

            using (SQLiteConnection con = new SQLiteConnection(conStr)) {
                using (SQLiteCommand cmd = new SQLiteCommand(con)) {
                    try
                    {
                        con.Open();
                        sql = "SELECT * FROM attribute";
                        cmd.CommandText = sql;

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int id = Convert.ToInt32(reader["id"]);
                                    using (SQLiteCommand countCmd = new SQLiteCommand(con))
                                    {
                                        sql = "SELECT COUNT(id) FROM form WHERE a_id = @aid";
                                        countCmd.CommandText = sql;

                                        countCmd.Parameters.AddWithValue("@aid", id);
                                        int count = Convert.ToInt32(countCmd.ExecuteScalar());

                                        //create Attribute Row and Add
                                        AttributeRow ar = new AttributeRow(
                                                reader["name"].ToString(),
                                                count, 0, 0,
                                                reader["descr"].ToString()
                                            );

                                        ar.id = Convert.ToInt32(reader["id"]);

                                        rows.Add(ar);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex) {
                        throw new Exception("Error data import: " + ex.Message);
                    }
                    finally {
                        con.Clone();
                    }
                }
            }

            return rows;
        }

        public void populateSchemaReference(){
            String conStr = this.WriteConStr;
            ProjectDB db = this.projectDb;
            Label lbl = (Label)this.lblDbError;
            String originalTxt = lbl.Text;

            var simpleList = db.getSimpleList();
            using (SQLiteConnection con = new SQLiteConnection(conStr)) {
                using (SQLiteCommand cmd = new SQLiteCommand(con)) {
                    try {
                        con.Open();
                        String sql = "INSERT INTO table_reference (description) VALUES (@d)";
                        cmd.CommandText = sql;
                        foreach (var element in simpleList) {
                            cmd.Parameters.AddWithValue("@d", element);
                            cmd.ExecuteNonQuery();
                            Debug.WriteLine(element);
                            lbl.Text = "Moving - " + element;
                            lbl.Refresh();
                        }
                    }
                    catch (Exception ex) {
                        throw new Exception("Error inserting reference: " + ex.Message);
                    }
                    finally {
                        con.Close();
                    }
                }
            }
            lbl.Text = originalTxt;
            lbl.Refresh();
        }

        private void btnExportDoc_Click(object sender, EventArgs e)
        {
            dlgSaveProject.DefaultExt = "xls";
            dlgSaveProject.AddExtension = true;
            dlgSaveProject.Filter = "Excel Spreadsheet|*.xls";
            dlgSaveProject.Title = "Save exported file";
            dlgSaveProject.ShowDialog();

            if (dlgSaveProject.FileName != "") { 
                //let's try this
                var table = this.dataGridViewAttributes;
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //put in header names
                for (int i = 0; i < table.ColumnCount; ++i)
                {
                    String name = table.Columns[i].HeaderText;
                    xlWorkSheet.Cells[1, i + 1] = name;
                }

                    for (int i = 0; i < table.RowCount; ++i)
                    {
                        for (int j = 0; j < table.ColumnCount; ++j)
                        {
                            var cell = table[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }

                xlWorkBook.SaveAs(dlgSaveProject.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,
                    misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Created!");
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dataGridViewAttributes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Clicked");
            var table = this.dataGridViewAttributes;

            Debug.WriteLine(e.RowIndex);

            DataGridViewRow row = table.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Value);

            launchModifyForm(id);
        }

        private void launchModifyForm(int id) {
            Form2 f = new Form2(this, id);
            f.populateAttrData(id);
            f.Show();
        }
    }
}

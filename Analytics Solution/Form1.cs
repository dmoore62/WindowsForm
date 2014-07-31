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

namespace Analytics_Solution
{
    public partial class Form1 : Form
    {
        public ProjectDB projectDb;
        public List<String> dataSchema = new List<string>();
        public XmlWriter writer;
        public String WriteConStr;
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
            Debug.WriteLine("Ending DOC");
            this.writer.WriteEndDocument();
        }

        private void btnImportTables_Click(object sender, EventArgs e)
        {
            TextBox dataFile = (TextBox)this.tbxDatabaseName;
            Label lblError = (Label)this.lblDbError;
            String descStr;

            //Check for text in input
            if (dlgDatabaseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                String fileName = dataFile.Text = dlgDatabaseFile.FileName;
                String conStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + fileName + ";Integrated Security=True;Connect Timeout=30";
                //String conStr1 = Properties.Settings.Default.connection;
                
                Debug.WriteLine(conStr);

                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                try {
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
                }
                if (dataSchema.Count > 0)
                {
                    lblDbError.ForeColor = Color.Green;
                    lblDbError.Text = "Schema Uploaded";
                    projectDb = new ProjectDB(dataSchema);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateDataBase_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
            DBConnForm inputform = new DBConnForm(this);
            inputform.Show();
        }
    }
}

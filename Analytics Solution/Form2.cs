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
using System.Data.SQLite;

namespace Analytics_Solution
{
    public partial class Form2 : Form
    {
        Form1 formRef = null;
        DataGridView expressions;
        public Form2(Form1 mainForm)
        {
            formRef = mainForm;
            InitializeComponent();

            //setup combo boxes
            expressions = (DataGridView)this.dataGridViewExpressions;
            DataGridViewComboBoxColumn columnBox = (DataGridViewComboBoxColumn)colExpColumn;
            columnBox.DataSource = formRef.projectDb.getSimpleList();

            DataGridViewComboBoxColumn rowBox = (DataGridViewComboBoxColumn)colExpTable;
            rowBox.DataSource = formRef.projectDb.getTableList();
            try
            {
                expressions.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(expression_EditingControlShowing);
                expressions.DataError += new DataGridViewDataErrorEventHandler(expression_DataErrorHandler);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void expression_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (expressions.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox) 
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += UpdateColumnCells;
            }
        }

        private void UpdateColumnCells(object sender, EventArgs e) {
            var curCell = expressions.CurrentCellAddress;
            try
            {
                if (curCell.X == 2)
                {

                    Debug.WriteLine("Changed");

                    var sendingCB = sender as DataGridViewComboBoxEditingControl;
                    DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)expressions.Rows[curCell.Y].Cells[curCell.X];
                    DataGridViewComboBoxCell prevCel = (DataGridViewComboBoxCell)expressions.Rows[curCell.Y].Cells[curCell.X - 1];
                    var tblName = sendingCB.EditingControlFormattedValue.ToString();
                    var list = formRef.projectDb.getColumnListForTable(tblName);
                    prevCel.DataSource = list;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void expression_DataErrorHandler(object sender, DataGridViewDataErrorEventArgs e) {
            Debug.WriteLine("HERE!!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAttrAdd_Click(object sender, EventArgs e)
        {
            TextBox name = this.tbxAttrName;
            TextBox desc = this.tbxAttrDesc;

            if (name.Text.Equals("") || desc.Text.Equals(""))
            {
                if (name.Text.Equals(""))
                {
                    //show error
                    this.lblAttrNameError.Show();
                }
                if (desc.Text.Equals(""))
                {
                    //show error
                    this.lblAttrDescError.Show();
                }
            }
            else
            {
                //submit form
                Debug.WriteLine("Submitting");

                AttributeRow ar = new AttributeRow(this.tbxAttrName.Text,
                                                   this.dataGridViewExpressions.RowCount - 1,
                                                   this.dataGridViewChildren.RowCount - 1,
                                                   this.dataGridViewParents.RowCount - 1,
                                                   this.tbxAttrDesc.Text);
                formRef.addToTable(ar);
                insertNewAttribute(ar, this);
                this.Close();
            }
        }

        private void dataGridViewExpressions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("dumb click call back");
        }

        private void insertNewAttribute(AttributeRow ar, Form2 form) {
            String conStr = formRef.WriteConStr;
            String connection = formRef.WriteConnection;
            String sql;
            int insert_id;

            //SQLiteConnection.CreateFile(connection);
            using(SQLiteConnection con = new SQLiteConnection(conStr)){
                using(SQLiteCommand cmd = new SQLiteCommand(con)){
                    try {
                        con.Open();
                        String now = DateTime.Now.ToString();
                        sql = "INSERT INTO attribute (name, descr, created) VALUES (@name, @desc, @created)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@name", ar.name);
                        cmd.Parameters.AddWithValue("@desc", ar.comments);
                        cmd.Parameters.AddWithValue("@created", now);
                        //execute insert
                        cmd.ExecuteNonQuery();

                        //get attribute insert_id
                        sql = "SELECT last_insert_rowid()";
                        cmd.CommandText = sql;

                        insert_id = Convert.ToInt32(cmd.ExecuteScalar());
                        Debug.WriteLine(insert_id);

                        //insert all form data
                        DataGridView table = form.dataGridViewExpressions;
                        sql = "INSERT INTO form (a_id, name, col, tabl, created) VALUES (@a_id, @name, @col, @tabl, @created)";
                        cmd.CommandText = sql;
                        String colName;
                        String tblName;
                        DataGridViewRow row;
                        for (int i = 0; i < ar.num_forms; ++i )
                        {
                            row = table.Rows[i];
                            cmd.Parameters.AddWithValue("@a_id", insert_id);
                            cmd.Parameters.AddWithValue("@name", row.Cells[0].Value);
                            colName = Convert.ToString((row.Cells[1] as DataGridViewComboBoxCell).EditedFormattedValue.ToString());
                            cmd.Parameters.AddWithValue("@col", colName);
                            tblName = Convert.ToString((row.Cells[2] as DataGridViewComboBoxCell).EditedFormattedValue.ToString());
                            cmd.Parameters.AddWithValue("@tabl", tblName);
                            cmd.Parameters.AddWithValue("@created", now);

                            cmd.ExecuteNonQuery();                            
                        }
                        
                    }
                    catch (Exception ex) {
                        throw new Exception("Error Inserting Attribute: " + ex.Message);
                    }
                    finally {
                        con.Close();
                    }
                }
            }
        }

    }
}

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
                this.Close();
            }
        }

        private void dataGridViewExpressions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("dumb click call back");
        }

    }
}

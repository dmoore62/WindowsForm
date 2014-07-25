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
        public Form2(Form1 mainForm)
        {
            formRef = mainForm;
            InitializeComponent();
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

    }
}

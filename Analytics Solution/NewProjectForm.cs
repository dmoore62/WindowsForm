using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analytics_Solution
{
    public partial class NewProjectForm : Form
    {
        public Form1 formRef;

        public NewProjectForm(Form1 mainForm)
        {
            formRef = mainForm;
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            TextBox input = (TextBox)this.tbxProjectName;

            if (input.Text != "") {
                formRef.projectName = input.Text;
                formRef.createNewDB(input.Text);

                this.Close();
            }
        }
    }
}

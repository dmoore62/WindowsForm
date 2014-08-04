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
    public partial class ErrorForm : Form
    {
        public ErrorForm(String title, String errorText)
        {
            InitializeComponent();
            this.Text = title;
            Label errorLbl = (Label)this.lblErrorText;
            errorLbl.Text = errorText;
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analytics_Solution
{
    public partial class DBConnForm : Form
    {
        public DBConnForm()
        {
            InitializeComponent();
            try
            {
                DbHelper db = new DbHelper();
                db.getAvailableDBServers();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnTest_Click(object sender, EventArgs e)
        {
            TextBox input = (TextBox)this.tbxConnInput;
            String conStr = "Data Source="+input.Text+";Integrated Security=True;Connect Timeout=10";
            Debug.WriteLine(conStr);
            SqlConnection conn = new SqlConnection(conStr);
            Label status = (Label)this.lblStatus;
            //status.ForeColor = Color.Black;

            try {
                Cursor.Current = Cursors.WaitCursor;
                Debug.WriteLine("Connecting");
                status.Text = "Attempting Connection";
                conn.Open();
                Debug.WriteLine("After");
                status.ForeColor = Color.Green;
                status.Text = "Successful Connection";
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                status.ForeColor = Color.Red;
                status.Text = "Connection Error";
            }
            finally {
                conn.Close();
                Cursor.Current = Cursors.Arrow;
            }
        }
    }
}

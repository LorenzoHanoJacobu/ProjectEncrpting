using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_communication
{
    public partial class frmRegiestration : Form
    {
        public frmRegiestration()
        {
            InitializeComponent();
        }

        private void btnCncel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Return to previous page?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmAdmin admin = new frmAdmin();
                admin.Show();
            }
            else
            {
                // Do something  
            }
        }
    }
}

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
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void tmLoading_Tick(object sender, EventArgs e)
        {
            if (pgLoad.Value < 100)
            {
                pgLoad.Value += 10;
            }
            else
            {
                tmLoading.Stop();
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            tmLoading.Start();
        }
    }
}

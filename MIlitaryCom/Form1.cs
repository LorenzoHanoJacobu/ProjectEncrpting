using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIlitaryCom
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLgin_Click(object sender, EventArgs e)
        {
            
//             SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
//   SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='"+ textBox1.Text +"' AND password='"+ textBox2.Text +"'",con);
  
//        /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */ 
 
//   DataTable dt = new DataTable(); //this is creating a virtual table  
//   sda.Fill(dt);  
//   if (dt.Rows[0][0].ToString() == "1")  
//   {  
//      /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */   
//      this.Hide();  
//      new home().Show();  
//   }  
//   else  
//   MessageBox.Show("Invalid username or password");  
  
//}  
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdminPage adminpage = new frmAdminPage();
            adminpage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegst register = new frmRegst();
            register.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMessageBoard ms = new frmMessageBoard();
            ms.Show();
        }
    }
}

using Library_Management_System.Model;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        DB_tables data = new DB_tables();
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            USER userData = data.USERS.Where(find => find.USERNAME == username_txt.Text && find.PASSWORD == password_txt.Text).FirstOrDefault();
            USER userData1 = data.USERS.Where(find => find.EMAIL == username_txt.Text && find.PASSWORD == password_txt.Text).FirstOrDefault();
            if (userData != null )
            {
                if(userData.ROLE == "admin")
                {
                   MetroMessageBox.Show(this, "Welcome admin "+userData.NAME+" !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(userData1.ROLE == "admin")
                {
                    MetroMessageBox.Show(this, "Welcome admin " + userData.NAME + " !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Admin_Dashboard dash = new Admin_Dashboard();
                this.Hide();
                dash.Show();
            }
            
            else
            {
                MetroMessageBox.Show(this, "Couldn't find your account !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Forgot_Pass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

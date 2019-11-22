using Library_Management_System.Forms;
using Library_Management_System.Model;
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
    public partial class Admin_Dashboard : Form
    {
        DB_tables data = new DB_tables();
        public Admin_Dashboard()
        {
            InitializeComponent();
            Theme_manager();
        }
        private void Theme_manager()
        {
            mini_logo.Visible = true;
            logo.Visible = false;
            navbar.Width = 50;
            FormSizing();
            //DefaultForm();
        }
        private void FormSizing()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        private void nav_shortner()
        {
            logo.Visible = false;
            navbar.Visible = false;
            navbar.Width = 50;
            mini_navbar_animator.ShowSync(navbar);
            mini_logo_animator.ShowSync(mini_logo);
        }
        private void Nav_btn_Click(object sender, EventArgs e)
        {
            if (navbar.Width == 50)
            {
                mini_logo.Visible = false;
                navbar.Visible = false;
                navbar.Width = 280;
                navbar_animator.ShowSync(navbar);
                logo_animator.ShowSync(logo);

            }
            else
            {
                logo.Visible = false;
                navbar.Visible = false;
                navbar.Width = 50;
                mini_navbar_animator.ShowSync(navbar);
                mini_logo_animator.ShowSync(mini_logo);

            }

        }
        private void Nav_opener_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 226; i++)
            {
                if (navbar.Width > 225)
                {
                    nav_opener.Stop();
                    break;
                }
                navbar.Width += 60;
            }
        }
        private void Nav_closer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 226; i++)
            {
                if (navbar.Width == 0)
                {
                    nav_closer.Stop();
                    break;
                }
                navbar.Width -= 60;
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            DashboardHome home = new DashboardHome();
            home.TopLevel = false;
            forms_container.Controls.Add(home);
            home.Show();
            home.BringToFront();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bookfram_btn_Click(object sender, EventArgs e)
        {
            BookFrame Bookhome = new BookFrame();
            Bookhome.TopLevel = false;
            forms_container.Controls.Add(Bookhome);
            Bookhome.Show();
            Bookhome.BringToFront();
        }

        private void Memberframe_btn_Click(object sender, EventArgs e)
        {
            MemberFrame Memberhome = new MemberFrame();
            Memberhome.TopLevel = false;
            forms_container.Controls.Add(Memberhome);
            Memberhome.Show();
            Memberhome.BringToFront();
        }

        private void ReturningBook_btn_Click(object sender, EventArgs e)
        {
            ReturningBook Returnhome = new ReturningBook();
            Returnhome.TopLevel = false;
            forms_container.Controls.Add(Returnhome);
            Returnhome.Show();
            Returnhome.BringToFront();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            //BD_Dataload();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            this.Hide();
            loginform.Show();
        }
    }
}

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

namespace Library_Management_System.Forms
{
    public partial class DashboardHome : Form
    {
        int count1 = 0;
        DB_tables data = new DB_tables();
        public DashboardHome()
        {
            InitializeComponent();
            var a = data.MEMBERS.ToList();
            foreach(var b in a)
            {
                count1++;
            }
            members_no_label.Text = Convert.ToString(count1);

            var c = data.BOOKDETAILS.ToList();
            foreach (var b in c)
            {
                count1++;
            }
            books_no_label.Text = Convert.ToString(count1);


            var z = data.ISSUED_BOOKS.ToList();
            foreach (var b in c)
            {
                count1++;
            }
            issued_no_label.Text = Convert.ToString(count1);

        }
    }
}

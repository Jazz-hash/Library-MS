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

namespace Library_Management_System.Forms
{
    public partial class ReturningBook : Form
    {
        DB_tables data = new DB_tables();
        decimal fine = 50;
        int user_id = 1;
        public ReturningBook()
        {
            InitializeComponent();
        }

        private void RB_Search_btn_Click(object sender, EventArgs e)
        {
            string book_index = RB_BookNAme_Combo.Text.ToString();
            var books = from item in data.BOOKDETAILS
                        where item.NAME == book_index
                        select item.ID;
            int book_id = 0;
            foreach (var item in books)
            {
                book_id = item;
            }

            int member_id = (int)RB_Member_Name_Combo.SelectedValue;

            var gridData = from item in data.ISSUED_BOOKS
                           where item.BOOKDETAIL_ID == book_id &&
                           item.ISSUED_TO == member_id &&
                           item.BOOKDETAIL.STATUS == true
                           select new
                           {
                               NAME = item.MEMBER.NAME,
                               ROLE = item.MEMBER.ROLE,
                               CATALOG = item.BOOKDETAIL.BOOK_CATALOG.CATALOG_NAME,
                               BOOK = item.BOOKDETAIL.NAME,
                               ISSUED_ON = item.ISSUED_ON,
                               ISSUED_BY = item.USER.NAME,
                               DAYS = item.ISSUED_DAYS_LIMIT.DAYS
                           };


            DataTable tb_data = new DataTable();
            tb_data.Columns.Add("Member Name");
            tb_data.Columns.Add("Member Role");
            tb_data.Columns.Add("Book Catalog");
            tb_data.Columns.Add("Book Name");
            tb_data.Columns.Add("Issued On");
            tb_data.Columns.Add("Issued By");
            tb_data.Columns.Add("Days Limit");
            foreach (var item in gridData)
            {
                DataRow tb_row = tb_data.NewRow();
                tb_row["Member Name"] = item.NAME;
                tb_row["Member Role"] = item.ROLE;
                tb_row["Book Catalog"] = item.CATALOG;
                tb_row["Book Name"] = item.BOOK;
                tb_row["Issued On"] = item.ISSUED_ON;
                tb_row["Issued By"] = item.ISSUED_BY;
                tb_row["Days Limit"] = item.DAYS;
                tb_data.Rows.Add(tb_row);
            }
            RB_Datagridciew.DataSource = tb_data;
        }
        public int returning_book_id;

        private void RB_Datagridciew_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RB_Member_Name_txtbox.Text = RB_Datagridciew.CurrentRow.Cells[0].Value.ToString();
            RB_BookName_txtbox.Text = RB_Datagridciew.CurrentRow.Cells[3].Value.ToString();
            string[] days = (RB_Datagridciew.CurrentRow.Cells[6].Value.ToString()).Split(' ');
            string days_count = "";
            foreach (var item in days)
            {
                days_count = item;
                break;
            }
            float real_days = float.Parse(days_count);


            bunifuDatepicker1.Value = DateTime.Now;


            DateTime startDate = Convert.ToDateTime(RB_Datagridciew.CurrentRow.Cells[4].Value).Date;
            DateTime endDate = DateTime.Now.Date;

            float period = startDate.Day - endDate.Day;

            if (period <= 0)
            {
                RB_Fine_txtbox.Text = "0.00 RS";

            }
            else
            {
                if (period >= real_days)
                {
                    float days_fined;
                    if (period == real_days)
                    {
                        days_fined = 1;
                    }
                    else
                    {
                        days_fined = period - real_days;

                    }
                    decimal fine_charged = fine * Convert.ToDecimal(days_fined);
                    RB_Fine_txtbox.Text = fine_charged.ToString() + " RS";
                }

            }
        }

        private void RB_Return_Book_btn_Click(object sender, EventArgs e)
        {
            string Book_Name = RB_BookName_txtbox.Text;
            var book_detail = from item in data.BOOKDETAILS
                              where item.NAME == Book_Name
                              select item;
            int book_id = 0;
            foreach (var item in book_detail)
            {
                book_id = item.ID;

            }
            RETURN_BOOK return_book = new RETURN_BOOK()
            {
                BOOKDETAIL_ID = book_id,
                FINE = (RB_Fine_txtbox.Text),
                RETURN_DATE = DateTime.Now,
                USER_ID = user_id

            };
            BOOKDETAIL book_check = data.BOOKDETAILS.Find(book_id);
            book_check.STATUS = false;
            data.RETURN_BOOKS.Add(return_book);
            data.SaveChanges();
            MetroMessageBox.Show(this, "Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReturningBook_Load(object sender, EventArgs e)
        {
            
        }

        private void ReturningBook_Load_1(object sender, EventArgs e)
        {
            ////DISPLAY MEMBER NAME IN RETURNIG BOOK SECTION
            RB_Member_Name_Combo.DataSource = data.MEMBERS.ToList();
            RB_Member_Name_Combo.ValueMember = "ID";
            RB_Member_Name_Combo.DisplayMember = "NAME";

            ////DISPLAYS BOOK NAME IN RETURNING BOOK SECTION
            var bookData = from item in data.BOOKDETAILS
                           where item.STATUS == true
                           select item;

            RB_BookNAme_Combo.DataSource = bookData.ToList();
            RB_BookNAme_Combo.ValueMember = "ID";
            RB_BookNAme_Combo.DisplayMember = "NAME";

        }
    }
}

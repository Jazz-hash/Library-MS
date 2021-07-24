using Library_Management_System.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : MaterialForm
    {
        DB_tables data = new DB_tables();
        int user_id = 1;
        decimal fine = 50;

        public Dashboard()
        {
            InitializeComponent();
            bd_loaddata();
            md_loaddata();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }


        private void BTNS_FIX()
        {
            Member_Delete_btn.Enabled = false;

        }


        private void Catalog_Combo_Click(object sender, EventArgs e)
        {

        }


        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            BD_Clear();
        }
        void BD_Clear()
        {
            Book_Name_Txtbox.Text = Language_Txtbox.Text = Number_of_Copies_txtbox.Text = Number_Of_Avilabe_Txtbox.Text = Publication_Year_Txtbox.Text = Author_Name_txtbox.Text = "";
            Save_btn.Text = "Save";
            Delete_btn.Enabled = false;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Save_btn.Text == "Save")
            {
                BOOKDETAIL bookData = new BOOKDETAIL
                {
                    NAME = Book_Name_Txtbox.Text.Trim(),
                    LANGUAGE = Language_Txtbox.Text.Trim(),
                    NO_OF_COPIES_ACTUAL = Number_of_Copies_txtbox.Text.Trim(),
                    NO_OF_COPIES_CURRENT = Number_Of_Avilabe_Txtbox.Text.Trim(),
                    PUBLICATION_YEAR = Publication_Year_Txtbox.Text.Trim(),
                    AUTHOR_NAME = Author_Name_txtbox.Text.Trim(),
                    Book_Catalog = (int)Catalog_Combo.SelectedValue,
                    USER_ID = user_id,
                    STATUS = false,
                };
                data.BOOKDETAILS.Add(bookData);
                data.SaveChanges();
                bd_loaddata();
                BD_Clear();
                MessageBox.Show("Successfull");
            }
            else if (Save_btn.Text == "Update")
            {
                id = (int)(BD_Gridview.CurrentRow.Cells[0].Value);
                BOOKDETAIL bookData = data.BOOKDETAILS.Find(id);
                bookData.Book_Catalog = (int)Catalog_Combo.SelectedValue;
                bookData.NAME = Book_Name_Txtbox.Text;
                bookData.LANGUAGE = Language_Txtbox.Text;
                bookData.NO_OF_COPIES_ACTUAL = Number_of_Copies_txtbox.Text;
                bookData.NO_OF_COPIES_CURRENT = Number_Of_Avilabe_Txtbox.Text;
                bookData.PUBLICATION_YEAR = Publication_Year_Txtbox.Text;
                bookData.AUTHOR_NAME = Author_Name_txtbox.Text;
                data.SaveChanges();
                MessageBox.Show("Successfull");
                Delete_btn.Enabled = false;
                Save_btn.Text = "New";
                BD_Clear();
                bd_loaddata();

            }
            load_comboBoxes();


        }

        /* BOOK DETAIL SECTION ENDS */

        private void Dashboard_Load(object sender, EventArgs e)
        {

            load_comboBoxes();
        }

        private void load_comboBoxes()
        {
            BD_Clear();
            MD_Clear();
            IB_Clear();

            //DISPLAYS BOOK CATALOG IN BOOK DETAILS
            Catalog_Combo.DataSource = data.BOOK_CATALOGS.ToList();
            Catalog_Combo.ValueMember = "ID";
            Catalog_Combo.DisplayMember = "CATALOG_NAME";

            ////DISPLAYS MEMBER NAME IN ISSUED BOOK
            Issued_Issuedto_Combo.DataSource = data.MEMBERS.ToList();
            Issued_Issuedto_Combo.ValueMember = "ID";
            Issued_Issuedto_Combo.DisplayMember = "NAME";

            ////DISPLAYS BOOK CATALOG IN ISSUED BOOK
            IB_Catalog_Name_Combo.DataSource = data.BOOK_CATALOGS.ToList();
            IB_Catalog_Name_Combo.ValueMember = "ID";
            IB_Catalog_Name_Combo.DisplayMember = "CATALOG_NAME";


            ////DISPLAY BOOK LIMIT IN ISSUED BOOKS
            Ib_issuuing_days_limit_combo.DataSource = data.ISSUED_DAYS_LIMITS.ToList();
            Ib_issuuing_days_limit_combo.ValueMember = "ID";
            Ib_issuuing_days_limit_combo.DisplayMember = "DAYS";

            ////DISPLAY MEMBER NAME IN RETURNIG BOOK SECTION
            RB_Member_Name_Combo.DataSource = data.MEMBERS.ToList();
            RB_Member_Name_Combo.ValueMember = "ID";
            RB_Member_Name_Combo.DisplayMember = "NAME";

            ////DISPLAYS BOOK NAME IN RETURNING BOOK SECTION
            var bookData = from item in data.BOOKDETAILS
                           where item.STATUS == true
                           select item;

            RB_BookName_Combo.DataSource = bookData.ToList();
            RB_BookName_Combo.ValueMember = "ID";
            RB_BookName_Combo.DisplayMember = "NAME";
        }

        /* MEMBER DETAILS & REGISTRATION SECTION STARTS */

        private void Member_Cancel_btn_Click(object sender, EventArgs e)
        {
            MD_Clear();
        }

        private void MD_Clear()
        {
            Member_Name_txtbox.Text = Member_Email_textbox.Text = Member_Gender_txtbox.Text = Member_Deprt_txtbox.Text = Member_Contact_txtbox.Text = Member_CNIC_txtbox.Text = Member_Address_txtbox.Text = MD_Role_Combo.Text = "";
            Member_Save_btn.Text = "Save";
            Member_Delete_btn.Enabled = false;
        }

        private void Member_Save_btn_Click(object sender, EventArgs e)
        {

            if (Member_Save_btn.Text == "Save")
            {
                MEMBER memberData = new MEMBER()
                {
                    ADDRESS = Member_Address_txtbox.Text,
                    CNIC = Member_CNIC_txtbox.Text,
                    CONTACT_NUMBER = Member_Contact_txtbox.Text,
                    DEPARTMENT = Member_Deprt_txtbox.Text,
                    EMAIL = Member_Email_textbox.Text,
                    GENDER = Member_Gender_txtbox.Text,
                    NAME = Member_Name_txtbox.Text,
                    REGISTERED_BY = user_id,
                    ROLE = MD_Role_Combo.SelectedItem.ToString(),
                };
                data.MEMBERS.Add(memberData);
                data.SaveChanges();

            }
            else if (Member_Save_btn.Text == "Update")
            {
                id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
                MEMBER memData = data.MEMBERS.Find(id);
                memData.ADDRESS = Member_Address_txtbox.Text;
                memData.CNIC = Member_CNIC_txtbox.Text;
                memData.NAME = Member_Name_txtbox.Text;
                memData.GENDER = Member_Gender_txtbox.Text;
                memData.EMAIL = Member_Email_textbox.Text;
                memData.DEPARTMENT = Member_Deprt_txtbox.Text;
                memData.CONTACT_NUMBER = Member_Contact_txtbox.Text;
                memData.ROLE = MD_Role_Combo.Text;
                Member_Save_btn.Text = "Save";
                Member_Delete_btn.Enabled = false;
                data.SaveChanges();

            }
            md_loaddata();
            MD_Clear();
            MessageBox.Show("Successfull");
            load_comboBoxes();


        }

        /* MEMBER DETAILS & REGISTRATION SECTION ENDS */

        /* ISSUED BOOKS SECTION STARTS */

        private void Issued_Cancel_btn_Click(object sender, EventArgs e)
        {
            IB_Clear();
        }

        private void IB_Clear()
        {
            Issued_Book_Combo.Text = Issued_Lang_txtbox.Text = Issued_publication_year_txtbox.Text = Issued_Author_txtbox.Text = Issued_Issuedto_Combo.Text = Issued_Issuedto_Combo.Text = "";
            Issued_Save_btn.Text = "Save";
            Issued_Delete_btn.Enabled = false;
        }

        private void Issued_Save_btn_Click(object sender, EventArgs e)
        {
            int book_id = (int)Issued_Book_Combo.SelectedValue;
            ISSUED_BOOK book_data = new ISSUED_BOOK
            {
                BOOKDETAIL_ID = book_id,
                ISSUED_BY = user_id,
                ISSUED_ON = DateTime.Now,
                ISSUED_TO = Issued_Issuedto_Combo.SelectedIndex + 1,
                DAY_LIMIT = Ib_issuuing_days_limit_combo.SelectedIndex + 1,
                IB_BOOKCAT = IB_Catalog_Name_Combo.SelectedIndex + 1,
            };
            BOOKDETAIL book_check = data.BOOKDETAILS.Find(book_id);
            book_check.STATUS = true;
            data.ISSUED_BOOKS.Add(book_data);
            data.SaveChanges();
            ib_loaddata();
            IB_Clear();
            load_comboBoxes();

        }

        private void Issued_Book_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = Issued_Book_Combo.SelectedIndex;
            BOOKDETAIL selected = Issued_Book_Combo.Items[id] as BOOKDETAIL;
            id = selected.ID;
            BOOKDETAIL data12 = data.BOOKDETAILS.Where(x => x.ID == id).SingleOrDefault();

            Issued_Author_txtbox.Text = data12.AUTHOR_NAME;
            Issued_Lang_txtbox.Text = data12.LANGUAGE;
            Issued_publication_year_txtbox.Text = data12.PUBLICATION_YEAR;


        }


        private void IB_Catalog_Name_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IB_Catalog_Name_Combo.SelectedValue);

            var books = from item in data.BOOKDETAILS
                        where item.Book_Catalog == id
                        select item;
            //{
            //    ID = item.ID,
            //    NAME = item.NAME,
            //};

            Issued_Book_Combo.DataSource = books.ToList();
            Issued_Book_Combo.DisplayMember = "NAME";
            Issued_Book_Combo.ValueMember = "ID";

        }


        /* ISSUED BOOKS SECTION ENDS */

        // LOADS DATA IN GRIDVIEW FOR BOOK DETAILS

        void bd_loaddata()
        {
            BD_Gridview.AutoGenerateColumns = false;
            BD_Gridview.DataSource = data.BOOKDETAILS.ToList();
        }

        // LOADS DATA IN GRIDVIEW FOR MEMBER DETAILS

        void md_loaddata()
        {
            MD_Grid.AutoGenerateColumns = false;
            MD_Grid.DataSource = data.MEMBERS.ToList<MEMBER>();
        }

        int id;

        private void BD_Gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(BD_Gridview.CurrentRow.Cells[0].Value.ToString());
        }

        private void BD_Gridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)(BD_Gridview.CurrentRow.Cells[0].Value);
            BOOKDETAIL bookData = data.BOOKDETAILS.Find(id);
            Catalog_Combo.SelectedValue = bookData.Book_Catalog;
            Book_Name_Txtbox.Text = bookData.NAME;
            Language_Txtbox.Text = bookData.LANGUAGE;
            Number_of_Copies_txtbox.Text = bookData.NO_OF_COPIES_ACTUAL;
            Number_Of_Avilabe_Txtbox.Text = bookData.NO_OF_COPIES_CURRENT;
            Publication_Year_Txtbox.Text = bookData.PUBLICATION_YEAR;
            Author_Name_txtbox.Text = bookData.AUTHOR_NAME;
            Save_btn.Text = "Update";
            Delete_btn.Enabled = true;
        }

        //LOADS DATA IN GRID VIEW FORM ISSUED BOOK

        void ib_loaddata()
        {
            Issued_book_Gridview.AutoGenerateColumns = false;
            Issued_book_Gridview.DataSource = data.ISSUED_BOOKS.ToList<ISSUED_BOOK>();
        }


        //LOADS DATA IN GRID VIEW RETURNING BOOK


        private void Delete_btn_Click(object sender, EventArgs e)
        {
            id = (int)(BD_Gridview.CurrentRow.Cells[0].Value);
            BOOKDETAIL bookData = data.BOOKDETAILS.Find(id);
            data.BOOKDETAILS.Remove(bookData);
            data.SaveChanges();
            bd_loaddata();
            BD_Clear();
            load_comboBoxes();

        }

        private void MD_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
            MEMBER memData = data.MEMBERS.Find(id);
            Member_Address_txtbox.Text = memData.ADDRESS;
            Member_CNIC_txtbox.Text = memData.CNIC;
            Member_Name_txtbox.Text = memData.NAME;
            Member_Gender_txtbox.Text = memData.GENDER;
            Member_Email_textbox.Text = memData.EMAIL;
            Member_Deprt_txtbox.Text = memData.DEPARTMENT;
            Member_Contact_txtbox.Text = memData.CONTACT_NUMBER;
            MD_Role_Combo.Text = memData.ROLE;
            Member_Save_btn.Text = "Update";
            Member_Delete_btn.Enabled = true;
        }

        private void Member_Delete_btn_Click(object sender, EventArgs e)
        {
            id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
            MEMBER memData = data.MEMBERS.Find(id);
            data.MEMBERS.Remove(memData);
            data.SaveChanges();
            load_comboBoxes();

        }

        private void Issued_Delete_btn_Click(object sender, EventArgs e)
        {
            id = (int)(Issued_book_Gridview.CurrentRow.Cells[0].Value);
            ISSUED_BOOK bookData = data.ISSUED_BOOKS.Find(id);
            data.ISSUED_BOOKS.Remove(bookData);
            data.SaveChanges();
            load_comboBoxes();

        }

        private void Issued_book_Gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)(Issued_book_Gridview.CurrentRow.Cells[0].Value);
            ISSUED_BOOK bookData = data.ISSUED_BOOKS.Find(id);

            IB_Catalog_Name_Combo.SelectedItem = bookData.BOOKDETAIL.BOOK_CATALOG;
            Issued_Book_Combo.SelectedItem = bookData.BOOKDETAIL.NAME;
            Issued_Lang_txtbox.Text = bookData.BOOKDETAIL.LANGUAGE;
            Issued_Author_txtbox.Text = bookData.BOOKDETAIL.AUTHOR_NAME;
            Issued_publication_year_txtbox.Text = bookData.BOOKDETAIL.PUBLICATION_YEAR;
            Ib_issuuing_days_limit_combo.SelectedItem = bookData.ISSUED_DAYS_LIMIT;
            Issued_Issuedto_Combo.SelectedValue = bookData.ISSUED_TO;
        }

        private void RB_Search_btn_Click(object sender, EventArgs e)
        {
            string book_index = RB_BookName_Combo.Text.ToString();
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


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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


            dateTimePicker1.Value = DateTime.Now;


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
            MessageBox.Show("Success");
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}

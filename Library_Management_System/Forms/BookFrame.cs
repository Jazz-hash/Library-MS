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
    public partial class BookFrame : Form
    {
        DB_tables data = new DB_tables();
        int user_id = 1;
        public BookFrame()
        {
            InitializeComponent();
        }

        private void load_comboBoxes()
        {

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

           
        }

        /*BOOK DETAIL Section Starts*/

        private void Save_btn_Click_1(object sender, EventArgs e)
        {

            if (Book_Name_Txtbox.Text == "")
            {
                MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Language_Txtbox.Text == "")
            {
                MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Number_Of_Avilabe_Txtbox.Text == "")
            {
                MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Number_of_Copies_txtbox.Text == "")
            {
                MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                BD_Dataload();
                MetroMessageBox.Show(this, "Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_comboBoxes();
            }

        }
        private void Save_btn_Click(object sender, EventArgs e)
        {


        }

        private void BookFrame_Load(object sender, EventArgs e)
        {
            load_comboBoxes();
            BD_Dataload();
        }

        private void BD_Dataload()
        {
            var book_data = from item in data.BOOKDETAILS
                            select new
                            {
                                ID = item.ID,
                                BOOK_NAME = item.NAME,
                                LANGUAGE = item.LANGUAGE,
                                NUMBER_OF_COPIES = item.NO_OF_COPIES_ACTUAL,
                                COPIES_AVAILABLE = item.NO_OF_COPIES_CURRENT,
                                PUBLICATION_YEAR = item.PUBLICATION_YEAR,
                                REGISTERED_BY = item.USER.NAME,
                            };
            BD_Gridview.DataSource = book_data.ToList();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

            if (Update_btn.Text == "Update")
            {
                int id = (int)(BD_Gridview.CurrentRow.Cells[0].Value);
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
                // BD_Clear();
                BD_Dataload();
            }
            load_comboBoxes();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int id = (int)(BD_Gridview.CurrentRow.Cells[0].Value);
            BOOKDETAIL bookData = data.BOOKDETAILS.Find(id);
            data.BOOKDETAILS.Remove(bookData);
            data.SaveChanges();
            load_comboBoxes();
        }

        private void BD_Gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(BD_Gridview.CurrentRow.Cells[0].Value.ToString());
        }

        private void BD_Gridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt16(BD_Gridview.CurrentRow.Cells[0].Value.ToString());
            BOOKDETAIL bookData = data.BOOKDETAILS.Find(id);
            //Catalog_Combo.SelectedValue = bookData.Book_Catalog;
            Book_Name_Txtbox.Text = bookData.NAME;
            Language_Txtbox.Text = bookData.LANGUAGE;
            Number_of_Copies_txtbox.Text = bookData.NO_OF_COPIES_ACTUAL;
            Number_Of_Avilabe_Txtbox.Text = bookData.NO_OF_COPIES_CURRENT;
            Publication_Year_Txtbox.Text = bookData.PUBLICATION_YEAR;
            Author_Name_txtbox.Text = bookData.AUTHOR_NAME;
        }


        /*BOOK DETAIL Section Ends*/


        /*ISSUING BOOK SECTION SARTS*/

       

        private void Issued_Save_btn_Click(object sender, EventArgs e)
        {
            if (IB_Catalog_Name_Combo.Text == "")
            {
                MetroMessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                load_comboBoxes();

                MetroMessageBox.Show(this, "Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
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
            string CATALOG_NAME = IB_Catalog_Name_Combo.Text;
            
            
            var books = from item in data.BOOKDETAILS
                        where item.BOOK_CATALOG.CATALOG_NAME == CATALOG_NAME
                        select item;

            Issued_Book_Combo.DataSource = books.ToList();
            Issued_Book_Combo.DisplayMember = "NAME";
            Issued_Book_Combo.ValueMember = "ID";

        }

        private void Issued_Delete_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((Issued_book_Gridview.CurrentRow.Cells[0].Value.ToString()));
            ISSUED_BOOK bookData = data.ISSUED_BOOKS.Find(id);
            data.ISSUED_BOOKS.Remove(bookData);
            data.SaveChanges();
            load_comboBoxes();
        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            BF_Tabcontrol.SelectedTab = Book_Info;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            BF_Tabcontrol.SelectedTab = Issuing_Book;
        }

        private void bunifuGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }




        /*ISSUINH BOOK SECTION ENDS*/
    }
}

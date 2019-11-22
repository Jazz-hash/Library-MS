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
    public partial class MemberFrame : Form
    {
        DB_tables data = new DB_tables();
        public MemberFrame()
        {
            InitializeComponent();
        }

        private void Member_Save_btn_Click_1(object sender, EventArgs e)
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
                ROLE = MD_Role_Combo.SelectedItem.ToString(),
            };
            data.MEMBERS.Add(memberData);
            data.SaveChanges();
        }

        private void Member_Update_btn_Click(object sender, EventArgs e)
        {
           int id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
            MEMBER memData = data.MEMBERS.Find(id);
            memData.ADDRESS = Member_Address_txtbox.Text;
            memData.CNIC = Member_CNIC_txtbox.Text;
            memData.NAME = Member_Name_txtbox.Text;
            memData.GENDER = Member_Gender_txtbox.Text;
            memData.EMAIL = Member_Email_textbox.Text;
            memData.DEPARTMENT = Member_Deprt_txtbox.Text;
            memData.CONTACT_NUMBER = Member_Contact_txtbox.Text;
            memData.ROLE = MD_Role_Combo.Text;
            Member_Delete_btn.Enabled = false;
            data.SaveChanges();
        }

        private void MD_Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           int id = Convert.ToInt32(MD_Grid.CurrentRow.Cells[0].Value.ToString());
        }

        private void MD_Grid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
            MEMBER memberdetail = data.MEMBERS.Find(id);
            Member_Name_txtbox.Text = memberdetail.NAME;
            Member_Gender_txtbox.Text = memberdetail.GENDER;
            Member_Address_txtbox.Text = memberdetail.ADDRESS;
            Member_CNIC_txtbox.Text = memberdetail.CNIC;
            Member_Contact_txtbox.Text = memberdetail.CONTACT_NUMBER;
            Member_Deprt_txtbox.Text = memberdetail.DEPARTMENT;
            Member_Email_textbox.Text = memberdetail.EMAIL;
            MD_Role_Combo.SelectedValue = memberdetail.ROLE;
        }

        private void Member_Delete_btn_Click(object sender, EventArgs e)
        {
            int id = (int)(MD_Grid.CurrentRow.Cells[0].Value);
            MEMBER memData = data.MEMBERS.Find(id);
            data.MEMBERS.Remove(memData);
            data.SaveChanges();
        }
        private void MD_dataload()
        {
            var memberdetails = from item in data.MEMBERS
                                select new
                                {
                                    ID = item.ID,
                                    Name = item.NAME,
                                    Gender = item.GENDER,
                                    ADDRESS = item.ADDRESS,
                                    CNIC = item.CNIC,
                                    CONTACT = item.CONTACT_NUMBER,
                                    DEPARTMENT = item.DEPARTMENT,
                                    EMAIL = item.EMAIL,
                                    ROLE = item.ROLE
                                };
            MD_Grid.DataSource = memberdetails.ToList();
        }

        private void MemberFrame_Load(object sender, EventArgs e)
        {
            MD_dataload();
        }
    }
}

namespace Library_Management_System.Forms
{
    partial class MemberFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberFrame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MemberTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.MemberlTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Member_details = new System.Windows.Forms.TabPage();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MD_Grid = new MetroFramework.Controls.MetroGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Member_Name_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Address_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_CNIC_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Contact_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Deprt_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Gender_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Email_textbox = new MetroFramework.Controls.MetroTextBox();
            this.Member_Update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Member_Delete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Member_Save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Member_Save_btn_Click = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MD_Role_Combo = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2.SuspendLayout();
            this.MemberlTabControl.SuspendLayout();
            this.Member_details.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MD_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.MemberTabSelector);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 10);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1026, 60);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // MemberTabSelector
            // 
            this.MemberTabSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MemberTabSelector.BaseTabControl = this.MemberlTabControl;
            this.MemberTabSelector.Depth = 0;
            this.MemberTabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberTabSelector.Location = new System.Drawing.Point(0, 60);
            this.MemberTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.MemberTabSelector.Name = "MemberTabSelector";
            this.MemberTabSelector.Size = new System.Drawing.Size(1026, 0);
            this.MemberTabSelector.TabIndex = 5;
            this.MemberTabSelector.Text = "materialTabSelector1";
            // 
            // MemberlTabControl
            // 
            this.MemberlTabControl.Controls.Add(this.Member_details);
            this.MemberlTabControl.Depth = 0;
            this.MemberlTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberlTabControl.Location = new System.Drawing.Point(0, 0);
            this.MemberlTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MemberlTabControl.Name = "MemberlTabControl";
            this.MemberlTabControl.SelectedIndex = 0;
            this.MemberlTabControl.Size = new System.Drawing.Size(1026, 749);
            this.MemberlTabControl.TabIndex = 6;
            // 
            // Member_details
            // 
            this.Member_details.Controls.Add(this.bunifuGradientPanel3);
            this.Member_details.Controls.Add(this.panel1);
            this.Member_details.Location = new System.Drawing.Point(4, 26);
            this.Member_details.Name = "Member_details";
            this.Member_details.Padding = new System.Windows.Forms.Padding(3);
            this.Member_details.Size = new System.Drawing.Size(1018, 719);
            this.Member_details.TabIndex = 0;
            this.Member_details.Text = "Member Details";
            this.Member_details.UseVisualStyleBackColor = true;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.panel5);
            this.bunifuGradientPanel3.Controls.Add(this.MD_Grid);
            this.bunifuGradientPanel3.Controls.Add(this.panel6);
            this.bunifuGradientPanel3.Controls.Add(this.panel7);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(422, 3);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(593, 713);
            this.bunifuGradientPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 677);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 36);
            this.panel5.TabIndex = 22;
            // 
            // MD_Grid
            // 
            this.MD_Grid.AllowUserToAddRows = false;
            this.MD_Grid.AllowUserToDeleteRows = false;
            this.MD_Grid.AllowUserToResizeRows = false;
            this.MD_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MD_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MD_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MD_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MD_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MD_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MD_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.MD_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MD_Grid.EnableHeadersVisualStyles = false;
            this.MD_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MD_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MD_Grid.Location = new System.Drawing.Point(0, 36);
            this.MD_Grid.Name = "MD_Grid";
            this.MD_Grid.ReadOnly = true;
            this.MD_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MD_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MD_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MD_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MD_Grid.Size = new System.Drawing.Size(573, 677);
            this.MD_Grid.TabIndex = 1;
            this.MD_Grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MD_Grid_RowHeaderMouseClick);
            this.MD_Grid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MD_Grid_RowHeaderMouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(573, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 677);
            this.panel6.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(593, 36);
            this.panel7.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Member_Name_txtbox);
            this.panel1.Controls.Add(this.Member_Address_txtbox);
            this.panel1.Controls.Add(this.Member_CNIC_txtbox);
            this.panel1.Controls.Add(this.Member_Contact_txtbox);
            this.panel1.Controls.Add(this.Member_Deprt_txtbox);
            this.panel1.Controls.Add(this.Member_Gender_txtbox);
            this.panel1.Controls.Add(this.Member_Email_textbox);
            this.panel1.Controls.Add(this.Member_Update_btn);
            this.panel1.Controls.Add(this.Member_Delete_btn);
            this.panel1.Controls.Add(this.Member_Save_btn);
            this.panel1.Controls.Add(this.Member_Save_btn_Click);
            this.panel1.Controls.Add(this.MD_Role_Combo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 713);
            this.panel1.TabIndex = 0;
            // 
            // Member_Name_txtbox
            // 
            // 
            // 
            // 
            this.Member_Name_txtbox.CustomButton.Image = null;
            this.Member_Name_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Name_txtbox.CustomButton.Name = "";
            this.Member_Name_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Name_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Name_txtbox.CustomButton.TabIndex = 1;
            this.Member_Name_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Name_txtbox.CustomButton.UseSelectable = true;
            this.Member_Name_txtbox.CustomButton.Visible = false;
            this.Member_Name_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Name_txtbox.Lines = new string[0];
            this.Member_Name_txtbox.Location = new System.Drawing.Point(67, 110);
            this.Member_Name_txtbox.MaxLength = 32767;
            this.Member_Name_txtbox.Name = "Member_Name_txtbox";
            this.Member_Name_txtbox.PasswordChar = '\0';
            this.Member_Name_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Name_txtbox.SelectedText = "";
            this.Member_Name_txtbox.SelectionLength = 0;
            this.Member_Name_txtbox.SelectionStart = 0;
            this.Member_Name_txtbox.ShortcutsEnabled = true;
            this.Member_Name_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Name_txtbox.TabIndex = 33;
            this.Member_Name_txtbox.UseSelectable = true;
            this.Member_Name_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Name_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Address_txtbox
            // 
            // 
            // 
            // 
            this.Member_Address_txtbox.CustomButton.Image = null;
            this.Member_Address_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Address_txtbox.CustomButton.Name = "";
            this.Member_Address_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Address_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Address_txtbox.CustomButton.TabIndex = 1;
            this.Member_Address_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Address_txtbox.CustomButton.UseSelectable = true;
            this.Member_Address_txtbox.CustomButton.Visible = false;
            this.Member_Address_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Address_txtbox.Lines = new string[0];
            this.Member_Address_txtbox.Location = new System.Drawing.Point(67, 507);
            this.Member_Address_txtbox.MaxLength = 32767;
            this.Member_Address_txtbox.Name = "Member_Address_txtbox";
            this.Member_Address_txtbox.PasswordChar = '\0';
            this.Member_Address_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Address_txtbox.SelectedText = "";
            this.Member_Address_txtbox.SelectionLength = 0;
            this.Member_Address_txtbox.SelectionStart = 0;
            this.Member_Address_txtbox.ShortcutsEnabled = true;
            this.Member_Address_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Address_txtbox.TabIndex = 33;
            this.Member_Address_txtbox.UseSelectable = true;
            this.Member_Address_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Address_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_CNIC_txtbox
            // 
            // 
            // 
            // 
            this.Member_CNIC_txtbox.CustomButton.Image = null;
            this.Member_CNIC_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_CNIC_txtbox.CustomButton.Name = "";
            this.Member_CNIC_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_CNIC_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_CNIC_txtbox.CustomButton.TabIndex = 1;
            this.Member_CNIC_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_CNIC_txtbox.CustomButton.UseSelectable = true;
            this.Member_CNIC_txtbox.CustomButton.Visible = false;
            this.Member_CNIC_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_CNIC_txtbox.Lines = new string[0];
            this.Member_CNIC_txtbox.Location = new System.Drawing.Point(67, 441);
            this.Member_CNIC_txtbox.MaxLength = 32767;
            this.Member_CNIC_txtbox.Name = "Member_CNIC_txtbox";
            this.Member_CNIC_txtbox.PasswordChar = '\0';
            this.Member_CNIC_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_CNIC_txtbox.SelectedText = "";
            this.Member_CNIC_txtbox.SelectionLength = 0;
            this.Member_CNIC_txtbox.SelectionStart = 0;
            this.Member_CNIC_txtbox.ShortcutsEnabled = true;
            this.Member_CNIC_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_CNIC_txtbox.TabIndex = 33;
            this.Member_CNIC_txtbox.UseSelectable = true;
            this.Member_CNIC_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_CNIC_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Contact_txtbox
            // 
            // 
            // 
            // 
            this.Member_Contact_txtbox.CustomButton.Image = null;
            this.Member_Contact_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Contact_txtbox.CustomButton.Name = "";
            this.Member_Contact_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Contact_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Contact_txtbox.CustomButton.TabIndex = 1;
            this.Member_Contact_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Contact_txtbox.CustomButton.UseSelectable = true;
            this.Member_Contact_txtbox.CustomButton.Visible = false;
            this.Member_Contact_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Contact_txtbox.Lines = new string[0];
            this.Member_Contact_txtbox.Location = new System.Drawing.Point(67, 370);
            this.Member_Contact_txtbox.MaxLength = 32767;
            this.Member_Contact_txtbox.Name = "Member_Contact_txtbox";
            this.Member_Contact_txtbox.PasswordChar = '\0';
            this.Member_Contact_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Contact_txtbox.SelectedText = "";
            this.Member_Contact_txtbox.SelectionLength = 0;
            this.Member_Contact_txtbox.SelectionStart = 0;
            this.Member_Contact_txtbox.ShortcutsEnabled = true;
            this.Member_Contact_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Contact_txtbox.TabIndex = 33;
            this.Member_Contact_txtbox.UseSelectable = true;
            this.Member_Contact_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Contact_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Deprt_txtbox
            // 
            // 
            // 
            // 
            this.Member_Deprt_txtbox.CustomButton.Image = null;
            this.Member_Deprt_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Deprt_txtbox.CustomButton.Name = "";
            this.Member_Deprt_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Deprt_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Deprt_txtbox.CustomButton.TabIndex = 1;
            this.Member_Deprt_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Deprt_txtbox.CustomButton.UseSelectable = true;
            this.Member_Deprt_txtbox.CustomButton.Visible = false;
            this.Member_Deprt_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Deprt_txtbox.Lines = new string[0];
            this.Member_Deprt_txtbox.Location = new System.Drawing.Point(67, 299);
            this.Member_Deprt_txtbox.MaxLength = 32767;
            this.Member_Deprt_txtbox.Name = "Member_Deprt_txtbox";
            this.Member_Deprt_txtbox.PasswordChar = '\0';
            this.Member_Deprt_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Deprt_txtbox.SelectedText = "";
            this.Member_Deprt_txtbox.SelectionLength = 0;
            this.Member_Deprt_txtbox.SelectionStart = 0;
            this.Member_Deprt_txtbox.ShortcutsEnabled = true;
            this.Member_Deprt_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Deprt_txtbox.TabIndex = 33;
            this.Member_Deprt_txtbox.UseSelectable = true;
            this.Member_Deprt_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Deprt_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Gender_txtbox
            // 
            // 
            // 
            // 
            this.Member_Gender_txtbox.CustomButton.Image = null;
            this.Member_Gender_txtbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Gender_txtbox.CustomButton.Name = "";
            this.Member_Gender_txtbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Gender_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Gender_txtbox.CustomButton.TabIndex = 1;
            this.Member_Gender_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Gender_txtbox.CustomButton.UseSelectable = true;
            this.Member_Gender_txtbox.CustomButton.Visible = false;
            this.Member_Gender_txtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Gender_txtbox.Lines = new string[0];
            this.Member_Gender_txtbox.Location = new System.Drawing.Point(67, 234);
            this.Member_Gender_txtbox.MaxLength = 32767;
            this.Member_Gender_txtbox.Name = "Member_Gender_txtbox";
            this.Member_Gender_txtbox.PasswordChar = '\0';
            this.Member_Gender_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Gender_txtbox.SelectedText = "";
            this.Member_Gender_txtbox.SelectionLength = 0;
            this.Member_Gender_txtbox.SelectionStart = 0;
            this.Member_Gender_txtbox.ShortcutsEnabled = true;
            this.Member_Gender_txtbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Gender_txtbox.TabIndex = 33;
            this.Member_Gender_txtbox.UseSelectable = true;
            this.Member_Gender_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Gender_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Email_textbox
            // 
            // 
            // 
            // 
            this.Member_Email_textbox.CustomButton.Image = null;
            this.Member_Email_textbox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.Member_Email_textbox.CustomButton.Name = "";
            this.Member_Email_textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Member_Email_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Member_Email_textbox.CustomButton.TabIndex = 1;
            this.Member_Email_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Member_Email_textbox.CustomButton.UseSelectable = true;
            this.Member_Email_textbox.CustomButton.Visible = false;
            this.Member_Email_textbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Member_Email_textbox.Lines = new string[0];
            this.Member_Email_textbox.Location = new System.Drawing.Point(67, 166);
            this.Member_Email_textbox.MaxLength = 32767;
            this.Member_Email_textbox.Name = "Member_Email_textbox";
            this.Member_Email_textbox.PasswordChar = '\0';
            this.Member_Email_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Member_Email_textbox.SelectedText = "";
            this.Member_Email_textbox.SelectionLength = 0;
            this.Member_Email_textbox.SelectionStart = 0;
            this.Member_Email_textbox.ShortcutsEnabled = true;
            this.Member_Email_textbox.Size = new System.Drawing.Size(298, 29);
            this.Member_Email_textbox.TabIndex = 33;
            this.Member_Email_textbox.UseSelectable = true;
            this.Member_Email_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Member_Email_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Member_Update_btn
            // 
            this.Member_Update_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member_Update_btn.BorderRadius = 0;
            this.Member_Update_btn.ButtonText = "Update";
            this.Member_Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member_Update_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Member_Update_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Member_Update_btn.Iconimage = null;
            this.Member_Update_btn.Iconimage_right = null;
            this.Member_Update_btn.Iconimage_right_Selected = null;
            this.Member_Update_btn.Iconimage_Selected = null;
            this.Member_Update_btn.IconMarginLeft = 0;
            this.Member_Update_btn.IconMarginRight = 0;
            this.Member_Update_btn.IconRightVisible = false;
            this.Member_Update_btn.IconRightZoom = 0D;
            this.Member_Update_btn.IconVisible = false;
            this.Member_Update_btn.IconZoom = 90D;
            this.Member_Update_btn.IsTab = false;
            this.Member_Update_btn.Location = new System.Drawing.Point(179, 624);
            this.Member_Update_btn.Margin = new System.Windows.Forms.Padding(16, 21, 16, 21);
            this.Member_Update_btn.Name = "Member_Update_btn";
            this.Member_Update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.Member_Update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Member_Update_btn.selected = false;
            this.Member_Update_btn.Size = new System.Drawing.Size(110, 41);
            this.Member_Update_btn.TabIndex = 29;
            this.Member_Update_btn.Text = "Update";
            this.Member_Update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Member_Update_btn.Textcolor = System.Drawing.Color.White;
            this.Member_Update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Update_btn.Click += new System.EventHandler(this.Member_Update_btn_Click);
            // 
            // Member_Delete_btn
            // 
            this.Member_Delete_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member_Delete_btn.BorderRadius = 0;
            this.Member_Delete_btn.ButtonText = "Delete";
            this.Member_Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member_Delete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Member_Delete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Member_Delete_btn.Iconimage = null;
            this.Member_Delete_btn.Iconimage_right = null;
            this.Member_Delete_btn.Iconimage_right_Selected = null;
            this.Member_Delete_btn.Iconimage_Selected = null;
            this.Member_Delete_btn.IconMarginLeft = 0;
            this.Member_Delete_btn.IconMarginRight = 0;
            this.Member_Delete_btn.IconRightVisible = false;
            this.Member_Delete_btn.IconRightZoom = 0D;
            this.Member_Delete_btn.IconVisible = false;
            this.Member_Delete_btn.IconZoom = 90D;
            this.Member_Delete_btn.IsTab = false;
            this.Member_Delete_btn.Location = new System.Drawing.Point(304, 624);
            this.Member_Delete_btn.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
            this.Member_Delete_btn.Name = "Member_Delete_btn";
            this.Member_Delete_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Delete_btn.OnHovercolor = System.Drawing.Color.Red;
            this.Member_Delete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Member_Delete_btn.selected = false;
            this.Member_Delete_btn.Size = new System.Drawing.Size(101, 41);
            this.Member_Delete_btn.TabIndex = 29;
            this.Member_Delete_btn.Text = "Delete";
            this.Member_Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Member_Delete_btn.Textcolor = System.Drawing.Color.White;
            this.Member_Delete_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Delete_btn.Click += new System.EventHandler(this.Member_Delete_btn_Click);
            // 
            // Member_Save_btn
            // 
            this.Member_Save_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member_Save_btn.BorderRadius = 0;
            this.Member_Save_btn.ButtonText = "Save";
            this.Member_Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member_Save_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Member_Save_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Member_Save_btn.Iconimage = null;
            this.Member_Save_btn.Iconimage_right = null;
            this.Member_Save_btn.Iconimage_right_Selected = null;
            this.Member_Save_btn.Iconimage_Selected = null;
            this.Member_Save_btn.IconMarginLeft = 0;
            this.Member_Save_btn.IconMarginRight = 0;
            this.Member_Save_btn.IconRightVisible = false;
            this.Member_Save_btn.IconRightZoom = 0D;
            this.Member_Save_btn.IconVisible = false;
            this.Member_Save_btn.IconZoom = 90D;
            this.Member_Save_btn.IsTab = false;
            this.Member_Save_btn.Location = new System.Drawing.Point(67, 624);
            this.Member_Save_btn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Member_Save_btn.Name = "Member_Save_btn";
            this.Member_Save_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.Member_Save_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Member_Save_btn.selected = false;
            this.Member_Save_btn.Size = new System.Drawing.Size(95, 41);
            this.Member_Save_btn.TabIndex = 28;
            this.Member_Save_btn.Text = "Save";
            this.Member_Save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Member_Save_btn.Textcolor = System.Drawing.Color.White;
            this.Member_Save_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Member_Save_btn_Click
            // 
            this.Member_Save_btn_Click.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member_Save_btn_Click.BorderRadius = 0;
            this.Member_Save_btn_Click.ButtonText = "Save";
            this.Member_Save_btn_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member_Save_btn_Click.DisabledColor = System.Drawing.Color.Gray;
            this.Member_Save_btn_Click.Iconcolor = System.Drawing.Color.Transparent;
            this.Member_Save_btn_Click.Iconimage = null;
            this.Member_Save_btn_Click.Iconimage_right = null;
            this.Member_Save_btn_Click.Iconimage_right_Selected = null;
            this.Member_Save_btn_Click.Iconimage_Selected = null;
            this.Member_Save_btn_Click.IconMarginLeft = 0;
            this.Member_Save_btn_Click.IconMarginRight = 0;
            this.Member_Save_btn_Click.IconRightVisible = false;
            this.Member_Save_btn_Click.IconRightZoom = 0D;
            this.Member_Save_btn_Click.IconVisible = false;
            this.Member_Save_btn_Click.IconZoom = 90D;
            this.Member_Save_btn_Click.IsTab = false;
            this.Member_Save_btn_Click.Location = new System.Drawing.Point(129, 749);
            this.Member_Save_btn_Click.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Member_Save_btn_Click.Name = "Member_Save_btn_Click";
            this.Member_Save_btn_Click.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Member_Save_btn_Click.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.Member_Save_btn_Click.OnHoverTextColor = System.Drawing.Color.White;
            this.Member_Save_btn_Click.selected = false;
            this.Member_Save_btn_Click.Size = new System.Drawing.Size(124, 51);
            this.Member_Save_btn_Click.TabIndex = 27;
            this.Member_Save_btn_Click.Text = "Save";
            this.Member_Save_btn_Click.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Member_Save_btn_Click.Textcolor = System.Drawing.Color.White;
            this.Member_Save_btn_Click.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MD_Role_Combo
            // 
            this.MD_Role_Combo.FormattingEnabled = true;
            this.MD_Role_Combo.ItemHeight = 23;
            this.MD_Role_Combo.Items.AddRange(new object[] {
            "Professor",
            "Student"});
            this.MD_Role_Combo.Location = new System.Drawing.Point(67, 580);
            this.MD_Role_Combo.Name = "MD_Role_Combo";
            this.MD_Role_Combo.Size = new System.Drawing.Size(298, 29);
            this.MD_Role_Combo.TabIndex = 14;
            this.MD_Role_Combo.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(63, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(63, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(63, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(63, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1026, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adding New Member";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1026, 10);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // MemberFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 749);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.MemberlTabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberFrame_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.MemberlTabControl.ResumeLayout(false);
            this.Member_details.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MD_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private MaterialSkin.Controls.MaterialTabSelector MemberTabSelector;
        private MaterialSkin.Controls.MaterialTabControl MemberlTabControl;
        private System.Windows.Forms.TabPage Member_details;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private MetroFramework.Controls.MetroGrid MD_Grid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Member_Update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Member_Delete_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Member_Save_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Member_Save_btn_Click;
        private MetroFramework.Controls.MetroComboBox MD_Role_Combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox Member_Deprt_txtbox;
        private MetroFramework.Controls.MetroTextBox Member_Gender_txtbox;
        private MetroFramework.Controls.MetroTextBox Member_Email_textbox;
        private MetroFramework.Controls.MetroTextBox Member_Name_txtbox;
        private MetroFramework.Controls.MetroTextBox Member_Address_txtbox;
        private MetroFramework.Controls.MetroTextBox Member_CNIC_txtbox;
        private MetroFramework.Controls.MetroTextBox Member_Contact_txtbox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
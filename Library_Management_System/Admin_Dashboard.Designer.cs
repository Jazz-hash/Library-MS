namespace Library_Management_System
{
    partial class Admin_Dashboard
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.navbar_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.nav_closer = new System.Windows.Forms.Timer(this.components);
            this.nav_opener = new System.Windows.Forms.Timer(this.components);
            this.mini_logo_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mini_navbar_animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.user_image_picker = new System.Windows.Forms.OpenFileDialog();
            this.forms_container = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.navbar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReturningBook_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Memberframe_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Bookfram_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mini_logo = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_logo)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar_animator
            // 
            this.navbar_animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.navbar_animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.navbar_animator.DefaultAnimation = animation1;
            this.navbar_animator.Interval = 7;
            // 
            // logo_animator
            // 
            this.logo_animator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logo_animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logo_animator.DefaultAnimation = animation2;
            // 
            // nav_closer
            // 
            this.nav_closer.Interval = 1;
            // 
            // nav_opener
            // 
            this.nav_opener.Interval = 1;
            // 
            // mini_logo_animator
            // 
            this.mini_logo_animator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.mini_logo_animator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.mini_logo_animator.DefaultAnimation = animation3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mini_navbar_animator
            // 
            this.mini_navbar_animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.mini_navbar_animator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.mini_navbar_animator.DefaultAnimation = animation4;
            // 
            // user_image_picker
            // 
            this.user_image_picker.FileName = "openFileDialog1";
            this.user_image_picker.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // forms_container
            // 
            this.forms_container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forms_container.BackgroundImage")));
            this.forms_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mini_navbar_animator.SetDecoration(this.forms_container, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.forms_container, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.forms_container, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.forms_container, BunifuAnimatorNS.DecorationType.None);
            this.forms_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forms_container.GradientBottomLeft = System.Drawing.Color.White;
            this.forms_container.GradientBottomRight = System.Drawing.Color.White;
            this.forms_container.GradientTopLeft = System.Drawing.Color.White;
            this.forms_container.GradientTopRight = System.Drawing.Color.White;
            this.forms_container.Location = new System.Drawing.Point(285, 24);
            this.forms_container.Name = "forms_container";
            this.forms_container.Quality = 10;
            this.forms_container.Size = new System.Drawing.Size(727, 647);
            this.forms_container.TabIndex = 29;
            // 
            // navbar
            // 
            this.navbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navbar.BackgroundImage")));
            this.navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navbar.Controls.Add(this.panel1);
            this.navbar.Controls.Add(this.ReturningBook_btn);
            this.navbar.Controls.Add(this.Memberframe_btn);
            this.navbar.Controls.Add(this.Bookfram_btn);
            this.navbar.Controls.Add(this.dashboard_btn);
            this.navbar.Controls.Add(this.logo);
            this.navbar.Controls.Add(this.panel2);
            this.navbar.Controls.Add(this.mini_logo);
            this.mini_navbar_animator.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.navbar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.navbar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.navbar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.navbar.Location = new System.Drawing.Point(0, 24);
            this.navbar.Name = "navbar";
            this.navbar.Quality = 10;
            this.navbar.Size = new System.Drawing.Size(285, 647);
            this.navbar.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Logout_btn);
            this.mini_navbar_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 77);
            this.panel1.TabIndex = 29;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Activecolor = System.Drawing.Color.Black;
            this.Logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_btn.BorderRadius = 0;
            this.Logout_btn.ButtonText = "     Logout";
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_navbar_animator.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.Logout_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Logout_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_btn.Iconimage = global::Library_Management_System.Properties.Resources.undo_25px;
            this.Logout_btn.Iconimage_right = null;
            this.Logout_btn.Iconimage_right_Selected = null;
            this.Logout_btn.Iconimage_Selected = null;
            this.Logout_btn.IconMarginLeft = 0;
            this.Logout_btn.IconMarginRight = 0;
            this.Logout_btn.IconRightVisible = true;
            this.Logout_btn.IconRightZoom = 0D;
            this.Logout_btn.IconVisible = true;
            this.Logout_btn.IconZoom = 50D;
            this.Logout_btn.IsTab = false;
            this.Logout_btn.Location = new System.Drawing.Point(2, 3);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Logout_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.Logout_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Logout_btn.selected = false;
            this.Logout_btn.Size = new System.Drawing.Size(280, 48);
            this.Logout_btn.TabIndex = 28;
            this.Logout_btn.Text = "     Logout";
            this.Logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Textcolor = System.Drawing.Color.White;
            this.Logout_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // ReturningBook_btn
            // 
            this.ReturningBook_btn.Activecolor = System.Drawing.Color.Black;
            this.ReturningBook_btn.BackColor = System.Drawing.Color.Transparent;
            this.ReturningBook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturningBook_btn.BorderRadius = 0;
            this.ReturningBook_btn.ButtonText = "     Return Book";
            this.ReturningBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_navbar_animator.SetDecoration(this.ReturningBook_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.ReturningBook_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.ReturningBook_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.ReturningBook_btn, BunifuAnimatorNS.DecorationType.None);
            this.ReturningBook_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ReturningBook_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ReturningBook_btn.Iconimage = global::Library_Management_System.Properties.Resources.reorder_25px;
            this.ReturningBook_btn.Iconimage_right = null;
            this.ReturningBook_btn.Iconimage_right_Selected = null;
            this.ReturningBook_btn.Iconimage_Selected = null;
            this.ReturningBook_btn.IconMarginLeft = 0;
            this.ReturningBook_btn.IconMarginRight = 0;
            this.ReturningBook_btn.IconRightVisible = true;
            this.ReturningBook_btn.IconRightZoom = 0D;
            this.ReturningBook_btn.IconVisible = true;
            this.ReturningBook_btn.IconZoom = 50D;
            this.ReturningBook_btn.IsTab = false;
            this.ReturningBook_btn.Location = new System.Drawing.Point(2, 419);
            this.ReturningBook_btn.Name = "ReturningBook_btn";
            this.ReturningBook_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.ReturningBook_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.ReturningBook_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ReturningBook_btn.selected = false;
            this.ReturningBook_btn.Size = new System.Drawing.Size(280, 48);
            this.ReturningBook_btn.TabIndex = 28;
            this.ReturningBook_btn.Text = "     Return Book";
            this.ReturningBook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturningBook_btn.Textcolor = System.Drawing.Color.White;
            this.ReturningBook_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturningBook_btn.Click += new System.EventHandler(this.ReturningBook_btn_Click);
            // 
            // Memberframe_btn
            // 
            this.Memberframe_btn.Activecolor = System.Drawing.Color.Black;
            this.Memberframe_btn.BackColor = System.Drawing.Color.Transparent;
            this.Memberframe_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Memberframe_btn.BorderRadius = 0;
            this.Memberframe_btn.ButtonText = "     Members Frame";
            this.Memberframe_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_navbar_animator.SetDecoration(this.Memberframe_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Memberframe_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.Memberframe_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.Memberframe_btn, BunifuAnimatorNS.DecorationType.None);
            this.Memberframe_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Memberframe_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Memberframe_btn.Iconimage = global::Library_Management_System.Properties.Resources.groups_25px;
            this.Memberframe_btn.Iconimage_right = null;
            this.Memberframe_btn.Iconimage_right_Selected = null;
            this.Memberframe_btn.Iconimage_Selected = null;
            this.Memberframe_btn.IconMarginLeft = 0;
            this.Memberframe_btn.IconMarginRight = 0;
            this.Memberframe_btn.IconRightVisible = true;
            this.Memberframe_btn.IconRightZoom = 0D;
            this.Memberframe_btn.IconVisible = true;
            this.Memberframe_btn.IconZoom = 50D;
            this.Memberframe_btn.IsTab = false;
            this.Memberframe_btn.Location = new System.Drawing.Point(-3, 331);
            this.Memberframe_btn.Name = "Memberframe_btn";
            this.Memberframe_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Memberframe_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.Memberframe_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Memberframe_btn.selected = false;
            this.Memberframe_btn.Size = new System.Drawing.Size(280, 48);
            this.Memberframe_btn.TabIndex = 28;
            this.Memberframe_btn.Text = "     Members Frame";
            this.Memberframe_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Memberframe_btn.Textcolor = System.Drawing.Color.White;
            this.Memberframe_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memberframe_btn.Click += new System.EventHandler(this.Memberframe_btn_Click);
            // 
            // Bookfram_btn
            // 
            this.Bookfram_btn.Activecolor = System.Drawing.Color.Black;
            this.Bookfram_btn.BackColor = System.Drawing.Color.Transparent;
            this.Bookfram_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bookfram_btn.BorderRadius = 0;
            this.Bookfram_btn.ButtonText = "     Books Frame";
            this.Bookfram_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_navbar_animator.SetDecoration(this.Bookfram_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.Bookfram_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.Bookfram_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.Bookfram_btn, BunifuAnimatorNS.DecorationType.None);
            this.Bookfram_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Bookfram_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Bookfram_btn.Iconimage = global::Library_Management_System.Properties.Resources.book_shelf_25px1;
            this.Bookfram_btn.Iconimage_right = null;
            this.Bookfram_btn.Iconimage_right_Selected = null;
            this.Bookfram_btn.Iconimage_Selected = null;
            this.Bookfram_btn.IconMarginLeft = 0;
            this.Bookfram_btn.IconMarginRight = 0;
            this.Bookfram_btn.IconRightVisible = true;
            this.Bookfram_btn.IconRightZoom = 0D;
            this.Bookfram_btn.IconVisible = true;
            this.Bookfram_btn.IconZoom = 50D;
            this.Bookfram_btn.IsTab = false;
            this.Bookfram_btn.Location = new System.Drawing.Point(-3, 249);
            this.Bookfram_btn.Name = "Bookfram_btn";
            this.Bookfram_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Bookfram_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.Bookfram_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Bookfram_btn.selected = false;
            this.Bookfram_btn.Size = new System.Drawing.Size(280, 48);
            this.Bookfram_btn.TabIndex = 28;
            this.Bookfram_btn.Text = "     Books Frame";
            this.Bookfram_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bookfram_btn.Textcolor = System.Drawing.Color.White;
            this.Bookfram_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookfram_btn.Click += new System.EventHandler(this.Bookfram_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Activecolor = System.Drawing.Color.Black;
            this.dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard_btn.BorderRadius = 0;
            this.dashboard_btn.ButtonText = "     Home";
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_navbar_animator.SetDecoration(this.dashboard_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.dashboard_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.dashboard_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.dashboard_btn, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_btn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Iconimage")));
            this.dashboard_btn.Iconimage_right = null;
            this.dashboard_btn.Iconimage_right_Selected = null;
            this.dashboard_btn.Iconimage_Selected = null;
            this.dashboard_btn.IconMarginLeft = 0;
            this.dashboard_btn.IconMarginRight = 0;
            this.dashboard_btn.IconRightVisible = true;
            this.dashboard_btn.IconRightZoom = 0D;
            this.dashboard_btn.IconVisible = true;
            this.dashboard_btn.IconZoom = 50D;
            this.dashboard_btn.IsTab = false;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 175);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.dashboard_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.dashboard_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard_btn.selected = false;
            this.dashboard_btn.Size = new System.Drawing.Size(280, 48);
            this.dashboard_btn.TabIndex = 28;
            this.dashboard_btn.Text = "     Home";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Textcolor = System.Drawing.Color.White;
            this.dashboard_btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.mini_logo_animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(23, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(183, 77);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.mini_navbar_animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 40);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_logo_animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Nav_btn_Click);
            // 
            // mini_logo
            // 
            this.mini_logo.BackColor = System.Drawing.Color.Transparent;
            this.mini_logo_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.mini_logo, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo.Image = ((System.Drawing.Image)(resources.GetObject("mini_logo.Image")));
            this.mini_logo.Location = new System.Drawing.Point(6, 68);
            this.mini_logo.Name = "mini_logo";
            this.mini_logo.Size = new System.Drawing.Size(43, 42);
            this.mini_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_logo.TabIndex = 27;
            this.mini_logo.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.minimize_btn);
            this.bunifuGradientPanel2.Controls.Add(this.close_btn);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.mini_navbar_animator.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.mini_logo_animator.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1012, 24);
            this.bunifuGradientPanel2.TabIndex = 7;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_logo_animator.SetDecoration(this.minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(956, 0);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(10);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Padding = new System.Windows.Forms.Padding(10, 8, 4, 0);
            this.minimize_btn.Size = new System.Drawing.Size(28, 24);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_btn.TabIndex = 10;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_logo_animator.SetDecoration(this.close_btn, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.close_btn, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.close_btn, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.close_btn, BunifuAnimatorNS.DecorationType.None);
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(984, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(10);
            this.close_btn.Name = "close_btn";
            this.close_btn.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.close_btn.Size = new System.Drawing.Size(28, 24);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 9;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.mini_logo_animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Library Management System";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 671);
            this.Controls.Add(this.forms_container);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.mini_logo_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.mini_navbar_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.navbar_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logo_animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.navbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_logo)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel navbar;
        private Bunifu.Framework.UI.BunifuFlatButton Bookfram_btn;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard_btn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mini_logo;
        private Bunifu.Framework.UI.BunifuGradientPanel forms_container;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_btn;
        private Bunifu.Framework.UI.BunifuFlatButton ReturningBook_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Memberframe_btn;
        private BunifuAnimatorNS.BunifuTransition mini_navbar_animator;
        private BunifuAnimatorNS.BunifuTransition navbar_animator;
        private BunifuAnimatorNS.BunifuTransition logo_animator;
        private BunifuAnimatorNS.BunifuTransition mini_logo_animator;
        private System.Windows.Forms.Timer nav_closer;
        private System.Windows.Forms.Timer nav_opener;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.OpenFileDialog user_image_picker;
        private System.Windows.Forms.Panel panel1;
    }
}
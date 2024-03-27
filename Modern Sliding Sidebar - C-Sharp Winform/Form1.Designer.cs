namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Elipse_Form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SideBar = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.Help_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.About_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.Statistics_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.Customers_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.Orders_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.Home_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel9 = new Guna.UI.WinForms.GunaPanel();
            this.Menu_Button = new Guna.UI.WinForms.GunaButton();
            this.DragControl_Form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Timer_Sidebar_Menu = new System.Windows.Forms.Timer(this.components);
            this.Link_Github = new Guna.UI.WinForms.GunaLinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.Close_Button = new Guna.UI.WinForms.GunaImageButton();
            this.SideBar.SuspendLayout();
            this.gunaPanel7.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel8.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.Radius = 9;
            this.Elipse_Form.TargetControl = this;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.SideBar.Controls.Add(this.gunaButton1);
            this.SideBar.Controls.Add(this.gunaPanel7);
            this.SideBar.Controls.Add(this.gunaPanel6);
            this.SideBar.Controls.Add(this.gunaPanel5);
            this.SideBar.Controls.Add(this.gunaPanel8);
            this.SideBar.Controls.Add(this.gunaPanel4);
            this.SideBar.Controls.Add(this.gunaPanel3);
            this.SideBar.Controls.Add(this.gunaPanel2);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4);
            this.SideBar.MaximumSize = new System.Drawing.Size(289, 608);
            this.SideBar.MinimumSize = new System.Drawing.Size(73, 608);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(289, 608);
            this.SideBar.TabIndex = 0;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(9, 522);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(5);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Silver;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton1.Size = new System.Drawing.Size(271, 49);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Đăng xuất";
            this.gunaButton1.TextOffsetX = 15;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.Controls.Add(this.Help_Button);
            this.gunaPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel7.Location = new System.Drawing.Point(0, 446);
            this.gunaPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel7.TabIndex = 6;
            // 
            // Help_Button
            // 
            this.Help_Button.AnimationHoverSpeed = 0.07F;
            this.Help_Button.AnimationSpeed = 0.03F;
            this.Help_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Help_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Help_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Help_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Help_Button.ForeColor = System.Drawing.Color.White;
            this.Help_Button.Image = ((System.Drawing.Image)(resources.GetObject("Help_Button.Image")));
            this.Help_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Help_Button.Location = new System.Drawing.Point(9, 10);
            this.Help_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Help_Button.OnHoverImage = null;
            this.Help_Button.OnPressedColor = System.Drawing.Color.White;
            this.Help_Button.Size = new System.Drawing.Size(271, 49);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Trợ giúp";
            this.Help_Button.TextOffsetX = 15;
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Controls.Add(this.About_Button);
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel6.Location = new System.Drawing.Point(0, 378);
            this.gunaPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel6.TabIndex = 4;
            // 
            // About_Button
            // 
            this.About_Button.AnimationHoverSpeed = 0.07F;
            this.About_Button.AnimationSpeed = 0.03F;
            this.About_Button.BaseColor = System.Drawing.Color.Transparent;
            this.About_Button.BorderColor = System.Drawing.Color.Transparent;
            this.About_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.About_Button.FocusedColor = System.Drawing.Color.Empty;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.About_Button.ForeColor = System.Drawing.Color.White;
            this.About_Button.Image = ((System.Drawing.Image)(resources.GetObject("About_Button.Image")));
            this.About_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.About_Button.Location = new System.Drawing.Point(9, 10);
            this.About_Button.Margin = new System.Windows.Forms.Padding(5);
            this.About_Button.Name = "About_Button";
            this.About_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.About_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.About_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.About_Button.OnHoverImage = null;
            this.About_Button.OnPressedColor = System.Drawing.Color.White;
            this.About_Button.Size = new System.Drawing.Size(271, 49);
            this.About_Button.TabIndex = 1;
            this.About_Button.Text = "About";
            this.About_Button.TextOffsetX = 15;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Controls.Add(this.Statistics_Button);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 310);
            this.gunaPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel5.TabIndex = 3;
            // 
            // Statistics_Button
            // 
            this.Statistics_Button.AnimationHoverSpeed = 0.07F;
            this.Statistics_Button.AnimationSpeed = 0.03F;
            this.Statistics_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Statistics_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Statistics_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistics_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Statistics_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Statistics_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Statistics_Button.ForeColor = System.Drawing.Color.White;
            this.Statistics_Button.Image = ((System.Drawing.Image)(resources.GetObject("Statistics_Button.Image")));
            this.Statistics_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Statistics_Button.Location = new System.Drawing.Point(9, 10);
            this.Statistics_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Statistics_Button.Name = "Statistics_Button";
            this.Statistics_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Statistics_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Statistics_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Statistics_Button.OnHoverImage = null;
            this.Statistics_Button.OnPressedColor = System.Drawing.Color.White;
            this.Statistics_Button.Size = new System.Drawing.Size(271, 49);
            this.Statistics_Button.TabIndex = 1;
            this.Statistics_Button.Text = "Quản lý nhân viên";
            this.Statistics_Button.TextOffsetX = 15;
            this.Statistics_Button.Click += new System.EventHandler(this.Statistics_Button_Click);
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.Controls.Add(this.Customers_Button);
            this.gunaPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel8.Location = new System.Drawing.Point(0, 242);
            this.gunaPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel8.TabIndex = 5;
            // 
            // Customers_Button
            // 
            this.Customers_Button.AnimationHoverSpeed = 0.07F;
            this.Customers_Button.AnimationSpeed = 0.03F;
            this.Customers_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Customers_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Customers_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Customers_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Customers_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Customers_Button.ForeColor = System.Drawing.Color.White;
            this.Customers_Button.Image = ((System.Drawing.Image)(resources.GetObject("Customers_Button.Image")));
            this.Customers_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Customers_Button.Location = new System.Drawing.Point(9, 10);
            this.Customers_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Customers_Button.Name = "Customers_Button";
            this.Customers_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Customers_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Customers_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Customers_Button.OnHoverImage = null;
            this.Customers_Button.OnPressedColor = System.Drawing.Color.White;
            this.Customers_Button.Size = new System.Drawing.Size(271, 49);
            this.Customers_Button.TabIndex = 1;
            this.Customers_Button.Text = "Quản lý khách hàng";
            this.Customers_Button.TextOffsetX = 15;
            this.Customers_Button.Click += new System.EventHandler(this.Customers_Button_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.Orders_Button);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 174);
            this.gunaPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel4.TabIndex = 2;
            // 
            // Orders_Button
            // 
            this.Orders_Button.AnimationHoverSpeed = 0.07F;
            this.Orders_Button.AnimationSpeed = 0.03F;
            this.Orders_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Orders_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Orders_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Orders_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Orders_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Orders_Button.ForeColor = System.Drawing.Color.White;
            this.Orders_Button.Image = ((System.Drawing.Image)(resources.GetObject("Orders_Button.Image")));
            this.Orders_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Orders_Button.Location = new System.Drawing.Point(9, 9);
            this.Orders_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Orders_Button.Name = "Orders_Button";
            this.Orders_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Orders_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Orders_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Orders_Button.OnHoverImage = null;
            this.Orders_Button.OnPressedColor = System.Drawing.Color.White;
            this.Orders_Button.Size = new System.Drawing.Size(271, 49);
            this.Orders_Button.TabIndex = 1;
            this.Orders_Button.Text = "Quản lý hoá đơn";
            this.Orders_Button.TextOffsetX = 15;
            this.Orders_Button.Click += new System.EventHandler(this.Orders_Button_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.Home_Button);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 106);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(289, 68);
            this.gunaPanel3.TabIndex = 1;
            // 
            // Home_Button
            // 
            this.Home_Button.AnimationHoverSpeed = 0.07F;
            this.Home_Button.AnimationSpeed = 0.03F;
            this.Home_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Home_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Home_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Home_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Home_Button.ForeColor = System.Drawing.Color.White;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Home_Button.Location = new System.Drawing.Point(9, 9);
            this.Home_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Home_Button.OnHoverImage = null;
            this.Home_Button.OnPressedColor = System.Drawing.Color.White;
            this.Home_Button.Size = new System.Drawing.Size(271, 49);
            this.Home_Button.TabIndex = 1;
            this.Home_Button.Text = "Quản lý hàng hoá";
            this.Home_Button.TextOffsetX = 15;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPanel9);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(289, 106);
            this.gunaPanel2.TabIndex = 0;
            // 
            // gunaPanel9
            // 
            this.gunaPanel9.Controls.Add(this.Menu_Button);
            this.gunaPanel9.Location = new System.Drawing.Point(0, 15);
            this.gunaPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel9.Name = "gunaPanel9";
            this.gunaPanel9.Size = new System.Drawing.Size(284, 84);
            this.gunaPanel9.TabIndex = 2;
            // 
            // Menu_Button
            // 
            this.Menu_Button.AnimationHoverSpeed = 0.07F;
            this.Menu_Button.AnimationSpeed = 0.03F;
            this.Menu_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Menu_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Menu_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_Button.ForeColor = System.Drawing.Color.White;
            this.Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Button.Image")));
            this.Menu_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Menu_Button.Location = new System.Drawing.Point(9, 17);
            this.Menu_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Menu_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Menu_Button.OnHoverImage = null;
            this.Menu_Button.OnPressedColor = System.Drawing.Color.White;
            this.Menu_Button.Size = new System.Drawing.Size(271, 49);
            this.Menu_Button.TabIndex = 1;
            this.Menu_Button.Text = "Menu";
            this.Menu_Button.TextOffsetX = 15;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // DragControl_Form
            // 
            this.DragControl_Form.TargetControl = this;
            // 
            // Timer_Sidebar_Menu
            // 
            this.Timer_Sidebar_Menu.Interval = 10;
            this.Timer_Sidebar_Menu.Tick += new System.EventHandler(this.Timer_Sidebar_Menu_Tick);
            // 
            // Link_Github
            // 
            this.Link_Github.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Link_Github.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Link_Github.AutoSize = true;
            this.Link_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.Link_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Link_Github.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Link_Github.Location = new System.Drawing.Point(588, 14);
            this.Link_Github.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Link_Github.Name = "Link_Github";
            this.Link_Github.Size = new System.Drawing.Size(236, 67);
            this.Link_Github.TabIndex = 5;
            this.Link_Github.TabStop = true;
            this.Link_Github.Text = "Nhóm 5";
            this.Link_Github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Link_Github.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.gunaImageButton3);
            this.panel1.Controls.Add(this.gunaImageButton2);
            this.panel1.Controls.Add(this.Link_Github);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(289, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 1050);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(7, 81);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 30;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1372, 958);
            this.gunaElipsePanel1.TabIndex = 9;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.Image")));
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaImageButton3.Location = new System.Drawing.Point(1229, 4);
            this.gunaImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(47, 43);
            this.gunaImageButton3.TabIndex = 8;
            this.gunaImageButton3.Click += new System.EventHandler(this.gunaImageButton3_Click);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaImageButton2.Location = new System.Drawing.Point(1285, 4);
            this.gunaImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(47, 43);
            this.gunaImageButton2.TabIndex = 7;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::Modern_Sliding_Sidebar___C_Sharp_Winform.Properties.Resources.github_64px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(74, 74);
            this.gunaImageButton1.Location = new System.Drawing.Point(497, 0);
            this.gunaImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = global::Modern_Sliding_Sidebar___C_Sharp_Winform.Properties.Resources.github_64px_Hover;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(100, 81);
            this.gunaImageButton1.TabIndex = 4;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageSize = new System.Drawing.Size(28, 28);
            this.Close_Button.Location = new System.Drawing.Point(1340, 4);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.OnHoverImage = global::Modern_Sliding_Sidebar___C_Sharp_Winform.Properties.Resources.multiply_48px_____;
            this.Close_Button.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Close_Button.Size = new System.Drawing.Size(47, 43);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.gunaPanel7.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel8.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse Elipse_Form;
        private Guna.UI.WinForms.GunaPanel SideBar;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaImageButton Close_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private Guna.UI.WinForms.GunaButton Help_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaButton Customers_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaButton Statistics_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI.WinForms.GunaButton About_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton Orders_Button;
        private Guna.UI.WinForms.GunaButton Home_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel9;
        private Guna.UI.WinForms.GunaButton Menu_Button;
        private Guna.UI.WinForms.GunaDragControl DragControl_Form;
        private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaLinkLabel Link_Github;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}


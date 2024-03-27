namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form3
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
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemhd = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoacthd = new System.Windows.Forms.Button();
            this.btn_suacthd = new System.Windows.Forms.Button();
            this.btn_themcthd = new System.Windows.Forms.Button();
            this.btn_xoahd = new System.Windows.Forms.Button();
            this.btn_themhd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahd = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_giaban = new Guna.UI.WinForms.GunaTextBox();
            this.txt_soluong = new Guna.UI.WinForms.GunaTextBox();
            this.txt_cthd = new Guna.UI.WinForms.GunaTextBox();
            this.MaSP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ngaymua = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dgv_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tensp2 = new System.Windows.Forms.TextBox();
            this.cbx_manv = new System.Windows.Forms.ComboBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_timkiem.Location = new System.Drawing.Point(925, 7);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(95, 28);
            this.btn_timkiem.TabIndex = 36;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiemhd
            // 
            this.txt_timkiemhd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiemhd.BackColor = System.Drawing.Color.Transparent;
            this.txt_timkiemhd.BaseColor = System.Drawing.Color.White;
            this.txt_timkiemhd.BorderColor = System.Drawing.Color.Silver;
            this.txt_timkiemhd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timkiemhd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_timkiemhd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_timkiemhd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_timkiemhd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timkiemhd.Location = new System.Drawing.Point(772, 7);
            this.txt_timkiemhd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timkiemhd.Name = "txt_timkiemhd";
            this.txt_timkiemhd.PasswordChar = '\0';
            this.txt_timkiemhd.Radius = 10;
            this.txt_timkiemhd.Size = new System.Drawing.Size(148, 30);
            this.txt_timkiemhd.TabIndex = 32;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHoaDon,
            this.Ngay,
            this.MaNhanVien,
            this.MaKhachHang});
            this.dgv_hoadon.Location = new System.Drawing.Point(261, 40);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(759, 259);
            this.dgv_hoadon.TabIndex = 31;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày mua";
            this.Ngay.Name = "Ngay";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // btn_xoacthd
            // 
            this.btn_xoacthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoacthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoacthd.Location = new System.Drawing.Point(157, 517);
            this.btn_xoacthd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoacthd.Name = "btn_xoacthd";
            this.btn_xoacthd.Size = new System.Drawing.Size(56, 42);
            this.btn_xoacthd.TabIndex = 52;
            this.btn_xoacthd.Text = "Xoá";
            this.btn_xoacthd.UseVisualStyleBackColor = false;
            this.btn_xoacthd.Click += new System.EventHandler(this.btn_xoacthd_Click);
            // 
            // btn_suacthd
            // 
            this.btn_suacthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_suacthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_suacthd.Location = new System.Drawing.Point(96, 517);
            this.btn_suacthd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suacthd.Name = "btn_suacthd";
            this.btn_suacthd.Size = new System.Drawing.Size(56, 42);
            this.btn_suacthd.TabIndex = 51;
            this.btn_suacthd.Text = "Sửa";
            this.btn_suacthd.UseVisualStyleBackColor = false;
            this.btn_suacthd.Click += new System.EventHandler(this.btn_suacthd_Click);
            // 
            // btn_themcthd
            // 
            this.btn_themcthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_themcthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_themcthd.Location = new System.Drawing.Point(35, 517);
            this.btn_themcthd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themcthd.Name = "btn_themcthd";
            this.btn_themcthd.Size = new System.Drawing.Size(56, 42);
            this.btn_themcthd.TabIndex = 50;
            this.btn_themcthd.Text = "Thêm";
            this.btn_themcthd.UseVisualStyleBackColor = false;
            this.btn_themcthd.Click += new System.EventHandler(this.btn_themcthd_Click);
            // 
            // btn_xoahd
            // 
            this.btn_xoahd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoahd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoahd.Location = new System.Drawing.Point(157, 249);
            this.btn_xoahd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoahd.Name = "btn_xoahd";
            this.btn_xoahd.Size = new System.Drawing.Size(56, 42);
            this.btn_xoahd.TabIndex = 55;
            this.btn_xoahd.Text = "Xoá";
            this.btn_xoahd.UseVisualStyleBackColor = false;
            this.btn_xoahd.Click += new System.EventHandler(this.btn_xoahd_Click);
            // 
            // btn_themhd
            // 
            this.btn_themhd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_themhd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_themhd.Location = new System.Drawing.Point(35, 249);
            this.btn_themhd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themhd.Name = "btn_themhd";
            this.btn_themhd.Size = new System.Drawing.Size(56, 42);
            this.btn_themhd.TabIndex = 53;
            this.btn_themhd.Text = "Thêm";
            this.btn_themhd.UseVisualStyleBackColor = false;
            this.btn_themhd.Click += new System.EventHandler(this.btn_themhd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ngày mua";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mã hoá đơn";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_mahd.BackColor = System.Drawing.Color.Transparent;
            this.txt_mahd.BaseColor = System.Drawing.Color.White;
            this.txt_mahd.BorderColor = System.Drawing.Color.Silver;
            this.txt_mahd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahd.Enabled = false;
            this.txt_mahd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_mahd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_mahd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mahd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mahd.Location = new System.Drawing.Point(96, 40);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.PasswordChar = '\0';
            this.txt_mahd.Radius = 10;
            this.txt_mahd.Size = new System.Drawing.Size(148, 30);
            this.txt_mahd.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Giá bán";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Số lượng";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_giaban.BackColor = System.Drawing.Color.Transparent;
            this.txt_giaban.BaseColor = System.Drawing.Color.White;
            this.txt_giaban.BorderColor = System.Drawing.Color.Silver;
            this.txt_giaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giaban.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_giaban.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_giaban.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_giaban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_giaban.Location = new System.Drawing.Point(96, 410);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.PasswordChar = '\0';
            this.txt_giaban.Radius = 10;
            this.txt_giaban.Size = new System.Drawing.Size(148, 30);
            this.txt_giaban.TabIndex = 71;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_soluong.BackColor = System.Drawing.Color.Transparent;
            this.txt_soluong.BaseColor = System.Drawing.Color.White;
            this.txt_soluong.BorderColor = System.Drawing.Color.Silver;
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_soluong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_soluong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluong.Location = new System.Drawing.Point(96, 377);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.Radius = 10;
            this.txt_soluong.Size = new System.Drawing.Size(148, 30);
            this.txt_soluong.TabIndex = 70;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // txt_cthd
            // 
            this.txt_cthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cthd.BackColor = System.Drawing.Color.Transparent;
            this.txt_cthd.BaseColor = System.Drawing.Color.White;
            this.txt_cthd.BorderColor = System.Drawing.Color.Silver;
            this.txt_cthd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cthd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cthd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cthd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cthd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cthd.Location = new System.Drawing.Point(96, 312);
            this.txt_cthd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cthd.Name = "txt_cthd";
            this.txt_cthd.PasswordChar = '\0';
            this.txt_cthd.Radius = 10;
            this.txt_cthd.Size = new System.Drawing.Size(148, 30);
            this.txt_cthd.TabIndex = 68;
            this.txt_cthd.TextChanged += new System.EventHandler(this.txt_cthd_TextChanged);
            // 
            // MaSP
            // 
            this.MaSP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaSP.AutoSize = true;
            this.MaSP.Location = new System.Drawing.Point(9, 319);
            this.MaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaSP.Name = "MaSP";
            this.MaSP.Size = new System.Drawing.Size(71, 13);
            this.MaSP.TabIndex = 74;
            this.MaSP.Text = "Mã sản phẩm";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 352);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Tên sản phẩm";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_thanhtien.BackColor = System.Drawing.Color.Transparent;
            this.txt_thanhtien.BaseColor = System.Drawing.Color.White;
            this.txt_thanhtien.BorderColor = System.Drawing.Color.Silver;
            this.txt_thanhtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thanhtien.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_thanhtien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_thanhtien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_thanhtien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_thanhtien.Location = new System.Drawing.Point(96, 449);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.PasswordChar = '\0';
            this.txt_thanhtien.Radius = 10;
            this.txt_thanhtien.Size = new System.Drawing.Size(148, 30);
            this.txt_thanhtien.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Thành tiền";
            // 
            // txt_ngaymua
            // 
            this.txt_ngaymua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ngaymua.BaseColor = System.Drawing.Color.White;
            this.txt_ngaymua.BorderColor = System.Drawing.Color.Silver;
            this.txt_ngaymua.CustomFormat = "dd/MM/yyyy";
            this.txt_ngaymua.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_ngaymua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ngaymua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ngaymua.ForeColor = System.Drawing.Color.Black;
            this.txt_ngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngaymua.Location = new System.Drawing.Point(96, 76);
            this.txt_ngaymua.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ngaymua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_ngaymua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_ngaymua.Name = "txt_ngaymua";
            this.txt_ngaymua.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_ngaymua.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ngaymua.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ngaymua.OnPressedColor = System.Drawing.Color.Black;
            this.txt_ngaymua.Size = new System.Drawing.Size(148, 24);
            this.txt_ngaymua.TabIndex = 80;
            this.txt_ngaymua.Text = "07/03/2024";
            this.txt_ngaymua.Value = new System.DateTime(2024, 3, 7, 18, 9, 13, 272);
            // 
            // dgv_chitiethoadon
            // 
            this.dgv_chitiethoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitiethoadon.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ThanhTien});
            this.dgv_chitiethoadon.Location = new System.Drawing.Point(259, 299);
            this.dgv_chitiethoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_chitiethoadon.Name = "dgv_chitiethoadon";
            this.dgv_chitiethoadon.RowHeadersWidth = 51;
            this.dgv_chitiethoadon.RowTemplate.Height = 24;
            this.dgv_chitiethoadon.Size = new System.Drawing.Size(759, 259);
            this.dgv_chitiethoadon.TabIndex = 31;
            this.dgv_chitiethoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitiethoadon_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Sản phẩm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // txt_tensp2
            // 
            this.txt_tensp2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tensp2.Location = new System.Drawing.Point(96, 347);
            this.txt_tensp2.Name = "txt_tensp2";
            this.txt_tensp2.Size = new System.Drawing.Size(148, 20);
            this.txt_tensp2.TabIndex = 81;
            this.txt_tensp2.TextChanged += new System.EventHandler(this.txt_tensp2_TextChanged);
            // 
            // cbx_manv
            // 
            this.cbx_manv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_manv.FormattingEnabled = true;
            this.cbx_manv.Location = new System.Drawing.Point(96, 105);
            this.cbx_manv.Name = "cbx_manv";
            this.cbx_manv.Size = new System.Drawing.Size(148, 21);
            this.cbx_manv.TabIndex = 82;
            // 
            // txt_makh
            // 
            this.txt_makh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_makh.Location = new System.Drawing.Point(96, 145);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(148, 20);
            this.txt_makh.TabIndex = 83;
            this.txt_makh.TextChanged += new System.EventHandler(this.txt_makh_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Tồng tiền phải trả :";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tongtien.AutoSize = true;
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(125, 192);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(27, 16);
            this.txt_tongtien.TabIndex = 85;
            this.txt_tongtien.Text = ".....";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 569);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.cbx_manv);
            this.Controls.Add(this.txt_tensp2);
            this.Controls.Add(this.txt_ngaymua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_cthd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.btn_xoahd);
            this.Controls.Add(this.btn_themhd);
            this.Controls.Add(this.btn_xoacthd);
            this.Controls.Add(this.btn_suacthd);
            this.Controls.Add(this.btn_themcthd);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiemhd);
            this.Controls.Add(this.dgv_chitiethoadon);
            this.Controls.Add(this.dgv_hoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_timkiem;
        private Guna.UI.WinForms.GunaTextBox txt_timkiemhd;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Button btn_xoacthd;
        private System.Windows.Forms.Button btn_suacthd;
        private System.Windows.Forms.Button btn_themcthd;
        private System.Windows.Forms.Button btn_xoahd;
        private System.Windows.Forms.Button btn_themhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_mahd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txt_giaban;
        private Guna.UI.WinForms.GunaTextBox txt_soluong;
        private Guna.UI.WinForms.GunaTextBox txt_cthd;
        private System.Windows.Forms.Label MaSP;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txt_thanhtien;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDateTimePicker txt_ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridView dgv_chitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txt_tensp2;
        private System.Windows.Forms.ComboBox cbx_manv;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_tongtien;
    }
}
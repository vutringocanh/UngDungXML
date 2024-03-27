namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form2
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
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemsp = new Guna.UI.WinForms.GunaTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_masp = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tensp = new Guna.UI.WinForms.GunaTextBox();
            this.txt_gia = new Guna.UI.WinForms.GunaTextBox();
            this.txt_soluongton = new Guna.UI.WinForms.GunaTextBox();
            this.txt_ngaysx = new Guna.UI.WinForms.GunaTextBox();
            this.txt_hsd = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sp
            // 
            this.dgv_sp.AllowUserToAddRows = false;
            this.dgv_sp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sp.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuongTon,
            this.NgaySX,
            this.HanSD});
            this.dgv_sp.Location = new System.Drawing.Point(353, 46);
            this.dgv_sp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 51;
            this.dgv_sp.RowTemplate.Height = 24;
            this.dgv_sp.Size = new System.Drawing.Size(1012, 642);
            this.dgv_sp.TabIndex = 7;
            this.dgv_sp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sp_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // NgaySX
            // 
            this.NgaySX.HeaderText = "Ngày sản xuất";
            this.NgaySX.MinimumWidth = 6;
            this.NgaySX.Name = "NgaySX";
            // 
            // HanSD
            // 
            this.HanSD.HeaderText = "Hạn sử dụng";
            this.HanSD.MinimumWidth = 6;
            this.HanSD.Name = "HanSD";
            // 
            // txttimkiemsp
            // 
            this.txttimkiemsp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiemsp.BackColor = System.Drawing.Color.Transparent;
            this.txttimkiemsp.BaseColor = System.Drawing.Color.White;
            this.txttimkiemsp.BorderColor = System.Drawing.Color.Silver;
            this.txttimkiemsp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiemsp.FocusedBaseColor = System.Drawing.Color.White;
            this.txttimkiemsp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttimkiemsp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttimkiemsp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiemsp.Location = new System.Drawing.Point(1035, 5);
            this.txttimkiemsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiemsp.Name = "txttimkiemsp";
            this.txttimkiemsp.PasswordChar = '\0';
            this.txttimkiemsp.Radius = 10;
            this.txttimkiemsp.Size = new System.Drawing.Size(197, 37);
            this.txttimkiemsp.TabIndex = 12;
            this.txttimkiemsp.TextChanged += new System.EventHandler(this.txttimkiemsp_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_them.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_them.Location = new System.Drawing.Point(43, 519);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(269, 52);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sua.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sua.Location = new System.Drawing.Point(43, 578);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(269, 52);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoa.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoa.Location = new System.Drawing.Point(43, 636);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(269, 52);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_timkiem.Location = new System.Drawing.Point(1237, 5);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(127, 34);
            this.btn_timkiem.TabIndex = 17;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_masp
            // 
            this.txt_masp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_masp.BackColor = System.Drawing.Color.Transparent;
            this.txt_masp.BaseColor = System.Drawing.Color.White;
            this.txt_masp.BorderColor = System.Drawing.Color.Silver;
            this.txt_masp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_masp.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_masp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_masp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_masp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_masp.Location = new System.Drawing.Point(128, 46);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.PasswordChar = '\0';
            this.txt_masp.Radius = 10;
            this.txt_masp.Size = new System.Drawing.Size(197, 37);
            this.txt_masp.TabIndex = 18;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tensp.BackColor = System.Drawing.Color.Transparent;
            this.txt_tensp.BaseColor = System.Drawing.Color.White;
            this.txt_tensp.BorderColor = System.Drawing.Color.Silver;
            this.txt_tensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tensp.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tensp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tensp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tensp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tensp.Location = new System.Drawing.Point(128, 85);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PasswordChar = '\0';
            this.txt_tensp.Radius = 10;
            this.txt_tensp.Size = new System.Drawing.Size(197, 37);
            this.txt_tensp.TabIndex = 19;
            // 
            // txt_gia
            // 
            this.txt_gia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_gia.BackColor = System.Drawing.Color.Transparent;
            this.txt_gia.BaseColor = System.Drawing.Color.White;
            this.txt_gia.BorderColor = System.Drawing.Color.Silver;
            this.txt_gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gia.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_gia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_gia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_gia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_gia.Location = new System.Drawing.Point(128, 126);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PasswordChar = '\0';
            this.txt_gia.Radius = 10;
            this.txt_gia.Size = new System.Drawing.Size(197, 37);
            this.txt_gia.TabIndex = 20;
            // 
            // txt_soluongton
            // 
            this.txt_soluongton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_soluongton.BackColor = System.Drawing.Color.Transparent;
            this.txt_soluongton.BaseColor = System.Drawing.Color.White;
            this.txt_soluongton.BorderColor = System.Drawing.Color.Silver;
            this.txt_soluongton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluongton.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_soluongton.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_soluongton.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_soluongton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluongton.Location = new System.Drawing.Point(128, 165);
            this.txt_soluongton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soluongton.Name = "txt_soluongton";
            this.txt_soluongton.PasswordChar = '\0';
            this.txt_soluongton.Radius = 10;
            this.txt_soluongton.Size = new System.Drawing.Size(197, 37);
            this.txt_soluongton.TabIndex = 21;
            // 
            // txt_ngaysx
            // 
            this.txt_ngaysx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ngaysx.BackColor = System.Drawing.Color.Transparent;
            this.txt_ngaysx.BaseColor = System.Drawing.Color.White;
            this.txt_ngaysx.BorderColor = System.Drawing.Color.Silver;
            this.txt_ngaysx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngaysx.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ngaysx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ngaysx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ngaysx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ngaysx.Location = new System.Drawing.Point(128, 206);
            this.txt_ngaysx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaysx.Name = "txt_ngaysx";
            this.txt_ngaysx.PasswordChar = '\0';
            this.txt_ngaysx.Radius = 10;
            this.txt_ngaysx.Size = new System.Drawing.Size(197, 37);
            this.txt_ngaysx.TabIndex = 22;
            // 
            // txt_hsd
            // 
            this.txt_hsd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_hsd.BackColor = System.Drawing.Color.Transparent;
            this.txt_hsd.BaseColor = System.Drawing.Color.White;
            this.txt_hsd.BorderColor = System.Drawing.Color.Silver;
            this.txt_hsd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hsd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_hsd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_hsd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_hsd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hsd.Location = new System.Drawing.Point(128, 245);
            this.txt_hsd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.PasswordChar = '\0';
            this.txt_hsd.Radius = 10;
            this.txt_hsd.Size = new System.Drawing.Size(197, 37);
            this.txt_hsd.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hạn sử dụng";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hsd);
            this.Controls.Add(this.txt_ngaysx);
            this.Controls.Add(this.txt_soluongton);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txttimkiemsp);
            this.Controls.Add(this.dgv_sp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sp;
        private Guna.UI.WinForms.GunaTextBox txttimkiemsp;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_timkiem;
        private Guna.UI.WinForms.GunaTextBox txt_masp;
        private Guna.UI.WinForms.GunaTextBox txt_tensp;
        private Guna.UI.WinForms.GunaTextBox txt_gia;
        private Guna.UI.WinForms.GunaTextBox txt_soluongton;
        private Guna.UI.WinForms.GunaTextBox txt_ngaysx;
        private Guna.UI.WinForms.GunaTextBox txt_hsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
    }
}
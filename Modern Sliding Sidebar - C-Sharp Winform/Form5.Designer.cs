namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_chucvu = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tennv = new Guna.UI.WinForms.GunaTextBox();
            this.txt_manv = new Guna.UI.WinForms.GunaTextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemnv = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_chucvu.BackColor = System.Drawing.Color.Transparent;
            this.txt_chucvu.BaseColor = System.Drawing.Color.White;
            this.txt_chucvu.BorderColor = System.Drawing.Color.Silver;
            this.txt_chucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chucvu.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_chucvu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_chucvu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_chucvu.Location = new System.Drawing.Point(123, 127);
            this.txt_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.PasswordChar = '\0';
            this.txt_chucvu.Radius = 10;
            this.txt_chucvu.Size = new System.Drawing.Size(197, 37);
            this.txt_chucvu.TabIndex = 39;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tennv.BackColor = System.Drawing.Color.Transparent;
            this.txt_tennv.BaseColor = System.Drawing.Color.White;
            this.txt_tennv.BorderColor = System.Drawing.Color.Silver;
            this.txt_tennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tennv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tennv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tennv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tennv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tennv.Location = new System.Drawing.Point(123, 87);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.PasswordChar = '\0';
            this.txt_tennv.Radius = 10;
            this.txt_tennv.Size = new System.Drawing.Size(197, 37);
            this.txt_tennv.TabIndex = 38;
            // 
            // txt_manv
            // 
            this.txt_manv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_manv.BackColor = System.Drawing.Color.Transparent;
            this.txt_manv.BaseColor = System.Drawing.Color.White;
            this.txt_manv.BorderColor = System.Drawing.Color.Silver;
            this.txt_manv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_manv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_manv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_manv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_manv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_manv.Location = new System.Drawing.Point(123, 47);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.PasswordChar = '\0';
            this.txt_manv.Radius = 10;
            this.txt_manv.Size = new System.Drawing.Size(197, 37);
            this.txt_manv.TabIndex = 37;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_timkiem.Location = new System.Drawing.Point(1233, 7);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(127, 34);
            this.btn_timkiem.TabIndex = 36;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiemnv
            // 
            this.txt_timkiemnv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiemnv.BackColor = System.Drawing.Color.Transparent;
            this.txt_timkiemnv.BaseColor = System.Drawing.Color.White;
            this.txt_timkiemnv.BorderColor = System.Drawing.Color.Silver;
            this.txt_timkiemnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timkiemnv.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_timkiemnv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_timkiemnv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_timkiemnv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timkiemnv.Location = new System.Drawing.Point(1029, 7);
            this.txt_timkiemnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiemnv.Name = "txt_timkiemnv";
            this.txt_timkiemnv.PasswordChar = '\0';
            this.txt_timkiemnv.Radius = 10;
            this.txt_timkiemnv.Size = new System.Drawing.Size(197, 37);
            this.txt_timkiemnv.TabIndex = 32;
            // 
            // dgv_nv
            // 
            this.dgv_nv.AllowUserToAddRows = false;
            this.dgv_nv.AllowUserToOrderColumns = true;
            this.dgv_nv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nv.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.TenNV,
            this.ChucVu,
            this.SDT,
            this.DiaChi});
            this.dgv_nv.Location = new System.Drawing.Point(348, 47);
            this.dgv_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.RowHeadersWidth = 51;
            this.dgv_nv.RowTemplate.Height = 24;
            this.dgv_nv.Size = new System.Drawing.Size(1012, 641);
            this.dgv_nv.TabIndex = 31;
            this.dgv_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nv_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoa.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoa.Location = new System.Drawing.Point(29, 634);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(269, 52);
            this.btn_xoa.TabIndex = 51;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sua.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sua.Location = new System.Drawing.Point(29, 576);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(269, 52);
            this.btn_sua.TabIndex = 50;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_them.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_them.Location = new System.Drawing.Point(29, 518);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(269, 52);
            this.btn_them.TabIndex = 49;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "SDT";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_sdt.BackColor = System.Drawing.Color.Transparent;
            this.txt_sdt.BaseColor = System.Drawing.Color.White;
            this.txt_sdt.BorderColor = System.Drawing.Color.Silver;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sdt.Location = new System.Drawing.Point(123, 167);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.Radius = 10;
            this.txt_sdt.Size = new System.Drawing.Size(197, 37);
            this.txt_sdt.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_diachi.BackColor = System.Drawing.Color.Transparent;
            this.txt_diachi.BaseColor = System.Drawing.Color.White;
            this.txt_diachi.BorderColor = System.Drawing.Color.Silver;
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diachi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_diachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diachi.Location = new System.Drawing.Point(123, 207);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.Radius = 10;
            this.txt_diachi.Size = new System.Drawing.Size(197, 37);
            this.txt_diachi.TabIndex = 54;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_chucvu);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiemnv);
            this.Controls.Add(this.dgv_nv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_chucvu;
        private Guna.UI.WinForms.GunaTextBox txt_tennv;
        private Guna.UI.WinForms.GunaTextBox txt_manv;
        private System.Windows.Forms.Button btn_timkiem;
        private Guna.UI.WinForms.GunaTextBox txt_timkiemnv;
        private System.Windows.Forms.DataGridView dgv_nv;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemkh = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.txt_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tenkh = new Guna.UI.WinForms.GunaTextBox();
            this.txt_makh = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_timkiem.Location = new System.Drawing.Point(1233, 7);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(127, 34);
            this.btn_timkiem.TabIndex = 36;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiemkh
            // 
            this.txt_timkiemkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiemkh.BackColor = System.Drawing.Color.Transparent;
            this.txt_timkiemkh.BaseColor = System.Drawing.Color.White;
            this.txt_timkiemkh.BorderColor = System.Drawing.Color.Silver;
            this.txt_timkiemkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timkiemkh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_timkiemkh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_timkiemkh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_timkiemkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timkiemkh.Location = new System.Drawing.Point(1030, 7);
            this.txt_timkiemkh.Name = "txt_timkiemkh";
            this.txt_timkiemkh.PasswordChar = '\0';
            this.txt_timkiemkh.Radius = 10;
            this.txt_timkiemkh.Size = new System.Drawing.Size(197, 34);
            this.txt_timkiemkh.TabIndex = 32;
            // 
            // dgv_kh
            // 
            this.dgv_kh.AllowUserToAddRows = false;
            this.dgv_kh.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_kh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_kh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_kh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_kh.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SDT});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_kh.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_kh.Location = new System.Drawing.Point(348, 47);
            this.dgv_kh.Name = "dgv_kh";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_kh.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_kh.RowHeadersWidth = 51;
            this.dgv_kh.RowTemplate.Height = 24;
            this.dgv_kh.Size = new System.Drawing.Size(1012, 641);
            this.dgv_kh.TabIndex = 31;
            this.dgv_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellClick);
            this.dgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoa.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoa.Location = new System.Drawing.Point(41, 633);
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
            this.btn_sua.Location = new System.Drawing.Point(41, 575);
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
            this.btn_them.Location = new System.Drawing.Point(41, 517);
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
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã khách hàng";
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
            this.txt_sdt.Location = new System.Drawing.Point(132, 167);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.Radius = 10;
            this.txt_sdt.Size = new System.Drawing.Size(197, 34);
            this.txt_sdt.TabIndex = 55;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
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
            this.txt_diachi.Location = new System.Drawing.Point(132, 127);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.Radius = 10;
            this.txt_diachi.Size = new System.Drawing.Size(197, 34);
            this.txt_diachi.TabIndex = 54;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tenkh.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenkh.BaseColor = System.Drawing.Color.White;
            this.txt_tenkh.BorderColor = System.Drawing.Color.Silver;
            this.txt_tenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenkh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tenkh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tenkh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tenkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenkh.Location = new System.Drawing.Point(132, 87);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.PasswordChar = '\0';
            this.txt_tenkh.Radius = 10;
            this.txt_tenkh.Size = new System.Drawing.Size(197, 34);
            this.txt_tenkh.TabIndex = 53;
            // 
            // txt_makh
            // 
            this.txt_makh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_makh.BackColor = System.Drawing.Color.Transparent;
            this.txt_makh.BaseColor = System.Drawing.Color.White;
            this.txt_makh.BorderColor = System.Drawing.Color.Silver;
            this.txt_makh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_makh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_makh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_makh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_makh.Location = new System.Drawing.Point(132, 47);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PasswordChar = '\0';
            this.txt_makh.Radius = 10;
            this.txt_makh.Size = new System.Drawing.Size(197, 34);
            this.txt_makh.TabIndex = 52;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiemkh);
            this.Controls.Add(this.dgv_kh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_timkiem;
        private Guna.UI.WinForms.GunaTextBox txt_timkiemkh;
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_sdt;
        private Guna.UI.WinForms.GunaTextBox txt_diachi;
        private Guna.UI.WinForms.GunaTextBox txt_tenkh;
        private Guna.UI.WinForms.GunaTextBox txt_makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}
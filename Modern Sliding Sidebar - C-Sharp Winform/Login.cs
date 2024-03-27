using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Login : Form
    {

        string fileName = @"C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\TaiKhoan.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_taikhoan;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_taikhoan = doc.DocumentElement;
            XmlNode check_tk = ql_taikhoan.SelectSingleNode("TaiKhoan[TaiKhoan ='" + txt_taikhoan.Text + "']");


            if (txt_taikhoan.Text.Length >= 6 && txt_matkhau.Text.Length>=6)
            {
                if (check_tk != null)
                {
                    if (check_tk.SelectSingleNode("MatKhau").InnerText == txt_matkhau.Text)
                    {
                        Form1 f = new Form1(check_tk.SelectSingleNode("@id_TaiKhoan").Value.ToString());
                        f.Show();
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Đăng nhập thất bại");
                }
            }
            else
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhâp tài khoản hoặc mật khẩu tối thiếu ít nhất là 6 ký tự", "Lỗi");

            }

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Text = "namth156";
            txt_matkhau.Text = "namth156";
            txt_matkhau.PasswordChar= '*';
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dangki_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangKi dangki = new Form_DangKi();
            dangki.ShowDialog();
        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




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
    public partial class Form_DangKi : Form
    {
        string fileName = @"D:\zKiemlongJr\XML\BaoCaoXML_Nhom3\Modern Sliding Sidebar - C-Sharp Winform\TaiKhoan.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_taikhoan;

        public Form_DangKi()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_taikhoan = doc.DocumentElement;
            XmlNode check_tk = ql_taikhoan.SelectSingleNode("TaiKhoan[TaiKhoan ='" + txt_taikhoan.Text + "']");


            if (!string.IsNullOrEmpty(txt_taikhoan.Text) && !string.IsNullOrEmpty(txt_matkhau.Text) && !string.IsNullOrEmpty(txt_dienthoai.Text) && !string.IsNullOrEmpty(txt_hoten.Text))
            {
                if (txt_taikhoan.Text.Length > 5 && txt_matkhau.Text.Length > 5 && txt_dienthoai.Text.Length > 5 && txt_hoten.Text.Length > 5)
                {
                    if (int.TryParse(txt_dienthoai.Text, out int phoneNumber))
                    {

                        if (check_tk == null)
                        {
                            XmlNodeList ds_tk = ql_taikhoan.SelectNodes("TaiKhoan");
                            XmlNode TaiKhoan = doc.CreateElement("TaiKhoan");
                            XmlAttribute id_tk = doc.CreateAttribute("id_TaiKhoan");

                            int id = ds_tk.Count + 1;
                            id_tk.Value = id.ToString();
                            TaiKhoan.Attributes.Append(id_tk);
                            XmlElement tk = doc.CreateElement("TaiKhoan");
                            tk.InnerText = txt_taikhoan.Text;
                            TaiKhoan.AppendChild(tk);

                            XmlElement mk = doc.CreateElement("MatKhau");
                            mk.InnerText = txt_matkhau.Text;
                            TaiKhoan.AppendChild(mk);

                            XmlElement hoten = doc.CreateElement("HoTen");
                            hoten.InnerText = txt_hoten.Text;
                            TaiKhoan.AppendChild(hoten);

                            XmlElement sdt = doc.CreateElement("SDT");
                            sdt.InnerText = txt_dienthoai.Text;
                            TaiKhoan.AppendChild(sdt);

                            ql_taikhoan.AppendChild(TaiKhoan);

                            doc.Save(fileName);
                            DialogResult result = MessageBox.Show("Bạn đã đăng kí tài khoản thành công. Bạn có muốn chuyển qua màn hình đăng nhập không?", "Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                this.Hide();
                                Login login = new Login();
                                login.ShowDialog();
                            }
                            else
                            {
                                // Xử lý khi người dùng không muốn chuyển qua màn hình đăng nhập
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã tồn tại", "Thất Bại");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại chỉ được chứa số", "Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ít nhất 6 kí tự cho mỗi trường thông tin", "Thất Bại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng không để trống bất kỳ trường nào", "Thất Bại");
            }

        }
    }
}

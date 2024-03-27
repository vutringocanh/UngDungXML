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
    public partial class Form4 : Form
    {
        string id_taikhoan;
        String namefile = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\KhachHang.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_kh;
        public Form4(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;
        }
        private void Show(DataGridView dgv)
        {
            dgv.Rows.Clear();
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("KhachHang");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {

                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaKH").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenKH").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("DiaChi").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SDT").InnerText;
                sd++;
                serialNumber++;
            }
        }
        

        
        private void Form4_Load(object sender, EventArgs e)
        {
            Show(dgv_kh);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode KhachHang = doc.CreateElement("KhachHang");

            XmlAttribute MaKH = doc.CreateAttribute("MaKH");
            MaKH.Value = txt_makh.Text;
            KhachHang.Attributes.Append(MaKH);

            XmlElement TenKH = doc.CreateElement("TenKH");
            TenKH.InnerText = txt_tenkh.Text;
            KhachHang.AppendChild(TenKH);

            XmlElement DiaChi = doc.CreateElement("DiaChi");
            DiaChi.InnerText = txt_diachi.Text;
            KhachHang.AppendChild(DiaChi);

            XmlElement SDT = doc.CreateElement("SDT");
            SDT.InnerText = txt_sdt.Text;
            KhachHang.AppendChild(SDT);

            DS_KhachHang.AppendChild(KhachHang);
            doc.Save(namefile);
            Show(dgv_kh);


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode KhachHangCu = DS_KhachHang.SelectSingleNode("KhachHang[@MaKH = '" + txt_makh.Text + "']");
            if(KhachHangCu != null)
            {
                XmlNode KhachHangMoi = doc.CreateElement("KhachHang");

                XmlAttribute MaKH = doc.CreateAttribute("MaKH");
                MaKH.Value = txt_makh.Text;
                KhachHangMoi.Attributes.Append(MaKH);

                XmlElement TenKH = doc.CreateElement("TenKH");
                TenKH.InnerText = txt_tenkh.Text;
                KhachHangMoi.AppendChild(TenKH);

                XmlElement DiaChi = doc.CreateElement("DiaChi");
                DiaChi.InnerText = txt_diachi.Text;
                KhachHangMoi.AppendChild(DiaChi);

                XmlElement SDT = doc.CreateElement("SDT");
                SDT.InnerText = txt_sdt.Text;
                KhachHangMoi.AppendChild(SDT);

                DS_KhachHang.ReplaceChild(KhachHangMoi, KhachHangCu);
                doc.Save(namefile);
                Show(dgv_kh);
            }
            

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode KhCanXoa = DS_KhachHang.SelectSingleNode("KhachHang[@MaKH ='" + txt_makh.Text + "']");
            if (KhCanXoa != null)
            {
                DS_KhachHang.RemoveChild(KhCanXoa);
                doc.Save(namefile);

            }
            Show(dgv_kh);

        }

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgv_kh.CurrentCell.RowIndex;
            txt_makh.Text = dgv_kh.Rows[t].Cells[1].Value.ToString();
            txt_tenkh.Text = dgv_kh.Rows[t].Cells[2].Value.ToString();
            txt_diachi.Text = dgv_kh.Rows[t].Cells[3].Value.ToString();
            txt_sdt.Text = dgv_kh.Rows[t].Cells[4].Value.ToString();
           

        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_kh.Rows.Clear();

            string maKHCanTim = txt_timkiemkh.Text.Trim().ToLower();

            foreach (XmlNode dsKhachHangNode in ql_kh.SelectNodes("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']"))
            {
                foreach (XmlNode KhachHangNode in dsKhachHangNode.SelectNodes("KhachHang"))
                {
                    if (KhachHangNode.Attributes["MaKH"].Value.ToLower() == maKHCanTim)
                    {
                        dgv_kh.Rows.Add(
                            KhachHangNode.Attributes["MaKH"].Value,
                            KhachHangNode.SelectSingleNode("TenKH").InnerText,
                            KhachHangNode.SelectSingleNode("DiaChi").InnerText,
                            KhachHangNode.SelectSingleNode("SDT").InnerText
                           
                        );
                        return; // Dừng khi tìm thấy sản phẩm
                    }
                }
            }

            // Nếu không tìm thấy sản phẩm, thông báo cho người dùng
            MessageBox.Show("Không tìm thấy khách hàng với mã số này.");
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

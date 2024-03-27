using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Form5 : Form
    {
        string id_taikhoan;
        XmlElement ql_nhanvien;
        String filename = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\NhanVien.xml";
        XmlDocument doc = new XmlDocument();

        
        public void show(DataGridView dgv)
        {
           dgv.Rows.Clear();
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_NhanVien.SelectNodes("NhanVien");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaNV").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenNV").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("ChucVu").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SDT").InnerText;
                dgv.Rows[sd].Cells[5].Value = node.SelectSingleNode("DiaChi").InnerText;
                sd++;
                serialNumber++;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            show(dgv_nv);
        }
        public Form5(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgv_nv.CurrentCell.RowIndex;

            txt_manv.Text = dgv_nv.Rows[t].Cells[1].Value.ToString();
            txt_tennv.Text = dgv_nv.Rows[t].Cells[2].Value.ToString();
            txt_chucvu.Text = dgv_nv.Rows[t].Cells[3].Value.ToString();
            txt_sdt.Text = dgv_nv.Rows[t].Cells[4].Value.ToString();
            txt_diachi.Text = dgv_nv.Rows[t].Cells[5].Value.ToString();
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode NhanVien = doc.CreateElement("NhanVien");

            XmlAttribute MaNV = doc.CreateAttribute("MaNV");
            MaNV.Value = txt_manv.Text;
            NhanVien.Attributes.Append(MaNV);

            XmlElement TenNV = doc.CreateElement("TenNV");
            TenNV.InnerText = txt_tennv.Text;
            NhanVien.AppendChild(TenNV);

            XmlElement ChucVu = doc.CreateElement("ChucVu");
            ChucVu.InnerText = txt_chucvu.Text;
            NhanVien.AppendChild(ChucVu);

            XmlElement SDT = doc.CreateElement("SDT");
            SDT.InnerText = txt_sdt.Text;
            NhanVien.AppendChild(SDT);

            XmlElement DiaChi = doc.CreateElement("DiaChi");
            DiaChi.InnerText = txt_diachi.Text;
            NhanVien.AppendChild(DiaChi);

            DS_NhanVien.AppendChild(NhanVien);
            doc.Save(filename);
            show(dgv_nv);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode NhanVienCu = DS_NhanVien.SelectSingleNode("NhanVien[@MaNV = '" + txt_manv.Text + "']");
            if (NhanVienCu != null)
            {
                XmlNode NhanVienMoi = doc.CreateElement("NhanVien");

                XmlAttribute MaNV = doc.CreateAttribute("MaNV");
                MaNV.Value = txt_manv.Text;
                NhanVienMoi.Attributes.Append(MaNV);

                XmlElement TenNV = doc.CreateElement("TenNV");
                TenNV.InnerText = txt_tennv.Text;
                NhanVienMoi.AppendChild(TenNV);

                XmlElement ChucVu = doc.CreateElement("ChucVu");
                ChucVu.InnerText = txt_chucvu.Text;
                NhanVienMoi.AppendChild(ChucVu);

                XmlElement SDT = doc.CreateElement("SDT");
                SDT.InnerText = txt_sdt.Text;
                NhanVienMoi.AppendChild(SDT);

                XmlElement DiaChi = doc.CreateElement("DiaChi");
                DiaChi.InnerText = txt_diachi.Text;
                NhanVienMoi.AppendChild(DiaChi);

                DS_NhanVien.ReplaceChild(NhanVienMoi, NhanVienCu);
                doc.Save(filename);
                show(dgv_nv);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode NVCanXoa = DS_NhanVien.SelectSingleNode("NhanVien[@MaNV ='" + txt_manv.Text + "']");
            if (NVCanXoa != null)
            {
                DS_NhanVien.RemoveChild(NVCanXoa);
                doc.Save(filename);

            }
            show(dgv_nv);

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_nv.Rows.Clear();

            string maKHCanTim = txt_timkiemnv.Text.Trim().ToLower();

            foreach (XmlNode dsNhanVienNode in ql_nhanvien.SelectNodes("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']"))
            {
                foreach (XmlNode NhanVienNode in dsNhanVienNode.SelectNodes("NhanVien"))
                {
                    if (NhanVienNode.Attributes["MaNV"].Value.ToLower() == maKHCanTim)
                    {
                            dgv_nv.Rows.Add(
                            NhanVienNode.Attributes["MaNV"].Value,
                            NhanVienNode.SelectSingleNode("TenNV").InnerText,
                            NhanVienNode.SelectSingleNode("ChucVu").InnerText,
                            NhanVienNode.SelectSingleNode("SDT").InnerText,
                            NhanVienNode.SelectSingleNode("DiaChi").InnerText

                        );
                        return; // Dừng khi tìm thấy sản phẩm
                    }
                }
            }

            // Nếu không tìm thấy sản phẩm, thông báo cho người dùng
            MessageBox.Show("Không tìm thấy nhân viên với mã số này.");
        }
    }
    
}

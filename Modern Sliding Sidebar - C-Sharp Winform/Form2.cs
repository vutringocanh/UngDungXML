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
    public partial class Form2 : Form
    {

        string id_taikhoan;
        XmlDocument doc = new XmlDocument();
        String filename = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\SanPham.xml";
        XmlElement ql_sanpham;
        
        private void Show(DataGridView dgv)
        {
            dgv.Rows.Clear();
            doc.Load(filename);
            ql_sanpham = doc.DocumentElement;
           

            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaSP").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenSP").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("Gia").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SoLuongTon").InnerText;
                dgv.Rows[sd].Cells[5].Value = node.SelectSingleNode("NgaySX").InnerText;
                dgv.Rows[sd].Cells[6].Value = node.SelectSingleNode("HanSD").InnerText;
                sd++;
                serialNumber++;
            }
        }
        public Form2(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Show(dgv_sp);
        }

        private void dgv_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgv_sp.CurrentCell.RowIndex;
            
            txt_masp.Text = dgv_sp.Rows[t].Cells[1].Value.ToString();
            txt_tensp.Text = dgv_sp.Rows[t].Cells[2].Value.ToString();
            txt_gia.Text = dgv_sp.Rows[t].Cells[3].Value.ToString();
            txt_soluongton.Text = dgv_sp.Rows[t].Cells[4].Value.ToString();
            txt_ngaysx.Text = dgv_sp.Rows[t].Cells[5].Value.ToString();
            txt_hsd.Text = dgv_sp.Rows[t].Cells[6].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            doc.Load(filename);
            ql_sanpham = doc.DocumentElement;
            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNode SanPham = doc.CreateElement("SanPham");

            XmlAttribute MaSP = doc.CreateAttribute("MaSP");
            MaSP.Value = txt_masp.Text;
            SanPham.Attributes.Append(MaSP);

            XmlElement TenSP = doc.CreateElement("TenSP");
            TenSP.InnerText = txt_tensp.Text;
            SanPham.AppendChild(TenSP);

            XmlElement Gia = doc.CreateElement("Gia");
            Gia.InnerText = txt_gia.Text;
            SanPham.AppendChild(Gia);

            XmlElement SoLuongTon = doc.CreateElement("SoLuongTon");
            SoLuongTon.InnerText = txt_soluongton.Text;
            SanPham.AppendChild(SoLuongTon);

            XmlElement NgaySX = doc.CreateElement("NgaySX");
            NgaySX.InnerText = txt_ngaysx.Text;
            SanPham.AppendChild(NgaySX);

            XmlElement HanSD = doc.CreateElement("HanSD");
            HanSD.InnerText = txt_hsd.Text;
            SanPham.AppendChild(HanSD);

            DS_SanPham.AppendChild(SanPham);
            doc.Save(filename);
            Show(dgv_sp);

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_sanpham = doc.DocumentElement;
            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");
            XmlNode spCanXoa = DS_SanPham.SelectSingleNode("SanPham[@MaSP ='" + txt_masp.Text + "']");
                if (spCanXoa != null)
                {
                    DS_SanPham.RemoveChild(spCanXoa);
                    doc.Save(filename);
                    
                }
            Show(dgv_sp);

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_sanpham = doc.DocumentElement;
            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNode SanPhamCu = DS_SanPham.SelectSingleNode("SanPham[@MaSP = '" + txt_masp.Text + "']");
            if(SanPhamCu != null)
            {
                XmlNode SanPhamMoi = doc.CreateElement("SanPham");

                XmlAttribute MaSP = doc.CreateAttribute("MaSP");
                MaSP.Value = txt_masp.Text;
                SanPhamMoi.Attributes.Append(MaSP);

                XmlElement TenSP = doc.CreateElement("TenSP");
                TenSP.InnerText = txt_tensp.Text;
                SanPhamMoi.AppendChild(TenSP);

                XmlElement Gia = doc.CreateElement("Gia");
                Gia.InnerText = txt_gia.Text;
                SanPhamMoi.AppendChild(Gia);

                XmlElement SoLuongTon = doc.CreateElement("SoLuongTon");
                SoLuongTon.InnerText = txt_soluongton.Text;
                SanPhamMoi.AppendChild(SoLuongTon);

                XmlElement NgaySX = doc.CreateElement("NgaySX");
                NgaySX.InnerText = txt_ngaysx.Text;
                SanPhamMoi.AppendChild(NgaySX);

                XmlElement HanSD = doc.CreateElement("HanSD");
                HanSD.InnerText = txt_hsd.Text;
                SanPhamMoi.AppendChild(HanSD);

                DS_SanPham.ReplaceChild(SanPhamMoi, SanPhamCu);
                doc.Save(filename);
                Show(dgv_sp);
            }

            
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            dgv_sp.Rows.Clear();

            string maSPCanTim = txttimkiemsp.Text.Trim().ToLower();

            foreach (XmlNode dsSanPhamNode in ql_sanpham.SelectNodes("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']"))
            {
                foreach (XmlNode sanPhamNode in dsSanPhamNode.SelectNodes("SanPham"))
                {
                    if (sanPhamNode.Attributes["MaSP"].Value.ToLower() == maSPCanTim)
                    {
                        dgv_sp.Rows.Add(
                            
                            sanPhamNode.Attributes["MaSP"].Value,
                            sanPhamNode.SelectSingleNode("TenSP").InnerText,
                            sanPhamNode.SelectSingleNode("Gia").InnerText,
                            sanPhamNode.SelectSingleNode("SoLuongTon").InnerText,
                            sanPhamNode.SelectSingleNode("NgaySX").InnerText,
                            sanPhamNode.SelectSingleNode("HanSD").InnerText
                        );
                        return; // Dừng khi tìm thấy sản phẩm
                    }
                }
            }

            // Nếu không tìm thấy sản phẩm, thông báo cho người dùng
            MessageBox.Show("Không tìm thấy sản phẩm với mã số này.");
        }

        private void txttimkiemsp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Form3 : Form
    {
        string id_taikhoan;
        String namefile = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\HoaDon.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_hoadon;
        String filenamesp = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\SanPham.xml";
        XmlElement ql_sanpham;
        XmlDocument doc2 = new XmlDocument();
        String filenamenv = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\NhanVien.xml";
        XmlElement ql_nv;
        XmlDocument doc3 = new XmlDocument();

        String filenamekh = "C:\\Users\\Admin\\Downloads\\DuAnXML\\DuAnXML-master\\Modern Sliding Sidebar - C-Sharp Winform\\KhachHang.xml";
        XmlElement ql_kh;
        XmlDocument doc4 = new XmlDocument();



        private List<string> dsSP = new List<string>();
        private List<string> dsKH= new List<string>();

        string mahoadon = "", masp = "";

        public Form3(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;

        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoadon.CurrentCell.RowIndex;
            if (dgv_hoadon.Rows[index].Cells[1].Value != null)
            {
                showChitiet( dgv_hoadon.Rows[index].Cells[1].Value.ToString());
                mahoadon = dgv_hoadon.Rows[index].Cells[1].Value.ToString();
            }

           

        }


      void loadcombobox()
        {

            doc3.Load(filenamenv);

            ql_nv = doc3.DocumentElement;

            XmlNode DS_NV = ql_nv.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_NV.SelectNodes("NhanVien");



            foreach (XmlNode node in ds)
            {
                cbx_manv.Items.Add(node.SelectSingleNode("@MaNV").Value);

            }
            cbx_manv.SelectedIndex=0;




        }

        void showChitiet(string id_HD)
        {


 

            dgv_chitiethoadon.Rows.Clear();
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");


            XmlNode HoaDon= DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + id_HD + "']");


            XmlNodeList ds = HoaDon.SelectNodes("SanPham");


            int sd = 0;
            int serialNumber = 1;
            int tt = 0;
            foreach (XmlNode node in ds)
            {

                dgv_chitiethoadon.Rows.Add();
                dgv_chitiethoadon.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv_chitiethoadon.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaSanPham").Value;
                dgv_chitiethoadon.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenSP").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[3].Value = node.SelectSingleNode("SoLuong").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[4].Value = node.SelectSingleNode("GiaBan").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[5].Value = node.SelectSingleNode("ThanhTien").InnerText;
                sd++;
                serialNumber++;
                tt += int.Parse(node.SelectSingleNode("ThanhTien").InnerText);
            }

            txt_tongtien.Text = tt.ToString()+"VND";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            show(dgv_hoadon);
            LoadAutocompletetxtFromXml();
            SetupAutoComplete();
            loadcombobox();

            txt_ngaymua.Value = DateTime.Now;

        }

        void show(DataGridView dgv)
        {
            dgv.Rows.Clear();
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("HoaDon");
            string maHD = "HD" + (ds.Count+1).ToString();
            txt_mahd.Text = maHD;
            int sd = 0;
            int serialNumber = 1;
  
            foreach (XmlNode node in ds)
            {

                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaHD").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("NgayDat").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("MaNV").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("MaKH").InnerText;
                sd++;
                serialNumber++;

            }

        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadAutocompletetxtFromXml()
        {

            doc2.Load(filenamesp);

            ql_sanpham = doc2.DocumentElement;

            doc4.Load(filenamekh);

            ql_kh = doc4.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");


            XmlNode DS_KH = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");
           
            XmlNodeList ds_kh = DS_KH.SelectNodes("KhachHang");
            foreach(XmlNode node in ds_kh)
            {

                dsKH.Add(node.SelectSingleNode("@MaKH").Value);
            }



            foreach (XmlNode node in ds)
            {
                dsSP.Add(node.SelectSingleNode("TenSP").InnerText);
            }
        }
        private void SetupAutoComplete()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(dsSP.ToArray());
            txt_tensp2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_tensp2.AutoCompleteCustomSource = source;
            txt_tensp2.AutoCompleteMode = AutoCompleteMode.Suggest;

            AutoCompleteStringCollection source2 = new AutoCompleteStringCollection();

            source2.AddRange(dsKH.ToArray());

            txt_makh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_makh.AutoCompleteCustomSource = source2;
            txt_makh.AutoCompleteMode = AutoCompleteMode.Suggest;



        }

        private void txt_cthd_TextChanged(object sender, EventArgs e)
        {

            doc2.Load(filenamesp);
            ql_sanpham = doc2.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");
            foreach (XmlNode node in ds)
            {
                if (txt_cthd.Text == node.SelectSingleNode("@MaSP").InnerText)
                {

                    if (txt_soluong.Text.Length > 0)
                    {
                        int gia = int.Parse(node.SelectSingleNode("Gia").InnerText);

                        int tht = gia * int.Parse(txt_soluong.Text);

                        txt_thanhtien.Text = tht.ToString();


                    }

                    txt_tensp2.Text = node.SelectSingleNode("TenSP").InnerText;
                    txt_giaban.Text = node.SelectSingleNode("Gia").InnerText;
                }

            }

        }

        private void txt_tensp2_TextChanged(object sender, EventArgs e)
        {
            doc2.Load(filenamesp);
            ql_sanpham = doc2.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");
            foreach (XmlNode node in ds)
            {
                if (txt_tensp2.Text == node.SelectSingleNode("TenSP").InnerText)
                {

                    txt_cthd.Text = node.SelectSingleNode("@MaSP").Value;
                    txt_giaban.Text = node.SelectSingleNode("Gia").InnerText;
                }

            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txt_soluong.Text);
                int dongia = int.Parse(txt_giaban.Text);
                int thanhtien = sl * dongia;
                txt_thanhtien.Text = thanhtien.ToString();
            }
            catch (Exception ex) { }
           
            
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNode HoaDon = doc.CreateElement("HoaDon");


            XmlAttribute MaHoaDon = doc.CreateAttribute("MaHD");
            MaHoaDon.Value = txt_mahd.Text;
            HoaDon.Attributes.Append(MaHoaDon);

            XmlElement ngaydat = doc.CreateElement("NgayDat");
            ngaydat.InnerText = txt_ngaymua.Text;
            HoaDon.AppendChild(ngaydat);

            XmlElement MaNV = doc.CreateElement("MaNV");
            MaNV.InnerText = cbx_manv.Text;
            HoaDon.AppendChild(MaNV);

            XmlElement MaKH = doc.CreateElement("MaKH");
            MaKH.InnerText = txt_makh.Text;
            HoaDon.AppendChild(MaKH);


            DS_HoaDon.AppendChild(HoaDon);

            doc.Save(namefile);

            show(dgv_hoadon);






        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            delete();
        }


        void delete()
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                doc.Load(namefile);
                ql_hoadon = doc.DocumentElement;

                XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

                XmlNode HoaDon = DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + this.mahoadon + "']");

                DS_HoaDon.RemoveChild(HoaDon);

                doc.Save(namefile);

                show(dgv_hoadon);
            }
            else
            {

            }

        }

        private void btn_themcthd_Click(object sender, EventArgs e)
        {
            try
            {
                int gia = int.Parse(txt_giaban.Text);

                int sl = int.Parse(txt_soluong.Text);

                if (mahoadon != "" && txt_tensp2.Text.Length > 0 && txt_cthd.Text.Length>0 && txt_giaban.Text.Length > 0 && txt_cthd.Text.Length > 0)
                {
                    dgv_chitiethoadon.Rows.Clear();
                    doc.Load(namefile);
                    ql_hoadon = doc.DocumentElement;

                    XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");


                    XmlNode HoaDon = DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + mahoadon + "']");


                    XmlNode SanPhamCu = HoaDon.SelectSingleNode("SanPham[@MaSanPham ='" + txt_cthd.Text + "']");




               //     string id = SanPhamCu.SelectSingleNode("ThanhTien").InnerText;


                    if (SanPhamCu != null)
                    {

                        XmlNode SanPham = SanPhamCu;

                        int sl_old = int.Parse(SanPhamCu.SelectSingleNode("SoLuong").InnerText);

                        int slladd = int.Parse(txt_soluong.Text);

                        int sum = sl_old + slladd;



                        int get_gia = int.Parse(SanPham.SelectSingleNode("GiaBan").InnerText);


                        SanPham.SelectSingleNode("SoLuong").InnerText = sum.ToString();
                        SanPham.SelectSingleNode("ThanhTien").InnerText = (sum * get_gia).ToString();


                        XmlAttribute MaSanPham = doc.CreateAttribute("MaSanPham");
                        MaSanPham.Value = txt_cthd.Text;
                        SanPham.Attributes.Append(MaSanPham);

                        XmlElement TenSP = doc.CreateElement("TenSP");
                        TenSP.InnerText = txt_tensp2.Text;
                        SanPham.AppendChild(TenSP);

                        XmlElement SoLuong = doc.CreateElement("SoLuong");
                        SoLuong.InnerText = txt_soluong.Text;
                        SanPham.AppendChild(SoLuong);

                        XmlElement GiaBan = doc.CreateElement("GiaBan");
                        GiaBan.InnerText = txt_giaban.Text;
                        SanPham.AppendChild(GiaBan);


                        XmlElement ThanhTien = doc.CreateElement("ThanhTien");
                        ThanhTien.InnerText = txt_thanhtien.Text;
                        SanPham.AppendChild(ThanhTien);

                        HoaDon.ReplaceChild(SanPham, SanPhamCu);

                        doc.Save(namefile);

                        showChitiet(mahoadon);

                    }
                    else
                    {

                        XmlNode SanPham = doc.CreateElement("SanPham");


                        XmlAttribute MaSanPham = doc.CreateAttribute("MaSanPham");
                        MaSanPham.Value = txt_cthd.Text;
                        SanPham.Attributes.Append(MaSanPham);

                        XmlElement TenSP = doc.CreateElement("TenSP");
                        TenSP.InnerText = txt_tensp2.Text;
                        SanPham.AppendChild(TenSP);

                        XmlElement SoLuong = doc.CreateElement("SoLuong");
                        SoLuong.InnerText = txt_soluong.Text;
                        SanPham.AppendChild(SoLuong);

                        XmlElement GiaBan = doc.CreateElement("GiaBan");
                        GiaBan.InnerText = txt_giaban.Text;
                        SanPham.AppendChild(GiaBan);


                        XmlElement ThanhTien = doc.CreateElement("ThanhTien");
                        ThanhTien.InnerText = txt_thanhtien.Text;
                        SanPham.AppendChild(ThanhTien);

                        HoaDon.AppendChild(SanPham);

                        doc.Save(namefile);

                        showChitiet(mahoadon);

                    }
              
                }


                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm", "Lỗi");
                }



            }
            catch
            {
                MessageBox.Show("Vui lòng nhập giá và số lượng sản phẩm là số", "Lỗi");
            }        

          
        }

        private void btn_suacthd_Click(object sender, EventArgs e)
        {


            try
            {

                int gia = int.Parse(txt_giaban.Text);

                int sl = int.Parse(txt_soluong.Text);

                if (mahoadon != "" || txt_tensp2.Text.Length > 0)
                {
                    dgv_chitiethoadon.Rows.Clear();
                    doc.Load(namefile);
                    ql_hoadon = doc.DocumentElement;

                    XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");


                    XmlNode HoaDon = DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + mahoadon + "']");



                    XmlNode SanPhamCu = HoaDon.SelectSingleNode("SanPham[@MaSanPham ='" + txt_cthd + "']");

                    if (SanPhamCu != null)
                    {
                        XmlNode SanPham = doc.CreateElement("SanPham");


                        XmlAttribute MaSanPham = doc.CreateAttribute("MaSanPham");
                        MaSanPham.Value = txt_cthd.Text;
                        SanPham.Attributes.Append(MaSanPham);

                        XmlElement TenSP = doc.CreateElement("TenSP");
                        TenSP.InnerText = txt_tensp2.Text;
                        SanPham.AppendChild(TenSP);

                        XmlElement SoLuong = doc.CreateElement("SoLuong");
                        SoLuong.InnerText = txt_soluong.Text;
                        SanPham.AppendChild(SoLuong);

                        XmlElement GiaBan = doc.CreateElement("GiaBan");
                        GiaBan.InnerText = txt_giaban.Text;
                        SanPham.AppendChild(GiaBan);


                        XmlElement ThanhTien = doc.CreateElement("ThanhTien");
                        ThanhTien.InnerText = txt_thanhtien.Text;
                        SanPham.AppendChild(ThanhTien);

                        HoaDon.ReplaceChild(SanPham, SanPhamCu);

                        doc.Save(namefile);

                        showChitiet(mahoadon);
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không có trong hóa đơn", "Lỗi");
                    }
                  

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm", "Lỗi");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập giá và số lượng sản phẩm là số", "Lỗi");
            }
        }

        private void btn_xoacthd_Click(object sender, EventArgs e)
        {
            dgv_chitiethoadon.Rows.Clear();
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");


            XmlNode HoaDon = DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + mahoadon + "']");



            XmlNode SanPhamCu = HoaDon.SelectSingleNode("SanPham[@MaSanPham ='" + masp + "']");



            HoaDon.RemoveChild( SanPhamCu);

            doc.Save(namefile);

            showChitiet(mahoadon);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiemhd.Text.Length == 0)
            {
                dgv_hoadon.Rows.Clear();
                doc.Load(namefile);
                ql_hoadon = doc.DocumentElement;

                XmlNode DS_KhachHang = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

                XmlNodeList ds = DS_KhachHang.SelectNodes("HoaDon");
                string maHD = "HD" + (ds.Count + 1).ToString();
                txt_mahd.Text = maHD;
                int sd = 0;
                int serialNumber = 1;
                foreach (XmlNode node in ds)
                {

                    dgv_hoadon.Rows.Add();
                    dgv_hoadon.Rows[sd].Cells[0].Value = serialNumber.ToString();
                    dgv_hoadon.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaHD").Value;
                    dgv_hoadon.Rows[sd].Cells[2].Value = node.SelectSingleNode("NgayDat").InnerText;
                    dgv_hoadon.Rows[sd].Cells[3].Value = node.SelectSingleNode("MaNV").InnerText;
                    dgv_hoadon.Rows[sd].Cells[4].Value = node.SelectSingleNode("MaKH").InnerText;
                    sd++;
                    serialNumber++;
                }
            }
            else
            {
                dgv_hoadon.Rows.Clear();
                doc.Load(namefile);
                ql_hoadon = doc.DocumentElement;

                XmlNode DS_KhachHang = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

                XmlNodeList ds = DS_KhachHang.SelectNodes("HoaDon");
                string maHD = "HD" + (ds.Count + 1).ToString();
                txt_mahd.Text = maHD;
                int sd = 0;
                int serialNumber = 1;
                foreach (XmlNode node in ds)
                {

                    if (node.SelectSingleNode("@MaHD").Value == txt_timkiemhd.Text)
                    {
                        dgv_hoadon.Rows.Add();
                        dgv_hoadon.Rows[sd].Cells[0].Value = serialNumber.ToString();
                        dgv_hoadon.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaHD").Value;
                        dgv_hoadon.Rows[sd].Cells[2].Value = node.SelectSingleNode("NgayDat").InnerText;
                        dgv_hoadon.Rows[sd].Cells[3].Value = node.SelectSingleNode("MaNV").InnerText;
                        dgv_hoadon.Rows[sd].Cells[4].Value = node.SelectSingleNode("MaKH").InnerText;
                        sd++;
                        serialNumber++;
                    }

                  
                }

            }
        }

        private void dgv_chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_chitiethoadon.CurrentCell.RowIndex;
            if (dgv_chitiethoadon.Rows[index].Cells[1].Value != null)
            {
                txt_cthd.Text = dgv_chitiethoadon.Rows[index].Cells[1].Value.ToString();
                txt_tensp2.Text= dgv_chitiethoadon.Rows[index].Cells[2].Value.ToString();
               txt_soluong.Text= dgv_chitiethoadon.Rows[index].Cells[3].Value.ToString();
               txt_giaban.Text= dgv_chitiethoadon.Rows[index].Cells[4].Value.ToString();
                txt_thanhtien.Text = dgv_chitiethoadon.Rows[index].Cells[5].Value.ToString();
                masp = dgv_chitiethoadon.Rows[index].Cells[1].Value.ToString();
            }


        }
    }
}

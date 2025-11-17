using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class NhapSach : Form
    {
        private string magd;
        private string NoiDung;
        private string Anh;
        private Random rd = new Random();
        public NhapSach()
        {
            InitializeComponent();
        }

        private void txtsoluongnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void ClearAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                }
                else if (ctrl is RichTextBox)
                {
                    ((RichTextBox)ctrl).Clear();
                }
                // Nếu control chứa control con (Panel, GroupBox,...)
                if (ctrl.HasChildren)
                {
                    ClearAllControls(ctrl);
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsoluongnhap.Text) || string.IsNullOrEmpty(txtgianhap.Text))
            {
                MessageBox.Show("Vui lòng điền giá nhập và số lượng", "Thông báo");
                return;
            }
            decimal tongtien = decimal.Parse(txtsoluongnhap.Text) * decimal.Parse(txtgianhap.Text);
            txttongtien.Text = tongtien.ToString();
        }

        private void txtsoluongnhap_Leave(object sender, EventArgs e)
        {
            int soluong;
            if (!int.TryParse(txtsoluongnhap.Text, out soluong) && !string.IsNullOrEmpty(txtsoluongnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo");
                txtsoluongnhap.Clear();
            }
        }

        private void txtgianhap_Leave(object sender, EventArgs e)
        {
            decimal gianhap;
            if (!decimal.TryParse(txtgianhap.Text, out gianhap) && !string.IsNullOrEmpty(txtgianhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtgianhap.Clear();
            }
        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttensach.Text) || string.IsNullOrWhiteSpace(txtmasach.Text) || string.IsNullOrWhiteSpace(txttacgia.Text) ||
                string.IsNullOrWhiteSpace(txttheloai.Text) || string.IsNullOrWhiteSpace(txtnxb.Text) || string.IsNullOrWhiteSpace(txtsoluongnhap.Text) ||
                string.IsNullOrWhiteSpace(txtgiaban.Text) || string.IsNullOrWhiteSpace(txtgianhap.Text) || string.IsNullOrEmpty(txttongtien.Text) ||
                string.IsNullOrWhiteSpace(txttennxb.Text))
            {
                MessageBox.Show("Vui điền đầy đủ thông tin!");
                return;
            }
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == txtmasach.Text.Trim());
                if (sach != null)
                {
                    if(sach.DaXoa == true)
                    {
                        HoaDon hoadons = new HoaDon();
                        hoadons.MaGD = rd.Next(0, 999999999).ToString();
                        magd = hoadons.MaGD;
                        hoadons.MaSach = txtmasach.Text;
                        hoadons.SoLuong = int.Parse(txtsoluongnhap.Text);
                        hoadons.HoTenNGGD = txttennxb.Text.Trim();
                        DateTime ngaygd = dateNgayNhap.Value;
                        hoadons.NgayGiaoDich = ngaygd.Date;
                        hoadons.Tong = decimal.Parse(txttongtien.Text);
                        sach.DaXoa = false;
                        sach.GiaGoc = decimal.Parse(txtgiaban.Text);
                        sach.TonKho = int.Parse(txtsoluongnhap.Text);
                        sach.MaNXB = txtnxb.Text;
                        sach.TenNXB = txttennxb.Text.Trim();
                        db.HoaDons.InsertOnSubmit(hoadons);
                        db.SubmitChanges();
                        db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                        MessageBox.Show("Nhập thành công!", "Thông báo");
                        return;
                    }
                    HoaDon hoadon = new HoaDon();
                    hoadon.MaGD = rd.Next(0, 999999999).ToString();
                    magd = hoadon.MaGD;
                    hoadon.MaSach = txtmasach.Text;
                    hoadon.SoLuong = int.Parse(txtsoluongnhap.Text);
                    hoadon.HoTenNGGD = txttennxb.Text.Trim();
                    DateTime NgayGD = dateNgayNhap.Value;
                    hoadon.NgayGiaoDich = NgayGD.Date;
                    hoadon.Tong = decimal.Parse(txttongtien.Text);
                    sach.TonKho = sach.TonKho + int.Parse(txtsoluongnhap.Text);
                    db.HoaDons.InsertOnSubmit(hoadon);
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                    MessageBox.Show("Nhập thành công!", "Thông báo");
                    return;
                }
            }
            if (string.IsNullOrEmpty(NoiDung) || string.IsNullOrEmpty(Anh))
            {
                MessageBox.Show("Vui lòng thêm nhập ảnh sách và nội dung!", "Thông báo");
                return;
            }
                try
                {
                    using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                    {
                        HoaDon hoadon = new HoaDon();
                        Sach sach = new Sach();
                        DateTime ngaynhap = dateNgayNhap.Value;
                        hoadon.NgayGiaoDich = ngaynhap.Date;
                        sach.PhanTramGiam = 0;
                        sach.MaSach = txtmasach.Text.Trim();
                        sach.TenSach = txttensach.Text.Trim();
                        sach.TacGia = txttacgia.Text.Trim();
                        sach.TheLoai = txttheloai.Text.Trim();
                        sach.GiaGoc = decimal.Parse(txtgiaban.Text);
                        sach.MaNXB = txtnxb.Text;
                        sach.TenNXB = txttennxb.Text.Trim();
                        sach.TonKho = int.Parse(txtsoluongnhap.Text);
                        sach.DaXoa = false;
                        hoadon.MaGD = rd.Next(0, 99999999).ToString();
                        magd = hoadon.MaGD;
                        hoadon.MaSach = sach.MaSach;
                        hoadon.HoTenNGGD = txttennxb.Text.Trim();
                        hoadon.SoLuong = int.Parse(txtsoluongnhap.Text);
                        hoadon.Tong = decimal.Parse(txttongtien.Text);
                        byte[] NoiDungBytes = File.ReadAllBytes(NoiDung);
                        byte[] AnhBytes = File.ReadAllBytes(Anh);
                        Binary NoiDungBinary = new Binary(NoiDungBytes);
                        Binary AnhBinary = new Binary(AnhBytes);
                        sach.Img = AnhBinary;
                        sach.NoiDung = NoiDungBinary;
                        db.Saches.InsertOnSubmit(sach);
                        db.HoaDons.InsertOnSubmit(hoadon);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm sách thành công!", "Thông báo");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi: " + ex.Message);
                }
            
        }

        private void btnNoiDung_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                dialog.Title = "Vui lòng chọn nội dung sách";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    NoiDung = dialog.FileName;
                }
            }
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "PNG Images (*.png)|*.png| JPG Images (*.jpg)|*.jpg|All Files (*.*)|*.*";
                dialog.Title = "Vui lòng chọn ảnh";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Anh = dialog.FileName;
                }
            }
        }

        private void txtmasach_Leave(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == txtmasach.Text.Trim());
                if(sach != null)
                {
                    txttensach.Text = sach.TenSach;
                    txttennxb.Text = sach.TenNXB;
                    txtgianhap.Text = sach.GiaGoc?.ToString("0.##");
                    txttacgia.Text = sach.TacGia;
                    txttheloai.Text = sach.TheLoai;
                    txtgiaban.Text = sach.GiaHienTai?.ToString("0.##");
                    txtnxb.Text = sach.MaNXB;
                }
            }
        }
        private void GoiYMS()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ds = db.Saches.Where(s => s.DaXoa == false).Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(ds);
                txtmasach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtmasach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtmasach.AutoCompleteCustomSource = goiy;
            }
        }

        private void NhapSach_Load(object sender, EventArgs e)
        {
            GoiYMS();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapSach hoadon = new frmHoaDonNhapSach(magd);
            hoadon.Show();
        }
    }
}

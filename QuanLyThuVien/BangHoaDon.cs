using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class BangHoaDon : Form
    {
        public BangHoaDon()
        {
            InitializeComponent();
        }
        private void btnNhapSach_CheckedChanged(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ds = db.HoaDons.Where(d => d.Sach.TenNXB == d.HoTenNGGD).Select(d => new
                {
                    MaSach = d.MaSach,
                    TenSach = d.Sach.TenSach,
                    NXB = d.HoTenNGGD,
                    SoLuong = d.SoLuong,
                    Tong = d.Tong,
                    NgayGD = d.NgayGiaoDich
                }).ToList();
                var data = ds.Select(d => new
                {
                    MaSach = d.MaSach,
                    TenSach = d.TenSach,
                    NXB = d.NXB,
                    SoLuong = d.SoLuong,
                    Tong = d.Tong?.ToString("0.##"),
                    d.NgayGD
                }).ToList();
                dtgvHienThi.DataSource = data;
                dtgvHienThi.Columns["MaSach"].HeaderText = "Mã sách";
                dtgvHienThi.Columns["TenSach"].HeaderText = "Tên sách";
                dtgvHienThi.Columns["NXB"].HeaderText = "Nhà xuất bản";
                dtgvHienThi.Columns["SoLuong"].HeaderText = "Số lượng";
                dtgvHienThi.Columns["Tong"].HeaderText = "Tổng";
                dtgvHienThi.Columns["NgayGD"].HeaderText = "Ngày giao dịch";
            }
        }

        private void btnHoaDonBanSach_CheckedChanged(object sender, EventArgs e)
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ds = db.HoaDons.Where(d => d.HoTenNGGD != d.Sach.TenNXB).Select(d => new
                {
                    MaSach = d.MaSach,
                    TenSach = d.Sach.TenSach,
                    User = d.HoTenNGGD,
                    SoLuong = d.SoLuong,
                    Gia = d.Sach.GiaHienTai,
                    Tong = d.Tong,
                    NgayGD = d.NgayGiaoDich
                }).ToList();
                var data = ds.Select(d => new
                {
                    MaSach = d.MaSach,
                    TenSach = d.TenSach,
                    User = d.User,
                    SoLuong = d.SoLuong,
                    Tong = d.Tong?.ToString("0.##"),
                    d.NgayGD
                }).ToList();
                dtgvHienThi.DataSource = data;
                dtgvHienThi.Columns["MaSach"].HeaderText = "Mã sách";
                dtgvHienThi.Columns["TenSach"].HeaderText = "Tên sách";
                dtgvHienThi.Columns["User"].HeaderText = "Họ tên khách hàng";
                dtgvHienThi.Columns["SoLuong"].HeaderText = "Số lượng";
                dtgvHienThi.Columns["Tong"].HeaderText = "Tổng";
                dtgvHienThi.Columns["NgayGD"].HeaderText = "Ngày giao dịch";
            }
        }

        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                if (btnHoaDonNhapSach.Checked)
                {
                        var data = db.HoaDons.Where(d => d.Sach.TenNXB == d.HoTenNGGD);
                        if(data.Any())
                        {
                            db.HoaDons.DeleteAllOnSubmit(data);
                            db.SubmitChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo");
                        }
                        btnHoaDonNhapSach.Checked = false;
                }
                else if(btnHoaDonBanSach.Checked)
                    {
                        var data = db.HoaDons.Where(d => d.Sach.TenNXB != d.HoTenNGGD);
                        if (data.Any())
                        {
                            db.HoaDons.DeleteAllOnSubmit(data);
                            db.SubmitChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo");
                        }
                        btnHoaDonBanSach.Checked = false;
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
            }
        }
    }
}

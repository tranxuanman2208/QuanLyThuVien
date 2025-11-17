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
    public partial class DanhSachKhachHang : Form
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            HienDanhSachKH();
        }
        private void HienDanhSachKH()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.KhachHangs.Select(d => new
                {
                    Ten = d.Ten,
                    Birth = d.NgaySinh,
                    SDT = d.SDT,
                    DiaChi = d.DiaChi,
                    Sex = d.Sex,
                    Mail = d.Email
                }).ToList();
                dtgvKhachHang.DataSource = data;
                dtgvKhachHang.Columns["Ten"].HeaderText = "Họ tên";
                dtgvKhachHang.Columns["Birth"].HeaderText = "Ngày sinh";
                dtgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dtgvKhachHang.Columns["Sex"].HeaderText = "Giới tính";
                dtgvKhachHang.Columns["Mail"].HeaderText = "Gmail";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienDanhSachKH();
        }
    }
}

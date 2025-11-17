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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            HienDanhSachNV();
        }
        private void HienDanhSachNV()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.NhanViens.Select(d => new
                {
                    User = d.UserName,
                    Ten = d.Ten,
                    Birth = d.NgaySinh,
                    DiaChi = d.DiaChi,
                    SDT = d.SDT,
                    NgayNhanChuc = d.NgayNhanChuc,
                    Sex = d.Sex,
                    Mail = d.Email
                }).ToList();
                dtgvNhanVien.DataSource = data;
                dtgvNhanVien.Columns["User"].HeaderText = "User";
                dtgvNhanVien.Columns["Ten"].HeaderText = "Họ tên";
                dtgvNhanVien.Columns["Birth"].HeaderText = "Ngày sinh";
                dtgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dtgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvNhanVien.Columns["NgayNhanChuc"].HeaderText = "Ngày bắt đầu làm việc";
                dtgvNhanVien.Columns["Sex"].HeaderText = "Giới tính";
                dtgvNhanVien.Columns["Mail"].HeaderText = "Email";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienDanhSachNV();
        }
    }
}

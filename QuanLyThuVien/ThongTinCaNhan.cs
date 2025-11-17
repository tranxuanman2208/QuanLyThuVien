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
    public partial class ThongTinCaNhan : Form
    {
        private TrangChu main;
        public ThongTinCaNhan(TrangChu main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void ThongTin()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                NhanVien nv = db.NhanViens.SingleOrDefault(n => n.MANV == main.MaNV);
                txtMaNV.Text = nv.MANV;
                txtHoTen.Text = nv.Ten;
                txtDiaChi.Text = nv.DiaChi;
                txtNgayNhanChuc.Text = nv.NgayNhanChuc?.ToString("dd/mm/yyyy") ?? "Chưa có thông tin";
                txtSDT.Text = nv.SDT;
                txtNgaySinh.Text = nv.NgaySinh?.ToString("dd/mm/yyyy") ?? "Chưa có thông tin";
                txtEmail.Text = nv.Email;
            }
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            ThongTin();
        }
    }
}

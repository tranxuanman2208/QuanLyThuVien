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
    public partial class LichSuMuonTra : Form
    {
        public LichSuMuonTra()
        {
            InitializeComponent();
        }

        private void LichSuMuonTra_Load(object sender, EventArgs e)
        {

        }


        private void btnDSMuon_CheckedChanged(object sender, EventArgs e)
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.DanhSachMuons.Where(ds => ds.NgayTraThucTe == null).Select(ds => new
                {
                    MaSach = ds.MaSach,
                    TenSach = ds.Sach.TenSach,
                    NgayMuon = ds.NgayMuon,
                    NgayHenTra = ds.NgayHenTra,
                    User = ds.UserNameKhachHang
                }).ToList();
                BangHienThi.DataSource = data;
                BangHienThi.Columns["MaSach"].HeaderText = "Mã sách";
                BangHienThi.Columns["TenSach"].HeaderText = "Tên sách";
                BangHienThi.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                BangHienThi.Columns["NgayHenTra"].HeaderText = "Ngày hẹn trả";
                BangHienThi.Columns["User"].HeaderText = "User";
            }
        }

        private void btnDSTra_CheckedChanged(object sender, EventArgs e)
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.DanhSachMuons.Where(ds => ds.NgayTraThucTe != null).Select(ds => new
                {
                    MaSach = ds.MaSach,
                    TenSach = ds.Sach.TenSach,
                    NgayMuon = ds.NgayMuon,
                    NgayTraThuc = ds.NgayTraThucTe,
                    User = ds.UserNameKhachHang
                }).ToList();
                BangHienThi.DataSource = data;
                BangHienThi.Columns["MaSach"].HeaderText = "Mã sách";
                BangHienThi.Columns["TenSach"].HeaderText = "Tên sách";
                BangHienThi.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                BangHienThi.Columns["NgayTraThuc"].HeaderText = "Ngày trả thực tế";
                BangHienThi.Columns["User"].HeaderText = "User";
            }
        }
    }
}

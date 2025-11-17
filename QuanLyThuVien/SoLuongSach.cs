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
    public partial class SoLuongSach : Form
    {
        public SoLuongSach()
        {
            InitializeComponent();
        }

        private void SoLuongSach_Load(object sender, EventArgs e)
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ds = db.Saches.Where(data => data.DaXoa == false).Select(data => new
                {
                    data.MaSach,
                    data.TenSach,
                    data.TheLoai,
                    data.TacGia,
                    data.TenNXB,
                    data.TonKho,
                    data.GiaHienTai
                }).ToList();
                var dsnew = ds.Select(data => new
                {
                    MaSach =data.MaSach, 
                    TenSach = data.TenSach, 
                    TheLoai =data.TheLoai, 
                    TacGia = data.TacGia, 
                    NXB = data.TenNXB, 
                    TonKho =data.TonKho, 
                    GiaBan = data.GiaHienTai?.ToString("0.##")
                }).ToList();
                dtgvHienThi.DataSource = dsnew;
                dtgvHienThi.Columns["MaSach"].HeaderText = "Mã sách";
                dtgvHienThi.Columns["TenSach"].HeaderText = "Tên sách";
                dtgvHienThi.Columns["TheLoai"].HeaderText = "Thể loại";
                dtgvHienThi.Columns["TacGia"].HeaderText = "Tác giả";
                dtgvHienThi.Columns["NXB"].HeaderText = "Nhà xuất bản";
                dtgvHienThi.Columns["TonKho"].HeaderText = "Tồn kho";
                dtgvHienThi.Columns["GiaBan"].HeaderText = "Giá bán";
            }
        }
    }
}

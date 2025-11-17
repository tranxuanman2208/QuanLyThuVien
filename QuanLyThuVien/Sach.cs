using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyThuVien
{
    public partial class Sach : Form
    {
        private string MS;
        private TrangChu main;
        public Sach(string MS, TrangChu main)
        {
            InitializeComponent();
            this.MS = MS;
            this.main = main;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            if(!main.IsLoggedIn)
            {
                btnBan.Enabled = false;
                btnMuon.Enabled = false;
            }
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.MaSach == MS.Trim()).Select(s => new
                {
                    TenSach = s.TenSach,
                    NXB = s.TenNXB,
                    TacGia = s.TacGia,
                    Gia = s.GiaHienTai,
                    Anh = s.Img
                }).FirstOrDefault();
                if (data != null)
                {
                    lbNXB.Text = $"NXB: {data.NXB}";
                    lbTacGia.Text = $"Tác giả: {data.TacGia}";
                    lbTenSach.Text = $"Tên: {data.TenSach}";
                    lbGia.Text = $"Giá: {data.Gia?.ToString("0.##")} đồng";
                    Image anh = null;
                    if (data.Anh != null && data.Anh.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(data.Anh.ToArray()))
                        {
                            anh = Image.FromStream(ms);
                        }
                    }
                    else anh = new Bitmap(picSach.Width, picSach.Height);
                    picSach.Image = anh;
                }

            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            BanSach bs = new BanSach(MS);
            this.Hide();
            DialogResult rs = bs.ShowDialog(main);
            if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.MaSach == MS.Trim()).Select(s => new { s.NoiDung } ).FirstOrDefault();
                if (data != null && data.NoiDung != null && data.NoiDung.Length > 0)
                {
                    DocSach f = new DocSach(data.NoiDung.ToArray());
                    this.Hide();
                    DialogResult rs = f.ShowDialog(main);
                    if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
                }
                else MessageBox.Show("Không tìm thấy nội dung", "Báo lỗi");
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            MuonSach ms = new MuonSach(MS);
            this.Hide();
            DialogResult rs = ms.ShowDialog(main);
            if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
        }

        private void lbTenSach_Click(object sender, EventArgs e)
        {

        }
    }
}

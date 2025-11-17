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
using System.Windows.Forms.VisualStyles;

namespace QuanLyThuVien
{
    public partial class SachTheoTheLoai : Form
    {
        private string theloai;
        private TrangChu main;
        public SachTheoTheLoai(string theloai, TrangChu main)
        {
            InitializeComponent();
            this.theloai = theloai;
            this.main = main;
        }

        private void SachTheoTheLoai_Load(object sender, EventArgs e)
        {
            lbTHELOAI.Text = $"Thể loại: {theloai}";
            HienThiSach();
        }
        private void HienThiSach()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.TheLoai.Trim() == theloai.Trim() && s.DaXoa == false).Select(s => new
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    Anh = s.Img
                }).ToList();
                if (data.Count > 0)
                {
                    foreach (var sach in data)
                    {
                        Image anh = null;
                        if (sach.Anh != null && sach.Anh.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(sach.Anh.ToArray()))
                            {
                                anh = Image.FromStream(ms);
                            }
                        }
                        else anh = new Bitmap(imgBox.ImageSize.Width, imgBox.ImageSize.Height);
                        imgBox.Images.Add(sach.MaSach, anh);
                        ListViewItem item = new ListViewItem();
                        item.Text = sach.TenSach;
                        item.ImageKey = sach.MaSach;
                        item.Tag = sach.MaSach;
                        LISTSACH.Items.Add(item);
                    }
                }
            }
        }

        private void LISTSACH_ItemActivate(object sender, EventArgs e)
        {
            if(LISTSACH.Items.Count > 0)
            {
                ListViewItem item = LISTSACH.SelectedItems[0];
                string masach = item.Tag.ToString();
                using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    var data = db.Saches.Where(s => s.MaSach.Trim() == masach.Trim()).Select(s => new { s.MaSach }).SingleOrDefault();
                    if (data != null)
                    {
                        Sach sach = new Sach(data.MaSach, main);
                        this.Hide();
                        DialogResult rs = sach.ShowDialog(main);
                        if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
                    }
                    else MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo");
                }
            }
        }
    }
}

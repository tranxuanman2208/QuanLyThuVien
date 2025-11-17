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

namespace QuanLyThuVien
{
    public partial class SachTheoNXB : Form
    {
        private TrangChu main;
        public SachTheoNXB(TrangChu main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void HienThiSach(string NXB)
        {
            listviewSach.Items.Clear();
            imgBox.Images.Clear();
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {


                var data = db.Saches.Where(p => p.TenNXB == NXB && p.DaXoa == false).Select(p => new
                {
                    MaSach = p.MaSach,
                    TenSach = p.TenSach,
                    HinhAnh = p.Img
                }).ToList();
                if (data.Count <= 0) { MessageBox.Show("Không tìm thấy nhà xuất bản!"); return; }
                foreach (var sach in data)
                {
                    Image anhSach = null;
                    if (sach.HinhAnh != null && sach.HinhAnh.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(sach.HinhAnh.ToArray()))
                        {
                            anhSach = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        anhSach = new Bitmap(imgBox.ImageSize.Width, imgBox.ImageSize.Height);
                    }
                    imgBox.Images.Add(sach.MaSach, anhSach);
                    ListViewItem item = new ListViewItem();
                    item.Text = sach.TenSach;
                    item.Tag = sach.MaSach;
                    item.ImageKey = sach.MaSach;
                    listviewSach.Items.Add(item);
                }
            }
        }

        private void txtNXB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXB.Text))
            {
                txtNXB.Text = "Nhập tên nhà xuất bản";
                txtNXB.ForeColor = Color.Gray;
            }
        }

        private void txtNXB_Enter(object sender, EventArgs e)
        {
            if(txtNXB.Text == "Nhập tên nhà xuất bản")
            {
                txtNXB.Clear();
                txtNXB.ForeColor = Color.Black;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string txt = txtNXB.Text;
            HienThiSach(txt);
        }
        private void GoiYNXB()
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            { 
                var data = db.Saches.Where(s => s.DaXoa == false).Select(s => s.TenNXB).ToArray();
                AutoCompleteStringCollection GoiY = new AutoCompleteStringCollection();
                GoiY.AddRange(data);
                txtNXB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtNXB.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtNXB.AutoCompleteCustomSource = GoiY;
            }
        }

        private void SachTheoNXB_Load(object sender, EventArgs e)
        {
            GoiYNXB();
        }

        private void listviewSach_ItemActivate(object sender, EventArgs e)
        {
            if (listviewSach.Items.Count > 0)
            {
                ListViewItem item = listviewSach.Items[0];
                string masach = item.Tag.ToString();
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    var data = db.Saches.Where(s => s.MaSach == masach).Select(s => s.MaSach).FirstOrDefault().ToString();
                    if (data != null)
                    {
                        Sach sach = new Sach(data, main);
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

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
    public partial class SachTheoTenTacGia : Form
    {
        private DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext();
        private TrangChu main;
        public SachTheoTenTacGia(TrangChu main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void HienThiSach(string TenTacGia)
        {
            listviewSach.Items.Clear();
            imagelistBox.Images.Clear();
            var data = db.Saches.Where(p => p.TacGia == TenTacGia && p.DaXoa == false).ToList();
            var dsSach = data.Select(p => new
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                HinhAnh = p.Img
            }).ToList();
            if (dsSach.Count <= 0) { MessageBox.Show("Không tìm thấy tác giả!"); return; }
            foreach(var sach in dsSach)
            {

                Image anhSach = null;
                if(sach.HinhAnh != null && sach.HinhAnh.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(sach.HinhAnh.ToArray()))
                    {
                        anhSach = Image.FromStream(ms);
                    }
                }
                else
                {
                    anhSach = new Bitmap(imagelistBox.ImageSize.Width, imagelistBox.ImageSize.Height);
                }
                imagelistBox.Images.Add(sach.MaSach,anhSach);
                ListViewItem item = new ListViewItem();
                item.Text = sach.TenSach;
                item.Tag = sach.MaSach;
                item.ImageKey = sach.MaSach.ToString();
                listviewSach.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTenTG.Text;
            HienThiSach(tukhoa);
        }

        private void txtTenTG_Enter(object sender, EventArgs e)
        {
            if(txtTenTG.Text == "Nhập tên tác giả")
            {
                txtTenTG.Clear();
                txtTenTG.ForeColor = Color.Black;
            }
        }

        private void txtTenTG_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                txtTenTG.Text = "Nhập tên tác giả";
                txtTenTG.ForeColor = Color.Gray;
            }
        }
        private void GoiYTacGia()
        {
            var dsTG = db.Saches.Where(p => p.TacGia != null && p.TacGia != "" && p.DaXoa == false).Distinct().Select(p => p.TacGia).ToArray();
            AutoCompleteStringCollection GoiY = new AutoCompleteStringCollection();
            GoiY.AddRange(dsTG);
            txtTenTG.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenTG.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenTG.AutoCompleteCustomSource = GoiY;
        }
        private void SachTheoTenTacGia_Load(object sender, EventArgs e)
        {
            GoiYTacGia();
        }

        private void listviewSach_ItemActivate(object sender, EventArgs e)
        {
            if (listviewSach.Items.Count > 0)
            {
                ListViewItem selectitem = listviewSach.Items[0];
                string ID = (string)selectitem.Tag;
                var sach = db.Saches.Where(s => s.MaSach == ID && s.DaXoa == false).Select(s => s.MaSach).FirstOrDefault().ToString();
                if( sach == null)
                {
                    MessageBox.Show("Không tìm thấy sách!", "Thông báo lỗi");
                    return;
                }
                Sach frmsach = new Sach(sach, main);
                this.Hide();
                DialogResult rs = frmsach.ShowDialog(main);
                if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
            }
        }
    }
}

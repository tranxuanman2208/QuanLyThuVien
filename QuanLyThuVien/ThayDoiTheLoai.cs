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
    public partial class ThayDoiTheLoai : Form
    {
        public ThayDoiTheLoai()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaSach_TenSach.Text != "Nhập mã sách hoặc tên sách")
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    Sach sach = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach_TenSach.Text.Trim() || s.TenSach == txtMaSach_TenSach.Text.Trim());
                    if (sach != null) { btnCapNhat.Enabled = true; return; }
                    MessageBox.Show("Không tìm thấy sách!", "Thông báo");

                }
            }
        }
        private void GoiY()
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ms = db.Saches.Select(s => s.MaSach).ToArray();
                var ts = db.Saches.Select(s => s.TenSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(ms);
                goiy.AddRange(ts);
                txtMaSach_TenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach_TenSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach_TenSach.AutoCompleteCustomSource = goiy;
            }
        }

        private void txtMaSach_TenSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach_TenSach.Text))
            {
                txtMaSach_TenSach.Text = "Nhập mã sách hoặc tên sách";
                txtMaSach_TenSach.ForeColor = Color.Gray;
            }
        }

        private void txtMaSach_TenSach_Enter(object sender, EventArgs e)
        {
            if (txtMaSach_TenSach.Text == "Nhập mã sách hoặc tên sách")
            {
                txtMaSach_TenSach.Clear();
                txtMaSach_TenSach.ForeColor = Color.Black;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNhapTheLoaiMoi.Text != "Nhập thể loại mới")
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    Sach sach = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach_TenSach.Text.Trim() || s.TenSach == txtMaSach_TenSach.Text.Trim());
                    sach.TheLoai = txtNhapTheLoaiMoi.Text;
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                    MessageBox.Show("Thay đổi thành công!\nThể loại hiện tại là: " + sach.TheLoai, "Thông báo");
                    ClearAllControls(this);
                    btnCapNhat.Enabled = false;
                }
            }
        }
        private void ClearAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                }
                else if (ctrl is RichTextBox)
                {
                    ((RichTextBox)ctrl).Clear();
                }
                if (ctrl.HasChildren)
                {
                    ClearAllControls(ctrl);
                }
            }
        }

        private void txtNhapTheLoaiMoi_Enter(object sender, EventArgs e)
        {
            if (txtNhapTheLoaiMoi.Text == "Nhập thể loại mới")
            {
                txtNhapTheLoaiMoi.Clear();
                txtNhapTheLoaiMoi.ForeColor = Color.Black;
            }
        }

        private void txtNhapTheLoaiMoi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapTheLoaiMoi.Text))
            {
                txtNhapTheLoaiMoi.Text = "Nhập thể loại mới";
                txtNhapTheLoaiMoi.ForeColor = Color.Gray;
            }
        }

        private void ThayDoiTheLoai_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            GoiY();
        }
    }
}
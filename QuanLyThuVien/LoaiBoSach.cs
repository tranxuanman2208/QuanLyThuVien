using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVien
{
    public partial class LoaiBoSach : Form
    {
        // Import hàm HideCaret từ thư viện user32.dll
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public LoaiBoSach()
        {
            InitializeComponent();
        }


        private void LoaiBoSach_Load(object sender, EventArgs e)
        {
            GoiYMS();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == txtNhapSachLoaiBo.Text.Trim() && s.DaXoa == false);
                if(sach == null)
                {
                    MessageBox.Show("Không tìm thấy sách!", "Thông báo");
                    return;
                }
                sach.DaXoa = true;
                db.SubmitChanges();
                db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearAllControls(this);
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbNgayLBS_Click(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemLBS_Click(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                Sach data = db.Saches.SingleOrDefault(s => s.MaSach == txtNhapSachLoaiBo.Text.Trim() && s.DaXoa == false);
                if(data == null)
                {
                    MessageBox.Show("Không tìm thấy sách!", "Thông báo");
                    return;
                }
                lbGia.Text = $"Giá: {data.GiaHienTai?.ToString("0.##")} đồng";
                lbMaSach.Text = $"Mã sách: {data.MaSach}";
                lbTenSach.Text = $"Tên sách: {data.TenSach}";
                lbNXB.Text = $"NXB: {data.TenNXB}";
                lbTonKho.Text = $"Tồn kho: {data.TonKho.ToString()}";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Gọi hàm xóa toàn bộ control trên form
            ClearAllControls(this);
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
                // Nếu control chứa control con (Panel, GroupBox,...)
                if (ctrl.HasChildren)
                {
                    ClearAllControls(ctrl);
                }
            }
        }

        private void lbTenSach_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapSachLoaiBo_Enter(object sender, EventArgs e)
        {
            if(txtNhapSachLoaiBo.Text == "Nhập mã sách...")
            {
                txtNhapSachLoaiBo.Clear();
                txtNhapSachLoaiBo.ForeColor = Color.Black;
            }
        }

        private void txtNhapSachLoaiBo_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNhapSachLoaiBo.Text))
            {
                txtNhapSachLoaiBo.Text = "Nhập mã sách...";
                txtNhapSachLoaiBo.ForeColor = Color.Gray;
            }
        }
        private void GoiYMS()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.DaXoa == false).Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(data);
                txtNhapSachLoaiBo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtNhapSachLoaiBo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtNhapSachLoaiBo.AutoCompleteCustomSource = goiy;
            }
        }
    }
}

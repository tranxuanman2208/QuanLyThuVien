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
    public partial class TraSach : Form
    {
        private bool hople = false;
        public TraSach()
        {
            InitializeComponent();
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            GoiY();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(!hople)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập!", "Thông báo");
                return;
            }
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                DanhSachMuon toUpdate = db.DanhSachMuons.FirstOrDefault(data => data.MaSach == txtMaSach.Text.Trim() && data.UserNameKhachHang == txtUserKH.Text.Trim());
                Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == toUpdate.MaSach);
                sach.TonKho = sach.TonKho + 1;
                DateTime ngaytra = dateNgayTra.Value;
                toUpdate.NgayTraThucTe = ngaytra.Date;
                db.SubmitChanges();
                db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, toUpdate);
                MessageBox.Show("Thành công!", "Thông báo");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GoiY()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.DanhSachMuons.Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(data);
                txtMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach.AutoCompleteCustomSource = goiy;
            }
        }

        private void btnKTra_User_MaSach_Click(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var dsmuon = db.DanhSachMuons.Where(data => data.MaSach == txtMaSach.Text && data.UserNameKhachHang == txtUserKH.Text)
                    .Select(data => new { data.MaSach, User = data.UserNameKhachHang }).SingleOrDefault();
                if(dsmuon == null || dsmuon.MaSach == null || dsmuon.User == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo");
                    hople = false;
                    return;
                }
                MessageBox.Show("Kiểm tra hợp lệ!", "Thông báo");
                hople = true;
                return;

            }
        }
    }
}

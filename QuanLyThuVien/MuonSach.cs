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
    public partial class MuonSach : Form
    {
        private Random rd = new Random();
        private string MS;
        private bool hople = false;
        public MuonSach(string MS = "")
        {
            InitializeComponent();
            this.MS = MS;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void lbNgayHenTra_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(!hople)
            {
                MessageBox.Show("Vui lòng nhập lại username hoặc mã sách!", "Thông báo");
                return;
            }
            try
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    Sach sach = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach.Text.Trim());
                    if(sach.TonKho <= 0)
                    {
                        MessageBox.Show("Sách trong kho đã hết!", "Thông báo");
                        return;
                    }
                    sach.TonKho = sach.TonKho - 1;
                    DanhSachMuon dsmuon = new DanhSachMuon();
                    dsmuon.MaSach = txtMaSach.Text;
                    dsmuon.UserNameKhachHang = txtUserKH.Text;
                    DateTime ngaymuon = dateMuon.Value;
                    dsmuon.NgayMuon = ngaymuon.Date;
                    DateTime ngayhentra = dateHenTra.Value;
                    dsmuon.NgayHenTra = ngayhentra.Date;
                    db.DanhSachMuons.InsertOnSubmit(dsmuon);
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, sach);
                    MessageBox.Show("Thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
                return;
            }
        }

        private void lbNhapNgayMuon_Click(object sender, EventArgs e)
        {

        }

        private void lbTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            GoiY();
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
        private void GoiY()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var ds = db.Saches.Where(s => s.DaXoa == false).Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(ds);
                txtMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach.AutoCompleteCustomSource = goiy;
            }
        }

        private void btnKTra_User_MaSach_Click(object sender, EventArgs e)
        {
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                KhachHang kh = db.KhachHangs.FirstOrDefault(KH => KH.UserName == txtUserKH.Text.Trim());
                Sach sach = db.Saches.FirstOrDefault(s => s.DaXoa == false && s.MaSach == txtMaSach.Text.Trim());
                if (kh == null || sach == null)
                {
                    MessageBox.Show("Username hoặc Mã sách không hợp lệ!", "Thông báo");
                    hople = false;
                    return;
                }
                lbTonKho.Text = sach.TonKho.ToString();
                hople = true;
                MessageBox.Show("Kiểm tra hợp lệ!", "Thông báo");
                return;
                
            }
        }
    }
}

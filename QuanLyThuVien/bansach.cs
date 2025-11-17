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
    public partial class BanSach : Form
    {
        private string MS;
        private Random rd = new Random();
        public BanSach(string MS = "")
        {
            InitializeComponent();
            this.MS = MS;
        }


        private void bansach_Load(object sender, EventArgs e)
        {
            GoiYMS();
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

        private void txtsoluongban_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtsoluongban.Text))
            {
                try
                {
                    int soluong = int.Parse(txtsoluongban.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}", "Báo lỗi");
                    txtsoluongban.Clear();
                }
            }
        }

        private void txtgiaban_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtgiaban.Text))
            {
                try
                {
                    int soluong = int.Parse(txtgiaban.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}", "Báo lỗi");
                    txtgiaban.Clear();
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtsoluongban.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo");
                return;
            }
            decimal tong = decimal.Parse(txtgiaban.Text) * int.Parse(txtsoluongban.Text);
            txttongtienban.Text = tong.ToString();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txttensach.Text) || string.IsNullOrWhiteSpace(txtmasach.Text) || string.IsNullOrWhiteSpace(txtsoluongban.Text)
                || string.IsNullOrWhiteSpace(txtgiaban.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txttongtienban.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }
            
            try
            {
                using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    
                    HoaDon hoadon = new HoaDon();
                    hoadon.MaGD = rd.Next(0, 999999999).ToString();
                    hoadon.HoTenNGGD = txtUser.Text;
                    hoadon.MaSach = txtmasach.Text;
                    hoadon.SoLuong = int.Parse(txtsoluongban.Text);
                    hoadon.Tong = decimal.Parse(txttongtienban.Text);
                    DateTime NgayGD = dtGD.Value;
                    hoadon.NgayGiaoDich = NgayGD.Date;
                    Sach toUpdate = db.Saches.Where(s => s.DaXoa == false).SingleOrDefault(s => s.MaSach == txtmasach.Text.Trim());
                    if(toUpdate != null)
                    {
                        if (toUpdate.TonKho < int.Parse(txtsoluongban.Text))
                        {
                            MessageBox.Show($"Kho hiện tại còn: {toUpdate.TonKho}\nKhông đủ sách để giao dịch!", "Thông báo");
                            txtsoluongban.Clear();
                            return;
                        }
                        toUpdate.TonKho = toUpdate.TonKho - int.Parse(txtsoluongban.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách!", "Thông báo");
                        return;
                    }
                    db.HoaDons.InsertOnSubmit(hoadon);
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, toUpdate);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
                return;
            }

        }

        private void txtmasach_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmasach.Text))
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    var data = db.Saches.Where(s => s.MaSach == txtmasach.Text.Trim() && s.DaXoa == false).Select(s => new { s.TenSach, s.GiaHienTai }).FirstOrDefault();
                    if (data == null)
                    {
                        MessageBox.Show("Không tìm thấy mã sách", "Thông báo");
                        return;
                    }
                    txtgiaban.Text = data.GiaHienTai?.ToString("0.##");
                    txttensach.Text = data.TenSach;
                }
            }
        }
        private void GoiYMS()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.DaXoa == false).Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(data);
                txtmasach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtmasach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtmasach.AutoCompleteCustomSource = goiy;
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {

        }
    }
}

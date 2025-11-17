using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace QuanLyThuVien
{
    public partial class ThayDoiMatKhau : Form
    {
        private TrangChu main;
        public ThayDoiMatKhau(TrangChu main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void btnhuybo_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text.Trim() != txtPassAgain.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Thông báo");
                return;
            }
            try
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    NhanVien nv = db.NhanViens.SingleOrDefault(n => n.MANV == main.MaNV);
                    bool CheckPass = BCrypt.Net.BCrypt.Verify(txtOldPass.Text.Trim(), nv.Pass);
                    if (!CheckPass)
                    {
                        MessageBox.Show("Sai mật khẩu!", "Thông báo");
                        return;
                    }
                    string tmp = BCrypt.Net.BCrypt.HashPassword(txtNewPass.Text.Trim());
                    nv.Pass = tmp;
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, nv);
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}

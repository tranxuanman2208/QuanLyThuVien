using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;

namespace QuanLyThuVien
{
    public partial class DangNhap : Form
    {
        private TrangChu main;
        public DangNhap(TrangChu main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes) this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string username = txtdangnhap.Text.Trim();
            string password = txtmatkhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo");
                return;
            }
            try
            {
                using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    NhanVien nv = db.NhanViens.SingleOrDefault(s => s.UserName == username);
                    if(nv == null)
                    {
                        MessageBox.Show("Sai tên đăng nhập!", "Thông báo");
                        return;
                    }
                    bool CheckPass = BCrypt.Net.BCrypt.Verify(password, nv.Pass);
                    if(!CheckPass)
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(nv.Admin))
                    {
                        main.IsAdmin = true;
                    }
                    else main.IsAdmin = false;
                        main.MaNV = nv.MANV;
                    main.IsLoggedIn = true;
                    main.CapNhatTrangThaiDangNhap();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống:" + ex.Message);
            }
            
        }

        private void btnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(btnHienMatKhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }    
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}

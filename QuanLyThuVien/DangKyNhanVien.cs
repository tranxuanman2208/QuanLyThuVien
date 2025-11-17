using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using BCrypt.Net;

namespace QuanLyThuVien
{
    public partial class DangKyNhanVien : Form
    {
        private string otp = "";
        public DangKyNhanVien()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }

        private void ClearAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb) tb.Clear();
                else if (ctrl is ComboBox cb) cb.SelectedIndex = -1;
                else if (ctrl is CheckBox ch) ch.Checked = false;
                else if (ctrl is RadioButton rb) rb.Checked = false;
                else if (ctrl is DateTimePicker dt) dt.Value = DateTime.Now;
                else if (ctrl is NumericUpDown num) num.Value = num.Minimum;
                else if (ctrl is RichTextBox rt) rt.Clear();

                if (ctrl.HasChildren) ClearAllControls(ctrl);
            }
        }


        private void btnOTP_Click(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                int otpV = rd.Next(100000, 1000000);
                otp = otpV.ToString();
                string mail = "tranman22082007@gmail.com";
                string passpr = "xlrx pfni mkgc ptrn";
                if (string.IsNullOrWhiteSpace(txtGmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập gmail!", "Thông báo");
                    return;
                }
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mail);
                message.To.Add(new MailAddress(txtGmail.Text.Trim()));
                message.Subject = "Mã xác thực OTP";
                message.Body = "Mã OTP của bạn là: " + otp;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(mail, passpr);
                this.Enabled = false;
                MessageBox.Show("Đang gửi OTP...", "Thông báo");
                Task.Run(() =>
                {
                    try
                    {
                        client.Send(message);
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("Gửi OTP thành công! Vui lòng kiểm tra gmail", "Thông báo");
                            this.Enabled = true;
                        });
                    }
                    catch (Exception ex)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
                            this.Enabled = true;
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                this.Enabled = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text != otp)
            {
                MessageBox.Show("Mã OTP không hợp lệ!", "Thông báo");
                txtOTP.Clear();
                return;
            }
            try
            {
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    NhanVien nv = new NhanVien();
                    nv.MANV = txtMaSo.Text.Trim();
                    nv.UserName = txtMaSo.Text.Trim();
                    nv.Pass = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text.Trim());
                    nv.Ten = txtHoTen.Text;
                    DateTime birth = dateNgaySinh.Value;
                    nv.NgaySinh = birth.Date;
                    nv.SDT = txtSDT.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.Sex = (btnNam.Checked) ? "Nam" : "Nữ";
                    nv.Email = txtGmail.Text.Trim();
                    nv.Admin = (string.IsNullOrWhiteSpace(txtAdmin.Text.Trim())) ? null : txtAdmin.Text.Trim();
                    DateTime ngaync = dateNgayNhanChuc.Value;
                    nv.NgayNhanChuc = ngaync.Date;
                    db.NhanViens.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }
    }
}

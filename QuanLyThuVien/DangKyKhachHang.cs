using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace QuanLyThuVien
{
    public partial class DangKyKhachHang : Form
    {
        private string pass = "";
        private string otp = "";
        public DangKyKhachHang()
        {
            InitializeComponent();
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                string otpV = rd.Next(100000, 1000000).ToString();
                otp = otpV;
                string mail = "tranman22082007@gmail.com";
                string passpr = "xlrx pfni mkgc ptrn";
                if (string.IsNullOrWhiteSpace(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập lại Email!", "Thông báo");
                    return;
                }
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mail);
                message.To.Add(new MailAddress(txtGmail.Text.Trim()));
                message.Subject = "Mã xác thực OTP";
                message.Body = "Mã xác thực OTP của bạn là:" + otpV;

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
                MessageBox.Show("Lỗi hệ thống:" + ex.Message);
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text.Trim() != otp)
            {
                MessageBox.Show("Mã OTP không hợp lệ!", "Thông báo");
                return;
            }
            if(txtPassAgain.Text.Trim() != pass)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
                return;
            }
            try
            {
                using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    KhachHang KH = new KhachHang();
                    KH.UserName = txtUser.Text.Trim();
                    KH.Pass = BCrypt.Net.BCrypt.HashPassword(pass.Trim());
                    KH.Ten = txtHoTen.Text;
                    DateTime birth = dateNgaySinh.Value;
                    KH.NgaySinh = birth.Date;
                    KH.SDT = txtSDT.Text;
                    KH.DiaChi = txtDiaChi.Text;
                    KH.Sex = (btnNam.Checked) ? "Nam" : "Nữ";
                    KH.Email = txtGmail.Text.Trim();
                    db.KhachHangs.InsertOnSubmit(KH);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống:" + ex.Message);
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPass.Text.Trim()))
            {
                pass = txtPass.Text.Trim();
            }
        }
    }
}

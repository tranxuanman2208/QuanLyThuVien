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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            HideCaret(txtKQ.Handle);
        }

        private void LoaiBoSach_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

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

        }

        private void txtNhapSachLoaiBo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

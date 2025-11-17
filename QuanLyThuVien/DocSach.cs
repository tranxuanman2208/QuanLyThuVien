using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersOne.Epub;

namespace QuanLyThuVien
{
    public partial class DocSach : Form
    {
        private byte[] data;
        private string _tempFilePath = "";

        public DocSach(byte[] data)
        {
            InitializeComponent();
            this.data = data;
            this.FormClosing += new FormClosingEventHandler(this.DocSach_FormClosing);
        }
        private  void DocSach_Load(object sender, EventArgs e)
        {
            try
            {
                _tempFilePath = Path.ChangeExtension(Path.GetTempFileName(), ".pdf");
                File.WriteAllBytes(_tempFilePath, data);
                webView21.Source = new Uri(_tempFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trình đọc PDF: " + ex.Message);
            }
        }
        private void DocSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.Source = new Uri("about:blank");
            }
            if (!string.IsNullOrEmpty(_tempFilePath) && File.Exists(_tempFilePath))
            {
                try
                {
                    File.Delete(_tempFilePath);
                }
                catch (Exception) { }
            }
        }
    }
}

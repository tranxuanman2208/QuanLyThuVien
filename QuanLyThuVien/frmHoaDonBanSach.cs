using Microsoft.Reporting.WinForms;
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
    public partial class frmHoaDonBanSach : Form
    {
        private string GD;
        public frmHoaDonBanSach(string GD)
        {
            InitializeComponent();
            this.GD = GD;
        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var hoadon = db.HoaDons.FirstOrDefault(hd => hd.MaGD == GD.Trim());
                List<Object> datahoadon = new List<object>();
                datahoadon.Add(hoadon);
                var sach = db.HoaDons.Where(hd => hd.MaGD == GD.Trim()).Select(s => s.Sach).ToList();
                this.reportviewHoaDonBanSach.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.HoaDonBanSach.rdlc";
                this.reportviewHoaDonBanSach.LocalReport.DataSources.Clear();
                ReportDataSource rshd = new ReportDataSource("HoaDon", datahoadon);
                this.reportviewHoaDonBanSach.LocalReport.DataSources.Add(rshd);
                ReportDataSource rssach = new ReportDataSource("Sach", sach);
                this.reportviewHoaDonBanSach.LocalReport.DataSources.Add(rssach);
                this.reportviewHoaDonBanSach.RefreshReport();
            }
        }
    }
}

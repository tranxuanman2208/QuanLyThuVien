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
    public partial class frmHoaDonNhapSach : Form
    {
        private string GD;
        public frmHoaDonNhapSach(string GD)
        {
            InitializeComponent();
            this.GD = GD;
        }

        private void frmHoaDonNhapSach_Load(object sender, EventArgs e)
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var hoadon = db.HoaDons.FirstOrDefault(hd => hd.MaGD == GD.Trim());
                List<object> datahoadon = new List<object>();
                datahoadon.Add(hoadon);
                var sach = db.HoaDons.Where(hd => hd.MaGD == GD.Trim()).Select(hd => hd.Sach).ToList();
                this.reportviewerHoaDonNhapSach.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.HoaDonNhapSach.rdlc";
                this.reportviewerHoaDonNhapSach.LocalReport.DataSources.Clear();
                ReportDataSource rshoadon = new ReportDataSource("HoaDon", datahoadon);
                this.reportviewerHoaDonNhapSach.LocalReport.DataSources.Add(rshoadon);
                ReportDataSource rssach = new ReportDataSource("Sach", sach);
                this.reportviewerHoaDonNhapSach.LocalReport.DataSources.Add(rssach);
                this.reportviewerHoaDonNhapSach.RefreshReport();
            }
        }
    }
}

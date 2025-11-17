namespace QuanLyThuVien
{
    partial class frmHoaDonNhapSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportviewerHoaDonNhapSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportviewerHoaDonNhapSach
            // 
            this.reportviewerHoaDonNhapSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportviewerHoaDonNhapSach.Location = new System.Drawing.Point(0, 0);
            this.reportviewerHoaDonNhapSach.Name = "reportviewerHoaDonNhapSach";
            this.reportviewerHoaDonNhapSach.ServerReport.BearerToken = null;
            this.reportviewerHoaDonNhapSach.Size = new System.Drawing.Size(800, 644);
            this.reportviewerHoaDonNhapSach.TabIndex = 0;
            // 
            // frmHoaDonNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.reportviewerHoaDonNhapSach);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDonNhapSach";
            this.Text = "frmHoaDonNhapSach";
            this.Load += new System.EventHandler(this.frmHoaDonNhapSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportviewerHoaDonNhapSach;
    }
}
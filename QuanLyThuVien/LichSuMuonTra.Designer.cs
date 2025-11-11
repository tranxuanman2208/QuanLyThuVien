namespace QuanLyThuVien
{
    partial class LichSuMuonTra
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayHenTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.NgayMuon,
            this.NgayHenTra,
            this.TrangThai});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(304, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 233);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã sách";
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            // 
            // NgayMuon
            // 
            this.NgayMuon.Text = "Ngày Mượn";
            // 
            // NgayHenTra
            // 
            this.NgayHenTra.Text = "Ngày Hẹn Trả";
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng thái";
            // 
            // LichSuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "LichSuMuonTra";
            this.Text = "LichSuMuonTra";
            this.Load += new System.EventHandler(this.LichSuMuonTra_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader NgayMuon;
        private System.Windows.Forms.ColumnHeader NgayHenTra;
        private System.Windows.Forms.ColumnHeader TrangThai;
    }
}
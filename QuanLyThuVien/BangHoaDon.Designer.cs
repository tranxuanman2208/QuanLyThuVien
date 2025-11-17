namespace QuanLyThuVien
{
    partial class BangHoaDon
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
            this.dtgvHienThi = new System.Windows.Forms.DataGridView();
            this.grHoaDon = new System.Windows.Forms.GroupBox();
            this.btnHoaDonNhapSach = new System.Windows.Forms.RadioButton();
            this.btnHoaDonBanSach = new System.Windows.Forms.RadioButton();
            this.btnXoaDuLieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).BeginInit();
            this.grHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHienThi
            // 
            this.dtgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHienThi.Location = new System.Drawing.Point(3, 18);
            this.dtgvHienThi.Name = "dtgvHienThi";
            this.dtgvHienThi.RowHeadersWidth = 51;
            this.dtgvHienThi.RowTemplate.Height = 24;
            this.dtgvHienThi.Size = new System.Drawing.Size(664, 428);
            this.dtgvHienThi.TabIndex = 0;
            // 
            // grHoaDon
            // 
            this.grHoaDon.Controls.Add(this.dtgvHienThi);
            this.grHoaDon.Location = new System.Drawing.Point(1, 61);
            this.grHoaDon.Name = "grHoaDon";
            this.grHoaDon.Size = new System.Drawing.Size(670, 449);
            this.grHoaDon.TabIndex = 1;
            this.grHoaDon.TabStop = false;
            // 
            // btnHoaDonNhapSach
            // 
            this.btnHoaDonNhapSach.AutoSize = true;
            this.btnHoaDonNhapSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhapSach.Location = new System.Drawing.Point(12, 21);
            this.btnHoaDonNhapSach.Name = "btnHoaDonNhapSach";
            this.btnHoaDonNhapSach.Size = new System.Drawing.Size(181, 26);
            this.btnHoaDonNhapSach.TabIndex = 2;
            this.btnHoaDonNhapSach.TabStop = true;
            this.btnHoaDonNhapSach.Text = "Hóa đơn nhập sách";
            this.btnHoaDonNhapSach.UseVisualStyleBackColor = true;
            this.btnHoaDonNhapSach.CheckedChanged += new System.EventHandler(this.btnNhapSach_CheckedChanged);
            // 
            // btnHoaDonBanSach
            // 
            this.btnHoaDonBanSach.AutoSize = true;
            this.btnHoaDonBanSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBanSach.Location = new System.Drawing.Point(225, 21);
            this.btnHoaDonBanSach.Name = "btnHoaDonBanSach";
            this.btnHoaDonBanSach.Size = new System.Drawing.Size(172, 26);
            this.btnHoaDonBanSach.TabIndex = 2;
            this.btnHoaDonBanSach.TabStop = true;
            this.btnHoaDonBanSach.Text = "Hóa đơn bán sách";
            this.btnHoaDonBanSach.UseVisualStyleBackColor = true;
            this.btnHoaDonBanSach.CheckedChanged += new System.EventHandler(this.btnHoaDonBanSach_CheckedChanged);
            // 
            // btnXoaDuLieu
            // 
            this.btnXoaDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDuLieu.Location = new System.Drawing.Point(434, 13);
            this.btnXoaDuLieu.Name = "btnXoaDuLieu";
            this.btnXoaDuLieu.Size = new System.Drawing.Size(207, 42);
            this.btnXoaDuLieu.TabIndex = 3;
            this.btnXoaDuLieu.Text = "Xóa toàn bộ dữ liệu";
            this.btnXoaDuLieu.UseVisualStyleBackColor = true;
            this.btnXoaDuLieu.Click += new System.EventHandler(this.btnXoaDuLieu_Click);
            // 
            // BangHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 509);
            this.Controls.Add(this.btnXoaDuLieu);
            this.Controls.Add(this.btnHoaDonBanSach);
            this.Controls.Add(this.btnHoaDonNhapSach);
            this.Controls.Add(this.grHoaDon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BangHoaDon";
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).EndInit();
            this.grHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHienThi;
        private System.Windows.Forms.GroupBox grHoaDon;
        private System.Windows.Forms.RadioButton btnHoaDonNhapSach;
        private System.Windows.Forms.RadioButton btnHoaDonBanSach;
        private System.Windows.Forms.Button btnXoaDuLieu;
    }
}
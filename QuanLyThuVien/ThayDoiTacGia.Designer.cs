namespace QuanLyThuVien
{
    partial class ThayDoiTacGia
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
            this.grThayDoiTacGia = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaSach_TenSach = new System.Windows.Forms.TextBox();
            this.txtNhapTacGiaMoi = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grThayDoiTacGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThayDoiTacGia
            // 
            this.grThayDoiTacGia.Controls.Add(this.btnCapNhat);
            this.grThayDoiTacGia.Controls.Add(this.txtMaSach_TenSach);
            this.grThayDoiTacGia.Controls.Add(this.txtNhapTacGiaMoi);
            this.grThayDoiTacGia.Controls.Add(this.btnTimKiem);
            this.grThayDoiTacGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThayDoiTacGia.Location = new System.Drawing.Point(12, 12);
            this.grThayDoiTacGia.Name = "grThayDoiTacGia";
            this.grThayDoiTacGia.Size = new System.Drawing.Size(629, 216);
            this.grThayDoiTacGia.TabIndex = 5;
            this.grThayDoiTacGia.TabStop = false;
            this.grThayDoiTacGia.Text = "Thay đổi tác giả";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(394, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 40);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaSach_TenSach
            // 
            this.txtMaSach_TenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach_TenSach.ForeColor = System.Drawing.Color.Gray;
            this.txtMaSach_TenSach.Location = new System.Drawing.Point(31, 58);
            this.txtMaSach_TenSach.Name = "txtMaSach_TenSach";
            this.txtMaSach_TenSach.Size = new System.Drawing.Size(254, 30);
            this.txtMaSach_TenSach.TabIndex = 0;
            this.txtMaSach_TenSach.Text = "Nhập mã sách hoặc tên sách";
            this.txtMaSach_TenSach.Enter += new System.EventHandler(this.txtMaSach_TenSach_Enter);
            this.txtMaSach_TenSach.Leave += new System.EventHandler(this.txtMaSach_TenSach_Leave);
            // 
            // txtNhapTacGiaMoi
            // 
            this.txtNhapTacGiaMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTacGiaMoi.ForeColor = System.Drawing.Color.Gray;
            this.txtNhapTacGiaMoi.Location = new System.Drawing.Point(31, 133);
            this.txtNhapTacGiaMoi.Name = "txtNhapTacGiaMoi";
            this.txtNhapTacGiaMoi.Size = new System.Drawing.Size(254, 30);
            this.txtNhapTacGiaMoi.TabIndex = 0;
            this.txtNhapTacGiaMoi.Text = "Nhập tên tác giả mới";
            this.txtNhapTacGiaMoi.Enter += new System.EventHandler(this.txtNhapTacGiaMoi_Enter);
            this.txtNhapTacGiaMoi.Leave += new System.EventHandler(this.txtNhapTacGiaMoi_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(394, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 40);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ThayDoiTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(651, 234);
            this.Controls.Add(this.grThayDoiTacGia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThayDoiTacGia";
            this.Text = "ThayDoiTacGia";
            this.Load += new System.EventHandler(this.ThayDoiTacGia_Load);
            this.grThayDoiTacGia.ResumeLayout(false);
            this.grThayDoiTacGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThayDoiTacGia;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaSach_TenSach;
        private System.Windows.Forms.TextBox txtNhapTacGiaMoi;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
namespace QuanLyThuVien
{
    partial class ThayDoiTheLoai
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
            this.grThayDoiTheLoai = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaSach_TenSach = new System.Windows.Forms.TextBox();
            this.txtNhapTheLoaiMoi = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grThayDoiTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThayDoiTheLoai
            // 
            this.grThayDoiTheLoai.Controls.Add(this.btnCapNhat);
            this.grThayDoiTheLoai.Controls.Add(this.txtMaSach_TenSach);
            this.grThayDoiTheLoai.Controls.Add(this.txtNhapTheLoaiMoi);
            this.grThayDoiTheLoai.Controls.Add(this.btnTimKiem);
            this.grThayDoiTheLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThayDoiTheLoai.Location = new System.Drawing.Point(12, 12);
            this.grThayDoiTheLoai.Name = "grThayDoiTheLoai";
            this.grThayDoiTheLoai.Size = new System.Drawing.Size(629, 216);
            this.grThayDoiTheLoai.TabIndex = 5;
            this.grThayDoiTheLoai.TabStop = false;
            this.grThayDoiTheLoai.Text = "Thay đổi thể loại";
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
            // txtNhapTheLoaiMoi
            // 
            this.txtNhapTheLoaiMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTheLoaiMoi.ForeColor = System.Drawing.Color.Gray;
            this.txtNhapTheLoaiMoi.Location = new System.Drawing.Point(31, 133);
            this.txtNhapTheLoaiMoi.Name = "txtNhapTheLoaiMoi";
            this.txtNhapTheLoaiMoi.Size = new System.Drawing.Size(254, 30);
            this.txtNhapTheLoaiMoi.TabIndex = 0;
            this.txtNhapTheLoaiMoi.Text = "Nhập thể loại mới";
            this.txtNhapTheLoaiMoi.Enter += new System.EventHandler(this.txtNhapTheLoaiMoi_Enter);
            this.txtNhapTheLoaiMoi.Leave += new System.EventHandler(this.txtNhapTheLoaiMoi_Leave);
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
            // ThayDoiTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 240);
            this.Controls.Add(this.grThayDoiTheLoai);
            this.Name = "ThayDoiTheLoai";
            this.Text = "ThayDoiTheLoai";
            this.Load += new System.EventHandler(this.ThayDoiTheLoai_Load);
            this.grThayDoiTheLoai.ResumeLayout(false);
            this.grThayDoiTheLoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThayDoiTheLoai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaSach_TenSach;
        private System.Windows.Forms.TextBox txtNhapTheLoaiMoi;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
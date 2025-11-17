namespace QuanLyThuVien
{
    partial class ThayDoiTenSach
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
            this.grThayDoiTenSach = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaSach_TenSach = new System.Windows.Forms.TextBox();
            this.txtNhapTenSachMoi = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grThayDoiTenSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThayDoiTenSach
            // 
            this.grThayDoiTenSach.Controls.Add(this.btnCapNhat);
            this.grThayDoiTenSach.Controls.Add(this.txtMaSach_TenSach);
            this.grThayDoiTenSach.Controls.Add(this.txtNhapTenSachMoi);
            this.grThayDoiTenSach.Controls.Add(this.btnTimKiem);
            this.grThayDoiTenSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThayDoiTenSach.Location = new System.Drawing.Point(8, 10);
            this.grThayDoiTenSach.Name = "grThayDoiTenSach";
            this.grThayDoiTenSach.Size = new System.Drawing.Size(629, 216);
            this.grThayDoiTenSach.TabIndex = 3;
            this.grThayDoiTenSach.TabStop = false;
            this.grThayDoiTenSach.Text = "Thay đổi tên sách";
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
            // txtNhapTenSachMoi
            // 
            this.txtNhapTenSachMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenSachMoi.ForeColor = System.Drawing.Color.Gray;
            this.txtNhapTenSachMoi.Location = new System.Drawing.Point(31, 133);
            this.txtNhapTenSachMoi.Name = "txtNhapTenSachMoi";
            this.txtNhapTenSachMoi.Size = new System.Drawing.Size(254, 30);
            this.txtNhapTenSachMoi.TabIndex = 0;
            this.txtNhapTenSachMoi.Text = "Nhập tên sách mới";
            this.txtNhapTenSachMoi.Enter += new System.EventHandler(this.txtNhapTenSachMoi_Enter);
            this.txtNhapTenSachMoi.Leave += new System.EventHandler(this.txtNhapTenSachMoi_Leave);
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
            // ThayDoiTenSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 238);
            this.Controls.Add(this.grThayDoiTenSach);
            this.Name = "ThayDoiTenSach";
            this.Text = "ThayDoiTenSach";
            this.Load += new System.EventHandler(this.ThayDoiTenSach_Load);
            this.grThayDoiTenSach.ResumeLayout(false);
            this.grThayDoiTenSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThayDoiTenSach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaSach_TenSach;
        private System.Windows.Forms.TextBox txtNhapTenSachMoi;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
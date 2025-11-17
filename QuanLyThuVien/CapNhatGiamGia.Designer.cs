namespace QuanLyThuVien
{
    partial class CapNhatGiamGia
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
            this.txtMaSach_TenSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtPhanTramGiam = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grUpdateGiamGia = new System.Windows.Forms.GroupBox();
            this.grUpdateGiamGia.SuspendLayout();
            this.SuspendLayout();
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
            this.txtMaSach_TenSach.TextChanged += new System.EventHandler(this.txtMaSach_TenSach_TextChanged);
            this.txtMaSach_TenSach.Enter += new System.EventHandler(this.txtMaSach_TenSach_Enter);
            this.txtMaSach_TenSach.Leave += new System.EventHandler(this.txtMaSach_TenSach_Leave);
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
            // txtPhanTramGiam
            // 
            this.txtPhanTramGiam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramGiam.ForeColor = System.Drawing.Color.Gray;
            this.txtPhanTramGiam.Location = new System.Drawing.Point(31, 133);
            this.txtPhanTramGiam.Name = "txtPhanTramGiam";
            this.txtPhanTramGiam.Size = new System.Drawing.Size(254, 30);
            this.txtPhanTramGiam.TabIndex = 0;
            this.txtPhanTramGiam.Text = "Nhập phần trăm giảm";
            this.txtPhanTramGiam.Enter += new System.EventHandler(this.txtPhanTramGiam_Enter);
            this.txtPhanTramGiam.Leave += new System.EventHandler(this.txtPhanTramGiam_Leave);
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
            // grUpdateGiamGia
            // 
            this.grUpdateGiamGia.Controls.Add(this.btnCapNhat);
            this.grUpdateGiamGia.Controls.Add(this.txtMaSach_TenSach);
            this.grUpdateGiamGia.Controls.Add(this.txtPhanTramGiam);
            this.grUpdateGiamGia.Controls.Add(this.btnTimKiem);
            this.grUpdateGiamGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grUpdateGiamGia.Location = new System.Drawing.Point(9, 10);
            this.grUpdateGiamGia.Name = "grUpdateGiamGia";
            this.grUpdateGiamGia.Size = new System.Drawing.Size(629, 216);
            this.grUpdateGiamGia.TabIndex = 2;
            this.grUpdateGiamGia.TabStop = false;
            this.grUpdateGiamGia.Text = "Cập nhật giảm giá";
            // 
            // CapNhatGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(650, 238);
            this.Controls.Add(this.grUpdateGiamGia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapNhatGiamGia";
            this.Text = "CapNhatGiamGia";
            this.Load += new System.EventHandler(this.CapNhatGiamGia_Load);
            this.grUpdateGiamGia.ResumeLayout(false);
            this.grUpdateGiamGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSach_TenSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtPhanTramGiam;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox grUpdateGiamGia;
    }
}
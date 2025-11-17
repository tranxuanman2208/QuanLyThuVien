namespace QuanLyThuVien
{
    partial class LoaiBoSach
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
            this.txtNhapSachLoaiBo = new System.Windows.Forms.TextBox();
            this.btnTimKiemLBS = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbTonKho = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapSachLoaiBo
            // 
            this.txtNhapSachLoaiBo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSachLoaiBo.ForeColor = System.Drawing.Color.Gray;
            this.txtNhapSachLoaiBo.Location = new System.Drawing.Point(24, 39);
            this.txtNhapSachLoaiBo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapSachLoaiBo.Name = "txtNhapSachLoaiBo";
            this.txtNhapSachLoaiBo.Size = new System.Drawing.Size(426, 34);
            this.txtNhapSachLoaiBo.TabIndex = 10;
            this.txtNhapSachLoaiBo.Text = "Nhập mã sách...";
            this.txtNhapSachLoaiBo.Enter += new System.EventHandler(this.txtNhapSachLoaiBo_Enter);
            this.txtNhapSachLoaiBo.Leave += new System.EventHandler(this.txtNhapSachLoaiBo_Leave);
            // 
            // btnTimKiemLBS
            // 
            this.btnTimKiemLBS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLBS.Image = global::QuanLyThuVien.Properties.Resources.Magnifier;
            this.btnTimKiemLBS.Location = new System.Drawing.Point(472, 39);
            this.btnTimKiemLBS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemLBS.Name = "btnTimKiemLBS";
            this.btnTimKiemLBS.Size = new System.Drawing.Size(132, 34);
            this.btnTimKiemLBS.TabIndex = 11;
            this.btnTimKiemLBS.Text = "Tìm kiếm";
            this.btnTimKiemLBS.UseVisualStyleBackColor = true;
            this.btnTimKiemLBS.Click += new System.EventHandler(this.btnTimKiemLBS_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(197, 293);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(172, 46);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTenSach);
            this.groupBox1.Controls.Add(this.lbTonKho);
            this.groupBox1.Controls.Add(this.lbGia);
            this.groupBox1.Controls.Add(this.lbNXB);
            this.groupBox1.Controls.Add(this.lbMaSach);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnDatLai);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.txtNhapSachLoaiBo);
            this.groupBox1.Controls.Add(this.btnTimKiemLBS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(636, 471);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOẠI BỎ SÁCH";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(12, 174);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(101, 26);
            this.lbTenSach.TabIndex = 64;
            this.lbTenSach.Text = "Tên sách:";
            this.lbTenSach.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // lbTonKho
            // 
            this.lbTonKho.AutoSize = true;
            this.lbTonKho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTonKho.Location = new System.Drawing.Point(437, 174);
            this.lbTonKho.Name = "lbTonKho";
            this.lbTonKho.Size = new System.Drawing.Size(98, 26);
            this.lbTonKho.TabIndex = 64;
            this.lbTonKho.Text = "Tồn kho:";
            this.lbTonKho.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(183, 234);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(50, 26);
            this.lbGia.TabIndex = 64;
            this.lbGia.Text = "Giá:";
            this.lbGia.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(437, 95);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(64, 26);
            this.lbNXB.TabIndex = 64;
            this.lbNXB.Text = "NXB:";
            this.lbNXB.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(12, 95);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(94, 26);
            this.lbMaSach.TabIndex = 64;
            this.lbMaSach.Text = "Mã sách:";
            this.lbMaSach.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(345, 377);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 43);
            this.btnDong.TabIndex = 62;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLai.Location = new System.Drawing.Point(71, 377);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(151, 43);
            this.btnDatLai.TabIndex = 63;
            this.btnDatLai.Text = "ĐẶT LẠI";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LoaiBoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 470);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoaiBoSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI BỎ SÁCH";
            this.Load += new System.EventHandler(this.LoaiBoSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapSachLoaiBo;
        private System.Windows.Forms.Button btnTimKiemLBS;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Label lbTonKho;
        private System.Windows.Forms.Label lbGia;
    }
}
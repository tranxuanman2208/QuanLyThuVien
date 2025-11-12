namespace QuanLyThuVien
{
    partial class MuonSach
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
            this.txtMASACHTENSACH = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtUserKH = new System.Windows.Forms.TextBox();
            this.btnKiemTraUserKH = new System.Windows.Forms.Button();
            this.lbTonKho = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.lbNhapNgayMuon = new System.Windows.Forms.Label();
            this.dateHenTra = new System.Windows.Forms.DateTimePicker();
            this.lbNgayHenTra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMASACHTENSACH
            // 
            this.txtMASACHTENSACH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASACHTENSACH.Location = new System.Drawing.Point(76, 39);
            this.txtMASACHTENSACH.Name = "txtMASACHTENSACH";
            this.txtMASACHTENSACH.Size = new System.Drawing.Size(351, 34);
            this.txtMASACHTENSACH.TabIndex = 6;
            this.txtMASACHTENSACH.Text = "Nhập mã sách hoặc tên sách";
            this.txtMASACHTENSACH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Red;
            this.btnXacNhan.Location = new System.Drawing.Point(168, 363);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(168, 46);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtUserKH
            // 
            this.txtUserKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserKH.Location = new System.Drawing.Point(76, 100);
            this.txtUserKH.Name = "txtUserKH";
            this.txtUserKH.Size = new System.Drawing.Size(353, 34);
            this.txtUserKH.TabIndex = 6;
            this.txtUserKH.Text = "Nhập username khách hàng";
            this.txtUserKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKiemTraUserKH
            // 
            this.btnKiemTraUserKH.BackColor = System.Drawing.Color.White;
            this.btnKiemTraUserKH.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnKiemTraUserKH.FlatAppearance.BorderSize = 2;
            this.btnKiemTraUserKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraUserKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTraUserKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKiemTraUserKH.Location = new System.Drawing.Point(167, 149);
            this.btnKiemTraUserKH.Name = "btnKiemTraUserKH";
            this.btnKiemTraUserKH.Size = new System.Drawing.Size(168, 37);
            this.btnKiemTraUserKH.TabIndex = 7;
            this.btnKiemTraUserKH.Text = "Kiểm tra ";
            this.btnKiemTraUserKH.UseVisualStyleBackColor = false;
            this.btnKiemTraUserKH.Click += new System.EventHandler(this.btnKiemTraUserKH_Click);
            // 
            // lbTonKho
            // 
            this.lbTonKho.AutoSize = true;
            this.lbTonKho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTonKho.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTonKho.Location = new System.Drawing.Point(81, 215);
            this.lbTonKho.Name = "lbTonKho";
            this.lbTonKho.Size = new System.Drawing.Size(98, 26);
            this.lbTonKho.TabIndex = 10;
            this.lbTonKho.Text = "Tồn kho:";
            this.lbTonKho.Click += new System.EventHandler(this.lbTonKho_Click);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTrangThai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(334, 215);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(84, 26);
            this.lbTrangThai.TabIndex = 10;
            this.lbTrangThai.Text = "Kết quả";
            this.lbTrangThai.Click += new System.EventHandler(this.lbTrangThai_Click);
            // 
            // dateMuon
            // 
            this.dateMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMuon.Location = new System.Drawing.Point(224, 264);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(269, 30);
            this.dateMuon.TabIndex = 11;
            this.dateMuon.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // lbNhapNgayMuon
            // 
            this.lbNhapNgayMuon.AutoSize = true;
            this.lbNhapNgayMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapNgayMuon.Location = new System.Drawing.Point(18, 265);
            this.lbNhapNgayMuon.Name = "lbNhapNgayMuon";
            this.lbNhapNgayMuon.Size = new System.Drawing.Size(194, 25);
            this.lbNhapNgayMuon.TabIndex = 12;
            this.lbNhapNgayMuon.Text = "Nhập ngày mượn:";
            this.lbNhapNgayMuon.Click += new System.EventHandler(this.lbNhapNgayMuon_Click);
            // 
            // dateHenTra
            // 
            this.dateHenTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHenTra.Location = new System.Drawing.Point(224, 317);
            this.dateHenTra.Name = "dateHenTra";
            this.dateHenTra.Size = new System.Drawing.Size(269, 30);
            this.dateHenTra.TabIndex = 11;
            this.dateHenTra.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // lbNgayHenTra
            // 
            this.lbNgayHenTra.AutoSize = true;
            this.lbNgayHenTra.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayHenTra.Location = new System.Drawing.Point(5, 317);
            this.lbNgayHenTra.Name = "lbNgayHenTra";
            this.lbNgayHenTra.Size = new System.Drawing.Size(208, 25);
            this.lbNgayHenTra.TabIndex = 12;
            this.lbNgayHenTra.Text = "Nhập ngày hẹn trả:";
            this.lbNgayHenTra.Click += new System.EventHandler(this.lbNgayHenTra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNgayHenTra);
            this.groupBox1.Controls.Add(this.txtMASACHTENSACH);
            this.groupBox1.Controls.Add(this.lbNhapNgayMuon);
            this.groupBox1.Controls.Add(this.txtUserKH);
            this.groupBox1.Controls.Add(this.dateHenTra);
            this.groupBox1.Controls.Add(this.btnKiemTraUserKH);
            this.groupBox1.Controls.Add(this.dateMuon);
            this.groupBox1.Controls.Add(this.lbTonKho);
            this.groupBox1.Controls.Add(this.lbTrangThai);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 419);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MƯỢN SÁCH";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 423);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuonSach";
            this.Text = "Mượn Trả Sách";
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMASACHTENSACH;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtUserKH;
        private System.Windows.Forms.Button btnKiemTraUserKH;
        private System.Windows.Forms.Label lbTonKho;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.Label lbNhapNgayMuon;
        private System.Windows.Forms.DateTimePicker dateHenTra;
        private System.Windows.Forms.Label lbNgayHenTra;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
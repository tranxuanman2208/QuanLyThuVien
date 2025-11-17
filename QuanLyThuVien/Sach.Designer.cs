namespace QuanLyThuVien
{
    partial class Sach
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
            this.picSach = new System.Windows.Forms.PictureBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.btnBan = new System.Windows.Forms.Button();
            this.lbGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).BeginInit();
            this.SuspendLayout();
            // 
            // picSach
            // 
            this.picSach.Location = new System.Drawing.Point(41, 90);
            this.picSach.Name = "picSach";
            this.picSach.Size = new System.Drawing.Size(200, 300);
            this.picSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSach.TabIndex = 0;
            this.picSach.TabStop = false;
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(407, 361);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(102, 43);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Đọc sách";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.Location = new System.Drawing.Point(507, 299);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(107, 43);
            this.btnMuon.TabIndex = 1;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(344, 90);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(86, 22);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên sách:";
            this.lbTenSach.Click += new System.EventHandler(this.lbTenSach_Click);
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGia.Location = new System.Drawing.Point(344, 141);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(69, 22);
            this.lbTacGia.TabIndex = 2;
            this.lbTacGia.Text = "Tác giả";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(344, 198);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(118, 22);
            this.lbNXB.TabIndex = 2;
            this.lbNXB.Text = "Nhà xuất bản:";
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Location = new System.Drawing.Point(308, 299);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(102, 43);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bán sách";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(344, 247);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(45, 22);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá:";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.picSach);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSach;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Label lbGia;
    }
}
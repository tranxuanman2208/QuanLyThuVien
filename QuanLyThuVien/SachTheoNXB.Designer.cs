namespace QuanLyThuVien
{
    partial class SachTheoNXB
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
            this.components = new System.ComponentModel.Container();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listviewSach = new System.Windows.Forms.ListView();
            this.imgBox = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNXB
            // 
            this.txtNXB.ForeColor = System.Drawing.Color.Gray;
            this.txtNXB.Location = new System.Drawing.Point(15, 29);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(369, 30);
            this.txtNXB.TabIndex = 8;
            this.txtNXB.Text = "Nhập tên nhà xuất bản";
            this.txtNXB.Enter += new System.EventHandler(this.txtNXB_Enter);
            this.txtNXB.Leave += new System.EventHandler(this.txtNXB_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLyThuVien.Properties.Resources.Magnifier;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(390, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 51);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.groupBox2);
            this.groupbox.Controls.Add(this.groupBox1);
            this.groupbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(0, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(594, 506);
            this.groupbox.TabIndex = 13;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "SÁCH THEO NHÀ XUẤT BẢN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listviewSach);
            this.groupBox2.Location = new System.Drawing.Point(21, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 370);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // listviewSach
            // 
            this.listviewSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewSach.HideSelection = false;
            this.listviewSach.LargeImageList = this.imgBox;
            this.listviewSach.Location = new System.Drawing.Point(3, 26);
            this.listviewSach.Name = "listviewSach";
            this.listviewSach.Size = new System.Drawing.Size(535, 341);
            this.listviewSach.TabIndex = 0;
            this.listviewSach.UseCompatibleStateImageBehavior = false;
            this.listviewSach.ItemActivate += new System.EventHandler(this.listviewSach_ItemActivate);
            // 
            // imgBox
            // 
            this.imgBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgBox.ImageSize = new System.Drawing.Size(100, 150);
            this.imgBox.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SachTheoNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 521);
            this.Controls.Add(this.groupbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SachTheoNXB";
            this.Text = "SachTheoNXB";
            this.Load += new System.EventHandler(this.SachTheoNXB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listviewSach;
        private System.Windows.Forms.ImageList imgBox;
    }
}
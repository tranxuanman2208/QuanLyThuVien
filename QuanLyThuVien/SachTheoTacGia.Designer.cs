namespace QuanLyThuVien
{
    partial class SachTheoTenTacGia
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
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imagelistBox = new System.Windows.Forms.ImageList(this.components);
            this.lsBook = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(12, 29);
            this.txtTenTG.Multiline = true;
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(423, 37);
            this.txtTenTG.TabIndex = 12;
            this.txtTenTG.Text = "Nhập tên tác giả";
            this.txtTenTG.TextChanged += new System.EventHandler(this.txtTenTG_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(444, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 37);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // imagelistBox
            // 
            this.imagelistBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagelistBox.ImageSize = new System.Drawing.Size(100, 150);
            this.imagelistBox.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lsBook
            // 
            this.lsBook.HideSelection = false;
            this.lsBook.LargeImageList = this.imagelistBox;
            this.lsBook.Location = new System.Drawing.Point(35, 85);
            this.lsBook.Name = "lsBook";
            this.lsBook.Size = new System.Drawing.Size(500, 300);
            this.lsBook.TabIndex = 14;
            this.lsBook.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lsBook);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 388);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SÁCH THEO TÁC GIẢ";
            // 
            // SachTheoTenTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(599, 413);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SachTheoTenTacGia";
            this.Text = "Sách theo tên tác giả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imagelistBox;
        private System.Windows.Forms.ListView lsBook;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace QuanLyThuVien
{
    partial class SachTheoTheLoai
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
            this.grSachTheoTheLoai = new System.Windows.Forms.GroupBox();
            this.lbTHELOAI = new System.Windows.Forms.Label();
            this.LISTSACH = new System.Windows.Forms.ListView();
            this.imgBox = new System.Windows.Forms.ImageList(this.components);
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.grSachTheoTheLoai.SuspendLayout();
            this.gr2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSachTheoTheLoai
            // 
            this.grSachTheoTheLoai.Controls.Add(this.lbTHELOAI);
            this.grSachTheoTheLoai.Controls.Add(this.gr2);
            this.grSachTheoTheLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSachTheoTheLoai.Location = new System.Drawing.Point(0, 2);
            this.grSachTheoTheLoai.Name = "grSachTheoTheLoai";
            this.grSachTheoTheLoai.Size = new System.Drawing.Size(657, 446);
            this.grSachTheoTheLoai.TabIndex = 0;
            this.grSachTheoTheLoai.TabStop = false;
            this.grSachTheoTheLoai.Text = "SÁCH THEO THỂ LOẠI";
            // 
            // lbTHELOAI
            // 
            this.lbTHELOAI.AutoSize = true;
            this.lbTHELOAI.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHELOAI.Location = new System.Drawing.Point(21, 26);
            this.lbTHELOAI.Name = "lbTHELOAI";
            this.lbTHELOAI.Size = new System.Drawing.Size(105, 25);
            this.lbTHELOAI.TabIndex = 2;
            this.lbTHELOAI.Text = "Thể loại: ";
            // 
            // LISTSACH
            // 
            this.LISTSACH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTSACH.HideSelection = false;
            this.LISTSACH.LargeImageList = this.imgBox;
            this.LISTSACH.Location = new System.Drawing.Point(3, 26);
            this.LISTSACH.Name = "LISTSACH";
            this.LISTSACH.Size = new System.Drawing.Size(648, 357);
            this.LISTSACH.TabIndex = 0;
            this.LISTSACH.UseCompatibleStateImageBehavior = false;
            this.LISTSACH.ItemActivate += new System.EventHandler(this.LISTSACH_ItemActivate);
            // 
            // imgBox
            // 
            this.imgBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgBox.ImageSize = new System.Drawing.Size(100, 150);
            this.imgBox.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.LISTSACH);
            this.gr2.Location = new System.Drawing.Point(3, 54);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(654, 386);
            this.gr2.TabIndex = 3;
            this.gr2.TabStop = false;
            // 
            // SachTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.grSachTheoTheLoai);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SachTheoTheLoai";
            this.Text = "Sách theo thể loại";
            this.Load += new System.EventHandler(this.SachTheoTheLoai_Load);
            this.grSachTheoTheLoai.ResumeLayout(false);
            this.grSachTheoTheLoai.PerformLayout();
            this.gr2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grSachTheoTheLoai;
        private System.Windows.Forms.ListView LISTSACH;
        private System.Windows.Forms.ImageList imgBox;
        private System.Windows.Forms.Label lbTHELOAI;
        private System.Windows.Forms.GroupBox gr2;
    }
}
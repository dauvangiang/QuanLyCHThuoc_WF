namespace QuanLyCHThuoc.BUL
{
    partial class Form_Home
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
            this.txt_THONGK = new System.Windows.Forms.Label();
            this.Ico_ThongKe = new System.Windows.Forms.PictureBox();
            this.Ico_BanHang = new System.Windows.Forms.PictureBox();
            this.txt_BH = new System.Windows.Forms.Label();
            this.Ico_SanPham = new System.Windows.Forms.PictureBox();
            this.txt_KH = new System.Windows.Forms.Label();
            this.txt_KT = new System.Windows.Forms.Label();
            this.Ico_KhachHang = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnVịĐốiTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ico_Logo = new System.Windows.Forms.PictureBox();
            this.Txt_NameCH = new System.Windows.Forms.Label();
            this.Spl_1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_BanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_KhachHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spl_1)).BeginInit();
            this.Spl_1.Panel1.SuspendLayout();
            this.Spl_1.Panel2.SuspendLayout();
            this.Spl_1.SuspendLayout();
            this.SuspendLayout();
            //
            // txt_THONGK
            // 
            this.txt_THONGK.AutoSize = true;
            this.txt_THONGK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_THONGK.Location = new System.Drawing.Point(46, 297);
            this.txt_THONGK.Name = "txt_THONGK";
            this.txt_THONGK.Size = new System.Drawing.Size(82, 23);
            this.txt_THONGK.TabIndex = 1;
            this.txt_THONGK.Text = "Báo Cáo";
            this.txt_THONGK.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ico_ThongKe
            // 
            this.Ico_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ico_ThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ico_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ico_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ico_ThongKe.Image = global::QuanLyCHThuoc.Properties.Resources.analytics1;
            this.Ico_ThongKe.Location = new System.Drawing.Point(28, 185);
            this.Ico_ThongKe.Name = "Ico_ThongKe";
            this.Ico_ThongKe.Size = new System.Drawing.Size(123, 109);
            this.Ico_ThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ico_ThongKe.TabIndex = 0;
            this.Ico_ThongKe.TabStop = false;
            // 
            // Ico_BanHang
            // 
            this.Ico_BanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ico_BanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ico_BanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ico_BanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ico_BanHang.Image = global::QuanLyCHThuoc.Properties.Resources.grocery_cart;
            this.Ico_BanHang.Location = new System.Drawing.Point(28, 12);
            this.Ico_BanHang.Name = "Ico_BanHang";
            this.Ico_BanHang.Size = new System.Drawing.Size(123, 109);
            this.Ico_BanHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ico_BanHang.TabIndex = 0;
            this.Ico_BanHang.TabStop = false;
            this.Ico_BanHang.Click += new System.EventHandler(this.Ico_BanHang_Click);
            // 
            // txt_BH
            // 
            this.txt_BH.AutoSize = true;
            this.txt_BH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_BH.Location = new System.Drawing.Point(46, 124);
            this.txt_BH.Name = "txt_BH";
            this.txt_BH.Size = new System.Drawing.Size(93, 23);
            this.txt_BH.TabIndex = 1;
            this.txt_BH.Text = "Bán Hàng";
            this.txt_BH.Click += new System.EventHandler(this.txt_BH_Click);
            // 
            // Ico_SanPham
            // 
            this.Ico_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ico_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ico_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ico_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ico_SanPham.Image = global::QuanLyCHThuoc.Properties.Resources.medicine;
            this.Ico_SanPham.Location = new System.Drawing.Point(217, 12);
            this.Ico_SanPham.Name = "Ico_SanPham";
            this.Ico_SanPham.Size = new System.Drawing.Size(119, 109);
            this.Ico_SanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ico_SanPham.TabIndex = 0;
            this.Ico_SanPham.TabStop = false;
            this.Ico_SanPham.Click += new System.EventHandler(this.Ico_SanPham_Click);
            // 
            // txt_KH
            // 
            this.txt_KH.AutoSize = true;
            this.txt_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KH.Location = new System.Drawing.Point(411, 124);
            this.txt_KH.Name = "txt_KH";
            this.txt_KH.Size = new System.Drawing.Size(113, 23);
            this.txt_KH.TabIndex = 1;
            this.txt_KH.Text = "Khách Hàng";
            // 
            // txt_KT
            // 
            this.txt_KT.AutoSize = true;
            this.txt_KT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KT.Location = new System.Drawing.Point(225, 124);
            this.txt_KT.Name = "txt_KT";
            this.txt_KT.Size = new System.Drawing.Size(101, 23);
            this.txt_KT.TabIndex = 1;
            this.txt_KT.Text = "Kho Thuốc";
            // 
            // Ico_KhachHang
            // 
            this.Ico_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ico_KhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ico_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ico_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ico_KhachHang.Image = global::QuanLyCHThuoc.Properties.Resources.rating;
            this.Ico_KhachHang.Location = new System.Drawing.Point(405, 12);
            this.Ico_KhachHang.Name = "Ico_KhachHang";
            this.Ico_KhachHang.Size = new System.Drawing.Size(119, 109);
            this.Ico_KhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ico_KhachHang.TabIndex = 0;
            this.Ico_KhachHang.TabStop = false;
            this.Ico_KhachHang.Click += new System.EventHandler(this.Ico_KhachHang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(581, 61);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHànhToolStripMenuItem,
            this.khoThuốcToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::QuanLyCHThuoc.Properties.Resources.menu;
            this.menuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 57);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // bánHànhToolStripMenuItem
            // 
            this.bánHànhToolStripMenuItem.Name = "bánHànhToolStripMenuItem";
            this.bánHànhToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.bánHànhToolStripMenuItem.Text = "Bán Hàng";
            // 
            // khoThuốcToolStripMenuItem
            // 
            this.khoThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.phânLoạiToolStripMenuItem,
            this.đơnVịĐốiTácToolStripMenuItem});
            this.khoThuốcToolStripMenuItem.Name = "khoThuốcToolStripMenuItem";
            this.khoThuốcToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.khoThuốcToolStripMenuItem.Text = "Kho Thuốc";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm ";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục ";
            // 
            // phânLoạiToolStripMenuItem
            // 
            this.phânLoạiToolStripMenuItem.Name = "phânLoạiToolStripMenuItem";
            this.phânLoạiToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.phânLoạiToolStripMenuItem.Text = "Phân Loại";
            // 
            // đơnVịĐốiTácToolStripMenuItem
            // 
            this.đơnVịĐốiTácToolStripMenuItem.Name = "đơnVịĐốiTácToolStripMenuItem";
            this.đơnVịĐốiTácToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.đơnVịĐốiTácToolStripMenuItem.Text = "Đơn Vị Đối Tác";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo ";
            // 
            // Ico_Logo
            // 
            this.Ico_Logo.BackgroundImage = global::QuanLyCHThuoc.Properties.Resources.Ảnh_chụp_màn_hình_2024_02_20_204012;
            this.Ico_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ico_Logo.Location = new System.Drawing.Point(10, 3);
            this.Ico_Logo.Name = "Ico_Logo";
            this.Ico_Logo.Size = new System.Drawing.Size(59, 50);
            this.Ico_Logo.TabIndex = 0;
            this.Ico_Logo.TabStop = false;
            // 
            // Txt_NameCH
            // 
            this.Txt_NameCH.AutoSize = true;
            this.Txt_NameCH.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Txt_NameCH.Location = new System.Drawing.Point(75, 16);
            this.Txt_NameCH.Name = "Txt_NameCH";
            this.Txt_NameCH.Size = new System.Drawing.Size(203, 27);
            this.Txt_NameCH.TabIndex = 1;
            this.Txt_NameCH.Text = "Cửa Hàng Thuốc TG";
            // 
            // Spl_1
            // 
            this.Spl_1.AllowDrop = true;
            this.Spl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Spl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spl_1.Location = new System.Drawing.Point(0, 0);
            this.Spl_1.Name = "Spl_1";
            this.Spl_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Spl_1.Panel1
            // 
            this.Spl_1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Spl_1.Panel1.Controls.Add(this.Txt_NameCH);
            this.Spl_1.Panel1.Controls.Add(this.Ico_Logo);
            this.Spl_1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // Spl_1.Panel2
            // 
            this.Spl_1.Panel2.BackColor = System.Drawing.Color.White;
            this.Spl_1.Panel2.Controls.Add(this.Ico_SanPham);
            this.Spl_1.Panel2.Controls.Add(this.txt_THONGK);
            this.Spl_1.Panel2.Controls.Add(this.txt_KT);
            this.Spl_1.Panel2.Controls.Add(this.txt_KH);
            this.Spl_1.Panel2.Controls.Add(this.txt_BH);
            this.Spl_1.Panel2.Controls.Add(this.Ico_KhachHang);
            this.Spl_1.Panel2.Controls.Add(this.Ico_ThongKe);
            this.Spl_1.Panel2.Controls.Add(this.Ico_BanHang);
            this.Spl_1.Size = new System.Drawing.Size(585, 463);
            this.Spl_1.SplitterDistance = 65;
            this.Spl_1.TabIndex = 0;
            // 
            // Form_Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 463);
            this.Controls.Add(this.Spl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ico_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_BanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_KhachHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_Logo)).EndInit();
            this.Spl_1.Panel1.ResumeLayout(false);
            this.Spl_1.Panel1.PerformLayout();
            this.Spl_1.Panel2.ResumeLayout(false);
            this.Spl_1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spl_1)).EndInit();
            this.Spl_1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.Label txt_THONGK;
        private System.Windows.Forms.PictureBox Ico_ThongKe;
        private System.Windows.Forms.PictureBox Ico_BanHang;
        private System.Windows.Forms.Label txt_BH;
        private System.Windows.Forms.PictureBox Ico_SanPham;
        private System.Windows.Forms.Label txt_KH;
        private System.Windows.Forms.Label txt_KT;
        private System.Windows.Forms.PictureBox Ico_KhachHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox Ico_Logo;
        private System.Windows.Forms.Label Txt_NameCH;
        private System.Windows.Forms.SplitContainer Spl_1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnVịĐốiTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.Txt_NameCH = new System.Windows.Forms.Label();
            this.Spl_1 = new System.Windows.Forms.SplitContainer();
            this.Ico_Logo = new System.Windows.Forms.PictureBox();
            this.button_KhachHang = new System.Windows.Forms.Button();
            this.button_KhoThuoc = new System.Windows.Forms.Button();
            this.button_BaoCao = new System.Windows.Forms.Button();
            this.button_BanHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Spl_1)).BeginInit();
            this.Spl_1.Panel1.SuspendLayout();
            this.Spl_1.Panel2.SuspendLayout();
            this.Spl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_NameCH
            // 
            this.Txt_NameCH.AutoSize = true;
            this.Txt_NameCH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_NameCH.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Txt_NameCH.Location = new System.Drawing.Point(75, 20);
            this.Txt_NameCH.Name = "Txt_NameCH";
            this.Txt_NameCH.Size = new System.Drawing.Size(191, 27);
            this.Txt_NameCH.TabIndex = 1;
            this.Txt_NameCH.Text = "Cửa hàng thuốc TG";
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
            // 
            // Spl_1.Panel2
            // 
            this.Spl_1.Panel2.BackColor = System.Drawing.Color.White;
            this.Spl_1.Panel2.Controls.Add(this.button_KhachHang);
            this.Spl_1.Panel2.Controls.Add(this.button_KhoThuoc);
            this.Spl_1.Panel2.Controls.Add(this.button_BaoCao);
            this.Spl_1.Panel2.Controls.Add(this.button_BanHang);
            this.Spl_1.Size = new System.Drawing.Size(736, 548);
            this.Spl_1.SplitterDistance = 74;
            this.Spl_1.TabIndex = 0;
            // 
            // Ico_Logo
            // 
            this.Ico_Logo.BackgroundImage = global::QuanLyCHThuoc.Properties.Resources.Ảnh_chụp_màn_hình_2024_02_20_204012;
            this.Ico_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ico_Logo.Location = new System.Drawing.Point(10, 10);
            this.Ico_Logo.Name = "Ico_Logo";
            this.Ico_Logo.Size = new System.Drawing.Size(59, 50);
            this.Ico_Logo.TabIndex = 0;
            this.Ico_Logo.TabStop = false;
            // 
            // button_KhachHang
            // 
            this.button_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.button_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_KhachHang.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.button_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("button_KhachHang.Image")));
            this.button_KhachHang.Location = new System.Drawing.Point(492, 29);
            this.button_KhachHang.Name = "button_KhachHang";
            this.button_KhachHang.Size = new System.Drawing.Size(168, 169);
            this.button_KhachHang.TabIndex = 0;
            this.button_KhachHang.Text = "Khách hàng";
            this.button_KhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_KhachHang.UseVisualStyleBackColor = false;
            this.button_KhachHang.Click += new System.EventHandler(this.button_KhachHang_Click);
            // 
            // button_KhoThuoc
            // 
            this.button_KhoThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.button_KhoThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_KhoThuoc.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.button_KhoThuoc.Image = ((System.Drawing.Image)(resources.GetObject("button_KhoThuoc.Image")));
            this.button_KhoThuoc.Location = new System.Drawing.Point(271, 29);
            this.button_KhoThuoc.Name = "button_KhoThuoc";
            this.button_KhoThuoc.Size = new System.Drawing.Size(168, 169);
            this.button_KhoThuoc.TabIndex = 0;
            this.button_KhoThuoc.Text = "Kho thuốc";
            this.button_KhoThuoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_KhoThuoc.UseVisualStyleBackColor = false;
            this.button_KhoThuoc.Click += new System.EventHandler(this.button_KhoThuoc_Click);
            // 
            // button_BaoCao
            // 
            this.button_BaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.button_BaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BaoCao.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.button_BaoCao.Image = global::QuanLyCHThuoc.Properties.Resources.report;
            this.button_BaoCao.Location = new System.Drawing.Point(43, 259);
            this.button_BaoCao.Name = "button_BaoCao";
            this.button_BaoCao.Size = new System.Drawing.Size(168, 169);
            this.button_BaoCao.TabIndex = 0;
            this.button_BaoCao.Text = "Báo cáo";
            this.button_BaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_BaoCao.UseVisualStyleBackColor = false;
            this.button_BaoCao.Click += new System.EventHandler(this.button_BaoCao_Click);
            // 
            // button_BanHang
            // 
            this.button_BanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.button_BanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BanHang.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.button_BanHang.Image = global::QuanLyCHThuoc.Properties.Resources.add_to_cart1;
            this.button_BanHang.Location = new System.Drawing.Point(43, 29);
            this.button_BanHang.Name = "button_BanHang";
            this.button_BanHang.Size = new System.Drawing.Size(168, 169);
            this.button_BanHang.TabIndex = 0;
            this.button_BanHang.Text = "Bán hàng";
            this.button_BanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_BanHang.UseVisualStyleBackColor = false;
            this.button_BanHang.Click += new System.EventHandler(this.button_BanHang_Click);
            // 
            // Form_Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 548);
            this.Controls.Add(this.Spl_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Spl_1.Panel1.ResumeLayout(false);
            this.Spl_1.Panel1.PerformLayout();
            this.Spl_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spl_1)).EndInit();
            this.Spl_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ico_Logo)).EndInit();
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
        private System.Windows.Forms.PictureBox Ico_Logo;
        private System.Windows.Forms.Label Txt_NameCH;
        private System.Windows.Forms.SplitContainer Spl_1;
        private System.Windows.Forms.Button button_KhachHang;
        private System.Windows.Forms.Button button_KhoThuoc;
        private System.Windows.Forms.Button button_BanHang;
        private System.Windows.Forms.Button button_BaoCao;
    }
}
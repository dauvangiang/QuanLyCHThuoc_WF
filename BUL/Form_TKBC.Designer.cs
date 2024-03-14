namespace QuanLyCHThuoc
{
    partial class Form_TKBC
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
            this.dgvTKBC = new System.Windows.Forms.DataGridView();
            this.txt_Time = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_NoiDung = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKBC
            // 
            this.dgvTKBC.AllowUserToAddRows = false;
            this.dgvTKBC.AllowUserToDeleteRows = false;
            this.dgvTKBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKBC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTKBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKBC.Location = new System.Drawing.Point(12, 140);
            this.dgvTKBC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTKBC.Name = "dgvTKBC";
            this.dgvTKBC.ReadOnly = true;
            this.dgvTKBC.RowHeadersWidth = 51;
            this.dgvTKBC.RowTemplate.Height = 24;
            this.dgvTKBC.Size = new System.Drawing.Size(881, 471);
            this.dgvTKBC.TabIndex = 5;
            // 
            // txt_Time
            // 
            this.txt_Time.AutoSize = true;
            this.txt_Time.Font = new System.Drawing.Font("Arial", 10.4F);
            this.txt_Time.Location = new System.Drawing.Point(7, 63);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(92, 21);
            this.txt_Time.TabIndex = 1;
            this.txt_Time.Text = "Thời gian:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(100, 88);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label2.Location = new System.Drawing.Point(319, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến: ";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(378, 88);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayKT.TabIndex = 3;
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.BackColor = System.Drawing.Color.White;
            this.button_XacNhan.Font = new System.Drawing.Font("Arial", 10.4F);
            this.button_XacNhan.Location = new System.Drawing.Point(660, 20);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(104, 37);
            this.button_XacNhan.TabIndex = 4;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = false;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nội dung:";
            // 
            // comboBox_NoiDung
            // 
            this.comboBox_NoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NoiDung.FormattingEnabled = true;
            this.comboBox_NoiDung.Items.AddRange(new object[] {
            "Thống Kê Doanh Thu",
            "Thống Kê Hàng Tồn"});
            this.comboBox_NoiDung.Location = new System.Drawing.Point(100, 20);
            this.comboBox_NoiDung.Name = "comboBox_NoiDung";
            this.comboBox_NoiDung.Size = new System.Drawing.Size(458, 27);
            this.comboBox_NoiDung.TabIndex = 1;
            // 
            // Form_TKBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(904, 624);
            this.Controls.Add(this.comboBox_NoiDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.dgvTKBC);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_TKBC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.Form_TKBC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKBC;
        private System.Windows.Forms.Label txt_Time;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button button_XacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_NoiDung;
    }
}
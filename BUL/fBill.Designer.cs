using System.Windows.Forms;

namespace QuanLyCHThuoc.BUL
{
    partial class fBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHuyHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btXuatHD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTraLai = new System.Windows.Forms.TextBox();
            this.tbTongTT = new System.Windows.Forms.TextBox();
            this.tbKHDua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPhaiTT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDsSPHD = new System.Windows.Forms.DataGridView();
            this.clNameMedicine = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuanty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIntoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNgayMua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSdtKH = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSPHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.btHuyHD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btXuatHD);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbNgayMua);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbSdtKH);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbSoHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 10.4F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 634);
            this.panel1.TabIndex = 0;
            // 
            // btHuyHD
            // 
            this.btHuyHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btHuyHD.BackColor = System.Drawing.Color.White;
            this.btHuyHD.ForeColor = System.Drawing.Color.Red;
            this.btHuyHD.Location = new System.Drawing.Point(804, 575);
            this.btHuyHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHuyHD.Name = "btHuyHD";
            this.btHuyHD.Size = new System.Drawing.Size(79, 37);
            this.btHuyHD.TabIndex = 22;
            this.btHuyHD.Text = "Hủy";
            this.btHuyHD.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(413, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "HÓA ĐƠN";
            // 
            // btXuatHD
            // 
            this.btXuatHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btXuatHD.BackColor = System.Drawing.Color.White;
            this.btXuatHD.Location = new System.Drawing.Point(719, 575);
            this.btXuatHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXuatHD.Name = "btXuatHD";
            this.btXuatHD.Size = new System.Drawing.Size(79, 37);
            this.btXuatHD.TabIndex = 16;
            this.btXuatHD.Text = "Xuất HD";
            this.btXuatHD.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbGiamGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbTraLai);
            this.groupBox1.Controls.Add(this.tbTongTT);
            this.groupBox1.Controls.Add(this.tbKHDua);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbPhaiTT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 444);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(874, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán:";
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGiamGia.BackColor = System.Drawing.SystemColors.Window;
            this.tbGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGiamGia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiamGia.Location = new System.Drawing.Point(325, 38);
            this.tbGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.ReadOnly = true;
            this.tbGiamGia.Size = new System.Drawing.Size(129, 27);
            this.tbGiamGia.TabIndex = 12;
            this.tbGiamGia.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label10.Location = new System.Drawing.Point(20, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tổng:";
            // 
            // tbTraLai
            // 
            this.tbTraLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTraLai.BackColor = System.Drawing.SystemColors.Window;
            this.tbTraLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTraLai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTraLai.Location = new System.Drawing.Point(325, 75);
            this.tbTraLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTraLai.Name = "tbTraLai";
            this.tbTraLai.ReadOnly = true;
            this.tbTraLai.Size = new System.Drawing.Size(129, 27);
            this.tbTraLai.TabIndex = 15;
            this.tbTraLai.TabStop = false;
            // 
            // tbTongTT
            // 
            this.tbTongTT.BackColor = System.Drawing.SystemColors.Window;
            this.tbTongTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTongTT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTT.Location = new System.Drawing.Point(114, 38);
            this.tbTongTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTongTT.Name = "tbTongTT";
            this.tbTongTT.ReadOnly = true;
            this.tbTongTT.Size = new System.Drawing.Size(129, 27);
            this.tbTongTT.TabIndex = 11;
            this.tbTongTT.TabStop = false;
            // 
            // tbKHDua
            // 
            this.tbKHDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKHDua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKHDua.Location = new System.Drawing.Point(114, 75);
            this.tbKHDua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKHDua.Name = "tbKHDua";
            this.tbKHDua.Size = new System.Drawing.Size(129, 27);
            this.tbKHDua.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label11.Location = new System.Drawing.Point(269, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Giảm:";
            // 
            // tbPhaiTT
            // 
            this.tbPhaiTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhaiTT.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhaiTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhaiTT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhaiTT.Location = new System.Drawing.Point(619, 38);
            this.tbPhaiTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhaiTT.Name = "tbPhaiTT";
            this.tbPhaiTT.ReadOnly = true;
            this.tbPhaiTT.Size = new System.Drawing.Size(129, 27);
            this.tbPhaiTT.TabIndex = 13;
            this.tbPhaiTT.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label12.Location = new System.Drawing.Point(487, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phải thanh toán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label13.Location = new System.Drawing.Point(20, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Khách đưa:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label14.Location = new System.Drawing.Point(269, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Trả lại:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvDsSPHD);
            this.panel2.Location = new System.Drawing.Point(10, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 218);
            this.panel2.TabIndex = 10;
            // 
            // dgvDsSPHD
            // 
            this.dgvDsSPHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsSPHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDsSPHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsSPHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNameMedicine,
            this.clUnit,
            this.clQuanty,
            this.clPrice,
            this.clIntoMoney,
            this.clNote});
            this.dgvDsSPHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsSPHD.Location = new System.Drawing.Point(0, 0);
            this.dgvDsSPHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDsSPHD.Name = "dgvDsSPHD";
            this.dgvDsSPHD.RowHeadersWidth = 51;
            this.dgvDsSPHD.RowTemplate.Height = 24;
            this.dgvDsSPHD.Size = new System.Drawing.Size(874, 218);
            this.dgvDsSPHD.TabIndex = 10;
            // 
            // clNameMedicine
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNameMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.clNameMedicine.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clNameMedicine.HeaderText = "Thuốc điều trị";
            this.clNameMedicine.Items.AddRange(new object[] {
            "Thuốc 1",
            "Thuốc 2",
            "Thuốc 3",
            "Thuốc 1",
            "Thuốc 2",
            "Thuốc 3"});
            this.clNameMedicine.MinimumWidth = 6;
            this.clNameMedicine.Name = "clNameMedicine";
            // 
            // clUnit
            // 
            this.clUnit.HeaderText = "Đơn vị";
            this.clUnit.MinimumWidth = 6;
            this.clUnit.Name = "clUnit";
            this.clUnit.ReadOnly = true;
            // 
            // clQuanty
            // 
            this.clQuanty.HeaderText = "S.Lượng";
            this.clQuanty.MinimumWidth = 6;
            this.clQuanty.Name = "clQuanty";
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Đơn giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // clIntoMoney
            // 
            this.clIntoMoney.HeaderText = "Thành tiền";
            this.clIntoMoney.MinimumWidth = 6;
            this.clIntoMoney.Name = "clIntoMoney";
            this.clIntoMoney.ReadOnly = true;
            // 
            // clNote
            // 
            this.clNote.HeaderText = "Ghi chú";
            this.clNote.MinimumWidth = 6;
            this.clNote.Name = "clNote";
            // 
            // tbNgayMua
            // 
            this.tbNgayMua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNgayMua.BackColor = System.Drawing.SystemColors.Window;
            this.tbNgayMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNgayMua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgayMua.Location = new System.Drawing.Point(594, 63);
            this.tbNgayMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNgayMua.Name = "tbNgayMua";
            this.tbNgayMua.ReadOnly = true;
            this.tbNgayMua.Size = new System.Drawing.Size(276, 27);
            this.tbNgayMua.TabIndex = 4;
            this.tbNgayMua.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label8.Location = new System.Drawing.Point(507, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày mua:";
            // 
            // tbSdtKH
            // 
            this.tbSdtKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSdtKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSdtKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdtKH.Location = new System.Drawing.Point(563, 155);
            this.tbSdtKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSdtKH.Name = "tbSdtKH";
            this.tbSdtKH.Size = new System.Drawing.Size(308, 27);
            this.tbSdtKH.TabIndex = 9;
            // 
            // tbTenKH
            // 
            this.tbTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(78, 155);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(308, 27);
            this.tbTenKH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label5.Location = new System.Drawing.Point(507, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label4.Location = new System.Drawing.Point(10, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên KH:";
            // 
            // tbSoHD
            // 
            this.tbSoHD.BackColor = System.Drawing.SystemColors.Window;
            this.tbSoHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoHD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoHD.Location = new System.Drawing.Point(110, 63);
            this.tbSoHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.ReadOnly = true;
            this.tbSoHD.Size = new System.Drawing.Size(276, 27);
            this.tbSoHD.TabIndex = 2;
            this.tbSoHD.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa hàng thuốc TG";
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(895, 634);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.4F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSPHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDsSPHD;
        private System.Windows.Forms.TextBox tbSdtKH;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTongTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTraLai;
        private System.Windows.Forms.TextBox tbKHDua;
        private System.Windows.Forms.TextBox tbPhaiTT;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private TextBox tbDateTime;
        private TextBox tbNgayMua;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button btXuatHD;
        private Button btHuyHD;
        private DataGridViewComboBoxColumn clNameMedicine;
        private DataGridViewTextBoxColumn clUnit;
        private DataGridViewTextBoxColumn clQuanty;
        private DataGridViewTextBoxColumn clPrice;
        private DataGridViewTextBoxColumn clIntoMoney;
        private DataGridViewTextBoxColumn clNote;
    }
}
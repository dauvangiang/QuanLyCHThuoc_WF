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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRefunds = new System.Windows.Forms.TextBox();
            this.tbMoneyGivenByGuests = new System.Windows.Forms.TextBox();
            this.tbNeedPayment = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSymptoms = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodeBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clNameMedicine = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuanty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIntoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbRefunds);
            this.panel1.Controls.Add(this.tbMoneyGivenByGuests);
            this.panel1.Controls.Add(this.tbNeedPayment);
            this.panel1.Controls.Add(this.tbDiscount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbDateTime);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbSymptoms);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.tbCustomer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCodeBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 10.4F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 803);
            this.panel1.TabIndex = 0;
            // 
            // tbRefunds
            // 
            this.tbRefunds.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefunds.Location = new System.Drawing.Point(581, 744);
            this.tbRefunds.Name = "tbRefunds";
            this.tbRefunds.ReadOnly = true;
            this.tbRefunds.Size = new System.Drawing.Size(182, 27);
            this.tbRefunds.TabIndex = 25;
            this.tbRefunds.TabStop = false;
            // 
            // tbMoneyGivenByGuests
            // 
            this.tbMoneyGivenByGuests.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoneyGivenByGuests.Location = new System.Drawing.Point(211, 744);
            this.tbMoneyGivenByGuests.Name = "tbMoneyGivenByGuests";
            this.tbMoneyGivenByGuests.Size = new System.Drawing.Size(182, 27);
            this.tbMoneyGivenByGuests.TabIndex = 24;
            // 
            // tbNeedPayment
            // 
            this.tbNeedPayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNeedPayment.Location = new System.Drawing.Point(887, 698);
            this.tbNeedPayment.Name = "tbNeedPayment";
            this.tbNeedPayment.ReadOnly = true;
            this.tbNeedPayment.Size = new System.Drawing.Size(227, 27);
            this.tbNeedPayment.TabIndex = 23;
            this.tbNeedPayment.TabStop = false;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(520, 698);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.ReadOnly = true;
            this.tbDiscount.Size = new System.Drawing.Size(106, 27);
            this.tbDiscount.TabIndex = 22;
            this.tbDiscount.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label14.Location = new System.Drawing.Point(457, 747);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Trả lại khách:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label13.Location = new System.Drawing.Point(65, 747);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Tiền khách đưa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label12.Location = new System.Drawing.Point(740, 701);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phải thanh toán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label11.Location = new System.Drawing.Point(457, 701);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Giảm:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(128, 698);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(227, 27);
            this.tbTotal.TabIndex = 17;
            this.tbTotal.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label10.Location = new System.Drawing.Point(65, 701);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tổng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thông tin thanh toán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label8.Location = new System.Drawing.Point(883, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày:";
            // 
            // tbDateTime
            // 
            this.tbDateTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateTime.Location = new System.Drawing.Point(946, 34);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.ReadOnly = true;
            this.tbDateTime.Size = new System.Drawing.Size(255, 27);
            this.tbDateTime.TabIndex = 13;
            this.tbDateTime.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNameMedicine,
            this.clUnit,
            this.clQuanty,
            this.clPrice,
            this.clIntoMoney,
            this.clNote});
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 434);
            this.dataGridView1.TabIndex = 12;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(821, 122);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(380, 27);
            this.tbAge.TabIndex = 11;
            // 
            // tbSymptoms
            // 
            this.tbSymptoms.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSymptoms.Location = new System.Drawing.Point(821, 163);
            this.tbSymptoms.Name = "tbSymptoms";
            this.tbSymptoms.Size = new System.Drawing.Size(380, 27);
            this.tbSymptoms.TabIndex = 10;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(86, 163);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(380, 27);
            this.tbPhoneNumber.TabIndex = 9;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(86, 122);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(380, 27);
            this.tbCustomer.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label7.Location = new System.Drawing.Point(703, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Triệu chứng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label6.Location = new System.Drawing.Point(703, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tuổi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(541, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ĐƠN THUỐC";
            // 
            // tbCodeBill
            // 
            this.tbCodeBill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeBill.Location = new System.Drawing.Point(118, 34);
            this.tbCodeBill.Name = "tbCodeBill";
            this.tbCodeBill.ReadOnly = true;
            this.tbCodeBill.Size = new System.Drawing.Size(255, 27);
            this.tbCodeBill.TabIndex = 2;
            this.tbCodeBill.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.4F);
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà thuốc";
            // 
            // clNameMedicine
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNameMedicine.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNameMedicine.HeaderText = "Thuốc điều trị";
            this.clNameMedicine.Items.AddRange(new object[] {
            "Thuốc 1",
            "Thuốc 2",
            "Thuốc 3"});
            this.clNameMedicine.MinimumWidth = 6;
            this.clNameMedicine.Name = "clNameMedicine";
            this.clNameMedicine.Width = 275;
            // 
            // clUnit
            // 
            this.clUnit.HeaderText = "Đơn vị";
            this.clUnit.MinimumWidth = 6;
            this.clUnit.Name = "clUnit";
            this.clUnit.ReadOnly = true;
            this.clUnit.Width = 72;
            // 
            // clQuanty
            // 
            this.clQuanty.HeaderText = "S.Lượng";
            this.clQuanty.MinimumWidth = 6;
            this.clQuanty.Name = "clQuanty";
            this.clQuanty.Width = 68;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Đơn giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 95;
            // 
            // clIntoMoney
            // 
            this.clIntoMoney.HeaderText = "Thành tiền";
            this.clIntoMoney.MinimumWidth = 6;
            this.clIntoMoney.Name = "clIntoMoney";
            this.clIntoMoney.ReadOnly = true;
            this.clIntoMoney.Width = 105;
            // 
            // clNote
            // 
            this.clNote.HeaderText = "Ghi chú";
            this.clNote.MinimumWidth = 6;
            this.clNote.Name = "clNote";
            this.clNote.Width = 235;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 827);
            this.Controls.Add(this.panel1);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán thuốc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodeBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSymptoms;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRefunds;
        private System.Windows.Forms.TextBox tbMoneyGivenByGuests;
        private System.Windows.Forms.TextBox tbNeedPayment;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DataGridViewComboBoxColumn clNameMedicine;
        private DataGridViewTextBoxColumn clUnit;
        private DataGridViewTextBoxColumn clQuanty;
        private DataGridViewTextBoxColumn clPrice;
        private DataGridViewTextBoxColumn clIntoMoney;
        private DataGridViewTextBoxColumn clNote;
    }
}
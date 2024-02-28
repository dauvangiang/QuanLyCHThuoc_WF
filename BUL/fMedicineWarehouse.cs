using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHThuoc.BUL
{
    public partial class fMedicineWarehouse : Form
    {
        public fMedicineWarehouse()
        {
            InitializeComponent();
            this.comboBox1.SelectedItem = "Tất cả";
            this.comboBox2.SelectedItem = "A → Z";
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            this.tbSearch.Text = "";
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (this.tbSearch.Text == "")
            {
                this.tbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
                this.tbSearch.Text = "Tìm kiếm...";
            }
        }
    }
}

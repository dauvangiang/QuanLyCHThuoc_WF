using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCHThuoc.BUL
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Ico_KhachHang_Click(object sender, EventArgs e)
        {
            Form_QLKH f = new Form_QLKH();
            f.Show();
        }

        private void Ico_BanHang_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.Show();
        }

        private void Ico_SanPham_Click(object sender, EventArgs e)
        {
            fMedicineWarehouse f = new fMedicineWarehouse();
            f.Show();
        }

        private void Ico_ThongKe_Click(object sender, EventArgs e)
        {
            Form_TKBC f = new Form_TKBC();
            f.Show();
        }
    }
}

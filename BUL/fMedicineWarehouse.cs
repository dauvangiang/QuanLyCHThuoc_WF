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
            //this.cbDanhMuc.SelectedItem = "Tất cả";
            //this.cbPhanLoai.SelectedItem = "A → Z";
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text == "Tìm kiếm...")
            {
                this.tbTimKiem.Text = "";
                this.tbTimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void tbTimKiem_Leave(object sender, EventArgs e)
        {
            if (this.tbTimKiem.Text == "")
            {
                this.tbTimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
                this.tbTimKiem.Text = "Tìm kiếm...";
            }
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            //Mở các đối tượng cho phép nhập/chọn thông tin
            //Ẩn và hiển thị các button phù hợp
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //Truy vấn dữ liệu từ database
            //Trả kết quả tìm kiếm lên DataGridView dgvDsSPKho
        }

        private void dgvDsSPKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đẩy dữ liệu từ các ô trong hàng lên các đối tượng trong grbChiTietSP
        }
    }
}

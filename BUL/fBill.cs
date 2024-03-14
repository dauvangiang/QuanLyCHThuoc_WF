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
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }

        private void btHuyHD_Click(object sender, EventArgs e)
        {
            //Hiển thị hộp thoại xác nhận hủy tạo hóa đơn
            var res = MessageBox.Show("Bạn có chắc chắn hủy?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btXuatHD_Click(object sender, EventArgs e)
        {
            setCodeAndDateOfBill(date: tbNgayMua);
            //Lưu thông tin KH vào bảng KhachHang

            //Lưu thông tin hóa đơn vào bảng HoaDon

            //Lưu thông tin chi tiết hóa đơn vào bảng ChiTietHD

        }

        //Hàm bổ trợ tạo số hóa đơn và ngày tự động
        private void setCodeAndDateOfBill(TextBox code = null, TextBox date = null)
        {
            //Tạo số hóa đơn tự động
            MessageBox.Show(DateTime.Now.ToString());
            //Hiển thị ngày mua tự động
            date.Text = DateTime.Now.ToString(" dd/MM/yyyy  HH:mm:ss");
        }
    }
}

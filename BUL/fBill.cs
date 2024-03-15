using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        #region Global variable

        private string sqlConnection = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = QUANLYCUAHANGTHUOC; Integrated Security = True";
        private SqlConnection conn = null;
        private bool sttKH = true; //Khách hàng mới
        private string tongDaMua = null;

        #endregion

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
                setCodeAndDateOfBill(tbSoHD, tbNgayMua);
                tbTenKH.Text = tbSdtKH.Text = tbKHDua.Text = "";
                tbTongTT.Text = tbGiamGia.Text = tbPhaiTT.Text = tbTraLai.Text = "0";
                dgvDsSPHD.Rows.Clear();
            }
        }

        private void btXuatHD_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlCommand cmd = null;

            //Lưu thông tin KH vào bảng KhachHang
            if (sttKH)
            {
                query = String.Format("Insert into KhachHang values (N'{0}', '{1}', '{2}')", tbTenKH.Text.Trim(), tbSdtKH.Text.Trim(), tbTongTT.Text);
            }
            else
            {
                tongDaMua = Convert.ToString(Convert.ToInt64(tbTongTT.Text) + Convert.ToInt64(tongDaMua));
                query = "Update KhachHang set TongDaMua = '" + tongDaMua + "' where SDT = '" + tbSdtKH.Text.Trim() + "'";
            }
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd = null;

            //Lưu thông tin hóa đơn vào bảng HoaDon
            string date = tbNgayMua.Text.Substring(6, 4) + "/" + tbNgayMua.Text.Substring(3, 2) + "/" + tbNgayMua.Text.Substring(0, 2);
            query = String.Format("Insert into HoaDon values ('{0}', '{1}', '{2}')", tbSoHD.Text.Trim(), date, tbSdtKH.Text.Trim());
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd = null;

            //Lưu thông tin chi tiết hóa đơn vào bảng ChiTietHD
            query = "Insert into ChiTietHD values";
            string value = null;
            for (int i = 0; i < dgvDsSPHD.Rows.Count - 1; i++)
            {
                string ghiChu = dgvDsSPHD.Rows[i].Cells[5].Value != null ? dgvDsSPHD.Rows[i].Cells[5].Value.ToString().Trim() : null;
                value = String.Format(" ('{0}', '{1}', '{2}', '{3}'),", tbSoHD.Text.Trim(), dgvDsSPHD.Rows[i].Cells[0].Value.ToString().Trim(), dgvDsSPHD.Rows[i].Cells[3].Value.ToString(), ghiChu);
                query += value;
            }
            query = query.Remove(query.Length - 1);
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd = null;

            setCodeAndDateOfBill(tbSoHD, tbNgayMua);
            tbTenKH.Text = tbSdtKH.Text = tbKHDua.Text = "";
            tbTongTT.Text = tbGiamGia.Text = tbPhaiTT.Text = tbTraLai.Text = "0";
            dgvDsSPHD.Rows.Clear();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            this.setCodeAndDateOfBill(tbSoHD, tbNgayMua);

            conn = new SqlConnection(sqlConnection);
            conn.Open();

            string query = "Select MaSP as [Mã số], TenSP as [Tên] from SanPham";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            clNameMedicine.DataSource = dt;
            clNameMedicine.DisplayMember = "Tên";
            clNameMedicine.ValueMember = "Mã số";
        }

        private void dgvDsSPHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0 && dgvDsSPHD.CurrentCell.Value.ToString() != "")
                {
                    string query = "Select DonViTinh, GiaBan from SanPham where MaSP = '" + dgvDsSPHD.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDsSPHD.Rows[e.RowIndex].Cells[1].Value = dt.Rows[0][0];
                    dgvDsSPHD.Rows[e.RowIndex].Cells[2].Value = Convert.ToString(Convert.ToInt32(dt.Rows[0][1]));
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0 && dgvDsSPHD.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    if (dgvDsSPHD.CurrentRow.Cells[3].Value.ToString() != "")
                    {
                        dgvDsSPHD.CurrentRow.Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvDsSPHD.CurrentRow.Cells[2].Value) * Convert.ToInt32(dgvDsSPHD.CurrentRow.Cells[3].Value));
                        tbTongTT.Text = Convert.ToString(Convert.ToInt32(tbTongTT.Text) + Convert.ToInt32(dgvDsSPHD.CurrentRow.Cells[4].Value));
                        tbPhaiTT.Text = Convert.ToString(Convert.ToInt32(tbTongTT.Text) - Convert.ToInt32(tbGiamGia.Text));
                    }
                    else
                    {
                        dgvDsSPHD.CurrentRow.Cells[4].Value = "";
                    }
                }
            }
        }

        private void tbKHDua_TextChanged(object sender, EventArgs e)
        {
            if (tbKHDua.Text == "")
            {
                return;
            }
            tbTraLai.Text = Convert.ToString(Convert.ToInt32(tbKHDua.Text) - Convert.ToInt32(tbPhaiTT.Text));
        }

        private void tbSdtKH_Leave(object sender, EventArgs e)
        {
            if (tbSdtKH.Text == "")
            {
                return;
            }
            string query = "Select TongDaMua from KhachHang where SDT = '" + tbSdtKH.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable(); da.Fill(dt);
            sttKH = dt.Rows.Count > 0 ? false : true;
            if (dt.Rows.Count > 0)
            {
                sttKH = false;
                long tmp = Convert.ToInt64(dt.Rows[0][0]);
                tongDaMua = Convert.ToString(tmp);
                if (tmp < 2000000) tbGiamGia.Text = "0";
                else if (tmp >= 2000000 && tmp < 5000000) tbGiamGia.Text = "7000";
                else if (tmp >= 5000000 && tmp < 8000000) tbGiamGia.Text = "12000";
                else if (tmp >= 8000000) tbGiamGia.Text = "20000";
            }
            else
            {
                sttKH = true;
                tongDaMua = null;
                tbGiamGia.Text = "0";
            }
        }

        //Tao số hóa đơn và ngày tự động
        private void setCodeAndDateOfBill(TextBox code = null, TextBox date = null)
        {
            DateTime now = DateTime.Now;
            //Tạo số hóa đơn tự động
            code.Text = now.Day.ToString() + now.Month.ToString() + now.Year.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            //Hiển thị ngày mua tự động
            date.Text = now.ToString("dd-MM-yyyy");
        }
    }
}

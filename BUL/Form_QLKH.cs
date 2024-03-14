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

namespace QuanLyCHThuoc
{
    public partial class Form_QLKH : Form
    {
        private DataTable htKH;
        string sqlConect = @"Data Source=LAPTOP-EOTGBTSV\SQLEXPRESS ;Initial Catalog = QLKhoThuoc ;Integrated Security = True";
        SqlConnection conn = null;

        public Form_QLKH()
        {
            InitializeComponent();
        }
        // Quan Ly khach hang
        void LoadData1()
        {
            string Command1 = "Select * from KhachHang";
            SqlDataAdapter daKH = new SqlDataAdapter(Command1, conn);
            htKH = new DataTable();
            daKH.Fill(htKH);
            dgvKhachHang.DataSource = htKH;
        }
        void LoadData2(string k)
        {
            string sdt = k;
            string Command2 = "SELECT  h.NgayMua, t.TenThuoc, cthd.SoLuong, k.TongTien FROM HoaDon h INNER JOIN ChiTietHD cthd ON h.SoDonThuoc = cthd.SoDonThuoc INNER JOIN Thuoc t ON cthd.MaThuoc = t.MaThuoc INNER JOIN KhachHang k ON h.SDT = k.SDT WHERE k.SDT = '" + sdt + "'";
            SqlDataAdapter daLS = new SqlDataAdapter(Command2, conn);
            DataTable htLS = new DataTable();
            daLS.Fill(htLS);
            dgvLichSu.DataSource = htLS;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string searchText = tbTimKiemKH.Text.Trim();

            // Truy vấn cơ sở dữ liệu để tìm kiếm khách hàng thích hợp
            string query = "SELECT * FROM KhachHang WHERE SDT LIKE @SearchText OR HoTenK LIKE @SearchText";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Kiểm tra xem có dữ liệu tìm thấy hay không
            if (dt.Rows.Count > 0)
            {
                // Hiển thị kết quả trong DataGridView
                dgvKhachHang.DataSource = dt;
            }
            else
            {
                // Hiển thị thông báo "Không tồn tại
                MessageBox.Show("Không tồn tại khách hàng với thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTimKiemKH.Text = "";
                //Hiển thị data ban đầuuu

                LoadData1();
            }
        }

        private void Form_QLKH_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConect);
            conn.Open();
            LoadData1();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                textBox_TenKH.Text = row.Cells["HoTenK"].Value.ToString();
                textBox_SdtKH.Text = row.Cells["SDT"].Value.ToString();
                LoadData2(textBox_SdtKH.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy thứ tự sắp xếp được chọn
            string sapxep = comboBox1.SelectedItem.ToString();

            // Sắp xếp DataGridView theo cột Họ tên
            if (sapxep == "Z-A")
            {
                
                dgvKhachHang.Sort(dgvKhachHang.Columns["HoTenK"], ListSortDirection.Descending);
                
            }
            else
            {
               
                dgvKhachHang.Sort(dgvKhachHang.Columns["HoTenK"], ListSortDirection.Ascending);
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ các TextBox
            string tenMoi = textBox_TenKH.Text;
            string sdtMoi = textBox_SdtKH.Text;
            if (tenMoi == "" || sdtMoi == "")
            {
                MessageBox.Show("Chưa chọn đối tượng hoặc để trống thông tin!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                // Lấy SDT của khách hàng cần sửa từ DataGridView
                string sdtCanSua = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();

                // Cập nhật thông tin trong cơ sở dữ liệu
                string query = "UPDATE KhachHang SET HoTenK = @HoTen, SDT = @SDT WHERE SDT = @SDTCanSua";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", tenMoi);
                cmd.Parameters.AddWithValue("@SDT", sdtMoi);
                cmd.Parameters.AddWithValue("@SDTCanSua", sdtCanSua);

                // Thực thi truy vấn cập nhật
                cmd.ExecuteNonQuery();

                // Cập nhật lại dữ liệu trên DataGridView
                LoadData1();

                MessageBox.Show("Thông tin khách hàng đã được cập nhật thành công.");
            }
           }
       

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy SDT của khách hàng cần xóa từ DataGridView
                string sdtCanXoa = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();

                // Xóa thông tin khách hàng từ cơ sở dữ liệu
                string query = "DELETE FROM KhachHang WHERE SDT = @SDTCanXoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SDTCanXoa", sdtCanXoa);
                cmd.ExecuteNonQuery();

                // Cập nhật lại dữ liệu trên DataGridView
                LoadData1();

                MessageBox.Show("Khách hàng đã được xóa thành công.");
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
    


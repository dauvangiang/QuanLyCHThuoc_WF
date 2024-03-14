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
using System.Data.SqlClient;

namespace QuanLyCHThuoc
{
    public partial class Form_TKBC : Form
    {
        string sqlConect = @"Data Source=LAPTOP-EOTGBTSV\SQLEXPRESS ;Initial Catalog = QLKhoThuoc ;Integrated Security = True";
        SqlConnection conn1 = null;

        public Form_TKBC()
        {
            InitializeComponent();
        }
        void LoadData3()
        {
            string NoiDung = comboBox_NoiDung.Text;
            DateTime NgayBatDau = dtpNgayBD.Value;
            DateTime NgayKetThuc = dtpNgayKT.Value;
            string Command3;
            NgayKetThuc.ToString();
            NgayBatDau.ToString();
            if (NoiDung == "Thống Kê Hàng Tồn")
            {
                Command3 = "SELECT Thuoc.TenThuoc, Thuoc.SlgCon, Thuoc.GiaBan, Thuoc.GiaNhap, Thuoc.DonViTinh FROM Thuoc;";
                }
            else {
                Command3 = "SELECT h.NgayMua, k.SDT AS SDT_KhachHang, " +
                           "SUM(t.GiaNhap * cthd.SoLuong) AS TongTienNhap, SUM(t.GiaBan * cthd.SoLuong) AS TongTienBan, " +
                           "SUM(t.GiaBan * cthd.SoLuong) - SUM(t.GiaNhap * cthd.SoLuong) AS TongLoiNhuan " +
                           "FROM HoaDon h INNER JOIN ChiTietHD cthd ON h.SoDonThuoc = cthd.SoDonThuoc " +
                           "INNER JOIN Thuoc t ON cthd.MaThuoc = t.MaThuoc INNER JOIN KhachHang k ON h.SDT = k.SDT " +
                           "WHERE h.NgayMua BETWEEN @NgayBatDau AND @NgayKetThuc " +
                           "GROUP BY h.NgayMua, k.SDT, t.TenThuoc, cthd.SoLuong;";  // Sử dụng tham số
            }


            // vì không sử dụng được cách dễ hơn như form qlkh lên phải gán:
                SqlDataAdapter daBCTK = new SqlDataAdapter(Command3, conn1);
                daBCTK.SelectCommand.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);  // Gán tham số
                daBCTK.SelectCommand.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);

                DataTable htBCTK = new DataTable();
                daBCTK.Fill(htBCTK);
                dgvTKBC.DataSource = htBCTK;
       
        }
        private void Form_TKBC_Load(object sender, EventArgs e)
        {
            conn1 = new SqlConnection(sqlConect);
            conn1.Open();
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            LoadData3();
        }
    }
}

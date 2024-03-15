using QuanLyCHThuoc.Data;
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
    public partial class fMedicineWarehouse : Form
    {
        #region Global variable

        string query = null;
        Button prevButton = null;
        SqlDataAdapter daSanPham = null, daDanhMuc = null, daPhanLoai = null, daNSX = null;
        public DataTable dtSanPham = null;
        DataTable dtDanhMuc = null, dtPhanLoai = null, dtNSX = null, dtDanhMucPL = null, dtDanhMucChiTiet = null, dtPhanLoaiChiTiet = null;
        string sqlConnection = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = QUANLYCUAHANGTHUOC; Integrated Security = True";
        SqlConnection conn = null;

        #endregion

        public fMedicineWarehouse()
        {
            InitializeComponent();
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
            panelTimKiem.Visible = lvTimKiem.Visible = false;
            if (this.tbTimKiem.Text == "")
            {
                this.tbTimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
                this.tbTimKiem.Text = "Tìm kiếm...";
            }
        }

        //Sự kiện click của các button thêm mới trong các tabpage
        private void btThem_Click(object sender, EventArgs e)
        {
            prevButton = null;
            TabPage tp = null;
            Button bt = (Button)sender;
            if (bt == btThemSP) tp = tpSanPham;
            else if (bt == btThemDanhMuc) tp = tpDanhMuc;
            else if (bt == btThemPhanLoai) tp = tpPhanLoai;
            else tp = tpDoiTac;

            //Hàm có chức năng mở các đối tượng cho phép nhập/chọn thông tin
            this.controlsStatus(tp, bt, 1);
            //Hàm làm rỗng các đối tượng
            this.setNull(tp);
        }

        //Sự kiện click của các button sửa trong các tabpage
        private void btSua_Click(object sender, EventArgs e)
        {
            prevButton = (Button)sender;
            TabPage tp = null;
            Button bt = (Button)sender;
            if (bt == btSuaSP) tp = tpSanPham;
            else if (bt == btSuaDanhMuc) tp = tpDanhMuc;
            else if (bt == btSuaPhanLoai) tp = tpPhanLoai;
            else tp = tpDoiTac;

            //Hàm có chức năng mở các đối tượng cho phép nhập/chọn thông tin
            this.controlsStatus(tp, bt, 1);
        }

        private void btXoaSp_Click(object sender, EventArgs e)
        {
            //Hiển thị hộp thoại xác nhận xóa
            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                query = "Delete from SanPham where MaSP = '" + this.tbMaSP.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    dtSanPham.Rows.Clear();
                    daSanPham.Fill(dtSanPham);
                    this.setNull(this.tpDanhMuc);
                    this.btXoaSp.Enabled = btSuaSP.Enabled = false;
                    this.btThemSP.Enabled = true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể xóa. Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            //Hển thị hộp thoại xác nhận hủy
            var res = MessageBox.Show("Bạn có chắc chắn hủy?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                TabPage tp = null;
                Button bt = (Button)sender;
                if (bt == btHuySP) tp = tpSanPham;
                else if (bt == btHuyDanhMuc) tp = tpDanhMuc;
                else if (bt == btHuyPhanLoai) tp = tpPhanLoai;
                else tp = tpDoiTac;

                this.controlsStatus(tp: tp, openOrClose: 0);
                this.setNull(tp, prevButton);
            }
        }

        private void btLuuSP_Click(object sender, EventArgs e)
        {
            string ma = tbMaSP.Text, ten = tbTenSP.Text, pl = cbPhanLoaiChiTiet.SelectedValue.ToString(), nsx = cbNhaSX.SelectedValue.ToString(), dv = tbDonViTinh.Text;
            string NSX = dtpNSX.Value.ToString(), HSD = dtpHSD.Value.ToString(), nhap = tbGiaNhap.Text, ban = tbGiaBan.Text, sl = tbSoLuongCon.Text, note = tbGhiChu.Text.Trim().Length != 0 ? tbGhiChu.Text.Trim() : null;
            if (prevButton == null)
            {
                query = String.Format("Insert into SanPham values ('{0}', N'{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}', N'{10}')", ma, ten, pl, nsx, dv, NSX, HSD, nhap, ban, sl, note);
            }
            else query = String.Format("Update SanPham set TenSP = N'{0}', MaPL = '{1}', MaNSX = '{2}', DonViTinh = N'{3}', NSX = '{4}', HSD = '{5}', GiaNhap = '{6}', GiaBan = '{7}', SoLuong = '{8}', GhiChu = N'{9}' where MaSP = '{10}'", ten, pl, nsx, dv, NSX, HSD, nhap, ban, sl, note, ma);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                dtSanPham.Rows.Clear();
                daSanPham.Fill(dtSanPham);
                this.controlsStatus(tp: this.tpSanPham, openOrClose: 0);
                this.setNull(tpSanPham);
            }
            catch (SqlException)
            {
                string message = prevButton == null ? "Không thể thêm dữ liệu." : "Không thể chỉnh sửa dữ liệu.";
                MessageBox.Show(message + " Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            cbDanhMuc.SelectedValue = cbPhanLoai.SelectedValue = "";
            query = "Select MaSP as [Mã số], TenSP as [Tên], TenDM as [Danh mục], TenPL as [Phân loại], TenNSX as [Sản phẩm của], DonViTinh as [Đơn vị], SP.NSX as [Ngày sản xuất], SP.HSD as [Hạn sử dụng], GiaNhap as [Giá nhập], GiaBan as [Giá bán], SoLuong as [Số lượng], GhiChu as [Ghi chú] " +
                " From SanPham SP, DanhMuc DM, PhanLoai PL, NSX " +
                " Where TenSP like N'" + tbTimKiem.Text.Trim() + "%' and SP.MaPL = PL.MaPL and PL.MaDM = DM.MaDM and SP.MaNSX = NSX.MaNSX";
            daSanPham = new SqlDataAdapter(query, conn);
            dtSanPham.Rows.Clear();
            daSanPham.Fill(dtSanPham);
        }

        private void btXoaDanhMuc_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                query = "Delete from DanhMuc where MaDM = '" + this.tbMaDanhMuc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    dtDanhMuc.Rows.Clear(); dtDanhMucChiTiet.Rows.Clear(); dtDanhMucPL.Rows.Clear();
                    daDanhMuc.Fill(dtDanhMuc); daDanhMuc.Fill(dtDanhMucChiTiet); daDanhMuc.Fill(dtDanhMucPL);
                    this.setNull(this.tpDanhMuc);
                    this.btXoaDanhMuc.Enabled = btSuaDanhMuc.Enabled = false;
                    this.btThemDanhMuc.Enabled = true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể xóa. Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLuuDanhMuc_Click(object sender, EventArgs e)
        {
            string ma = tbMaDanhMuc.Text, ten = tbTenDanhMuc.Text;
            if (prevButton == null)
            {
                query = String.Format("Insert into DanhMuc values ('{0}', N'{1}')", ma, ten);
            }
            else query = String.Format("Update DanhMuc set TenDM = N'{0}' where MaDM = '{1}'", ten, ma);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                dtDanhMuc.Rows.Clear(); dtDanhMucPL.Rows.Clear(); dtDanhMucChiTiet.Rows.Clear();
                daDanhMuc.Fill(dtDanhMuc); daDanhMuc.Fill(dtDanhMucChiTiet); daDanhMuc.Fill(dtDanhMucPL);
                this.controlsStatus(tp: this.tpDanhMuc, openOrClose: 0);
                this.setNull(tpDanhMuc);
            }
            catch (SqlException)
            {
                string message = prevButton == null ? "Không thể thêm dữ liệu." : "Không thể chỉnh sửa dữ liệu.";
                MessageBox.Show(message + " Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoaPhanLoai_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                query = "Delete from PhanLoai where MaPL = '" + this.tbMaPhanLoai.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    dtPhanLoai.Rows.Clear(); dtPhanLoaiChiTiet.Rows.Clear();
                    daPhanLoai.Fill(dtPhanLoai); daPhanLoai.Fill(dtPhanLoaiChiTiet);
                    this.setNull(this.tpPhanLoai);
                    this.btXoaPhanLoai.Enabled = btSuaPhanLoai.Enabled = false;
                    this.btThemPhanLoai.Enabled = true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể xóa. Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLuuPhanLoai_Click(object sender, EventArgs e)
        {
            string ma = tbMaPhanLoai.Text, ten = tbTenPhanLoai.Text, dm = cbDanhMucPL.SelectedValue.ToString();
            if (prevButton == null)
            {
                query = String.Format("Insert into PhanLoai values ('{0}', N'{1}', '{2}')", ma, ten, dm);
            }
            else query = String.Format("Update PhanLoai set TenPL = N'{0}', MaDM = '{1}' where MaPL = '{2}'", ten, dm, ma);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                dtPhanLoai.Rows.Clear(); dtPhanLoaiChiTiet.Rows.Clear();
                daPhanLoai.Fill(dtPhanLoai); daPhanLoai.Fill(dtPhanLoaiChiTiet);
                this.controlsStatus(tp: this.tpPhanLoai, openOrClose: 0);
                this.setNull(tpPhanLoai);
            }
            catch (SqlException)
            {
                string message = prevButton == null ? "Không thể thêm dữ liệu." : "Không thể chỉnh sửa dữ liệu.";
                MessageBox.Show(message + " Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoaDoiTac_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                query = "Delete from NSX where MaNSX = '" + this.tbMaDoiTac.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    dtNSX.Rows.Clear();
                    daNSX.Fill(dtNSX);
                    this.setNull(this.tpDoiTac);
                    this.btXoaDoiTac.Enabled = btSuaDoiTac.Enabled = false;
                    this.btThemDoiTac.Enabled = true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể xóa. Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLuuDoiTac_Click(object sender, EventArgs e)
        {
            string ma = tbMaDoiTac.Text, ten = tbTenDoiTac.Text, sdt = tbSdtDoiTac.Text;
            if (prevButton == null)
            {
                query = String.Format("Insert into NSX values ('{0}', N'{1}', '{2}')", ma, ten, sdt);
            }
            else query = String.Format("Update NSX set TenNSX = N'{0}', SDT = '{1}' where MaNSX = '{2}'", ten, sdt, ma);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                dtNSX.Rows.Clear();
                daNSX.Fill(dtNSX);
                this.controlsStatus(tp: this.tpDoiTac, openOrClose: 0);
                this.setNull(tpDoiTac);
            }
            catch (SqlException)
            {
                string message = prevButton == null ? "Không thể thêm dữ liệu." : "Không thể chỉnh sửa dữ liệu.";
                MessageBox.Show(message + " Vui lòng thử lại sau!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDsSPKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra 1 hàng bất kỳ trong bảng có được chọn không
            if (e.RowIndex == -1)
            {
                this.btSuaSP.Enabled = this.btXoaSp.Enabled = false;
                this.setNull(this.tpSanPham);
                return;
            }
            this.btSuaSP.Enabled = this.btXoaSp.Enabled = true;
            DataGridViewRow currRow = dgvDsSPKho.CurrentRow;
            this.tbMaSP.Text = currRow.Cells[0].Value.ToString().Trim();
            this.tbTenSP.Text = currRow.Cells[1].Value.ToString().Trim();
            this.cbDanhMucChiTiet.Text = currRow.Cells[2].Value.ToString();
            this.cbPhanLoaiChiTiet.Text = currRow.Cells[3].Value.ToString();
            this.cbNhaSX.Text = currRow.Cells[4].Value.ToString();
            this.tbDonViTinh.Text = currRow.Cells[5].Value.ToString().Trim();
            this.dtpNSX.Value = DateTime.Parse(currRow.Cells[6].Value.ToString());
            this.dtpHSD.Value = DateTime.Parse(currRow.Cells[7].Value.ToString());
            this.tbGiaNhap.Text = currRow.Cells[8].Value.ToString();
            this.tbGiaBan.Text = currRow.Cells[9].Value.ToString();
            this.tbSoLuongCon.Text = currRow.Cells[10].Value.ToString();
            this.tbGhiChu.Text = currRow.Cells[11].Value.ToString().Trim();
        }

        private void cbDanhMuc_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            ComboBox cbPL = null, cb = (ComboBox)sender;
            daPhanLoai = null;
            DataTable dt = null;
            if (cb == cbDanhMuc) cbPL = cbPhanLoai;
            else if (cb == cbDanhMucChiTiet) cbPL = cbPhanLoaiChiTiet;
            if (cb.SelectedValue != null)
            {
                MessageBox.Show(cb.SelectedValue.ToString() + "'");
                if (cb.Text.Trim() == "Tất cả")
                {
                    query = "Select MaPL as [Mã số], TenPL as [Tên] from PhanLoai";
                }
                else
                {
                    query = "Select MaPL as [Mã số], TenPL as [Tên] from PhanLoai where MaDM = '" + cb.SelectedValue.ToString() + "'";
                }
                daPhanLoai = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                daPhanLoai.Fill(dt);
                cbPL.DataSource = dt;
                cbPL.DisplayMember = "Tên";
                cbPL.ValueMember = "Mã số";
                cbPL.SelectedValue = "";
            }
            */
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.btSuaDanhMuc.Enabled = this.btXoaDanhMuc.Enabled = false;
                this.setNull(this.tpDanhMuc);
                return;
            }
            this.btSuaDanhMuc.Enabled = this.btXoaDanhMuc.Enabled = true;
            DataGridViewRow currRow = dgvDanhMuc.CurrentRow;
            this.tbMaDanhMuc.Text = currRow.Cells[0].Value.ToString().Trim();
            this.tbTenDanhMuc.Text = currRow.Cells[1].Value.ToString().Trim();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string querySearch = null;
            if (tbTimKiem.Text.Trim().Length != 0 && tbTimKiem.Text != "Tìm kiếm...")
            {
                panelTimKiem.Visible = lvTimKiem.Visible = true;
                querySearch = "Select TenSP from SanPham where TenSP like N'" + tbTimKiem.Text.Trim() + "%'";
                DataTable dtSearch = DataProvider.Instance.ExecuteQuery(querySearch);
                lvTimKiem.Items.Clear();
                //lvTimKiem.Items.Add(new ListViewItem("Vi du"));
                foreach (DataRow row in dtSearch.Rows)
                {
                    lvTimKiem.Items.Add(new ListViewItem(row[0].ToString()));
                }
                lvTimKiem.Refresh();
            }
            else
            {
                panelTimKiem.Visible = lvTimKiem.Visible = false;
            }
        }

        private void dgvPhanLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.btSuaPhanLoai.Enabled = this.btXoaPhanLoai.Enabled = false;
                this.setNull(this.tpPhanLoai);
                return;
            }
            this.btSuaPhanLoai.Enabled = this.btXoaPhanLoai.Enabled = true;
            DataGridViewRow currRow = dgvPhanLoai.CurrentRow;
            this.tbMaPhanLoai.Text = currRow.Cells[0].Value.ToString().Trim();
            this.tbTenPhanLoai.Text = currRow.Cells[1].Value.ToString().Trim();
            this.cbDanhMucPL.Text = currRow.Cells[2].Value.ToString();
        }

        private void dgvDoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.btSuaDoiTac.Enabled = this.btXoaDoiTac.Enabled = false;
                this.setNull(tpDoiTac);
                return;
            }
            this.btSuaDoiTac.Enabled = this.btXoaDoiTac.Enabled = true;
            DataGridViewRow currRow = dgvDoiTac.CurrentRow;
            this.tbMaDoiTac.Text = currRow.Cells[0].Value.ToString().Trim();
            this.tbTenDoiTac.Text = currRow.Cells[1].Value.ToString().Trim();
            this.tbSdtDoiTac.Text = currRow.Cells[2].Value.ToString().Trim();
        }

        private void fMedicineWarehouse_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConnection); conn.Open();

            //San pham
            query = "Select MaSP as [Mã số], TenSP as [Tên], TenDM as [Danh mục], TenPL as [Phân loại], TenNSX as [Sản phẩm của], DonViTinh as [Đơn vị], SP.NSX as [Ngày sản xuất], SP.HSD as [Hạn sử dụng], GiaNhap as [Giá nhập], GiaBan as [Giá bán], SoLuong as [Số lượng], GhiChu as [Ghi chú] " +
                " From SanPham SP, DanhMuc DM, PhanLoai PL, NSX " +
                " Where SP.MaPL = PL.MaPL and PL.MaDM = DM.MaDM and SP.MaNSX = NSX.MaNSX";
            daSanPham = new SqlDataAdapter(query, conn);
            dtSanPham = new DataTable();
            daSanPham.Fill(dtSanPham);
            dgvDsSPKho.DataSource = dtSanPham;
            dgvDsSPKho.Columns["Ngày sản xuất"].DefaultCellStyle.Format = dgvDsSPKho.Columns["Hạn sử dụng"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //danh muc
            query = "Select MaDM as [Mã số], TenDM as [Tên] from DanhMuc";
            daDanhMuc = new SqlDataAdapter(query, conn);
            dtDanhMuc = new DataTable(); dtDanhMucChiTiet = new DataTable(); dtDanhMucPL = new DataTable();
            daDanhMuc.Fill(dtDanhMuc); daDanhMuc.Fill(dtDanhMucPL); daDanhMuc.Fill(dtDanhMucChiTiet);
            dgvDanhMuc.DataSource = cbDanhMuc.DataSource = dtDanhMuc;
            cbDanhMucPL.DataSource = dtDanhMucPL; cbDanhMucChiTiet.DataSource = dtDanhMucChiTiet;
            cbDanhMucPL.DisplayMember = cbDanhMuc.DisplayMember = cbDanhMucChiTiet.DisplayMember = "Tên";
            cbDanhMucPL.ValueMember = cbDanhMuc.ValueMember = cbDanhMucChiTiet.ValueMember = "Mã số";
            cbDanhMucPL.SelectedValue = cbDanhMucChiTiet.SelectedValue = "";

            //Phan loai
            query = "Select MaPL as [Mã số], TenPL as [Tên], TenDM as [Danh mục] from PhanLoai, DanhMuc where PhanLoai.MaDM = DanhMuc.MaDM";
            daPhanLoai = new SqlDataAdapter(query, conn);
            dtPhanLoai = new DataTable(); dtPhanLoaiChiTiet = new DataTable();
            daPhanLoai.Fill(dtPhanLoai); daPhanLoai.Fill(dtPhanLoaiChiTiet);
            dgvPhanLoai.DataSource = cbPhanLoai.DataSource = dtPhanLoai;
            cbPhanLoaiChiTiet.DataSource = dtPhanLoaiChiTiet;
            cbPhanLoai.DisplayMember = cbPhanLoaiChiTiet.DisplayMember = "Tên"; cbPhanLoai.ValueMember = cbPhanLoaiChiTiet.ValueMember = "Mã số";
            cbPhanLoaiChiTiet.SelectedValue = "";

            //NSX
            query = "Select MaNSX as [Mã số], TenNSX as [Tên], SDT as [Số điện thoại] from NSX";
            daNSX = new SqlDataAdapter(query, conn);
            dtNSX = new DataTable(); daNSX.Fill(dtNSX);
            dgvDoiTac.DataSource = dtNSX;
            cbNhaSX.DataSource = dtNSX;
            cbNhaSX.DisplayMember = "Tên"; cbNhaSX.ValueMember = "Mã số";
            cbNhaSX.SelectedValue = "";
        }


        #region Các hàm bổ trợ

        private void setNull(TabPage tp, Button bt = null) //Button dung voi truong hop nhan huy cua nut sua
        {
            if (tp == null) return;
            if (tp == this.tpSanPham)
            {
                this.tbMaSP.Text = this.tbTenSP.Text = this.tbDonViTinh.Text = this.tbGiaNhap.Text = this.tbGiaBan.Text = this.tbSoLuongCon.Text = this.tbGhiChu.Text = null;
                this.cbDanhMucChiTiet.SelectedValue = this.cbPhanLoaiChiTiet.SelectedValue = this.cbNhaSX.SelectedValue = "";
                this.dtpNSX.Value = dtpHSD.Value = DateTime.Now;
                if (bt != null)
                {
                    int rowIndex = this.dgvDsSPKho.CurrentRow.Index;
                    int colIndex = this.dgvDsSPKho.CurrentCell.ColumnIndex;
                    DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(colIndex, rowIndex);
                    //goi ham DataGridViewCell_Click cua tpSanPham
                    this.dgvDsSPKho_CellClick(this.dgvDsSPKho, e);
                }
                else
                {
                    btSuaSP.Enabled = btXoaSp.Enabled = false;
                }
            }
            else if (tp == this.tpDanhMuc)
            {
                this.tbMaDanhMuc.Text = this.tbTenDanhMuc.Text = null;
                if (bt != null)
                {
                    int rowIndex = this.dgvDanhMuc.CurrentRow.Index;
                    int colIndex = this.dgvDanhMuc.CurrentCell.ColumnIndex;
                    DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(colIndex, rowIndex);
                    //goi ham DataGridViewCell_Click cua tpDanhMuc
                    this.dgvDanhMuc_CellClick(this.dgvDanhMuc, e);
                }
                else
                {
                    btSuaDanhMuc.Enabled = btXoaDanhMuc.Enabled = false;
                }
            }
            else if (tp == this.tpPhanLoai)
            {
                this.tbMaPhanLoai.Text = this.tbTenPhanLoai.Text = null;
                this.cbDanhMucPL.SelectedValue = "";
                if (bt != null)
                {
                    int rowIndex = this.dgvPhanLoai.CurrentRow.Index;
                    int colIndex = this.dgvPhanLoai.CurrentCell.ColumnIndex;
                    DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(colIndex, rowIndex);
                    //goi ham DataGridViewCell_Click cua tpPhanLoai
                    this.dgvPhanLoai_CellClick(this.dgvPhanLoai, e);
                }
                else
                {
                    btSuaPhanLoai.Enabled = btXoaPhanLoai.Enabled = false;
                }
            }
            else if (tp == tpDoiTac)
            {
                this.tbMaDoiTac.Text = this.tbTenDoiTac.Text = this.tbSdtDoiTac.Text = null;
                if (bt != null)
                {
                    int rowIndex = this.dgvDoiTac.CurrentRow.Index;
                    int colIndex = this.dgvDoiTac.CurrentCell.ColumnIndex;
                    DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(colIndex, rowIndex);
                    //goi ham DataGridViewCell_Click cua tpDoiTac
                    this.dgvDoiTac_CellClick(this.dgvDoiTac, e);
                }
                else
                {
                    btSuaDoiTac.Enabled = btXoaDoiTac.Enabled = false;
                }
            }
        }

        private void controlsStatus(TabPage tp, Button bt = null, int openOrClose = 1) //openOrClose == 1 ? Open : Close
        {
            if (tp == this.tpSanPham)
            {
                if (bt == this.btThemSP || bt == null)
                {
                    this.textBoxControl(tbMaSP, openOrClose);
                }
                TextBox[] textBoxes = { tbTenSP, tbDonViTinh, tbGiaNhap, tbGiaBan, tbSoLuongCon, tbGhiChu };
                foreach (TextBox textBox in textBoxes)
                {
                    this.textBoxControl(textBox, openOrClose);
                }
                this.cbDanhMucChiTiet.Enabled = this.cbPhanLoaiChiTiet.Enabled = this.cbNhaSX.Enabled = this.dtpNSX.Enabled = this.dtpHSD.Enabled = openOrClose == 1 ? true : false;
                //Ẩn, hiện button
                this.btThemSP.Visible = this.btSuaSP.Visible = this.btXoaSp.Visible = openOrClose == 1 ? false : true;
                this.btHuySP.Visible = this.btLuuSP.Visible = openOrClose == 1 ? true : false;
            }
            else if (tp == tpDanhMuc)
            {
                if (bt == btThemDanhMuc || bt == null)
                {
                    this.textBoxControl(tbMaDanhMuc, openOrClose);
                }
                this.textBoxControl(tbTenDanhMuc, openOrClose);
                this.btThemDanhMuc.Visible = this.btSuaDanhMuc.Visible = this.btXoaDanhMuc.Visible = openOrClose == 1 ? false : true;
                this.btHuyDanhMuc.Visible = this.btLuuDanhMuc.Visible = openOrClose == 1 ? true : false;
            }
            else if (tp == tpPhanLoai)
            {
                if (bt == btThemPhanLoai || bt == null)
                {
                    this.textBoxControl(tbMaPhanLoai, openOrClose);
                }
                this.textBoxControl(tbTenPhanLoai, openOrClose);
                this.cbDanhMucPL.Enabled = openOrClose == 1 ? true : false;
                this.btThemPhanLoai.Visible = this.btSuaPhanLoai.Visible = this.btXoaPhanLoai.Visible = openOrClose == 1 ? false : true;
                this.btHuyPhanLoai.Visible = this.btLuuPhanLoai.Visible = openOrClose == 1 ? true : false;
            }
            else if (tp == tpDoiTac)
            {
                if (bt == btThemDoiTac || bt == null) this.textBoxControl(tbMaDoiTac, openOrClose);
                TextBox[] textBoxes = { this.tbTenDoiTac, this.tbSdtDoiTac };
                foreach (TextBox textBox in textBoxes)
                {
                    this.textBoxControl(textBox, openOrClose);
                }
                this.btThemDoiTac.Visible = this.btSuaDoiTac.Visible = this.btXoaDoiTac.Visible = openOrClose == 1 ? false : true;
                this.btHuyDoiTac.Visible = this.btLuuDoiTac.Visible = openOrClose == 1 ? true : false;
            }
        }

        private void textBoxControl(TextBox tb, int openOrClose)
        {
            if (tb == null) return;
            tb.ReadOnly = openOrClose == 1 ? false : true;
            tb.Cursor = openOrClose == 1 ? Cursors.IBeam : Cursors.No;
            tb.BackColor = openOrClose == 1 ? Color.White : System.Drawing.SystemColors.Control;
        }

        
        #endregion

        
    }
}

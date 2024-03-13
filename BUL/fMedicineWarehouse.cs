﻿using System;
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

        //Sự kiện click của các button thêm mới trong các tabpage
        private void btThem_Click(object sender, EventArgs e)
        {
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
                //Xử lý với CSDL
            }
        }

        private void btHuySP_Click(object sender, EventArgs e)
        {
            //Hển thị hộp thoại xác nhận hủy
            var res = MessageBox.Show("Bạn có chắc chắn hủy?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                this.controlsStatus(tp: this.tpSanPham, openOrClose: 0);
            }
        }

        private void btLuuSP_Click(object sender, EventArgs e)
        {
            //Xử lý CSDL
            dgvDsSPKho.Rows.Add(tbMaSP.Text, tbTenSP.Text, cbDanhMucChiTiet.Text, cbPhanLoaiChiTiet.Text, cbNhaSX.Text, tbDonViTinh.Text, dtpNSX.Value.Date.ToString(), dtpHSD.Value.Date.ToString(), tbGiaNhap.Text, tbGiaBan.Text, tbSoLuongCon.Text, tbGhiChu.Text);
            MessageBox.Show("Saved!");
            //Quay về giao diện trước khi thực hiện thêm hoặc xóa
            this.controlsStatus(tp: this.tpSanPham, openOrClose: 0);
            this.setNull(tpSanPham);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //Truy vấn dữ liệu từ database
            //Trả kết quả tìm kiếm lên DataGridView dgvDsSPKho
        }

        private void dgvDsSPKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra 1 hàng bất kỳ trong bảng có được chọn không
            if (e.RowIndex == -1)
            {
                this.setNull(this.tpSanPham);
                return;
            }
            DataGridViewRow currRow = dgvDsSPKho.CurrentRow;
            this.tbMaSP.Text = currRow.Cells[0].Value.ToString().Trim();
            this.tbTenSP.Text = currRow.Cells[1].Value.ToString().Trim();
            this.cbDanhMuc.Text = currRow.Cells[2].Value.ToString();
            this.cbPhanLoaiChiTiet.Text = currRow.Cells[3].Value.ToString();
            this.cbNhaSX.Text = currRow.Cells[4].Value.ToString();
            this.tbDonViTinh.Text = currRow.Cells[5].Value.ToString().Trim();
            this.dtpNSX.Value = DateTime.ParseExact(currRow.Cells[6].Value.ToString(), "dd/MM/yyyy", null);
            this.dtpHSD.Value = DateTime.ParseExact(currRow.Cells[7].Value.ToString(), "dd/MM/yyyy", null);
            this.tbGiaNhap.Text = currRow.Cells[8].Value.ToString();
            this.tbGiaBan.Text = currRow.Cells[9].Value.ToString();
            this.tbSoLuongCon.Text = currRow.Cells[10].Value.ToString();
            this.tbGhiChu.Text = currRow.Cells[11].Value.ToString().Trim();
        }



        #region Các hàm bổ trợ
        private void setNull(TabPage tp)
        {
            if (tp == this.tpSanPham)
            {
                this.tbMaSP.Text = this.tbTenSP.Text = this.tbDonViTinh.Text = this.tbGiaNhap.Text = this.tbGiaBan.Text = this.tbSoLuongCon.Text = this.tbGhiChu.Text = null;
                this.cbDanhMucChiTiet.SelectedValue = this.cbPhanLoaiChiTiet.SelectedValue = this.cbNhaSX.SelectedValue = "";
                this.dtpNSX.Value = dtpHSD.Value = DateTime.Now;
            }
            else if (tp == this.tpDanhMuc)
            {
                this.tbMaDanhMuc.Text = this.tbTenDanhMuc.Text = null;
            }
            else if (tp == this.tpPhanLoai)
            {
                this.tbMaPhanLoai.Text = this.tbTenPhanLoai.Text = null;
                this.cbDanhMucPL.SelectedValue = "";
            }
            else if (tp == tpDoiTac)
            {
                this.tbMaDoiTac.Text = this.tbTenDoiTac.Text = this.tbSdtDoiTac.Text = null;
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
                if (bt == btThemDanhMuc)
                {
                    this.textBoxControl(tbMaDanhMuc, openOrClose);
                }
                this.textBoxControl(tbTenDanhMuc, openOrClose);
                this.btThemDanhMuc.Visible = this.btSuaDanhMuc.Visible = this.btXoaDanhMuc.Visible = openOrClose == 1 ? false : true;
                this.btHuyDanhMuc.Visible = this.btLuuDanhMuc.Visible = openOrClose == 1 ? true : false;
            }
            else if (tp == tpPhanLoai)
            {
                if (bt == btThemPhanLoai)
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
                if (bt == btThemDoiTac) this.textBoxControl(tbMaDoiTac, openOrClose);
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

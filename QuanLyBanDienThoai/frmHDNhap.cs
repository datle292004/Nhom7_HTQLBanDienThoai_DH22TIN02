using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanDienThoai
{
    public partial class frmHDNhap : Form
    {
        public string state;
        public void hienthi()
        {
            try
            {
                dagHDNhap.DataSource = KetNoiDB.Getdatatble("select * from HDNhap");
            }
            catch
            {
            }
        }
        public void dongtxt()
        {
            cmbTenNCC.Enabled = false;
            txtMaHDNhap.Enabled = false;
            mskNgayLap.Enabled = false;
        }
        public void motxt()
        {
            cmbTenNCC.Enabled = true;
            txtMaHDNhap.Enabled = true;
            mskNgayLap.Enabled = true;
        }
        public void dongbtn()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void mobtn()
        {
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void setnull()
        {
            txtMaHDNhap.Clear();
            mskNgayLap.Clear();

        }
        public frmHDNhap()
        {
            InitializeComponent();
        }

        private void frmHDNhap_Load(object sender, EventArgs e)
        {
            hienthi();
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatble("select * from NhaCC");
            cmbTenNCC.DataSource = dt;
            cmbTenNCC.DisplayMember = "TenNCC";
            cmbTenNCC.ValueMember = "MaNCC";
            dongtxt();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            dongbtn();
            motxt();
            setnull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            motxt();
            dongbtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    KetNoiDB.ThucthicaulenhSQL("INSERT INTO HDNhap  (MaHDN, MaNCC, NgayLap) VALUES ('" + txtMaHDNhap.Text + "','" + cmbTenNCC.SelectedValue + "','" + DateTime.Parse(mskNgayLap.Text) + "')");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm", "Thông báo");
            }
            try
            {
                if (state == "update")
                {
                    KetNoiDB.ThucthicaulenhSQL("UPDATE    HDNhap SET   MaNCC ='" + cmbTenNCC.SelectedValue + "', NgayLap ='" + DateTime.Parse(mskNgayLap.Text) + "' where MaHDN='" + txtMaHDNhap.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa", "Thông báo");
            }
            hienthi();
            dongtxt();
            mobtn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dongbtn();
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KetNoiDB.ThucthicaulenhSQL("DELETE FROM HDNhap where MaHDN='" + txtMaHDNhap.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa", "Thông báo");
            }
            hienthi();
            mobtn();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtTimKiem.Text;
                cmbTenNCC.SelectedValue = a;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp");
            }
        }

        private void dagHDNhap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagHDNhap.CurrentRow.Index;
                txtMaHDNhap.Text = dagHDNhap.Rows[dong].Cells[0].Value.ToString();
                mskNgayLap.Text = dagHDNhap.Rows[dong].Cells[2].Value.ToString();
                cmbTenNCC.SelectedValue = dagHDNhap.Rows[dong].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
    }
}

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
    public partial class frmHDXuat : Form
    {
        public string state;
        public void hienthi()
        {
            try
            {
                dagHDXuat.DataSource = KetNoiDB.Getdatatble("select * from HDXuat");
            }
            catch
            {
            }
        }
        public void dongtxt()
        {
            cmbTenKH.Enabled = false;
            txtMaHDXuat.Enabled = false;
            mskNgayLap.Enabled = false;
        }
        public void motxt()
        {
            cmbTenKH.Enabled = true;
            txtMaHDXuat.Enabled = true;
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
            txtMaHDXuat.Clear();
            mskNgayLap.Clear();

        }
       

        private void frmHDXuat_Load(object sender, EventArgs e)
        {
            hienthi();
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatble("select * from KhachHang");
            cmbTenKH.DataSource = dt;
            cmbTenKH.DisplayMember = "TenKH";
            cmbTenKH.ValueMember = "MaKH";
            dongtxt();
        }
        public frmHDXuat()
        {
            InitializeComponent();
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void dagHDXuat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagHDXuat.CurrentRow.Index;
                txtMaHDXuat.Text = dagHDXuat.Rows[dong].Cells[0].Value.ToString();
                mskNgayLap.Text = dagHDXuat.Rows[dong].Cells[2].Value.ToString();
                cmbTenKH.SelectedValue = dagHDXuat.Rows[dong].Cells[1].Value.ToString();
            }
            catch
            {
            }
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

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            state = "update";
            motxt();
            dongbtn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dongbtn();
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KetNoiDB.ThucthicaulenhSQL("DELETE FROM HDXuat where MaHDX='"+txtMaHDXuat.Text+"'");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa", "Thông báo");
            }
            hienthi();
            mobtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    KetNoiDB.ThucthicaulenhSQL("INSERT INTO HDXuat  (MaHDX, MaKH, NgayLap) VALUES ('" + txtMaHDXuat.Text + "','" + cmbTenKH.SelectedValue + "','" + DateTime.Parse(mskNgayLap.Text) + "')");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm","Thông báo");
            }
            try
            {
                if (state == "update")
                {
                    KetNoiDB.ThucthicaulenhSQL("UPDATE    HDXuat SET   MaKH ='"+cmbTenKH.SelectedValue+"', NgayLap ='"+DateTime.Parse(mskNgayLap.Text)+"' where MaHDX='"+txtMaHDXuat.Text+"'");
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtTimKiem.Text;
                cmbTenKH.SelectedValue = a;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }
    }
}

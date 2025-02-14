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
    public partial class frmMatHang : Form
    {
        public string state;
        public void hienthi()
        {
            try
            {
                dagNCC.DataSource = KetNoiDB.Getdatatble("select * from MatHang");
            }
            catch
            {
            }
        }
        public void dongtxt()
        {
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            cmbDonVi.Enabled = false;
            txtSoLuongTon.Enabled = false;
        }
        public void motxt()
        {
            txtMaHang.Enabled = true;
            txtTenHang.Enabled = true;
            cmbDonVi.Enabled = true;
            txtSoLuongTon.Enabled = true;
        }
        public void setnull()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuongTon.Text = "0";
        }
        public void dongbtn()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void mobtn()
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            hienthi();
            dongtxt();
            mobtn();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            motxt();
            dongbtn();
            setnull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            state = "update";
            motxt();
            dongbtn();
            txtMaHang.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dongtxt();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KetNoiDB.ThucthicaulenhSQL("DELETE FROM MatHang where MaHang='" + txtMaHang.Text + "'");
            }
            hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    KetNoiDB.ThucthicaulenhSQL("INSERT INTO MatHang (MaHang, TenHang, DonVi, SLTon) VALUES ('"+txtMaHang.Text+"',N'"+txtTenHang.Text+"',N'"+cmbDonVi.Text+"','"+txtSoLuongTon.Text+"')");
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
            try
            {
                if (state == "update")
                {
                    KetNoiDB.ThucthicaulenhSQL("UPDATE    MatHang SET  TenHang =N'" + txtTenHang.Text + "', DonVi =N'" + cmbDonVi.Text + "', SLTon ='" + txtSoLuongTon.Text + "' where MaHang='" + txtMaHang.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công", "Thông báo");
            }
            hienthi();
            mobtn();
            dongtxt();
        }

        private void dagNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagNCC.CurrentRow.Index;
                txtMaHang.Text = dagNCC.Rows[dong].Cells[0].Value.ToString();
                txtTenHang.Text = dagNCC.Rows[dong].Cells[1].Value.ToString();
                cmbDonVi.Text = dagNCC.Rows[dong].Cells[2].Value.ToString();
                txtSoLuongTon.Text = dagNCC.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
    }
}

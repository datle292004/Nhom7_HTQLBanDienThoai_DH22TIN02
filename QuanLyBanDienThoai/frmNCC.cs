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
    public partial class frmNCC : Form
    {
        public string state;
        public void hienthi()
        {
            try
            {
                dagNCC.DataSource = KetNoiDB.Getdatatble("select * from NhaCC");
            }
            catch
            {
            }
        }
        public void dongtxt()
        {
            txtDiaChi.Enabled = false;
            txtMaNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNCC.Enabled = false;
        }
        public void motxt()
        {
            txtDiaChi.Enabled = true;
            txtMaNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNCC.Enabled = true;
        }
        public void setnull()
        {
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtMaNCC.Clear();
            txtDiaChi.Clear();
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
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
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
            txtMaNCC.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (state == "add")
                {
                    KetNoiDB.ThucthicaulenhSQL("INSERT INTO NhaCC  (MaNCC, TenNCC, DiaChi, SDT) VALUES ('"+txtMaNCC.Text+"',N'"+txtTenNCC.Text+"',N'"+txtDiaChi.Text+"','"+txtSDT.Text+"')");
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
                    KetNoiDB.ThucthicaulenhSQL("UPDATE NhaCC SET  TenNCC =N'" + txtTenNCC.Text + "', DiaChi =N'" + txtDiaChi.Text + "', SDT ='" + txtSDT.Text + "' where MaNCC='"+txtMaNCC.Text+"'");
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công", "Thông báo");
            }
            hienthi();
            dongtxt();
            mobtn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dongtxt();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KetNoiDB.ThucthicaulenhSQL("DELETE FROM NhaCC where MaNCC='"+txtMaNCC.Text+"'");
            }
            hienthi();
        }

        private void dagNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagNCC.CurrentRow.Index;
                txtMaNCC.Text = dagNCC.Rows[dong].Cells[0].Value.ToString();
                txtTenNCC.Text = dagNCC.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dagNCC.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dagNCC.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
    }
}

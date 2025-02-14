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
    public partial class frmKhachHang : Form
    {
        public string state;
        public void hienthi()
        {
            try
            {
                dagKhachHang.DataSource = KetNoiDB.Getdatatble("select * from KhachHang");
            }
            catch
            {
            }
        }
        public void dongtxt()
        {
            txtDiaChi.Enabled = false;
            txtMaKH.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKH.Enabled = false;
        }
        public void motxt()
        {
            txtDiaChi.Enabled = true;
            txtMaKH.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;
        }
        public void setnull()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
            txtMaKH.Clear();
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
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dongtxt();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KetNoiDB.ThucthicaulenhSQL("DELETE FROM KhachHang where MaKH='"+txtMaKH.Text+"'");
            }
            hienthi();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            hienthi();
            dongtxt();
            mobtn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            motxt();
            dongbtn();
            txtMaKH.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             state = "add";
            motxt();
            dongbtn();
            setnull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    KetNoiDB.ThucthicaulenhSQL("INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SDT) VALUES  ('"+txtMaKH.Text+"',N'"+txtTenKH.Text+"',N'"+txtDiaChi.Text+"','"+txtSDT.Text+"')");
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
                    KetNoiDB.ThucthicaulenhSQL("UPDATE    KhachHang SET  TenKH =N'" + txtTenKH.Text + "', DiaChi =N'" + txtDiaChi.Text + "', SDT ='" + txtSDT.Text + "' where MaKH='"+txtMaKH.Text+"'");
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

        private void dagKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagKhachHang.CurrentRow.Index;
                txtMaKH.Text = dagKhachHang.Rows[dong].Cells[0].Value.ToString();
                txtTenKH.Text = dagKhachHang.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dagKhachHang.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dagKhachHang.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
            }

        }
    }
}

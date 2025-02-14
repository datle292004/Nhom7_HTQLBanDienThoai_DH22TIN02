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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            dagMatHang.DataSource = KetNoiDB.Getdatatble("SELECT  MaHang, TenHang, DonVi, SLTon FROM  MatHang");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            frm.ShowDialog();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDXuat frm = new frmHDXuat();
            frm.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDNhap frm = new frmHDNhap();
            frm.Show();
        }

        private void hàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangNhap frm = new frmHangNhap();
            frm.Show();
        }

        private void hàngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangXuat frm = new frmHangXuat();
            frm.Show();
        }
    }
}

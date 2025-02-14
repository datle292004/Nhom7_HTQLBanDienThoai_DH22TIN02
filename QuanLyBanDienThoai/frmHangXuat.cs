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
    public partial class frmHangXuat : Form
    {
        public frmHangXuat()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            dagHangXuat.DataSource = KetNoiDB.Getdatatble("select * from HangXuat");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmHangXuat_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatble("select * from HDXuat");
            cmbMaHDX.DataSource = dt;
            cmbMaHDX.DisplayMember = "MaHDX";
            cmbMaHDX.ValueMember = "MaHDX";
            DataTable dt1 = new DataTable();
            dt1 = KetNoiDB.Getdatatble("select * from MatHang");
            cmbMaHang.DataSource = dt1;
            cmbMaHang.DisplayMember = "MaHang";
            cmbMaHang.ValueMember = "MaHang";
            txtDonGia.Enabled = false;
            
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDonGia.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(numSoLuong.Value.ToString());
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatble("select SLTon from MatHang where MaHang='" + cmbMaHang.SelectedValue + "'");
            int a = int.Parse(dt.Rows[0][0].ToString());
            if (sl > a)
            {
                MessageBox.Show("Số lượng trong kho không đủ đáp ứng");

            }
            else
            {
                DataTable dt1 = new DataTable();
                dt1 = KetNoiDB.Getdatatble("select count(*) from HangXuat where MaHDX='" + cmbMaHDX.SelectedValue + "'");
                int k = int.Parse(dt1.Rows[0][0].ToString());
                //txtDonGia.Text = k.ToString();
                if (k == 0)
                {
                    try
                    {
                        KetNoiDB.ThucthicaulenhSQL("INSERT INTO HangXuat  (MaHDX, MaHang, SoLuong, DonGia) VALUES ('" + cmbMaHDX.SelectedValue + "','" + cmbMaHang.SelectedValue + "','" + int.Parse(numSoLuong.Value.ToString()) + "','" + float.Parse(txtDonGia.Text) + "')");
                        MessageBox.Show("Lưu thành công");
                       

                    }
                    catch
                    {
                        MessageBox.Show("Hóa đơn đã tồn tại");
                    }
                }
                else
                {
                    try
                    {
                        KetNoiDB.ThucthicaulenhSQL("UPDATE  HangXuat SET SoLuong ='" + int.Parse(numSoLuong.Value.ToString()) + "', DonGia ='" + float.Parse(txtDonGia.Text) + "' where MaHDN='" + cmbMaHDX.SelectedValue + "'");
                        MessageBox.Show("Lưu thành công");
                        
                    }
                    catch
                    {
                        MessageBox.Show("Hóa đơn đã tồn tại");
                    }
                }
                DataTable dt2 = new DataTable();
                dt2 = KetNoiDB.Getdatatble("select SLTon from MatHang where MaHang='" + cmbMaHang.SelectedValue + "'");
                int u = int.Parse(dt2.Rows[0][0].ToString());

                int v = int.Parse(numSoLuong.Value.ToString());

                int b = u - v;
                //txtDonGia.Text = a.ToString();
                KetNoiDB.ThucthicaulenhSQL("UPDATE    MatHang SET  SLTon ='" + b + "' where MaHang ='" + cmbMaHang.SelectedValue + "'");
                hienthi();
            }
            txtDonGia.Enabled = false;
        }

        private void dagHangXuat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagHangXuat.CurrentRow.Index;
                cmbMaHang.Text = dagHangXuat.Rows[dong].Cells[1].Value.ToString();
                cmbMaHDX.Text = dagHangXuat.Rows[dong].Cells[0].Value.ToString();
                numSoLuong.Value = int.Parse(dagHangXuat.Rows[dong].Cells[2].Value.ToString());
                txtDonGia.Text = dagHangXuat.Rows[dong].Cells[3].Value.ToString();
                float a = int.Parse(txtDonGia.Text);
                int b = int.Parse(numSoLuong.Value.ToString());
                lblTongTien.Text = (a * b).ToString();
                //txtDonGia.Text = dong.ToString();
            }
            catch
            {
            }
        }
    }
}

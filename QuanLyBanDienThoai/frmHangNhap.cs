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
    public partial class frmHangNhap : Form
    {
        public frmHangNhap()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            dagHangNhap.DataSource = KetNoiDB.Getdatatble("select * from HangNhap");
        }
        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void frmHangNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatble("select * from HDNhap");
            cmbMaHDN.DataSource = dt;
            cmbMaHDN.DisplayMember = "MaHDN";
            cmbMaHDN.ValueMember = "MaHDN";
            DataTable dt1 = new DataTable();
            dt1 = KetNoiDB.Getdatatble("select * from MatHang");
            cmbMaHang.DataSource = dt1;
            cmbMaHang.DisplayMember = "MaHang";
            cmbMaHang.ValueMember = "MaHang";
            txtDonGia.Enabled = false;
                float a = int.Parse(txtDonGia.Text);
           
            int b = int.Parse(numSoLuong.Value.ToString());
            lblTongTien.Text = (a * b).ToString();
            hienthi();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDonGia.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //int sl = int.Parse(numSoLuong.Value.ToString());
            //DataTable dt = new DataTable();
            //dt = KetNoiDB.Getdatatble("select SLTon from MatHang where MaHang='"+cmbMaHang.SelectedValue+"'");
            //int a = int.Parse(dt.Rows[0][0].ToString());
            //if (sl > a)
            //{
            //    MessageBox.Show("Số lượng trong kho không đủ đáp ứng");
                
            //}
            //else
            //{
                DataTable dt1 = new DataTable();
                dt1 = KetNoiDB.Getdatatble("select count(*) from HangNhap where MaHDN='"+cmbMaHDN.SelectedValue+"'");
                int k = int.Parse(dt1.Rows[0][0].ToString());
                //txtDonGia.Text = k.ToString();
                if (k == 0)
                {
                    try
                    {
                        KetNoiDB.ThucthicaulenhSQL("INSERT INTO HangNhap  (MaHDN, MaHang, SoLuong, DonGia) VALUES ('" + cmbMaHDN.SelectedValue + "','" + cmbMaHang.SelectedValue + "','" + int.Parse(numSoLuong.Value.ToString()) + "','" + float.Parse(txtDonGia.Text) + "')");
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
                        KetNoiDB.ThucthicaulenhSQL("UPDATE  HangNhap SET SoLuong ='" + int.Parse(numSoLuong.Value.ToString()) + "', DonGia ='" + float.Parse(txtDonGia.Text) + "' where MaHDN='" + cmbMaHDN.SelectedValue + "'");
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

                int a = u + v;
                //txtDonGia.Text = a.ToString();
                KetNoiDB.ThucthicaulenhSQL("UPDATE    MatHang SET  SLTon ='" + a + "' where MaHang ='" + cmbMaHang.SelectedValue + "'");
                hienthi();
            //}
            txtDonGia.Enabled = false;
        }

        private void dagHangNhap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = dagHangNhap.CurrentRow.Index;
                cmbMaHang.Text = dagHangNhap.Rows[dong].Cells[1].Value.ToString();
                cmbMaHDN.Text = dagHangNhap.Rows[dong].Cells[0].Value.ToString();
                numSoLuong.Value = int.Parse(dagHangNhap.Rows[dong].Cells[2].Value.ToString());
                txtDonGia.Text = dagHangNhap.Rows[dong].Cells[3].Value.ToString();
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

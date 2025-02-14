using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyBanDienThoai
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi kết nối SQL
            string connectionString = @"Data Source=ASUS\DAT;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    object result = cmd.ExecuteScalar(); // Lấy giá trị cột LoaiTaiKhoan

                    if (result != null) // Đăng nhập thành công
                    {
                        string loaiTaiKhoan = result.ToString();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở form chính
                        frmTrangChu trangChu = new frmTrangChu();
                        this.Hide();
                        trangChu.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


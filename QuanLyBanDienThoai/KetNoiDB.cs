using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanDienThoai

{

    public class KetNoiDB
    {
        public static SqlConnection conn;//khai báo 1 d?i tu?ng tên là conn ki?u sqlconnection;
        public static SqlCommand cm;
        public static SqlDataAdapter da;
        public static void MoKetNoi()//t?o 1 phuong th?c m? k?t n?i
        {
            conn = new SqlConnection("Data Source=ASUS\\DAT;Initial Catalog=QuanLyBanDienThoai;Integrated Security=True");//kh?i t?o có tham s? truy?n vào lad 1 chu?i k?t n?i
            conn.Open();// phuong th?c m? k?t n?i
        }   
        public static void DongKetNoi()//
        {
            conn.Close();
        }
        public static void ThucthicaulenhSQL(string sql)//update, insert, delete;
        {
            MoKetNoi();
            cm = new SqlCommand(sql, conn);//kh?i t?o
            cm.ExecuteNonQuery();//phuong th?c không ch? v? giá tr?
            DongKetNoi();

        }
        public static DataTable Getdatatble(string sql)//select
        {
            MoKetNoi();
            DataTable dt = new DataTable();
            cm = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cm);
            da.Fill(dt);//d? d? li?u t? adapter vào datatable
            return dt; //tr? v? 1 giá tr? ki?u datatable
        }
    }
}

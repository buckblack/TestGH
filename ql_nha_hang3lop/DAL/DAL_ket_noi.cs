using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_ket_noi
    {
        public static string chuoiketnoi = "Data Source=DESKTOP-5DDA5DU\\SQLEXPRESS; Initial Catalog=ql_nha_hang;User ID=sa;Password=sa2012";
        public static string tenserver = "DESKTOP-5DDA5DU\\SQLEXPRESS";
        public static string taikhoan = "sa";
        public static string matkhau = "sa2012";
        public static string database = "ql_nha_hang";
        public static string PathImage_monan = @"D:\wamp64\www\QL_NhaHang\public\nha_hang\images\hinh_mon_an\";
        public static string PathImage_tintuc = @"D:\wamp64\www\QL_NhaHang\public\nha_hang\images\tin_tuc\";
        protected SqlConnection cnn = new SqlConnection(chuoiketnoi);
        public void MoKetNoi()
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }
        public void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}

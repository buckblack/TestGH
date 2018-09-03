using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_thay_doi_so_luong:DAL_ket_noi
    {
        public void thay_doi_so_luong(string soluong,string hoadon,string mamon)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update chi_tiet_dat_ban set thanh_tien=don_gia*@soluong, so_luong=@soluong where ma_dat_ban=@hoadon and ma_mon=@mamon", cnn);
            cm.Parameters.AddWithValue("@soluong", soluong);
            cm.Parameters.AddWithValue("@hoadon", hoadon);
            cm.Parameters.AddWithValue("@mamon", mamon);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}

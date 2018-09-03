using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_thong_ke:DAL_ket_noi
    {
        public DataTable Lay_danh_sach_theo_thang(string sql,string thang)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data;
            data = new SqlDataAdapter(sql, cnn);
            data.SelectCommand.Parameters.AddWithValue("@thang", thang);
            data.Fill(tb);
            return tb;
        }

        
    }
}

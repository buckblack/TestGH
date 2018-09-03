using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_tra_cuu:DAL_ket_noi
    {
        public DataTable Lay_danh_sach(string sql, string tukhoa)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data;
            data = new SqlDataAdapter(sql, cnn);
            data.SelectCommand.Parameters.AddWithValue("@tukhoa", tukhoa);
            data.Fill(tb);
            return tb;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_doi_mat_khau:DAL_ket_noi
    {
        public bool kiemtra_doi_mat_khau(string mk_hien_tai,string mk_moi)
        {
            if (BCrypt.Net.BCrypt.Verify(mk_hien_tai, NhanVien.matkhau))
            {
                mk_moi = BCrypt.Net.BCrypt.HashString(mk_moi);
                MoKetNoi();
                SqlCommand update = new SqlCommand("update users set password=@mk_moi where email=N'" + NhanVien.email + "'", cnn);
                update.Parameters.AddWithValue("@mk_moi", mk_moi);
                update.ExecuteNonQuery();
                DongKetNoi();
                NhanVien.matkhau = mk_moi;
                return true;
            }
            return false;
        }
    }
}

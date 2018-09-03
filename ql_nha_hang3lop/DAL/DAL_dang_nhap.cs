using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using BCrypt;

namespace DAL
{
    public class DAL_dang_nhap:DAL_ket_noi
    {
        public bool kiemtra_dangnhap(string user,string pass)
        {
            MoKetNoi();
            SqlCommand cm;
            string s = "select * from users where xoa=0 and email=@tendangnhap";
            cm = new SqlCommand(s, cnn);
            cm.Parameters.AddWithValue("@tendangnhap", user);
            SqlDataReader rdr = cm.ExecuteReader();
            string tennv = "";
            string passnv = "";
            string mailnv = "";
            int manv = 1;
            while (rdr.Read())
            {
                tennv = rdr.GetString(1);
                passnv = rdr.GetString(3);
                mailnv = rdr.GetString(2);
                manv = rdr.GetInt32(0);
                NhanVien.quyen = rdr.GetInt32(6);
                break;
            }
            DongKetNoi();
            if (mailnv == user && BCrypt.Net.BCrypt.Verify(pass, passnv) == true && user != "" && pass != "")
            {
                NhanVien.tennv = tennv;
                NhanVien.matkhau = passnv;
                NhanVien.email = mailnv;
                NhanVien.manv = manv;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string ten_nhan_vien()
        {
            return NhanVien.tennv;
        }
    }
}

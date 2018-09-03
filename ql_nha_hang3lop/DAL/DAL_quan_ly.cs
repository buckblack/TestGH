using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BCrypt;

namespace DAL
{
    public class DAL_quan_ly:DAL_ket_noi
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


        //nhân viên
        public void Them_nhan_vien(string name, string email, string password, string diachi, string dienthoai)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into users(name,email,password,dia_chi,dien_thoai,quyen) values(@name,@email,@password,@dia_chi,@dien_thoai,0)", cnn);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@email", email);
            cm.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashString(password));
            cm.Parameters.AddWithValue("@dia_chi", diachi);
            cm.Parameters.AddWithValue("@dien_thoai", dienthoai);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Xoa_nhan_vien(string manv)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update users set xoa=1 where quyen=0 and id=" + manv, cnn);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Cap_nhat_nhan_vien(string manv,string name,string diachi,string dienthoai)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update users set name=@name,dia_chi=@diachi,dien_thoai=@dienthoai where id=@manv", cnn);
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@diachi", diachi);
            cm.Parameters.AddWithValue("@dienthoai", dienthoai);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        //hết nhân viên

        //tin tức
        public void Them_tin_tuc(string tieude,string tomtat,string chitiet,string tacgia,string hinh)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into tin_tuc(tieu_de,tom_tat,chi_tiet,tac_gia,hinh) values(@tieu_de,@tom_tat,@chi_tiet,@tac_gia,@hinh)", cnn);
            cm.Parameters.AddWithValue("@tieu_de", tieude);
            cm.Parameters.AddWithValue("@tom_tat", tomtat);
            cm.Parameters.AddWithValue("@chi_tiet", chitiet);
            cm.Parameters.AddWithValue("@tac_gia", tacgia);
            cm.Parameters.AddWithValue("@hinh", hinh);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Cap_nhat_tin_tuc(string matin,string tieude, string tomtat, string chitiet, string tacgia, string hinh)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update tin_tuc set tieu_de=@tieu_de,tom_tat=@tom_tat,chi_tiet=@chi_tiet,tac_gia=@tac_gia,hinh=@hinh where id=@matin", cnn);
            cm.Parameters.AddWithValue("@tieu_de",tieude);
            cm.Parameters.AddWithValue("@tom_tat", tomtat);
            cm.Parameters.AddWithValue("@chi_tiet", chitiet);
            cm.Parameters.AddWithValue("@tac_gia", tacgia);
            cm.Parameters.AddWithValue("@hinh", hinh);
            cm.Parameters.AddWithValue("@matin", matin);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Xoa_tin_tuc(string matin)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("delete tin_tuc where id=@matin", cnn);
            cm.Parameters.AddWithValue("@matin", matin);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        //hết tin túc

        //bàn
        public string Lay_loai_ban(string dattruoc, string songuoi)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("select id from loai_ban where dat_truoc=@dattruoc and so_nguoi=@songuoi", cnn);
            cm.Parameters.AddWithValue("@dattruoc", dattruoc);
            cm.Parameters.AddWithValue("@songuoi", songuoi);
            object loaiban = cm.ExecuteScalar();
            DongKetNoi();
            return loaiban.ToString();
        }

        public void Them_ban(string loaiban)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into ban(ma_loai_ban) values(@loaiban)", cnn);
            cm.Parameters.AddWithValue("@loaiban", loaiban);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Cap_nhat_ban(string loaiban,string maban)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update ban set ma_loai_ban=@loaiban where id=@maban", cnn);
            cm.Parameters.AddWithValue("@loaiban", loaiban);
            cm.Parameters.AddWithValue("@maban", maban);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Xoa_ban(string maban)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update ban set xoa=1 where id=@maban", cnn);
            cm.Parameters.AddWithValue("@maban", maban);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        //hết tab bàn

        //loại món ăn
        public void Them_loai_mon_an(string tenloai,string mota)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into loai_mon_an(ten_loai,mo_ta) values(@ten_loai,@mo_ta)", cnn);
            cm.Parameters.AddWithValue("@ten_loai", tenloai);
            cm.Parameters.AddWithValue("@mo_ta", mota);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Cap_nhat_loai_mon_an(string maloai,string tenloai,string mota)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update loai_mon_an set ten_loai=@ten_loai,mo_ta=@mo_ta where id=@maloai", cnn);
            cm.Parameters.AddWithValue("@ten_loai", tenloai);
            cm.Parameters.AddWithValue("@mo_ta", mota);
            cm.Parameters.AddWithValue("@maloai", maloai);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        //hết loại món ăn

        //món ăn
        public void Them_mon_an(string ma_loai, string thuc_don, string noi_dung_tom_tat, string ten_mon, string dvt, string don_gia, string noi_dung_chi_tiet, string hinh)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into mon_an(ma_loai,ten_mon,noi_dung_tom_tat,noi_dung_chi_tiet,don_gia,hinh,dvt,thuc_don) values(@ma_loai,@ten_mon,@noi_dung_tom_tat,@noi_dung_chi_tiet,@don_gia,@hinh,@dvt,@thuc_don)", cnn);
            cm.Parameters.AddWithValue("@ma_loai", ma_loai);
            cm.Parameters.AddWithValue("@thuc_don", thuc_don);
            cm.Parameters.AddWithValue("@noi_dung_tom_tat", noi_dung_tom_tat);
            cm.Parameters.AddWithValue("@ten_mon", ten_mon);
            cm.Parameters.AddWithValue("@dvt", dvt);
            cm.Parameters.AddWithValue("@don_gia", don_gia);
            cm.Parameters.AddWithValue("@noi_dung_chi_tiet", noi_dung_chi_tiet);
            cm.Parameters.AddWithValue("@hinh", hinh);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Cap_nhat_mon_an(string ma_loai, string thuc_don, string noi_dung_tom_tat, string ten_mon, string dvt, string don_gia, string noi_dung_chi_tiet, string hinh,string mamon)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update mon_an set ma_loai=@ma_loai,ten_mon=@ten_mon,noi_dung_tom_tat=@noi_dung_tom_tat,noi_dung_chi_tiet=@noi_dung_chi_tiet,don_gia=@don_gia,hinh=@hinh,dvt=@dvt,thuc_don=@thuc_don where id=@mamon", cnn);
            cm.Parameters.AddWithValue("@ma_loai", ma_loai);
            cm.Parameters.AddWithValue("@thuc_don", thuc_don);
            cm.Parameters.AddWithValue("@noi_dung_tom_tat", noi_dung_tom_tat);
            cm.Parameters.AddWithValue("@ten_mon", ten_mon);
            cm.Parameters.AddWithValue("@dvt", dvt);
            cm.Parameters.AddWithValue("@don_gia", don_gia);
            cm.Parameters.AddWithValue("@noi_dung_chi_tiet", noi_dung_chi_tiet);
            cm.Parameters.AddWithValue("@hinh", hinh);
            cm.Parameters.AddWithValue("@mamon", mamon);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void Xoa_mon_an(string mamon)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update mon_an set xoa=1 where id=" + mamon, cnn);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        //hết tab món ăn

    }
}

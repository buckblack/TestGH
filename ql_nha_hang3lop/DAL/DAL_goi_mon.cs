using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_goi_mon:DAL_ket_noi
    {
      
        public DataTable Lay_cac_mon_da_goi(string mahd)
        {
            SqlDataAdapter data;
            string s = "select c.ma_dat_ban,m.id,ten_loai,ten_mon,c.don_gia,c.so_luong,c.thanh_tien " +
                "from mon_an m, chi_tiet_dat_ban c,loai_mon_an l where c.ma_mon=m.id and l.id=m.ma_loai and c.ma_dat_ban=@mahd";
            data = new SqlDataAdapter(s, cnn);
            data.SelectCommand.Parameters.AddWithValue("@mahd", mahd);
            DataTable tb = new DataTable();
            data.Fill(tb);
            return tb;
        }

        public string tongtien(string mahd)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cm = new SqlCommand("select sum(thanh_tien) as tong_tien from chi_tiet_dat_ban where ma_dat_ban=" + mahd, cnn);
            object kq = cm.ExecuteScalar();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return kq.ToString();
        }

        public DataTable Lay_ds_tat_ca_mon_an()
        {
            SqlDataAdapter data;
            string s = "select * from mon_an where xoa=0";
            data = new SqlDataAdapter(s, cnn);
            DataTable tb = new DataTable();
            data.Fill(tb);
            return tb;
        }

        public void Them_hoa_don_moi(string ma_ban, string tongtien)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into dat_ban(ma_ban,ngay_dat,ma_khach_hang,ma_nhan_vien,tong_tien,trang_thai) values(@ma_ban,getdate(),1,@manv,@tongtien,N'Chưa thanh toán')", cnn);
            cm.Parameters.AddWithValue("@ma_ban", ma_ban);
            cm.Parameters.AddWithValue("@manv", NhanVien.manv);
            cm.Parameters.AddWithValue("@tongtien", tongtien);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public string Lay_hoa_don_moi_them()
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("select top 1 id from dat_ban order by id desc", cnn);
            object sohd = cm.ExecuteScalar();
            DongKetNoi();
            return sohd.ToString();
        }

        public void Them_1_CTHD(string ma_dat_ban, string ma_mon, string so_luong, string don_gia, string thanh_tien)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("insert into chi_tiet_dat_ban values(@ma_dat_ban,@ma_mon,@so_luong,@don_gia,@thanh_tien)", cnn);
            cm.Parameters.AddWithValue("@ma_dat_ban", ma_dat_ban);
            cm.Parameters.AddWithValue("@ma_mon", ma_mon);
            cm.Parameters.AddWithValue("@so_luong", so_luong);
            cm.Parameters.AddWithValue("@don_gia", don_gia);
            cm.Parameters.AddWithValue("@thanh_tien", thanh_tien);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void update_ban(string hoadon, string maban)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("update ban set trang_thai=N'Đang phục vụ',hoa_don_dang_phuc_vu=@hoadon where id=@maban", cnn);
            cm.Parameters.AddWithValue("@hoadon", hoadon);
            cm.Parameters.AddWithValue("@maban", maban);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public string[] Lay_1_mon_an(string mamon)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("select m.id,ten_mon,ten_loai,don_gia from mon_an m, loai_mon_an l where m.ma_loai=l.id and m.id=@mamon", cnn);
            cm.Parameters.AddWithValue("@mamon", mamon);
            SqlDataReader rdr = cm.ExecuteReader();
            string[] item = new string[4];
            while (rdr.Read())
            {
                item[0] = rdr.GetInt32(0).ToString();//mã món
                item[1] = rdr.GetString(1);//tên món
                item[2] = rdr.GetString(2);//tên loại
                item[3] = rdr.GetDouble(3).ToString();//đơn giá

            }
            DongKetNoi();
            return item;
        }
    }
}

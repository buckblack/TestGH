using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_thanh_toan:DAL_ket_noi
    {
        public DataTable Lay_ds_theo_ban(string maban)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data;
            string sql = "select ma_dat_ban,ma_mon,ten_mon,so_luong,c.don_gia,thanh_tien from chi_tiet_dat_ban c,mon_an m where c.ma_mon=m.id and ma_dat_ban=(select hoa_don_dang_phuc_vu from ban where id=@maban)";
            data = new SqlDataAdapter(sql, cnn);
            data.SelectCommand.Parameters.AddWithValue("@maban",maban);
            data.Fill(tb);
            return tb;
        }
        public string Lay_tong_tien_hoa_don(string mahd)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("select sum(thanh_tien) from chi_tiet_dat_ban where ma_dat_ban="+mahd, cnn);
            object kq = cm.ExecuteScalar();
            DongKetNoi();
            return kq.ToString();
        }

        public void update_thong_tin_hoa_don(string mahd)
        {
            MoKetNoi();
            //trạng thái hóa đơn: đã thanh toán, cập nhật tổng tiền, cập nhật nhân viên nào thanh toán
            string updateHD = "update dat_ban set trang_thai=N'Đã thanh toán',ma_nhan_vien=@manv, tong_tien=(select sum(thanh_tien) from chi_tiet_dat_ban where ma_dat_ban=@mahd) where id=@mahd";
            SqlCommand cm = new SqlCommand(updateHD, cnn);
            cm.Parameters.AddWithValue("mahd",mahd);
            cm.Parameters.AddWithValue("@manv",NhanVien.manv);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }

        public void update_thong_tin_ban(string mahd)
        {
            MoKetNoi();
            //trạng thái bàn: trống
            string updateBan = "update ban set trang_thai=N'Trống',hoa_don_dang_phuc_vu=NULL where hoa_don_dang_phuc_vu=@mahd";
            SqlCommand cm = new SqlCommand(updateBan, cnn);
            cm.Parameters.AddWithValue("@mahd",mahd);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}

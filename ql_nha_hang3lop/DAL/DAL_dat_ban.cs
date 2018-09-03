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
    public class DAL_dat_ban:DAL_ket_noi
    {
        public DataTable Lay_tat_ca_ban()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from ban where xoa=0", cnn);
            data.Fill(tb);
            return tb;
        }

        public DataTable Lay_ban_theo_so_nguoi(string songuoi)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from ban where xoa=0 and ma_loai_ban in (select id from loai_ban where so_nguoi=@songuoi)", cnn);
            data.SelectCommand.Parameters.AddWithValue("@songuoi", songuoi);
            data.Fill(tb);
            return tb;
        }

        public DataTable Lay_ban_theo_ten_khach(string tenkh)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select b.* from ban b,dat_ban d, khach_hang k where b.xoa=0 and b.id=d.ma_ban and b.trang_thai=N'Đang phục vụ' and d.trang_thai=N'Chưa thanh toán' and k.id=d.ma_khach_hang and ten_khach_hang like concat('%',@ten_kh,'%')", cnn);
            data.SelectCommand.Parameters.AddWithValue("@ten_kh", tenkh);
            data.Fill(tb);
            return tb;
        }
        public string Lay_ten_khach(string tukhoa)
        {
            MoKetNoi();
            SqlCommand cm = new SqlCommand("select top 1 ten_khach_hang from khach_hang where id in(select ma_khach_hang from dat_ban where dat_ban.id=@tukhoa)", cnn);
            cm.Parameters.AddWithValue("@tukhoa", tukhoa);
            object kq = cm.ExecuteScalar();
            DongKetNoi();
            return kq.ToString();
        }
    }
}

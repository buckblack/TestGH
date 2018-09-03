using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_tra_cuu
    {
        DAL_tra_cuu DAL_tc = new DAL_tra_cuu();
        public DataTable Tim_mon_an(string tukhoa)
        {
            string sql = "select m.id,l.ten_loai,ten_mon,noi_dung_tom_tat,noi_dung_chi_tiet,don_gia,dvt from mon_an m,loai_mon_an l "+
                "where m.ma_loai=l.id and xoa=0 and ma_loai<>13 and ten_mon like concat('%',@tukhoa,'%')";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_khach_hang(string tukhoa)
        {
            string sql = "select id,ten_khach_hang,email,dia_chi,dien_thoai from khach_hang where ten_khach_hang like concat('%',@tukhoa,'%')";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_nhan_vien(string tukhoa)
        {
            string sql = "select id,name,email,dia_chi,dien_thoai from users where xoa=0 and name like concat('%',@tukhoa,'%')";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_hoa_don(string tukhoa)
        {
            string sql = "select d.id,ngay_dat,ten_khach_hang,name,tong_tien from dat_ban d, khach_hang k,users u " +
                "where d.ma_khach_hang=k.id and d.ma_nhan_vien=u.id and trang_thai=N'Đã thanh toán' " +
                "and (d.id like concat('%',@tukhoa,'%') or ten_khach_hang like concat('%',@tukhoa,'%') or name like concat('%',@tukhoa,'%') )";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_thuc_don(string tukhoa)
        {
            string sql = "select id,ten_mon,noi_dung_chi_tiet,don_gia,dvt from mon_an where xoa=0 and ma_loai=13 and ten_mon like concat('%',@tukhoa,'%')";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_chi_tiet_hoa_don(string tukhoa)
        {
            string sql = "select ma_dat_ban,ten_mon,so_luong,c.don_gia,thanh_tien from chi_tiet_dat_ban c,mon_an m where m.id=c.ma_mon and ma_dat_ban=@tukhoa";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

        public DataTable Tim_chi_tiet_thuc_don(string tukhoa)
        {
            string sql = "select id,ten_mon,noi_dung_tom_tat,noi_dung_chi_tiet,don_gia,dvt from mon_an where thuc_don=@tukhoa";
            return DAL_tc.Lay_danh_sach(sql, tukhoa);
        }

    }
}

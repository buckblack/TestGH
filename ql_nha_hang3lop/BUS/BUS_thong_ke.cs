using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_thong_ke
    {
        DAL_thong_ke DAL_tk = new DAL_thong_ke();
        public DataTable Lay_ds_thong_ke_hoa_don(string thang)
        {
            return DAL_tk.Lay_danh_sach_theo_thang(sql_thong_ke_hoa_don(), thang);
        }
        public DataTable Lay_ds_thong_ke_mon_an(string thang)
        {
            return DAL_tk.Lay_danh_sach_theo_thang(sql_thong_ke_mon_an(), thang);
        }

        public string sql_thong_ke_hoa_don()
        {
            return "select d.id,ma_ban,(convert(nvarchar,month(ngay_dat),10)+'-'+convert(nvarchar,YEAR(ngay_dat)))as ngaydat,ten_khach_hang,name,tong_tien " +
                            "from dat_ban d, khach_hang k,users u " +
                            "where trang_thai=N'Đã thanh toán' and d.ma_khach_hang=k.id and u.id=d.ma_nhan_vien and " +
                            "(convert(nvarchar,month(ngay_dat),10)+'-'+convert(nvarchar,YEAR(ngay_dat)))=@thang";
        }
        public string sql_thong_ke_mon_an()
        {
            return "select m.id,m.ten_mon,l.ten_loai, bang2.soluong,bang2.ngaydat from mon_an m,loai_mon_an l," +
                "(select ngaydat,ma_mon, sum(so_luong) as soluong from " +
                "(select (convert(nvarchar,month(ngay_dat),10)+'-'+convert(nvarchar,YEAR(ngay_dat))) as ngaydat,ma_mon,so_luong " +
                "from dat_ban d, chi_tiet_dat_ban c where d.id=c.ma_dat_ban and d.trang_thai=N'Đã thanh toán') bang1 group by ma_mon,ngaydat) bang2 " +
                "where m.id=bang2.ma_mon and m.ma_loai=l.id  and bang2.ngaydat=@thang";
        }
    }
}

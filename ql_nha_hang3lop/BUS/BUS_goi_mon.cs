using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_goi_mon
    {
        DAL_goi_mon DAL_gm = new DAL_goi_mon();
        public DataTable Lay_cac_mon_da_goi(string mahd)
        {
            return DAL_gm.Lay_cac_mon_da_goi(mahd);
        }

        public string tongtien(string mahd)
        {
            return DAL_gm.tongtien(mahd);
        }

        public DataTable Lay_ds_tat_ca_mon_an()
        {
            return DAL_gm.Lay_ds_tat_ca_mon_an();
        }

        public void Them_hoa_don_moi(string ma_ban, string tongtien)
        {
            DAL_gm.Them_hoa_don_moi(ma_ban,tongtien);
        }

        public string Lay_hoa_don_moi_them()
        {
            return DAL_gm.Lay_hoa_don_moi_them();
        }

        public void Them_1_CTHD(string ma_dat_ban, string ma_mon, string so_luong, string don_gia, string thanh_tien)
        {
            DAL_gm.Them_1_CTHD(ma_dat_ban,ma_mon,so_luong,don_gia,thanh_tien);
        }

        public void update_ban(string hoadon, string maban)
        {
            DAL_gm.update_ban(hoadon,maban);
        }

        public string[] Lay_1_mon_an(string mamon)
        {
            return DAL_gm.Lay_1_mon_an(mamon);
        }

    }
}

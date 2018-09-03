using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_thanh_toan
    {
        DAL_thanh_toan DAL_tt = new DAL_thanh_toan();
        public DataTable Lay_ds_theo_ban(string maban)
        {
            return DAL_tt.Lay_ds_theo_ban(maban);
        }

        public string Lay_tong_tien_hoa_don(string mahd)
        {
            return DAL_tt.Lay_tong_tien_hoa_don(mahd);
        }

        public void update_thong_tin_hoa_don(string mahd)
        {
            DAL_tt.update_thong_tin_hoa_don(mahd);
        }

        public void update_thong_tin_ban(string mahd)
        {
            DAL_tt.update_thong_tin_ban(mahd);
        }
    }
}

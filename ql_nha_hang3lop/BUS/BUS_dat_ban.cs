using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_dat_ban
    {
        DAL_dat_ban DAL_db = new DAL_dat_ban();
        public DataTable Lay_tat_ca_ban()
        {
            return DAL_db.Lay_tat_ca_ban();
        }

        public DataTable Lay_ban_theo_so_nguoi(string songuoi)
        {
            return DAL_db.Lay_ban_theo_so_nguoi(songuoi);
        }

        public DataTable Lay_ban_theo_ten_khach(string tenkh)
        {
            return DAL_db.Lay_ban_theo_ten_khach(tenkh);
        }
        public string Lay_ten_khach(string tukhoa)
        {
            return DAL_db.Lay_ten_khach(tukhoa);
        }
    }
}

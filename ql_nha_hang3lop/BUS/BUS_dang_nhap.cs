using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_dang_nhap
    {
        DAL_dang_nhap DAL_dn = new DAL_dang_nhap();
        public bool kiemtra_dangnhap(string user, string pass)
        {
            return DAL_dn.kiemtra_dangnhap(user, pass);
        }
        public string ten_nhan_vien()
        {
            return DAL_dn.ten_nhan_vien();
        }
    }
}

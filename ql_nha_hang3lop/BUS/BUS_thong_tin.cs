using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_thong_tin
    {
        public string ten_nhan_vien()
        {
            return NhanVien.tennv;
        }

        public string ten_server()
        {
            return DAL_ket_noi.tenserver;
        }

        public string ten_dang_nhap()
        {
            return DAL_ket_noi.taikhoan;
        }

        public string mat_khau()
        {
            return DAL_ket_noi.matkhau;
        }

        public string ten_database()
        {
            return DAL_ket_noi.database;
        }
        public string PathImage_tintuc()
        {
            return DAL_ket_noi.PathImage_tintuc;
        }
        public string PathImage_monan()
        {
            return DAL_ket_noi.PathImage_monan;
        }

        public int quyen_nhan_vien()
        {
            return NhanVien.quyen;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_thay_doi_so_luong
    {
        DAL_thay_doi_so_luong DAL_tdsl = new DAL_thay_doi_so_luong();
        public void thay_doi_so_luong(string soluong, string hoadon, string mamon)
        {
            DAL_tdsl.thay_doi_so_luong(soluong,hoadon,mamon);
        }
    }
}

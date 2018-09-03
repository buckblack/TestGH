using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_doi_mat_khau
    {
        DAL_doi_mat_khau DAL_dmk = new DAL_doi_mat_khau();
        public bool kiemtra_doi_mat_khau(string mk_hien_tai, string mk_moi)
        {
            return DAL_dmk.kiemtra_doi_mat_khau(mk_hien_tai,mk_moi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_quan_ly
    {
        DAL_quan_ly DAL_ql = new DAL_quan_ly();
        //góp ý web
        public DataTable Lay_danh_sach_gopy_web()
        {
            return DAL_ql.Lay_danh_sach("select * from gop_y", "");
        }
        //hết góp ý web

        //nhân viên
        public DataTable Tim_nhan_vien(string tukhoa)
        {
            string sql = "select id,name,email,dia_chi,dien_thoai from users where xoa=0 and (name like concat('%',@tukhoa,'%') or email like concat('%',@tukhoa,'%') or id like concat('%',@tukhoa,'%') )";
            return DAL_ql.Lay_danh_sach(sql, tukhoa);
        }

        public void Them_nhan_vien(string name, string email, string password, string diachi, string dienthoai)
        {
            DAL_ql.Them_nhan_vien(name,email,password,diachi,dienthoai);
        }

        public void Xoa_nhan_vien(string manv)
        {
            DAL_ql.Xoa_nhan_vien(manv);
        }

        public void Cap_nhat_nhan_vien(string manv, string name, string diachi, string dienthoai)
        {
            DAL_ql.Cap_nhat_nhan_vien(manv,name,diachi,dienthoai);
        }
        //hết nhân viên

        //tin tức
        public DataTable Lay_danh_sach_tin_tuc(string tukhoa)
        {
            string sql = "select id,tieu_de,tom_tat,chi_tiet,tac_gia,hinh from tin_tuc where (tieu_de like concat('%',@tukhoa,'%') or tom_tat like concat('%',@tukhoa,'%') or tac_gia like concat('%',@tukhoa,'%') )";
            return DAL_ql.Lay_danh_sach(sql, tukhoa);
        }

        public void Them_tin_tuc(string tieude, string tomtat, string chitiet, string tacgia, string hinh)
        {
            DAL_ql.Them_tin_tuc(tieude,tomtat,chitiet,tacgia,hinh);
        }

        public void Cap_nhat_tin_tuc(string matin, string tieude, string tomtat, string chitiet, string tacgia, string hinh)
        {
            DAL_ql.Cap_nhat_tin_tuc(matin,tieude,tomtat,chitiet,tacgia,hinh);
        }

        public void Xoa_tin_tuc(string matin)
        {
            DAL_ql.Xoa_tin_tuc(matin);
        }
        //hết tin tức

        //bàn
        public DataTable Lay_danh_sach_ban()
        {
            string sql = "select b.id,so_nguoi,trang_thai,hoa_don_dang_phuc_vu, (CASE when dat_truoc=1 then N'Có' else N'Không' end) as dat_truoc " +
                "from ban b,loai_ban l where b.ma_loai_ban=l.id and xoa=0";
            return DAL_ql.Lay_danh_sach(sql, "");
        }

        public string Lay_loai_ban(string dattruoc, string songuoi)
        {
            return DAL_ql.Lay_loai_ban(dattruoc,songuoi);
        }

        public void Them_ban(string loaiban)
        {
            DAL_ql.Them_ban(loaiban);
        }
        public void Cap_nhat_ban(string loaiban, string maban)
        {
            DAL_ql.Cap_nhat_ban(loaiban, maban);
        }

        public void Xoa_ban(string maban)
        {
            DAL_ql.Xoa_ban(maban);
        }
        //hết tab bàn

        //loại món ăn
        public DataTable Lay_danh_sach_loai_mon_an(string tukhoa)
        {
            string sql = "select * from loai_mon_an where ten_loai like concat('%',@tukhoa,'%')";
            return DAL_ql.Lay_danh_sach(sql, tukhoa);
        }

        public void Them_loai_mon_an(string tenloai, string mota)
        {
            DAL_ql.Them_loai_mon_an(tenloai,mota);
        }

        public void Cap_nhat_loai_mon_an(string maloai, string tenloai, string mota)
        {
            DAL_ql.Cap_nhat_loai_mon_an(maloai, tenloai, mota);
        }
        //loại hết món ăn

        //món ăn
        public DataTable Lay_danh_sach_mon_an(string tukhoa)
        {
            string sql = "select m.id,ten_mon,ten_loai,noi_dung_tom_tat,noi_dung_chi_tiet,m.don_gia,dvt," +
                   "(select ten_mon from mon_an m2 where m2.id=m.thuc_don) as thucdon,hinh from mon_an m,loai_mon_an l " +
                   "where m.xoa=0 and m.ma_loai=l.id and (ten_mon like concat('%',@tukhoa,'%') or ten_loai like concat('%',@tukhoa,'%'))";
            return DAL_ql.Lay_danh_sach(sql,tukhoa);
        }

        public DataTable Lay_combobox_loai_mon_an()
        {
            return DAL_ql.Lay_danh_sach("select * from loai_mon_an", "");
        }

        public DataTable Lay_combobox_thuc_don()
        {
            return DAL_ql.Lay_danh_sach("select * from mon_an where xoa=0 and ma_loai=13", "");
        }

        public void Them_mon_an(string ma_loai, string thuc_don, string noi_dung_tom_tat, string ten_mon, string dvt, string don_gia, string noi_dung_chi_tiet, string hinh)
        {
            DAL_ql.Them_mon_an(ma_loai, thuc_don, noi_dung_tom_tat, ten_mon, dvt, don_gia, noi_dung_chi_tiet, hinh);
        }

        public void Cap_nhat_mon_an(string ma_loai, string thuc_don, string noi_dung_tom_tat, string ten_mon, string dvt, string don_gia, string noi_dung_chi_tiet, string hinh,string mamon)
        {
            DAL_ql.Cap_nhat_mon_an(ma_loai, thuc_don, noi_dung_tom_tat, ten_mon, dvt, don_gia, noi_dung_chi_tiet, hinh,mamon);
        }

        public void Xoa_mon_an(string mamon)
        {
            DAL_ql.Xoa_mon_an(mamon);
        }
        //hết tab món ăn
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace ql_nha_hang
{
    public partial class GUI_form_tra_cuu : Form
    {
        BUS_tra_cuu BUS_tc = new BUS_tra_cuu();
        public GUI_form_tra_cuu()
        {
            InitializeComponent();
        }

        private void btn_tim_mon_an_Click(object sender, EventArgs e)
        {
            dtg_monan.DataSource = BUS_tc.Tim_mon_an(txt_tim_monan.Text);
        }

        private void btn_timkhachhang_Click(object sender, EventArgs e)
        {
            dtg_khachhang.DataSource =BUS_tc.Tim_khach_hang(txt_timkhachhang.Text);
        }

        private void btn_timnhanvien_Click(object sender, EventArgs e)
        {
            dtg_nhanvien.DataSource =BUS_tc.Tim_nhan_vien(txt_timnhanvien.Text);
        }

        private void btn_timhoadon_Click(object sender, EventArgs e)
        {
            dtg_timhoadon.DataSource =BUS_tc.Tim_hoa_don(txt_timhoadon.Text);
        }

        private void btn_timthucdon_Click(object sender, EventArgs e)
        {
            dtg_thucdon.DataSource = BUS_tc.Tim_thuc_don(txt_timthucdon.Text);
        }
        

        private void dtg_timhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = dtg_timhoadon.Rows[dtg_timhoadon.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dtg_CTHD.DataSource =BUS_tc.Tim_chi_tiet_hoa_don(maHD);
            }
            catch { MessageBox.Show("Chọn hóa đơn cần xem."); }
        }

        

        private void dtg_thucdon_Click(object sender, EventArgs e)
        {
            try
            {
                string mathucdon = dtg_thucdon.Rows[dtg_thucdon.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dtg_chitietthucdon.DataSource =BUS_tc.Tim_chi_tiet_thuc_don(mathucdon);
            }
            catch { MessageBox.Show("Chọn thực đơn cần xem."); }
        }



        

        
    }
}

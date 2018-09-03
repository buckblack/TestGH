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
    public partial class GUI_form_thong_ke : Form
    {
        BUS_thong_ke BUS_tk = new BUS_thong_ke();
        public GUI_form_thong_ke()
        {
            InitializeComponent();

        }

        private void btn_inHD_Click(object sender, EventArgs e)
        {
            GUI_IN_HoaDon i = new GUI_IN_HoaDon(dtimep_HD.Text);
            i.ShowDialog();
        }

        private void btn_timHD_Click(object sender, EventArgs e)
        {
            dtg_dsHD.DataSource = BUS_tk.Lay_ds_thong_ke_hoa_don(dtimep_HD.Text);
        }

        private void btn_timMonan_Click(object sender, EventArgs e)
        {
            dtg_monan.DataSource = BUS_tk.Lay_ds_thong_ke_mon_an(dtimep_monan.Text);
        }

        private void btn_inMonan_Click(object sender, EventArgs e)
        {
            GUI_IN_MonAn i = new GUI_IN_MonAn(dtimep_monan.Text);
            i.ShowDialog();
        }


        
    }
}

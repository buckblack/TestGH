using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ql_nha_hang
{
    public partial class GUI_IN_HoaDon : Form
    {
        BUS_thong_tin BUS_tttk = new BUS_thong_tin();
        public GUI_IN_HoaDon()
        {
            InitializeComponent();
        }
        public string thang;
        public GUI_IN_HoaDon(string thang)
        {
            InitializeComponent();
            this.thang = thang;
        }

        private void IN_HoaDon_Load(object sender, EventArgs e)
        {
            Report_Hoa_don rpt = new Report_Hoa_don();
            rpt.SetParameterValue("loc_thang", thang);
            rpt.SetParameterValue("nhan_vien_lap", BUS_tttk.ten_nhan_vien());
            rpt.SetDatabaseLogon(BUS_tttk.ten_dang_nhap(), BUS_tttk.mat_khau(), BUS_tttk.ten_server(), BUS_tttk.ten_database());
            crystalReportViewer_HD.ReportSource = rpt;
            crystalReportViewer_HD.Refresh();
        }
    }
}

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
    public partial class GUI_form_thanh_toan : Form
    {
        BUS_thanh_toan BUS_tt=new BUS_thanh_toan();
        string soban;
        public GUI_form_thanh_toan()
        {
            InitializeComponent();
        }
        public GUI_form_thanh_toan(string soban)
        {
            InitializeComponent();
            this.soban = soban;
            txt_soban.Text = soban;
            
        }

        private void form_thanh_toan_Load(object sender, EventArgs e)
        {
            if(txt_soban.Text!="")
                btn_tim.PerformClick();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            timhoadon(txt_soban.Text);
        }

        void timhoadon(string maban)
        {
            if (txt_soban.Text.Length > 0)
            {
                dtg_dsmonan.DataSource = BUS_tt.Lay_ds_theo_ban(maban);
                try
                {
                    string sohd= dtg_dsmonan.Rows[dtg_dsmonan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    txt_soHD.Text = sohd;
                    txt_tongtien.Text = BUS_tt.Lay_tong_tien_hoa_don(sohd);
                }
                catch 
                {
                    txt_soHD.Text = "";
                    txt_tongtien.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số bàn!");
                txt_soban.Focus();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_soHD.Text == "")
            {
                MessageBox.Show("Bàn trống! Vui lòng chọn bàn đang phục vụ!");
            }
            else
            {
                if (MessageBox.Show("Xác nhận thanh toán hóa đơn: " + txt_soHD.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //trạng thái hóa đơn: đã thanh toán, cập nhật tổng tiền, cập nhật nhân viên nào thanh toán
                    BUS_tt.update_thong_tin_hoa_don(txt_soHD.Text);
                    //trạng thái bàn: trống
                    BUS_tt.update_thong_tin_ban(txt_soHD.Text);
                    MessageBox.Show("Thanh toán thành công");
                    timhoadon("-1");
                    txt_soHD.Text = "";
                }
            }
        }
    }
}

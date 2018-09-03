using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom_Control;
using BUS;

namespace ql_nha_hang
{
    public partial class GUI_form_dat_ban : Form
    {
        BUS_dat_ban BUS_db = new BUS_dat_ban();
        public GUI_form_dat_ban()
        {
            InitializeComponent();
            
        }

        private void form_dat_ban_Load(object sender, EventArgs e)
        {
            load_cb_songuoi();
            load_ds_ban(BUS_db.Lay_tat_ca_ban());
  
        }

        void load_cb_songuoi()
        {
            cb_songuoi.Items.Add("all");
            cb_songuoi.Items.Add("2");
            cb_songuoi.Items.Add("4");
            cb_songuoi.Items.Add("10");
            cb_songuoi.SelectedIndex = 0;
        }

        void load_ds_ban(DataTable data_tb)
        {
            pnl_ban.Controls.Clear();
            int top = 0;
            int left = 0;
            int dem = 0;

            foreach (DataRow dr in data_tb.Rows)
            {
                if (dem == 12)
                {
                    top += 76;
                    left = 0;
                    dem = 0;
                }
                button_datban btn = new button_datban();
                btn.Top = top;
                btn.Left = left;
                btn.Text = dr[0].ToString();
                string hd = dr[3].ToString();
                if (hd != "")
                {
                    btn.Tag = hd;
                }
                else
                {
                    btn.Tag = "";
                }
                string trangthai = dr[2].ToString();
                if (trangthai == "Đang phục vụ")
                {
                    btn.BackColor = Color.DarkSlateGray;
                }
                btn.Click += btn_Click;
                pnl_ban.Controls.Add(btn);
                left += 76;
                dem++;

            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            button_datban btn= sender as button_datban;
            string tenkh = "";
            if (btn.Tag.ToString() != "")
            {
                tenkh = BUS_db.Lay_ten_khach(btn.Tag.ToString());
            }

            GUI_form_goi_mon g = new GUI_form_goi_mon(btn.Text.ToString(),btn.Tag.ToString(),tenkh);
            this.Hide();
            g.ShowDialog();
            this.Show();
            btn_reload.PerformClick();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GUI_form_goi_mon g = new GUI_form_goi_mon();
            this.Hide();
            g.ShowDialog();
            this.Show();
        }

        private void cb_songuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_songuoi.SelectedItem.ToString() == "2")
            {
                load_ds_ban(BUS_db.Lay_ban_theo_so_nguoi("2"));
            }
            else if (cb_songuoi.SelectedItem.ToString() == "4")
            {
                load_ds_ban(BUS_db.Lay_ban_theo_so_nguoi("4"));
            }
            else if (cb_songuoi.SelectedItem.ToString() == "10")
            {
                load_ds_ban(BUS_db.Lay_ban_theo_so_nguoi("10"));
            }
            else
            {
                load_ds_ban(BUS_db.Lay_tat_ca_ban());
            }

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            load_ds_ban(BUS_db.Lay_ban_theo_ten_khach(txt_ten_kh.Text));
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            load_ds_ban(BUS_db.Lay_tat_ca_ban());
        }

       
    }
}

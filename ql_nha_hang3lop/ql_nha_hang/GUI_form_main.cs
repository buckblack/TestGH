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
    public partial class GUI_form_main : Form
    {
        BUS_thong_tin BUS_tttk = new BUS_thong_tin();
        public GUI_form_main()
        {
            InitializeComponent();
        }

        private void fdghdfgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_dat_ban_Click(object sender, EventArgs e)
        {
            GUI_form_dat_ban d = new GUI_form_dat_ban();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            GUI_form_thanh_toan t = new GUI_form_thanh_toan();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void btn_doi_mat_khau_Click(object sender, EventArgs e)
        {
            GUI_form_doi_mat_khau d = new GUI_form_doi_mat_khau();
            d.ShowDialog();
        }

        private void btn_tra_cuu_Click(object sender, EventArgs e)
        {
            GUI_form_tra_cuu t = new GUI_form_tra_cuu();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void btn_thong_ke_Click(object sender, EventArgs e)
        {
            GUI_form_thong_ke t = new GUI_form_thong_ke();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void btn_quan_ly_Click(object sender, EventArgs e)
        {
            GUI_form_quan_ly q = new GUI_form_quan_ly();
            this.Hide();
            q.ShowDialog();
            this.Show();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            if (BUS_tttk.quyen_nhan_vien() == 0)
            {
                btn_quan_ly.Visible = false;
            }
        }
    }
}

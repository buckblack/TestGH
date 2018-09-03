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
    public partial class GUI_form_dang_nhap : Form
    {
        BUS_dang_nhap BUS_dn = new BUS_dang_nhap();
        public GUI_form_dang_nhap()
        {
            InitializeComponent();
        }

        private void form_dang_nhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_dn.kiemtra_dangnhap(txt_user.Text, txt_pass.Text))
                {
                    GUI_form_main f = new GUI_form_main();
                    f.Text = "Phần mềm quản lý nhà hàng - " + BUS_dn.ten_nhan_vien();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
            catch 
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.");
            }

        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_dang_nhap.PerformClick();
        }



        private void form_dang_nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

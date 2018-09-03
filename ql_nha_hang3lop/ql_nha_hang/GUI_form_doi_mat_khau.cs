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
    public partial class GUI_form_doi_mat_khau : Form
    {
        BUS_doi_mat_khau BUS_dmk = new BUS_doi_mat_khau();
        public GUI_form_doi_mat_khau()
        {
            InitializeComponent();
            
        }

        private void btn_xac_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhân đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_mkht.Text.Trim() != "" && txt_mkmoi.Text.Trim() != "" && txt_nhaplaimk.Text.Trim() != "")
                    {
                        if (txt_mkmoi.Text == txt_nhaplaimk.Text)
                        {
                            if (BUS_dmk.kiemtra_doi_mat_khau(txt_mkht.Text, txt_mkmoi.Text))
                            {
                                MessageBox.Show("Đổi thành công.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu hiện tại không đúng");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới chưa trùng khớp");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được bỏ trống");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau.");
            }
        }
    }
}

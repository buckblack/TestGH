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
    public partial class GUI_form_thay_doi_so_luong : Form
    {
        BUS_thay_doi_so_luong BUS_tdsl = new BUS_thay_doi_so_luong();
        string hoadon, mamon;
        public GUI_form_thay_doi_so_luong()
        {
            InitializeComponent();
        }

        public GUI_form_thay_doi_so_luong(string hoadon, string mamon)
        {
            InitializeComponent();
            this.hoadon = hoadon;
            this.mamon = mamon;
            txt_hoadon.Text = hoadon;
            txt_mamon.Text = mamon;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_mamon.Text != "")
            {
                if (txt_soluong.Text != "0" && txt_soluong.Text.Length > 0)
                {
                    if (MessageBox.Show("Bạn có chắc muốn thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUS_tdsl.thay_doi_so_luong(txt_soluong.Text, txt_hoadon.Text, txt_mamon.Text);
                        MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món ăn");
            }

        }
    }
}

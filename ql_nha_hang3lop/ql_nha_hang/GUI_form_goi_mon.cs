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
    public partial class GUI_form_goi_mon : Form
    {
        BUS_goi_mon BUS_gm = new BUS_goi_mon();
        public string soban, sohd,tenkh;
        public GUI_form_goi_mon()
        {
            InitializeComponent();
        }
        public GUI_form_goi_mon(string soban,string sohd,string tenkh)
        {
            InitializeComponent();
            this.soban = soban;
            this.sohd = sohd;
            this.tenkh = tenkh;
        }

        private void form_goi_mon_Load(object sender, EventArgs e)
        {
            txt_soban.Text = soban;
            txt_sohd.Text = sohd;
            txt_tenkh.Text = tenkh;
            hientongtien();
            load_cbo_monan();
            if (txt_sohd.Text != "")
            {
                dtg_dsMonan.DataSource=BUS_gm.Lay_cac_mon_da_goi(txt_sohd.Text);
            }
        }


        void hientongtien()
        {
            if (txt_sohd.Text != "")
            {
                txt_tongtien.Text = BUS_gm.tongtien(txt_sohd.Text);
            }
            else
            {
                txt_tongtien.Text = "0";
            }
        }
        void load_cbo_monan()
        {
            cbo_monan.DataSource = BUS_gm.Lay_ds_tat_ca_mon_an();
            cbo_monan.DisplayMember = "ten_mon";//hiện thị
            cbo_monan.ValueMember = "id";//xử lý
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_soluong.Text.Length > 0 && txt_soluong.Text != "0")
            {

                if (kiemtra_tontai_monan_tronglist(cbo_monan.SelectedValue.ToString()) == false)//kiểm tra có tồn tại trong danh sách sắp thêm ko
                {
                    if (kiemtra_tontai_monan_trongdatagrid(cbo_monan.SelectedValue.ToString()) == false)//kiểm tra xem đã gọi trước đó hay chưa
                    {
                        string[] item_monan = BUS_gm.Lay_1_mon_an(cbo_monan.SelectedValue.ToString());
                        ListViewItem item = new ListViewItem();
                        item.Text = item_monan[0];
                        item.SubItems.Add(item_monan[1]);
                        item.SubItems.Add(item_monan[2]);
                        item.SubItems.Add(txt_soluong.Text);
                        item.SubItems.Add(item_monan[3]);
                        double thanhtien = (double.Parse(item_monan[3]) * double.Parse(txt_soluong.Text));
                        item.SubItems.Add(thanhtien.ToString());
                        lv_dsMonan.Items.Add(item);
                        txt_tongtien.Text = (double.Parse(txt_tongtien.Text) + thanhtien).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Món ăn đã tồn tại trong hóa đơn");
                    }
                }
                else
                {
                    MessageBox.Show("Món ăn đã tồn tại trong danh sách");
                }

            }
            else 
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
            }
        }

        bool kiemtra_tontai_monan_tronglist(string ma_mon)
        {
            for (int i = 0; i < lv_dsMonan.Items.Count; i++)
            {
                if (lv_dsMonan.Items[i].SubItems[0].Text.ToString() == ma_mon)
                    return true;
            }
            return false;
        }
        bool kiemtra_tontai_monan_trongdatagrid(string ma_mon)
        {
            for (int i = 0; i < dtg_dsMonan.RowCount-1; i++)
            {
                if(dtg_dsMonan.Rows[i].Cells[1].Value.ToString()==ma_mon)
                    return true;
            }
            return false;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                foreach (ListViewItem item in lv_dsMonan.SelectedItems)
                {
                    txt_tongtien.Text = (double.Parse(txt_tongtien.Text) - double.Parse(item.SubItems[5].Text)).ToString();
                    lv_dsMonan.Items.Remove(item);
                }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (lv_dsMonan.Items.Count > 0)
            {
                if (MessageBox.Show("Xác nhận gọi món", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_sohd.Text == "")//bàn trống, chưa có hóa đơn
                    {
                        BUS_gm.Them_hoa_don_moi(txt_soban.Text, txt_tongtien.Text);//thêm 1 hóa  đơn mới
                        string sohd=BUS_gm.Lay_hoa_don_moi_them();//lấy số hd mới thêm
                        BUS_gm.update_ban(sohd, txt_soban.Text);//update bàn
                        for (int i = 0; i < lv_dsMonan.Items.Count; i++)//thêm từng dòng CTHD
                        {

                            string ma_mon=lv_dsMonan.Items[i].SubItems[0].Text.ToString();
                            string so_luong=lv_dsMonan.Items[i].SubItems[3].Text.ToString();
                            string don_gia=lv_dsMonan.Items[i].SubItems[4].Text.ToString();
                            string thanh_tien=lv_dsMonan.Items[i].SubItems[5].Text.ToString();
                            BUS_gm.Them_1_CTHD(sohd,ma_mon,so_luong,don_gia,thanh_tien);
                        }
                        MessageBox.Show("Đặt món thành công");
                        this.Close();
                    }
                    else//bàn đang sử dụng
                    {
                        for (int i = 0; i < lv_dsMonan.Items.Count; i++)
                        {
                            string ma_mon = lv_dsMonan.Items[i].SubItems[0].Text.ToString();
                            string so_luong = lv_dsMonan.Items[i].SubItems[3].Text.ToString();
                            string don_gia = lv_dsMonan.Items[i].SubItems[4].Text.ToString();
                            string thanh_tien = lv_dsMonan.Items[i].SubItems[5].Text.ToString();
                            BUS_gm.Them_1_CTHD(sohd, ma_mon, so_luong, don_gia, thanh_tien);
                        }
                        MessageBox.Show("Đặt món thành công");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn món ăn");
                }
            }

        }





        private void thayĐổiSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtg_dsMonan.RowCount > 1)
            {
                string mahoadon = dtg_dsMonan.Rows[dtg_dsMonan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string mamon = dtg_dsMonan.Rows[dtg_dsMonan.CurrentCell.RowIndex].Cells[1].Value.ToString();
                GUI_form_thay_doi_so_luong f = new GUI_form_thay_doi_so_luong(mahoadon, mamon);
                f.ShowDialog();
                dtg_dsMonan.DataSource = BUS_gm.Lay_cac_mon_da_goi(txt_sohd.Text);//refresh lại datagridview
                hientongtien();
            }
            else
            {
                MessageBox.Show("Chưa chọn món ăn");
            }

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_sohd.Text == "")
            {
                MessageBox.Show("Bàn đang trống, không thể thanh toán");
            }
            else
            {
                GUI_form_thanh_toan f = new GUI_form_thanh_toan(txt_soban.Text);
                f.ShowDialog();
                this.Close();
            }
        }
    }
}

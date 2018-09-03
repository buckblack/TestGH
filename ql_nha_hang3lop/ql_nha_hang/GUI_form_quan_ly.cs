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
    public partial class GUI_form_quan_ly : Form
    {
        BUS_quan_ly BUS_ql = new BUS_quan_ly();
        BUS_thong_tin BUS_tt = new BUS_thong_tin();
        OpenFileDialog OpenFileDialog_tintuc = new OpenFileDialog();
        OpenFileDialog OpenFileDialog_monan = new OpenFileDialog();
        public GUI_form_quan_ly()
        {
            InitializeComponent();
        }

        private void form_quan_ly_Load(object sender, EventArgs e)
        {

        }

        //bắt đầu tab web
        void load_gopy_web()
        {
            dtg_gopy_web.DataSource = BUS_ql.Lay_danh_sach_gopy_web();
        }

        private void btn_reload_gopy_Click(object sender, EventArgs e)
        {
            load_gopy_web();
        }
        //kết thúc tab web

        //bắt đầu tab nhân viên
        private void btn_tim_nhanvien_Click(object sender, EventArgs e)
        {
            dtg_nhanvien.DataSource = BUS_ql.Tim_nhan_vien(txt_tim_nhanvien.Text);
        }

        private void btn_them_nhanvien_Click(object sender, EventArgs e)
        {
            if (txt_ten_nhanvien.Text.Trim() == "" || txt_email_nhanvien.Text.Trim() == "" || txt_pass_nhanvien.Text.Trim() == "" || txt_diachi_nhanvien.Text.Trim() == "" || txt_dienthoai_nhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đầy đủ");
            }
            else
            {
                try
                {
                    BUS_ql.Them_nhan_vien(txt_ten_nhanvien.Text, txt_email_nhanvien.Text, txt_pass_nhanvien.Text, txt_diachi_nhanvien.Text, txt_dienthoai_nhanvien.Text);
                    MessageBox.Show("Thêm thành công");
                    btn_reload_nhanvien.PerformClick();
                    btn_tim_nhanvien.PerformClick();  
                }
                catch 
                {
                    MessageBox.Show("Email đã tồn tại");
                }
            }
        }

        private void dtg_nhanvien_Click(object sender, EventArgs e)
        {
            string ten = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string email = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string diachi = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string dienthoai = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txt_ten_nhanvien.Text = ten;
            txt_email_nhanvien.Text = email;
            txt_dienthoai_nhanvien.Text = diachi;
            txt_diachi_nhanvien.Text = dienthoai;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (manv != "")
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        BUS_ql.Xoa_nhan_vien(manv);
                        MessageBox.Show("Xóa thành công");
                        ClearTexbox(tab_nhanvien);
                        btn_tim_nhanvien.PerformClick();
                    }
                }
            }
            catch
            { }
        }

        private void btn_capnhat_nhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = dtg_nhanvien.Rows[dtg_nhanvien.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (txt_ten_nhanvien.Text.Trim() != ""  && txt_diachi_nhanvien.Text.Trim() != "" && txt_dienthoai_nhanvien.Text.Trim() != "")
                {
                    if (MessageBox.Show("Bạn có chắc muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUS_ql.Cap_nhat_nhan_vien(manv, txt_ten_nhanvien.Text, txt_diachi_nhanvien.Text, txt_dienthoai_nhanvien.Text);
                        MessageBox.Show("Cập nhật thành công");
                        ClearTexbox(tab_nhanvien);
                        btn_tim_nhanvien.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu đầy đủ");
                }
            }
            catch { }
        }

        private void btn_reload_nhanvien_Click(object sender, EventArgs e)
        {
            ClearTexbox(tab_nhanvien);
        }
        //kết thúc tab nhân viên


        //bắt đầu tab tin tức
        private void btn_tim_tintuc_Click(object sender, EventArgs e)
        {
            dtg_tintuc.DataSource = BUS_ql.Lay_danh_sach_tin_tuc(txt_tim_tintuc.Text);
        }

        private void dtg_tintuc_Click(object sender, EventArgs e)
        {
            try
            {
                string tieude = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string tomtat = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string chitiet = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[3].Value.ToString();
                string tacgia = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string hinh = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[5].Value.ToString();
                txt_tieude_tintuc.Text = tieude;
                txt_tomtat_tintuc.Text = tomtat;
                txt_tacgia_tintuc.Text = tacgia;
                txt_chitiet_tintuc.Text = chitiet;
                picB_tintuc.Image = Image.FromFile(BUS_tt.PathImage_tintuc() + hinh);
            }
            catch
            {
                picB_tintuc.Image = picB_tintuc.ErrorImage;
            }

        }

        private void btn_reload_tintuc_Click(object sender, EventArgs e)
        {
            ClearTexbox(tab_tintuc);
            btn_tim_tintuc.PerformClick();
        }

        private void btn_them_tintuc_Click(object sender, EventArgs e)
        {
            if (txt_tieude_tintuc.Text.Trim() == "" || txt_tomtat_tintuc.Text.Trim() == "" || txt_chitiet_tintuc.Text.Trim() == "" || txt_tacgia_tintuc.Text.Trim() == "" || OpenFileDialog_tintuc.FileName=="")
            {
                MessageBox.Show("Chưa nhập dữ liệu đầy đủ, hoặc chưa chọn hình");
            }
            else
            {
                BUS_ql.Them_tin_tuc(txt_tieude_tintuc.Text, txt_tomtat_tintuc.Text, txt_chitiet_tintuc.Text, txt_tacgia_tintuc.Text, System.IO.Path.GetFileName(OpenFileDialog_tintuc.FileName));
                move_hinh(OpenFileDialog_tintuc.FileName, BUS_tt.PathImage_tintuc() + System.IO.Path.GetFileName(OpenFileDialog_tintuc.FileName));
                MessageBox.Show("Thêm thành công");
                OpenFileDialog_tintuc.FileName = "";
                btn_reload_tintuc.PerformClick();
            }
        }

        private void btn_capnhat_tintuc_Click(object sender, EventArgs e)
        {
            if (txt_tieude_tintuc.Text.Trim() == "" || txt_tomtat_tintuc.Text.Trim() == "" || txt_chitiet_tintuc.Text.Trim() == "" || txt_tacgia_tintuc.Text.Trim() == "" || OpenFileDialog_tintuc.FileName == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đầy đủ, hoặc chưa chọn hình");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matin = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    BUS_ql.Cap_nhat_tin_tuc(matin,txt_tieude_tintuc.Text, txt_tomtat_tintuc.Text, txt_chitiet_tintuc.Text, txt_tacgia_tintuc.Text, System.IO.Path.GetFileName(OpenFileDialog_tintuc.FileName));
                    move_hinh(OpenFileDialog_tintuc.FileName, BUS_tt.PathImage_tintuc() + System.IO.Path.GetFileName(OpenFileDialog_tintuc.FileName));
                    MessageBox.Show("Cập nhật thành công");
                    OpenFileDialog_tintuc.FileName = "";
                    btn_reload_tintuc.PerformClick();
                }

            }
        }

        private void picB_tintuc_DoubleClick(object sender, EventArgs e)
        {
            
            OpenFileDialog_tintuc.Filter = "PNG Image|*.png|JPEG Image|*.jpg|All Files|*.*";//lọc file
            string tenfile = "";
            if (OpenFileDialog_tintuc.ShowDialog() == DialogResult.OK)
            {
                tenfile = OpenFileDialog_tintuc.FileName;
            }
            try
            {
                picB_tintuc.Image = Image.FromFile(tenfile);
            }
            catch { picB_tintuc.Image = picB_tintuc.ErrorImage; }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string matintuc = dtg_tintuc.Rows[dtg_tintuc.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (matintuc != "")
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUS_ql.Xoa_tin_tuc(matintuc);
                        MessageBox.Show("Xóa thành công");
                        ClearTexbox(tab_tintuc);
                        btn_reload_tintuc.PerformClick();
                        picB_tintuc.Image = picB_tintuc.ErrorImage;
                    }
                }
            }
            catch
            { }
        }

        //kết thúc tab tin tức


        //bắt đầu tab Bàn
        private void btn_reload_ban_Click(object sender, EventArgs e)
        {
            dtg_ban.DataSource = BUS_ql.Lay_danh_sach_ban();
        }

        private void btn_capnhat_ban_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_songuoi_ban.Text == "")
                {
                    MessageBox.Show("Chưa chọn số người");
                }
                else
                {
                    string ma_ban = dtg_ban.Rows[dtg_ban.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    //lấy loại bàn
                    string loaiban = BUS_ql.Lay_loai_ban((rad_co_ban.Checked) ? "1" : "0", cbo_songuoi_ban.Text);
                    //cập nhật bàn
                    BUS_ql.Cap_nhat_ban(loaiban, ma_ban);
                    MessageBox.Show("Cập nhật thành công");
                    btn_reload_ban.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật!");
            }
        }

        private void btn_them_ban_Click(object sender, EventArgs e)
        {
            if (cbo_songuoi_ban.Text == "")
            {
                MessageBox.Show("Chưa chọn số người");
            }
            else
            {
                //lấy loại bàn
                string loaiban = BUS_ql.Lay_loai_ban((rad_co_ban.Checked) ? "1" : "0", cbo_songuoi_ban.Text);
                //thêm bàn
                BUS_ql.Them_ban(loaiban);
                MessageBox.Show("Thêm thành công");
                btn_reload_ban.PerformClick();
            }
        }

        private void xóaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_ban.Rows[dtg_ban.CurrentCell.RowIndex].Cells[2].Value.ToString() != "Trống")
                {
                    MessageBox.Show("Không thể xóa bàn này!");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        BUS_ql.Xoa_ban(dtg_ban.Rows[dtg_ban.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Xóa thành công");
                        btn_reload_ban.PerformClick();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }
        private void dtg_ban_Click(object sender, EventArgs e)
        {
            try
            {
                string dattruoc = dtg_ban.Rows[dtg_ban.CurrentCell.RowIndex].Cells[4].Value.ToString();
                if (dattruoc == "Có")
                {
                    rad_co_ban.Checked = true;
                    
                }
                else
                {
                    rad_khong_ban.Checked = true;
                }
            }
            catch
            {

            }
        }

        //kết thúc tab bàn


        //bắt đầu tab loại món ăn
        private void btn_tim_loaimonan_Click(object sender, EventArgs e)
        {
            dtg_loaimonan.DataSource = BUS_ql.Lay_danh_sach_loai_mon_an(txt_tim_loaimonan.Text);
        }

        private void btn_reload_loaimonan_Click(object sender, EventArgs e)
        {
            ClearTexbox(tab_loaimonan);
            btn_tim_loaimonan.PerformClick();
        }

        private void btn_them_loaimonan_Click(object sender, EventArgs e)
        {
            if (txt_mota_loaimonan.Text.Trim() == "" || txt_ten_loaimonan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS_ql.Them_loai_mon_an(txt_ten_loaimonan.Text, txt_mota_loaimonan.Text);
                    MessageBox.Show("Thêm thành công");
                    btn_reload_loaimonan.PerformClick();
                }
            }
        }

        private void btn_capnhat_loaimonan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mota_loaimonan.Text.Trim() == "" || txt_ten_loaimonan.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string maloai = dtg_loaimonan.Rows[dtg_loaimonan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        BUS_ql.Cap_nhat_loai_mon_an(maloai,txt_ten_loaimonan.Text, txt_mota_loaimonan.Text);
                        MessageBox.Show("Cập nhật thành công");
                        btn_reload_loaimonan.PerformClick();
                    }
                }
            }
            catch { }
        }

        private void dtg_loaimonan_Click(object sender, EventArgs e)
        {
            try
            {
                string tenloai = dtg_loaimonan.Rows[dtg_loaimonan.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string mota = dtg_loaimonan.Rows[dtg_loaimonan.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txt_ten_loaimonan.Text = tenloai;
                txt_mota_loaimonan.Text = mota;
            }
            catch
            {

            }
        }

        //Kết thúc tab loại món ăn


        //bắt đầu tab món ăn
        private void btn_tim_monan_Click(object sender, EventArgs e)
        {
            dtg_monan.DataSource =BUS_ql.Lay_danh_sach_mon_an(txt_tim_monan.Text);
            load_cbo_monan();
        }

        void load_cbo_monan()
        {
            cbo_loaimon_monan.DataSource = BUS_ql.Lay_combobox_loai_mon_an();
            cbo_loaimon_monan.DisplayMember = "ten_loai";
            cbo_loaimon_monan.ValueMember = "id";
            cbo_thucdon_monan.DataSource = BUS_ql.Lay_combobox_thuc_don();
            cbo_thucdon_monan.DisplayMember = "ten_mon";
            cbo_thucdon_monan.ValueMember = "id";
        }

        private void btn_reload_monan_Click(object sender, EventArgs e)
        {
            ClearTexbox(tab_monan);
            load_cbo_monan();
            btn_tim_monan.PerformClick();
        }

        private void btn_them_monan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_loaimon_monan.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn loại món");
                }
                else
                {
                    if (txt_tomtat_monan.Text.Trim() == "" || txt_tenmon_monan.Text.Trim() == "" || txt_dvt_mon_an.Text.Trim() == "" || txt_dongia_monan.Text.Trim() == "" || txt_chitiet_monan.Text.Trim() == "" || OpenFileDialog_monan.FileName == "")
                    {
                        MessageBox.Show("Chưa nhập dữ liệu đầy đủ hoặc chưa chọn hình");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string hinh = System.IO.Path.GetFileName(OpenFileDialog_monan.FileName);
                            string thucdon=(rad_co_monan.Checked) ? cbo_thucdon_monan.SelectedValue.ToString() : "0";
                            BUS_ql.Them_mon_an(cbo_loaimon_monan.SelectedValue.ToString(),thucdon,txt_tomtat_monan.Text,txt_tenmon_monan.Text,txt_dvt_mon_an.Text,txt_dongia_monan.Text,txt_chitiet_monan.Text,hinh);
                            move_hinh(OpenFileDialog_monan.FileName, BUS_tt.PathImage_monan() + System.IO.Path.GetFileName(OpenFileDialog_monan.FileName));
                            MessageBox.Show("Thêm thành công");
                            OpenFileDialog_monan.FileName = "";
                            btn_reload_monan.PerformClick();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void btn_capnhat_monan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_loaimon_monan.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn loại món");
                }
                else
                {
                    if (txt_tomtat_monan.Text.Trim() == "" || txt_tenmon_monan.Text.Trim() == "" || txt_dvt_mon_an.Text.Trim() == "" || txt_dongia_monan.Text.Trim() == "" || txt_chitiet_monan.Text.Trim() == "" || OpenFileDialog_monan.FileName == "")
                    {
                        MessageBox.Show("Chưa nhập dữ liệu đầy đủ hoặc chưa chọn hình");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string mamon = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                            string hinh = System.IO.Path.GetFileName(OpenFileDialog_monan.FileName);
                            string thucdon = (rad_co_monan.Checked) ? cbo_thucdon_monan.SelectedValue.ToString() : "0";
                            BUS_ql.Cap_nhat_mon_an(cbo_loaimon_monan.SelectedValue.ToString(), thucdon, txt_tomtat_monan.Text, txt_tenmon_monan.Text, txt_dvt_mon_an.Text, txt_dongia_monan.Text, txt_chitiet_monan.Text, hinh,mamon);
                            move_hinh(OpenFileDialog_monan.FileName, BUS_tt.PathImage_monan() + System.IO.Path.GetFileName(OpenFileDialog_monan.FileName));
                            MessageBox.Show("Cập nhật thành công");
                            OpenFileDialog_monan.FileName = "";
                            btn_reload_monan.PerformClick();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void picB_monan_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog_monan.Filter = "PNG Image|*.png|JPEG Image|*.jpg|All Files|*.*";//lọc file
            string tenfile = "";
            if (OpenFileDialog_monan.ShowDialog() == DialogResult.OK)
            {
                tenfile = OpenFileDialog_monan.FileName;
            }
            try
            {
                picB_monan.Image = Image.FromFile(tenfile);
            }
            catch { picB_monan.Image = picB_tintuc.ErrorImage; }
        }

        private void dtg_monan_Click(object sender, EventArgs e)
        {
            try
            {
                string tenmon = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string dongia = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[5].Value.ToString();
                string dvt = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[6].Value.ToString();
                string tomtat = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[3].Value.ToString();
                string chitiet = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string hinh = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[8].Value.ToString();
                txt_tomtat_monan.Text = tomtat;
                txt_tenmon_monan.Text = tenmon;
                txt_dvt_mon_an.Text = dvt;
                txt_dongia_monan.Text = dongia;
                txt_chitiet_monan.Text = chitiet;
                picB_monan.Image = Image.FromFile(BUS_tt.PathImage_monan() + hinh);
            }
            catch 
            {
                picB_monan.Image = picB_monan.ErrorImage;
            }
            
        }

        private void xóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mamon = dtg_monan.Rows[dtg_monan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    BUS_ql.Xoa_mon_an(mamon);
                    MessageBox.Show("Xóa thành công");
                    btn_reload_monan.PerformClick();
                    picB_monan.Image=picB_monan.ErrorImage;
                }
            }
            catch 
            {
            }
        }

        private void rad_co_monan_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_co_monan.Checked == true)
            {
                cbo_thucdon_monan.Enabled = true;
            }
            else
            {
                cbo_thucdon_monan.Enabled = false;
            }
        }

        //kết thúc tab món ăn


        private void ClearTexbox(Control ctr)
        {
            if (ctr is TextBox)
                ctr.Text = "";
            foreach (Control item in ctr.Controls)
                ClearTexbox(item);
        }

        void move_hinh(string nguon, string dich)
        {
            try
            {
                System.IO.File.Copy(nguon, dich);
            }
            catch { }
        }

  
        
    }
}

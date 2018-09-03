namespace ql_nha_hang
{
    partial class GUI_form_thay_doi_so_luong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_form_thay_doi_so_luong));
            this.btn_xacnhan = new Custom_Control.button_xanh();
            this.txt_hoadon = new Custom_Control.textbox_nhapso();
            this.label_to1 = new Custom_Control.label_to();
            this.label_to2 = new Custom_Control.label_to();
            this.txt_mamon = new Custom_Control.textbox_nhapso();
            this.label_to3 = new Custom_Control.label_to();
            this.txt_soluong = new Custom_Control.textbox_nhapso();
            this.SuspendLayout();
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(12, 122);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(269, 36);
            this.btn_xacnhan.TabIndex = 0;
            this.btn_xacnhan.Text = "Xác nhận thay đổi";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // txt_hoadon
            // 
            this.txt_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoadon.Location = new System.Drawing.Point(129, 15);
            this.txt_hoadon.Name = "txt_hoadon";
            this.txt_hoadon.ReadOnly = true;
            this.txt_hoadon.Size = new System.Drawing.Size(140, 26);
            this.txt_hoadon.TabIndex = 2;
            // 
            // label_to1
            // 
            this.label_to1.AutoSize = true;
            this.label_to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_to1.Location = new System.Drawing.Point(49, 15);
            this.label_to1.Name = "label_to1";
            this.label_to1.Size = new System.Drawing.Size(74, 20);
            this.label_to1.TabIndex = 3;
            this.label_to1.Text = "Hóa đơn:";
            // 
            // label_to2
            // 
            this.label_to2.AutoSize = true;
            this.label_to2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_to2.Location = new System.Drawing.Point(57, 50);
            this.label_to2.Name = "label_to2";
            this.label_to2.Size = new System.Drawing.Size(66, 20);
            this.label_to2.TabIndex = 5;
            this.label_to2.Text = "Món ăn:";
            // 
            // txt_mamon
            // 
            this.txt_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamon.Location = new System.Drawing.Point(129, 47);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.ReadOnly = true;
            this.txt_mamon.Size = new System.Drawing.Size(140, 26);
            this.txt_mamon.TabIndex = 4;
            // 
            // label_to3
            // 
            this.label_to3.AutoSize = true;
            this.label_to3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_to3.Location = new System.Drawing.Point(18, 82);
            this.label_to3.Name = "label_to3";
            this.label_to3.Size = new System.Drawing.Size(105, 20);
            this.label_to3.TabIndex = 6;
            this.label_to3.Text = "Số lượng mới:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(129, 79);
            this.txt_soluong.MaxLength = 3;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(140, 26);
            this.txt_soluong.TabIndex = 7;
            // 
            // GUI_form_thay_doi_so_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 170);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label_to3);
            this.Controls.Add(this.label_to2);
            this.Controls.Add(this.txt_mamon);
            this.Controls.Add(this.label_to1);
            this.Controls.Add(this.txt_hoadon);
            this.Controls.Add(this.btn_xacnhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_form_thay_doi_so_luong";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi số lượng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Control.button_xanh btn_xacnhan;
        private Custom_Control.textbox_nhapso txt_hoadon;
        private Custom_Control.label_to label_to1;
        private Custom_Control.label_to label_to2;
        private Custom_Control.textbox_nhapso txt_mamon;
        private Custom_Control.label_to label_to3;
        private Custom_Control.textbox_nhapso txt_soluong;
    }
}
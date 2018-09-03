namespace ql_nha_hang
{
    partial class GUI_form_thong_ke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_form_thong_ke));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_timHD = new Custom_Control.button_xanh();
            this.dtg_dsHD = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtimep_HD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_inHD = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_timMonan = new Custom_Control.button_xanh();
            this.dtg_monan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtimep_monan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inMonan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsHD)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_monan)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1157, 48);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_timHD);
            this.tabPage2.Controls.Add(this.dtg_dsHD);
            this.tabPage2.Controls.Add(this.dtimep_HD);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_inHD);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1149, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_timHD
            // 
            this.btn_timHD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_timHD.FlatAppearance.BorderSize = 0;
            this.btn_timHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timHD.ForeColor = System.Drawing.Color.White;
            this.btn_timHD.Location = new System.Drawing.Point(758, 8);
            this.btn_timHD.Name = "btn_timHD";
            this.btn_timHD.Size = new System.Drawing.Size(74, 41);
            this.btn_timHD.TabIndex = 43;
            this.btn_timHD.Text = "Tìm";
            this.btn_timHD.UseVisualStyleBackColor = false;
            this.btn_timHD.Click += new System.EventHandler(this.btn_timHD_Click);
            // 
            // dtg_dsHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_dsHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_dsHD.BackgroundColor = System.Drawing.Color.White;
            this.dtg_dsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dsHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtg_dsHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_dsHD.Location = new System.Drawing.Point(3, 77);
            this.dtg_dsHD.MultiSelect = false;
            this.dtg_dsHD.Name = "dtg_dsHD";
            this.dtg_dsHD.ReadOnly = true;
            this.dtg_dsHD.RowHeadersVisible = false;
            this.dtg_dsHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_dsHD.Size = new System.Drawing.Size(1143, 442);
            this.dtg_dsHD.TabIndex = 42;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngaydat";
            this.Column3.HeaderText = "Tháng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ma_ban";
            this.Column2.HeaderText = "Số bàn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ten_khach_hang";
            this.Column4.HeaderText = "Tên khách hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "name";
            this.Column5.HeaderText = "Tên nhân viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tong_tien";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // dtimep_HD
            // 
            this.dtimep_HD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimep_HD.CustomFormat = "M-yyyy";
            this.dtimep_HD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimep_HD.Location = new System.Drawing.Point(532, 13);
            this.dtimep_HD.Name = "dtimep_HD";
            this.dtimep_HD.Size = new System.Drawing.Size(220, 31);
            this.dtimep_HD.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Chọn tháng cần xem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Danh sách hóa đơn trong tháng:";
            // 
            // btn_inHD
            // 
            this.btn_inHD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_inHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inHD.ForeColor = System.Drawing.Color.White;
            this.btn_inHD.Image = global::ql_nha_hang.Properties.Resources.printer;
            this.btn_inHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inHD.Location = new System.Drawing.Point(838, 6);
            this.btn_inHD.Name = "btn_inHD";
            this.btn_inHD.Size = new System.Drawing.Size(74, 46);
            this.btn_inHD.TabIndex = 36;
            this.btn_inHD.Text = "IN";
            this.btn_inHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inHD.UseVisualStyleBackColor = false;
            this.btn_inHD.Click += new System.EventHandler(this.btn_inHD_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_timMonan);
            this.tabPage1.Controls.Add(this.dtg_monan);
            this.tabPage1.Controls.Add(this.dtimep_monan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_inMonan);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_timMonan
            // 
            this.btn_timMonan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_timMonan.FlatAppearance.BorderSize = 0;
            this.btn_timMonan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timMonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timMonan.ForeColor = System.Drawing.Color.White;
            this.btn_timMonan.Location = new System.Drawing.Point(758, 7);
            this.btn_timMonan.Name = "btn_timMonan";
            this.btn_timMonan.Size = new System.Drawing.Size(74, 41);
            this.btn_timMonan.TabIndex = 49;
            this.btn_timMonan.Text = "Tìm";
            this.btn_timMonan.UseVisualStyleBackColor = false;
            this.btn_timMonan.Click += new System.EventHandler(this.btn_timMonan_Click);
            // 
            // dtg_monan
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_monan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_monan.BackgroundColor = System.Drawing.Color.White;
            this.dtg_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_monan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtg_monan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_monan.Location = new System.Drawing.Point(3, 77);
            this.dtg_monan.MultiSelect = false;
            this.dtg_monan.Name = "dtg_monan";
            this.dtg_monan.ReadOnly = true;
            this.dtg_monan.RowHeadersVisible = false;
            this.dtg_monan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_monan.Size = new System.Drawing.Size(1143, 442);
            this.dtg_monan.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ngaydat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tháng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã món ăn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ten_mon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên món ăn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ten_loai";
            this.dataGridViewTextBoxColumn4.HeaderText = "Loại món ăn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng đã bán";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dtimep_monan
            // 
            this.dtimep_monan.CustomFormat = "M-yyyy";
            this.dtimep_monan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimep_monan.Location = new System.Drawing.Point(532, 12);
            this.dtimep_monan.Name = "dtimep_monan";
            this.dtimep_monan.Size = new System.Drawing.Size(220, 31);
            this.dtimep_monan.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Chọn tháng cần xem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Danh sách hóa đơn trong tháng:";
            // 
            // btn_inMonan
            // 
            this.btn_inMonan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_inMonan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inMonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inMonan.ForeColor = System.Drawing.Color.White;
            this.btn_inMonan.Image = global::ql_nha_hang.Properties.Resources.printer;
            this.btn_inMonan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inMonan.Location = new System.Drawing.Point(838, 5);
            this.btn_inMonan.Name = "btn_inMonan";
            this.btn_inMonan.Size = new System.Drawing.Size(74, 46);
            this.btn_inMonan.TabIndex = 44;
            this.btn_inMonan.Text = "IN";
            this.btn_inMonan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inMonan.UseVisualStyleBackColor = false;
            this.btn_inMonan.Click += new System.EventHandler(this.btn_inMonan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 560);
            this.tabControl1.TabIndex = 32;
            // 
            // GUI_form_thong_ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1157, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI_form_thong_ke";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsHD)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_monan)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_inHD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtimep_HD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_dsHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Custom_Control.button_xanh btn_timHD;
        private Custom_Control.button_xanh btn_timMonan;
        private System.Windows.Forms.DataGridView dtg_monan;
        private System.Windows.Forms.DateTimePicker dtimep_monan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inMonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
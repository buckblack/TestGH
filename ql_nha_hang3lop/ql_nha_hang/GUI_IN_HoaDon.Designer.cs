namespace ql_nha_hang
{
    partial class GUI_IN_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_IN_HoaDon));
            this.crystalReportViewer_HD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_HD
            // 
            this.crystalReportViewer_HD.ActiveViewIndex = -1;
            this.crystalReportViewer_HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_HD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_HD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_HD.Name = "crystalReportViewer_HD";
            this.crystalReportViewer_HD.Size = new System.Drawing.Size(1157, 608);
            this.crystalReportViewer_HD.TabIndex = 0;
            // 
            // GUI_IN_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 608);
            this.Controls.Add(this.crystalReportViewer_HD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_IN_HoaDon";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.IN_HoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_HD;
    }
}
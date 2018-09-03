namespace ql_nha_hang
{
    partial class GUI_IN_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_IN_MonAn));
            this.crystalReportViewer_MonAn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_MonAn
            // 
            this.crystalReportViewer_MonAn.ActiveViewIndex = -1;
            this.crystalReportViewer_MonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_MonAn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_MonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_MonAn.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_MonAn.Name = "crystalReportViewer_MonAn";
            this.crystalReportViewer_MonAn.Size = new System.Drawing.Size(1157, 608);
            this.crystalReportViewer_MonAn.TabIndex = 1;
            // 
            // GUI_IN_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 608);
            this.Controls.Add(this.crystalReportViewer_MonAn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_IN_MonAn";
            this.Text = "IN_MonAn";
            this.Load += new System.EventHandler(this.IN_MonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_MonAn;
    }
}
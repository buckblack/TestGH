using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Custom_Control
{
    public class button_xanh:Button
    {
        public button_xanh()
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(100, 36);
            this.UseVisualStyleBackColor = false;
        }
    }
}

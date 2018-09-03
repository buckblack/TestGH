using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_Control
{
    public class button_datban:Button
    {
        public button_datban()
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(70, 70);
            this.UseVisualStyleBackColor = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_Control
{
    public class radiobutton_to:RadioButton
    {
        public radiobutton_to()
        {
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(475, 49);
            this.Size = new System.Drawing.Size(47, 24);
            this.UseVisualStyleBackColor = true;
        }
    }
}

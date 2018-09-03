using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_Control
{
    public class label_to:Label
    {
        public label_to()
        {
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(256, 70);
            this.Size = new System.Drawing.Size(40, 20);
        }
    }
}

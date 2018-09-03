using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_Control
{
    public class combobox_to:ComboBox
    {
        public combobox_to()
        {
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingEnabled = true;
            this.Size = new System.Drawing.Size(190, 28);       
        }
       
    }
}

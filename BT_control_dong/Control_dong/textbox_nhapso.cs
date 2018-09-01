using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Control_dong
{
    public class textbox_nhapso:TextBox
    {
        public textbox_nhapso()
        {
            this.KeyPress += textbox_nhapso_KeyPress;
        }

        void textbox_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        
    }
}

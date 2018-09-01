using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_dong;


namespace BT_control_dong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            for (int i = 0; i < 15; i++)
            {
                int left = 0;
                for (int j = 0; j <= 15; j++)
                {

                    Button btn = new Button();
                    btn.Width = 30;
                    btn.Height = 30;
                    //btn.Text = i.ToString();
                    btn.Left = left;
                    left += 30;
                    btn.Top = top;
                    btn.Click += btn_Click;
                    panel1.Controls.Add(btn);
                }
                top += 30;
            }
        }

        bool luot = true;
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "")
            {
                if (luot)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }
                luot = !luot;
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert1_Click(object sender, EventArgs e)
        {
            string strText = textbox1.Text;


            byte[] btText;
            btText = System.Text.Encoding.UTF8.GetBytes(strText);
            Array.Reverse(btText);
            BitArray bit = new BitArray(btText);
            StringBuilder sb = new StringBuilder();


            for (int i = bit.Length - 1; i >= 0; i--)
            {
                if (bit[i] == true)
                {
                    sb.Append(1);
                }
                else
                {
                    sb.Append(0);
                }
            }


            output1.Text = sb.ToString();
        }

        private void convert2_Click(object sender, EventArgs e)
        {

        }
    }
}

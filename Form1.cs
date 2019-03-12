using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool NumPerfecto(int n)
        {
            int c= 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    c += i;
                }
            }
            if (c == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i;
            a = Convert.ToInt32(tb1.Text);
            for (i = 1; i < a; i++)
            {
                if (NumPerfecto(i))
                    tb2.Text += i.ToString() + "\r \n";
         
            }
        }
    }
}

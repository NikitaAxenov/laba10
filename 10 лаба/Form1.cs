using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_лаба
{
    public partial class Form1 : Form
    {
        const double b = 4294967299;
        const double m = 9223372036854775808;
        double xNext = b;
        double xBefore, xNow;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                xBefore = xNext;
                xNext = (b * xBefore) % m;
                xNow = xNext / m;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            one.Text = "";
            two.Text = "";
            three.Text = "";
            four.Text = "";
            five.Text = "";
            six.Text = "";
            seven.Text = "";
            xBefore = xNext;
            xNext = (b * xBefore) % m;
            xNow = xNext / m;
            if (xNow < 0.15)
                four.Text = "•";
            else if (xNow >= 0.15 && xNow < 0.3)
            {
                one.Text = "•";
                seven.Text = "•";
            }
            else if (xNow >= 0.3 && xNow < 0.45)
            {
                one.Text = "•";
                four.Text = "•";
                seven.Text = "•";
            }
            else if (xNow >= 0.45 && xNow < 0.6)
            {
                one.Text = "•";
                two.Text = "•";
                six.Text = "•";
                seven.Text = "•";
            }
            else if (xNow >= 0.6 && xNow < 0.85)
            {
                one.Text = "•";
                two.Text = "•";
                four.Text = "•";
                six.Text = "•";
                seven.Text = "•";
            }
            else if (xNow >= 0.85 && xNow < 1)
            {
                one.Text = "•";
                two.Text = "•";
                three.Text = "•";
                five.Text = "•";
                six.Text = "•";
                seven.Text = "•";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int theta = 0; theta < 361; theta ++)
            {
                double d = Math.Sin(theta*(Math.PI)/180);
                gg.FillEllipse(sb,100+theta,150-(float)d*50,5,5);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            double[] s = new double[361];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Math.Cos(i * (Math.PI) / 180);
            }
            for (int theta = 0; theta < 361; theta++)
            {
                gg.FillEllipse(sb, 100 + theta, 150 - (float)s[theta] * 50, 5, 5);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            float f = 10, m = 20;
            double dt = 0.1;
            double[] x = new double[100];
            double[] v = new double[100];
            x[0] = 5;
            v[0] = 1;
            for (int t = 0; t < x.Length-1; t++)
            {
                v[t + 1] = v[t] + (f / m) * dt;
                x[t + 1] = x[t] + v[t] * dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            Pen p = new Pen(Color.Blue);
            for (int t = 0; t < x.Length; t++)
            {
                gg.FillEllipse(sb, 150 + t * 2, 350 - (float)x[t] * 5, 5, 5);
                gg.DrawEllipse(p, 150 + t * 2, 350 - (float)v[t] * 5, 5, 5);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.Brown);
            for (int theta = 0; theta < 361; theta++)
            {
                double d = Math.Tan(theta * 3.1417 / 180);
                gg.DrawEllipse(p, 100 + theta, 150 - (float)d * 50, 5, 5);
            }
        }
    }
}

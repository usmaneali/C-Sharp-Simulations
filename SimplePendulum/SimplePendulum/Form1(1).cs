using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePendulum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 500;
            double[] th = new double[size];
            double[] w = new double[size];
            double[] t = new double[size];
            th[0] = 1;
            w[0] = 1;
            double dt = 0.3, g = 9.8, l = 30;
            for (int i = 0; i < t.Length - 1; i++)
            {
                th[i + 1] = th[i] + w[i] * dt;
                w[i + 1] = w[i] - (g / l) * th[i] * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Chocolate);
            for (int i = 0; i < t.Length; i++)
            {
                gg.FillEllipse(sb, 200 + (float)t[i] * 5, 200 - (float)w[i] * 5, 5, 5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = 500;
            double[] th = new double[size];
            double[] t = new double[size];
            th[0] = 1;
            th[1] = 2;
            double dt = 0.3, g = 9.8, l = 30;
            for (int i = 1; i < t.Length - 1; i++)
            {
                th[i + 1] = 2 * th[i] - th[i - 1] - (g / l) * th[i] * dt * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.DarkKhaki);
            for (int i = 0; i < t.Length; i++)
            {
                gg.FillEllipse(sb, 200 + (float)t[i] * 5, 200 - (float)th[i] * 5, 5, 5);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = 500;
            double[] th = new double[size];
            double[] w = new double[size];
            double[] t = new double[size];
            th[0] = 1;
            w[0] = 1;
            double dt = 0.3, g = 9.8, l = 30;
            for (int i = 0; i < t.Length - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * th[i] * dt;
                th[i + 1] = th[i] + w[i + 1] * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.DarkOrange);
            for (int i = 0; i < t.Length; i++)
            {
                gg.FillEllipse(sb, 200 + (float)t[i] * 5, 200 - (float)w[i] * 5, 5, 5);
            }
        }
        class Rk4
        {
            public double f(double t, double th, double w)
            {
                return w;
            }
            public double f1(double t, double th, double w)
            {
                double g = 9.8, l = 10.0;
                return (-g / l * th);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double t = 2, th = 5, w = 1, dt = 0.05;
            double k, k1, k2, k3, k4;
            double l, l1, l2, l3, l4;
            Rk4 Robj = new Rk4();
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Crimson);
            SolidBrush sb1 = new SolidBrush(Color.Cyan);
            SolidBrush sb2 = new SolidBrush(Color.DarkBlue);
            for (int i = 0; i < 360; i++)
            {
                k1 = Robj.f(t, th, w);
                l1 = Robj.f1(t, th, w);
                k2 = Robj.f(t + dt / 2.0, th + k1 / 2.0, w + l1 / 2.0);
                l2 = Robj.f1(t + dt / 2.0, th + k1 / 2.0, w + l1 / 2.0);
                k3 = Robj.f(t + dt / 2.0, th + k2 / 2.0, w + l2 / 2.0);
                l3 = Robj.f1(t + dt / 2.0, th + l2 / 2.0, w + l2 / 2.0);
                k4 = Robj.f(t + dt, th + k3, w + l3);
                l4 = Robj.f1(t + dt, th + l3, w + l3);
                k = (k1 + 2.0 * (k2 + k3) + k4) * (1.0 / 6) * dt;
                l = (l1 + 2.0 * (l2 + l3) + l4) * (1.0 / 6) * dt;
                th = th + k;
                w = w + l;
                t = t + dt;
                gg.FillEllipse(sb, 200 + (float)t * 20, 250 - (float)th * 30, 5, 5);
                gg.FillEllipse(sb1, 250 + (float)t * 20, 300 - (float)w * 30, 5, 5);
                gg.FillEllipse(sb2, 300 + (float)th * 20, 200 - (float)w * 30, 5, 5);

            }
        }
    }
}

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
        private void eulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point P = new Point(300, 250);
            DrawAxis(P);
            double dt = 0.01, l = 1, g = 9.8;
            double[] th = new double[1000];
            double[] w = new double[1000];
            double[] t = new double[1000];
            th[0] = Math.PI / 4;
            for (int i = 0; i <w.Length - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * Math.Sin(th[i]) * dt;
                th[i + 1] = th[i] + w[i] * dt;
            }
            Graphics gg = textBox1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            Pen p = new Pen(Color.Blue);
            for (int i = 0; i < w.Length; i++)
            {
                gg.FillEllipse(sb, P.X + (float)i/3, P.Y - (float)th[i] * 50, 5, 5);
            }
        }
        private void DrawAxis(Point O)
        {
            Point p1 = new Point(O.X + 500, O.Y);
            Point p2 = new Point(O.X - 500, O.Y);
            Point p3 = new Point(O.X, O.Y + 500);
            Point p4 = new Point(O.X, O.Y - 500);
            Graphics g = textBox1.CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            Font f = new Font("Arial Bold", 12);
            g.DrawString(" t ", f, b, O.X + 130, O.Y + 5);
            g.DrawString(" th ", f, b, O.X - 25, O.Y - 130);
        }
        private void verlutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point P = new Point(300, 250);
            DrawAxis(P);
            double dt = 0.01, l = 1, g = 9.8;
            double[] th = new double[1000];
            double[] t = new double[1000];
            th[0] = Math.PI / 4;
            th[1] = Math.PI / 4 + dt;
            for (int i = 1; i < th.Length - 1; i++)
            {              
                th[i + 1] = 2 * th[i] - th[i - 1] - g / l * th[i] * dt * dt;
            }
            Graphics gg = textBox1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Blue);
            for (int i = 0; i < th.Length; i++)
            {
                gg.FillEllipse(sb, P.X + (float)i / 3, P.Y - (float)th[i] * 50, 5, 5);
            }
        }
        private void eulerChromerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point P = new Point(300, 250);
            DrawAxis(P);
            double dt = 0.01, l = 1, g = 9.8;
            double[] th = new double[1000];
            double[] w = new double[1000];
            double[] t = new double[1000];
            th[0] = Math.PI / 4;
            for (int i = 0; i < w.Length - 1; i++)
            {
                w[i + 1] = w[i] - (g / l) * Math.Sin(th[i]) * dt;
                th[i + 1] = th[i] + w[i+1] * dt;
            }
            Graphics gg = textBox1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Blue);
            for (int i = 0; i < w.Length; i++)
            {
                gg.FillEllipse(sb, P.X + (float)i / 3, P.Y - (float)th[i] * 50, 5, 5);
            }
        }

        public class RK4
        {
            public double f1(double t, double th, double w)
            {
                return w;
            }
            public double f2(double t, double th, double w)
            {
                double g = 9.8, l = 1;
                return th * (-g / l);
            }
        }
        private void rungeKuta4MethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point P = new Point(300, 250);
            DrawAxis(P);
            RK4 R = new RK4();
            double k1, k2, k3, k4, l1, l2, l3, l4, dt = 0.1;
            double[] t = new double[1000];
            double[] th = new double[1000];
            double[] w = new double[1000];
            th[0] = Math.PI / 6;
            for (int i = 0; i < 1000-1; i++)
            {
                k1 = R.f1(t[i], th[i], w[i]);
                l1 = R.f2(t[i], th[i], w[i]);
                k2 = R.f1(t[i] + dt / 2, th[i] + k1 / 2, w[i] + l1 / 2);
                l2 = R.f2(t[i] + dt / 2, th[i] + k1 / 2, w[i] + l1 / 2);
                k3 = R.f1(t[i] + dt / 2, th[i] + k2 / 2, w[i] + l2 / 2);
                l3 = R.f2(t[i] + dt / 2, th[i] + k2 / 2, w[i] + l2 / 2);
                k4 = R.f1(t[i] + dt, th[i] + k3, w[i] + l3);
                l4 = R.f2(t[i] + dt, th[i] + k3, w[i] + l3);
                th[i + 1] = th[i] + (1.0 / 6) * (k1 + 2 * k2 + 2 * k3 + k4) * dt;
                w[i + 1] = w[i] + (1.0 / 6) * (l1 + 2 * l2 + 2 * l3 + l4) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics g = textBox1.CreateGraphics();
            SolidBrush s = new SolidBrush(Color.DarkCyan);
            for (int i = 0; i < 1000; i++)
            {
                g.FillEllipse(s, (float)t[i]*20+150, 200-(float)th[i]*300, 5, 5);
            }
        }
    }
}

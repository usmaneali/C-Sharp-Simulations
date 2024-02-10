using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dym_Equation_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point P = new Point(300, 250);
            DrawAxis(P);
            double dn = 0.01, v = 2;
            double[] u = new double[1000];
            double[] y = new double[1000];
            double[] z = new double[1000];
            u[0] = 1; y[0] = 2; z[0] = 0;
            for (int i = 0; i < u.Length - 1; i++)
            {
                u[i + 1] = u[i] + y[i] * dn;
                y[i + 1] = y[i] + z[i] * dn;
                z[i + 1] = z[i] - v / (Math.Pow(u[i], 3)) * y[i] * dn;
            }
            Graphics gg = textBox1.CreateGraphics();
            SolidBrush sb1 = new SolidBrush(Color.Blue);
            for (int i = 0; i < u.Length; i++)
            {
                gg.FillEllipse(sb1, P.X + (float)i / 3, P.Y - (float)u[i] * 50, 5, 5);             
            }
        }
        private void DrawAxis(Point O)
        {
            Point p1 = new Point(O.X + 1000, O.Y);
            Point p2 = new Point(O.X - 1000, O.Y);
            Point p3 = new Point(O.X, O.Y + 1000);
            Point p4 = new Point(O.X, O.Y - 1000);
            Graphics g = textBox1.CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            Font f = new Font("Arial Bold", 12);
            g.DrawString(" eta ", f, b, O.X + 130, O.Y + 5);
            g.DrawString(" u ", f, b, O.X - 30, O.Y - 130);
        }
    }
}

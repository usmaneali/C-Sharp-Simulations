using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioActiveDecay
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
            double dt = 0.2, T;
            double[] N = new double[1000];
            T = double.Parse(textBox3.Text);
            N[0]=double.Parse(textBox1.Text);
            for (int t = 0; t < N.Length - 1; t++)
            {
                N[t + 1] = N[t] - (N[t] / T) * dt;
            }
            Graphics gg =textBox2.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            Pen p = new Pen(Color.Blue);
            for (int t = 0; t < N.Length; t++)
            {
                gg.FillEllipse(sb, P.X + t * 2, P.Y - (float)N[t] * 5, 5, 5);                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void DrawAxis(Point O)
        {
            Point p1 = new Point(O.X + 500, O.Y);
            Point p2 = new Point(O.X - 500, O.Y);
            Point p3 = new Point(O.X, O.Y + 500);
            Point p4 = new Point(O.X, O.Y - 500);
            Graphics g = textBox2.CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b);
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            Font f = new Font("Arial Bold", 12);
            g.DrawString("Time t(s) ", f, b, O.X + 130, O.Y + 5);
            g.DrawString("Nuclie N ", f, b, O.X - 1, O.Y + 175);
        }
    }
}

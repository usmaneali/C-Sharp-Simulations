using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSimplePendulum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eulerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void eulerCromerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void verletToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

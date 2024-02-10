using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK4_SimplePendulum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Rk4
        {
            
           public double f(double t, double th, double w)
            {
                return w;
            }
           public double f1(double t, double th, double w)
        {
          double g=9.8,l=10;
            return (-g/l)*th;
        }
        }
        private void simplePendulumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double t=2, th=5, w=1, dt = 0.05f,g=9.8f;
            double k, k1, k2, k3, k4;
            double l, l1, l2, l3, l4;
        
            Rk4 Robj = new Rk4();
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Crimson);
            SolidBrush sb1 = new SolidBrush(Color.Cyan);
            SolidBrush sb2 = new SolidBrush(Color.DarkBlue);
            for (int i = 0; i < 500; i++)
            {
                k1 = Robj.f(t, th, w);
              l1 = Robj.f1(t, th, w);
                k2= Robj.f(t+dt/2.0, th+k1/2.0, w+l1/2.0);
                    l2= Robj.f1(t+dt/2.0, th+k1/2.0, w+l1/2.0);
                    k3= Robj.f(t+dt/2.0, th+k2/2.0, w+l2/2.0);
                    l3= Robj.f1(t+dt/2.0, th+l2/2.0, w+l2/2.0);
                    k4= Robj.f(t+dt, th+k3, w+l3);
                    l4 = Robj.f1(t+dt, th+l3, w+l3);
                    k = (k1 + 2*(k2 + k3) + k4)*(1.0/6)*dt;
                    l = (l1 + 2 * (l2 + l3) + l4)*(1.0 / 6) * dt;
                    th = th + k;
                    w = w + l;
                    t = t + dt;
                    gg.FillEllipse(sb, 200 + (float)t*20, 250 - (float)th*30, 5, 5);
                    gg.FillEllipse(sb1, 250 + (float)t*20, 300 - (float)w*30, 5, 5);
                    gg.FillEllipse(sb2, 300 + (float)th * 20, 200 - (float)w * 30, 5, 5);

            }
        
           
        }
    }
}

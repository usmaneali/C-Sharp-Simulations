using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float xe = 1, ye = 0, vxe = 0, vye = 2 * 3.142f;
            float xj =5.2f, yj = 0, vxj = 0, vyj = 2.8f;
            Graphics gg = this.CreateGraphics();
            SolidBrush sy = new SolidBrush(Color.Yellow);
            SolidBrush sw = new SolidBrush(Color.White);
            SolidBrush sr = new SolidBrush(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Blue);
            Planet EJ = new Planet(xe, ye, vxe, vye,xj,yj,vxj,vyj);
            float xs = ClientSize.Width / 2, ys = ClientSize.Height / 2;
            //Make Sun
            gg.FillEllipse(sy, xs, ys, 20, 20);
            //Make Earth and jupitar
            if (radioButton2.Checked == true)
            {
                while (EJ.t < 10000)
                {
                    gg.FillEllipse(sb, xs + EJ.xe * 200, ys - EJ.ye * 200, 10, 10);
                    gg.FillEllipse(sr, xs + EJ.xj * 50, ys - EJ.yj * 50, 10, 10);
                    System.Threading.Thread.Sleep(2);
                    gg.FillEllipse(sw, xs + EJ.xj * 50, ys - EJ.yj * 50, 10, 10);
                    gg.FillEllipse(sw, xs + EJ.xe * 200, ys - EJ.ye * 200, 10, 10);
                    EJ.revolve();
                }
            }
            //Make earth
            if (radioButton1.Checked == true)
            {
                while (EJ.t < 10000)
                {
                    gg.FillEllipse(sb, xs + EJ.xe * 200, ys - EJ.ye * 200, 10, 10);
                    System.Threading.Thread.Sleep(10);
                    gg.FillEllipse(sw, xs + EJ.xe * 200, ys - EJ.ye * 200, 10, 10);
                    EJ.Revolve();
                }
            }
        }
    }
}

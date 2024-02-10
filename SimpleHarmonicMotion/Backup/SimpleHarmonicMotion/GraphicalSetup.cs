using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Drawing;

namespace SimpleHarmonicMotion
{
    class GraphicalSetup
    {
        //Data
        public Graphics gg;
        public SolidBrush bred, bblue, bwhite,bgreen;
      public  Pen pblue, pred, pwhite;
       public Font f;
        public float x0, y0;
        //constructor
        public GraphicalSetup(Form1 frm)
        {
            gg = frm.CreateGraphics();
            bred = new SolidBrush(Color.Red);
            bblue = new SolidBrush(Color.Blue);
            bgreen = new SolidBrush(Color.Green);
            bwhite = new SolidBrush(Color.White);
            pred = new Pen(Color.Red);
            pblue = new Pen(Color.Blue,3);
            pwhite = new Pen(Color.White,3);
            f = new Font("Arial",16);
            x0 = frm.ClientSize.Width / 2;
            y0 = frm.ClientSize.Height / 2;
        }
        //Other Functions
        public void DrawAxes(float xlen,float ylen,
            string xlabel,string ylabel,float deltax,
            float deltay)
        {
            gg.DrawLine(pred, x0, y0, x0 + xlen, y0);
            gg.DrawLine(pred, x0, y0, x0, y0 - ylen);
            gg.DrawString(xlabel,f,bblue, 
                x0 + xlen / 2, y0 + 10);
            gg.DrawString(ylabel, f, bblue,
               x0 -150, y0-ylen/2);

        }
        public void plotter(float hv,float vv,
            float hscale,float vscale,SolidBrush b)
        {
            gg.FillEllipse(b, x0 + hv * hscale,
                y0 - vv * vscale-5, 5, 5);
        }
        public void eraser(float hv, float vv,
            float hscale, float vscale)
        {
            gg.FillEllipse(bwhite, x0 + hv * hscale,
                y0 - vv * vscale-5, 5, 5);
        }
    }
}

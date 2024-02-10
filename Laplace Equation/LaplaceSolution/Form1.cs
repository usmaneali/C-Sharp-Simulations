using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaplaceSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicalSetup gs = new GraphicalSetup(this);
            FreeSpace region = new FreeSpace(gs);
            do
            {
                region.Relaxation(gs);
                textBox1.Text = region.sigmav.ToString();
                textBox1.Refresh();
            } while (region.sigmav > region.deltav);
        }
    }
}

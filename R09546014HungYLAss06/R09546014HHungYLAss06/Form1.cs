using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chartController1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tChart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            surface1.NumXValues = 100;
            surface1.NumZValues = 80;
            surface1.IrregularGrid = true;
            surface1.Clear();
            for(double x = 0; x < 100; x++)
            {
                for(double zz = 0; zz < 80; zz++)
                {
                    double y = 0;
                    y = Math.Sin(x / 10.0) * Math.Cos(zz / 4.0);
                    surface1.Add(x, y, zz);
                }
            }
        }
    }
}

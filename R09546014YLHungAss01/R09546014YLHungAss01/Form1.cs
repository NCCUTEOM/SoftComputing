using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014YLHungAss01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnDrawgFunction_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnDrawgFunction_Click(object sender, EventArgs e)
        {
            Thechart.Series[0].Points.Clear();
            double y;
            if (radioButtonTfunction.Checked == true)
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double c = Convert.ToDouble(textBoxC.Text);
                for (double x = -2; x <= 2; x += 0.1)
                {

                    if (x <= a) y = 0;

                    else if (a <= x && x <= b)
                    {
                        y = (x - a) / (b - a);
                    }
                    else if (b <= x && x <= c)
                    {
                        y = (c - x) / (c - b);
                    }
                    else { y = 0; }
                    Thechart.Series[0].Points.AddXY(x, y);
                }
            }
            else if (radioButtonGfunction.Checked == true)
            {
                for (double x = -2; x <= 2; x += 0.1)
                {

                    double c = Convert.ToDouble(textBoxCenter.Text);
                    double sigma = Convert.ToDouble(textBoxSigma.Text);

                    y = Math.Exp((Math.Pow(x - c, 2) / 2 / sigma));
                    Thechart.Series[0].Points.AddXY(x, y);


                }

            }
            else if (radioButtonBfunction.Checked == true)
            {
                for (double x = -2; x <= 2; x += 0.1)
                {
                    double a = Convert.ToDouble(textBoxA_Bfunction.Text);
                    double b = Convert.ToDouble(textBoxB_Bfunction.Text);
                    double c = Convert.ToDouble(textBoxC_Bfunction.Text);


                    y = 1 / (1 + Math.Pow((x - c) / a, 2 * b));
                    Thechart.Series[0].Points.AddXY(x, y);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
           



        }
    }
}

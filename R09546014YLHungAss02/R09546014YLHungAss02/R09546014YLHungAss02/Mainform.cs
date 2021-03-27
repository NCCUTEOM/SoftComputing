using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014YLHungAss02
{
    public partial class Mainform : Form
    {
        Random myRnd = new Random();
        int count = 0;//紀錄加了幾個series

        //紀錄畫了幾個不同類別的function

        int countGaussian = 0;
        int countBell = 0;
        int countTriangle = 0;
        int countSigmoid = 0;

        public Mainform()
        {
            InitializeComponent();
            int select = listBoxFunction.SelectedIndex = 2;
           
            



        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBoxFunction.SelectedIndex;
            switch (idx)
            {
                case 0:
                    label1.Text = TriangleFunction.parameterNames[0];
                    label2.Text = TriangleFunction.parameterNames[1];
                    label3.Text = TriangleFunction.parameterNames[2];

                    label3.Visible = true;
                    nudPar3.Visible = true;

                    decimal tmp = nudPar2.Value = myRnd.Next(5, 21); //peak隨機給定[5,20]
                    nudPar1.Value = nudPar2.Value - 5; //left 在peak左邊五單位
                    nudPar3.Value = nudPar2.Value + 5; //right在peak右邊五單位


                    //待解決指引a<=b<=c
                    if((nudPar1.Value > nudPar2.Value ) || (nudPar2.Value > nudPar3.Value))
                    {
                        MessageBox.Show("please follow the rule a<=b<=c");

                    }

                    break;
                case 1:
                    label1.Text = BellFunction.parameterNames[0];
                    label2.Text = BellFunction.parameterNames[1];
                    label3.Text = BellFunction.parameterNames[2];

                    label3.Visible = true;
                    nudPar3.Visible = true;

                    nudPar1.Value = myRnd.Next(-5, 6); //a 隨機給定整數 [-5,5]
                    nudPar2.Value = (decimal)(myRnd.NextDouble()*4.0); 
                    nudPar3.Value = (decimal)(myRnd.NextDouble()*2.0); 
                    break;
                case 2:
                    label1.Text = GaussianFunction.parameterNames[0];
                    label2.Text = GaussianFunction.parameterNames[1];
                    label3.Visible = false;
                    nudPar3.Visible = false;
                    nudPar1.Value = myRnd.Next(-5, 6); //center隨機給定[-5,5]
                    nudPar2.Value = (decimal) (myRnd.NextDouble() * 3.0); //std 隨機給定 [0,3)


                    break;
                case 3:
                    label1.Text = SigmoidFunction.parameterNames[0];
                    label2.Text = SigmoidFunction.parameterNames[1];
                    label3.Visible = false;
                    nudPar3.Visible = false;

                    nudPar1.Value = (decimal)myRnd.NextDouble(); //a隨機給定[0,1)的浮點數
                    nudPar2.Value = (decimal)(myRnd.NextDouble() * 3.0); //c 隨機給定 [0,3)的浮點數

                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateButtonClicked(object sender, EventArgs e)
        {
            
            

            //提供使用者自訂x,y軸範圍
            TheChart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(numericUpDownAxisXmin.Value);
            TheChart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(numericUpDownAxisXmax.Value);
            TheChart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(numericUpDownAxisYmin.Value);
            TheChart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(numericUpDownAxisYmax.Value);

            
            double pt = 0;//紀錄畫了幾個點
            




            switch (listBoxFunction.SelectedIndex)
            {
                
                case 0://Traingle
                    //提示 left<=peak<=right
                    if ((nudPar1.Value > nudPar2.Value) || (nudPar2.Value > nudPar3.Value))
                    {
                        MessageBox.Show("please follow the rule:left<=peak<=right");
                        break;
                    }

                    double left, peak, right;
                    left = (double)nudPar1.Value;
                    peak = (double)nudPar2.Value;
                    right =(double)nudPar3.Value;



                    TriangleFunction myTriangleObj = new TriangleFunction(left, peak, right);
                    Series t = new Series($"Triangle{countTriangle}(x;{left:0.00},{peak:0.00},{right:0.00})");
                    t.ChartType = SeriesChartType.Line;

                    
                    while (pt <= 200)
                    { //總共畫200個點
                        pt += 1;
                        double x = TheChart.ChartAreas[0].AxisX.Minimum; ;
                        x += pt*0.1;
                        double y = myTriangleObj.GetFunctionValue(x);
                        t.Points.AddXY(x, y);
                    }
                    TheChart.Series.Add(t);
                    TheChart.Series[count].ToolTip = $"Triangle{countTriangle}(x;{left:0.00},{peak:0.00},{right:0.00})";
                    count++;
                    countTriangle++;
                    break;

                case 1://Bell
                    double a,b,c;
                    a = (double)nudPar1.Value;
                    b = (double)nudPar2.Value;
                    c = (double)nudPar3.Value;

                    BellFunction myBellObj = new BellFunction(a,b,c);
                    Series bell = new Series($"Bell{countBell}(x;{a:0.00},{b:0.00},{c:0.00})");
                    bell.ChartType = SeriesChartType.Line;




                    
                    while (pt <= 200)
                    { //總共會畫200個點
                        pt += 1;
                        double x = TheChart.ChartAreas[0].AxisX.Minimum; ;
                        x += pt*0.1;
                        double y = myBellObj.GetFunctionValue(x);
                        bell.Points.AddXY(x, y);
                    }
                    TheChart.Series.Add(bell);
                    TheChart.Series[count].ToolTip = $"Bell{countBell}(x;{a:0.00},{b:0.00},{c:0.00})";
                    count++;
                    countBell++;

                    break;



                case 2://Gaussian
                    double center, std;
                    center = (double)nudPar1.Value;
                    std = (double)nudPar2.Value;
                    GaussianFunction myGaussianObj = new GaussianFunction(center, std);
                    Series g = new Series($"Gaussian{countGaussian}(x;{center:0.00},{std:0.00})");
                    g.ChartType = SeriesChartType.Line;
                    // s.Color = Color.Red;
                    //for (double i = -10; i <= 10; i += 0.1)
                    //{
                    //    double y = myGaussianObj.GetFunctionValue(i);
                    //    g.Points.AddXY(i, y);
                    //}

                    while (pt <= 200)
                    { //總共畫200個點
                        pt += 1;
                        double x = TheChart.ChartAreas[0].AxisX.Minimum; ;
                        x += pt * 0.1;
                        double y = myGaussianObj.GetFunctionValue(x);
                        g.Points.AddXY(x, y);
                    }
                    TheChart.Series.Add(g);
                    TheChart.Series[count].ToolTip = $"Gaussian{countGaussian}(x:{center:0.00},{std:0.00})";
                    count++;
                    countGaussian++;

                    break;

                case 3://Sigmoid
                    double _a, middle;
                    _a = (double)nudPar1.Value;
                    middle = (double)nudPar2.Value;
                    SigmoidFunction mySigmoidObj = new SigmoidFunction(_a, middle);
                    Series s = new Series($"Sigmoid{countSigmoid}(x;{_a:0.00},{middle:0.00})");
                    s.ChartType = SeriesChartType.Line;
                    // s.Color = Color.Red;
                    //for (double x = -10; x <= 10; x += 0.1)
                    //{
                    //    double y = mySigmoidObj.GetFunctionValue(x);
                    //    s.Points.AddXY(x, y);
                    //}
                    while (pt <= 200)
                    { //總共畫200個點
                        pt += 1;
                        double x = TheChart.ChartAreas[0].AxisX.Minimum; ;
                        x += pt*0.1;
                        double y = mySigmoidObj.GetFunctionValue(x);
                        s.Points.AddXY(x, y);
                    }


                    TheChart.Series.Add(s);
                    TheChart.Series[count].ToolTip = $"Sigmoid{countSigmoid}(x;{_a:0.00},{middle:0.00})";
                    
                    count++;
                    countSigmoid++;

                    break;
            }
        }

        private void nudPar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TheChart_MouseHover(object sender, EventArgs e)
        {

        }

        //private void TheChart_DoubleClick(object sender, EventArgs e)
        //{
        //    for(int i = 0; i <count; i++)
        //    {
        //        if (TheChart.Series[i].ToolTip.Contains("Gaussian")){
        //            string tmp_center = TheChart.Series[i].ToolTip.Substring(TheChart.Series[i].ToolTip.IndexOf("center:"));
        //            string tmp_std = TheChart.Series[i].ToolTip.Substring(TheChart.Series[i].ToolTip.IndexOf("std:"));

        //        }
        //    }
        //}

        //private void TheChart_GetToolTipText(object sender, ToolTipEventArgs e)
        //{
        //    string original = e.Text;
        //    Console.WriteLine(original);
            
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void nudPar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownAxisXmin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

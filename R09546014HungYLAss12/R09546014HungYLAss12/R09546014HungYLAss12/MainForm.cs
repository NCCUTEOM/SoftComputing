using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace R09546014HungYLAss12
{
    public partial class MainForm : Form
    {
        BbackPropagationMLP theMLPsolver;

        public MainForm()
        {
            InitializeComponent();
            theChart.Series.Clear();
            theChart.ChartAreas.Clear();




            theMLPsolver = new BbackPropagationMLP();

            //create the chartarea
            string s = "Epoch";
            ChartArea theArea = new ChartArea(s);
            theChart.ChartAreas.Add(theArea);


            //add the series to Chart.Series
            theMLPsolver.RMSE.ChartArea = theArea.Name;
            theMLPsolver.RMSE.ChartType = SeriesChartType.Line;
            theChart.Series.Add(theMLPsolver.RMSE);
            theChart.Legends["Legend1"].Docking = Docking.Bottom;

            //initialize HiddenLayer & NeuronNumber
            listBoxHiddenLayerNeuronNumbers.SelectedIndex = 0;

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);//防止圖數過多造成閃爍

            object[] pars = { ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true };
            //MethodInfo setStyleMethodOfPanel = typeof(Panel).GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //setStyleMethodOfPanel.Invoke(, pars);

        }
        int[,] confusionMatrix;//for predict(row)/groundtruth(column) recording

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;

            var sr = new StreamReader(dlgOpen.FileName);
            theMLPsolver.ReadInDataSet(sr, 0.7f);
            propertyGridTrainingSetting.SelectedObject = theMLPsolver;

        }

        private void listBoxHiddenLayerNeuronNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownNeuronNumber.Value = Convert.ToInt32(listBoxHiddenLayerNeuronNumbers.SelectedItem);
        }

        private void numericUpDownNeuronNumber_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxHiddenLayerNeuronNumbers.SelectedIndex;
           
            listBoxHiddenLayerNeuronNumbers.Items.Insert(selectedIndex, numericUpDownNeuronNumber.Value.ToString());
            listBoxHiddenLayerNeuronNumbers.SelectedIndex = selectedIndex;

            listBoxHiddenLayerNeuronNumbers.Items.RemoveAt(selectedIndex+1);
           
        }

        //record the oldvalue of numericUpDownHiddenLayers
        private int oldvalue;
        private void numericUpDownHiddenLayers_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownHiddenLayers.Value > oldvalue)
            {
                listBoxHiddenLayerNeuronNumbers.Items.Add(3);
            }

            if (numericUpDownHiddenLayers.Value< oldvalue) listBoxHiddenLayerNeuronNumbers.Items.RemoveAt(listBoxHiddenLayerNeuronNumbers.Items.Count-1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {


            string[] arr = new string[listBoxHiddenLayerNeuronNumbers.Items.Count];
            for (int i = 0; i < listBoxHiddenLayerNeuronNumbers.Items.Count; i++)
            {
                arr[i] = listBoxHiddenLayerNeuronNumbers.Items[i].ToString();
            }

            int[] hiddenNeuronNumbers = Array.ConvertAll(arr, int.Parse);

            theMLPsolver.ConfigureNeuralNetwork(hiddenNeuronNumbers);

            theMLPsolver.ResetWeightsAndInitialCondition();
           
            theMLPsolver.TrainingTimes = 0;
            theMLPsolver.RMSE.Points.Clear();

            

            

        }

        private void btnTrainAnEpoch_Click(object sender, EventArgs e)
        {
            theMLPsolver.TrainAnEpoch();
            richTextBoxRMSE.Text = Convert.ToString(theMLPsolver.RootMeanSquareError);
            richTextBoxCorrectness.Text = Convert.ToString(theMLPsolver.TestingClassification(out confusionMatrix));


            int matrixlength = (int)Math.Sqrt(confusionMatrix.Length);
            richTextBoxConfusionMatrix.Clear();
            for(int r = 0; r < matrixlength; r++)
            {
                for(int c = 0;c< matrixlength; c++)
                {
                    richTextBoxConfusionMatrix.AppendText(Convert.ToString(confusionMatrix[r, c]) + ' ');
                }
                richTextBoxConfusionMatrix.AppendText(Environment.NewLine);
            }

            
        }

        ////20201221上課新增
        //private void buttonDraw_Click(object sender, EventArgs e)
        //{
        //    Graphics g = buttonDraw.CreateGraphics();
        //    Draw(g,buttonDraw.ClientRectangle);
        //}

        //void Draw(Graphics g,Rectangle bound)
        //{
        //    Rectangle rect = Rectangle.Empty;
        //    rect.X = 10;
        //    rect.Y = 5;
        //    rect.Width = 100;
        //    rect.Height = 50;
        //    //g.FillEllipse(Brushes.Gold, rect);
        //    //g.DrawEllipse(Pens.Red, rect);
        //    Pen myPen = new Pen(Color.Blue, 3);
        //    Point p1 = new Point(0, 0);
        //    Point p2 = new Point(buttonDraw.Width, buttonDraw.Height);
        //    g.DrawLine(myPen, p1, p2);
        //    g.DrawString("NTU IE", Font, Brushes.Gray, new PointF(0.0f, 0.0f));
        //    Font myFont = new Font("Arial", 36.0f);
        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;
        //    sf.LineAlignment = StringAlignment.Center;
        //    g.DrawString("NTU", myFont, Brushes.Magenta, buttonDraw.ClientRectangle, sf);

        //}

        //private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        //{
        //    if (theMLPsolver != null) theMLPsolver.DrawMLP(e.Graphics, e.ClipRectangle);
        //}

        private void buttonTrainToEnd_Click(object sender, EventArgs e)
        {
            int matrixlength;
            while (theMLPsolver.TrainingTimes < 100)
            {
                theMLPsolver.TrainingTimes += 1;
                theMLPsolver.TrainAnEpoch();

                richTextBoxRMSE.Text = Convert.ToString(theMLPsolver.RootMeanSquareError);
                richTextBoxCorrectness.Text = Convert.ToString(theMLPsolver.TestingClassification(out confusionMatrix));

                richTextBoxConfusionMatrix.Clear();

                matrixlength = (int)Math.Sqrt(confusionMatrix.Length);
                for (int r = 0; r < matrixlength; r++)
                {
                    for (int c = 0; c < matrixlength; c++)
                    {
                        richTextBoxConfusionMatrix.AppendText(Convert.ToString(confusionMatrix[r, c]) + ' ');
                    }
                    richTextBoxConfusionMatrix.AppendText(Environment.NewLine);
                }
            }
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxCorrectness_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {
            if(theMLPsolver != null)theMLPsolver.DrawMLP(e.Graphics, e.ClipRectangle);
            //Draw(e.Graphics, e.ClipRectangle);
        }

        private void labelConfusionMatrix_Click(object sender, EventArgs e)
        {

        }
    }

}

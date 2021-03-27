using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TSPBenchmark;

namespace R09546014HungYLAss10
{
    public partial class MainForm : Form
    {
        AntColonySystemTSP theSolver;
        //TSPBenchmarkProblem theProblem;


        
        public MainForm()
        {
            InitializeComponent();
            theChart.ChartAreas.Clear();
            theChart.Series.Clear();

        }

        private void buttonOpenTSP_Click(object sender, EventArgs e)
        {
            int status = TSPBenchmarkProblem.ImportATSPFile(true, true);

            if(TSPBenchmarkProblem.OptimumObjective !=0 )
            labelKnownBestObjvalue.Text = $"Known shortest length:{Environment.NewLine + TSPBenchmarkProblem.OptimumObjective:0.00}";

            else
            {
                labelKnownBestObjvalue.Text = $"Known shortest length:{Environment.NewLine} Unknown";
            }


            richTextBoxbestSol.Clear();
            richTextBoxPheromoneMap.Clear();
            richTextBoxShortestLength.Clear();
            richTextBoxShowSolution.Clear();
            theChart.ChartAreas.Clear();
            theChart.Series.Clear();
            
            

        }

        //private void spcfourth_Panel2_Paint(object sender, PaintEventArgs e)
        //{
        //    TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, spcfourth.Panel2.Width, spcfourth.Panel2.Height, null);
        //    if (theSolver !=null)
        //        TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics,spcfourth.Panel2.Width,
        //            spcfourth.Panel2.Height,theSolver.SoFarTheBestSolution);
        //}

        //private void spcfourth_Panel2_Paint(object sender, PaintEventArgs e)
        //{
        //    TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, spcfourth.Panel2.Width, spcfourth.Panel2.Height, null);
        //    if (theSolver != null)
        //        TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics, spcfourth.Panel2.Width,
        //            spcfourth.Panel2.Height, theSolver.SoFarTheBestSolution);
        //}

        private void btnCreateACSsolver_Click(object sender, EventArgs e)
        {
            theSolver = new AntColonySystemTSP(TSPBenchmarkProblem.NumberOfCities, TSPBenchmarkProblem.ComputeRouteLength,TSPBenchmarkProblem.FromToDistanceMatrix);
            propertyGridSetting.SelectedObject = theSolver;

            string s = "Iteration";
            ChartArea theArea = new ChartArea(s);
            theArea.AxisX.Name = "iteration";
            theArea.AxisY.Name = "Objective";
            theArea.AxisX.Minimum = 0;

            theChart.Legends[0].Docking = Docking.Top;

            theChart.ChartAreas.Add(theArea);


            theSolver.Average.ChartArea = theArea.Name;
            theSolver.Average.ChartType = SeriesChartType.Line;
            theChart.Series.Add(theSolver.Average);

            theSolver.ItrBest.ChartArea = theArea.Name;
            theSolver.ItrBest.ChartType = SeriesChartType.Line;
            theChart.Series.Add(theSolver.ItrBest);


            theSolver.SofarTheBest.ChartArea = theArea.Name;
            theSolver.SofarTheBest.ChartType = SeriesChartType.Line;
            theChart.Series.Add(theSolver.SofarTheBest);

            //spcfourth.Panel2.Refresh();
            tabPageShow.Refresh();


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            theSolver.Reset();
            foreach (var series in theChart.Series)
            {
                series.Points.Clear();
            }
            tabPageShow.Refresh();

            richTextBoxbestSol.Clear();
            richTextBoxPheromoneMap.Clear();
            richTextBoxShortestLength.Clear();
            richTextBoxShowSolution.Clear();
            
           









        }


        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            richTextBoxbestSol.Clear();
            richTextBoxShortestLength.Clear();
            richTextBoxShowSolution.Clear();
            richTextBoxPheromoneMap.Clear();

            theSolver.RunOneIteration();

            string bestsol = "";
            for (int i = 0; i < theSolver.SoFarTheBestSolution.Length;i++) bestsol += $"{theSolver.SoFarTheBestSolution[i]} ";
            richTextBoxbestSol.Text = Environment.NewLine+bestsol;

            richTextBoxShortestLength.Text = Environment.NewLine+theSolver.SoFarTheBestObjective.ToString();

            //spcfourth.Panel2.Refresh();
            tabPageShow.Refresh();
            if (checkBoxSol.Checked == true)
            {
                UpdaterichTextBoxSol();
                richTextBoxbestSol.Update();
            }
            if (checkBoxPheromone.Checked == true)
            {
                UpdaterichTextBoxPheromoneMap();
                richTextBoxPheromoneMap.Update();

            }

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRunToEnd_Click(object sender, EventArgs e)
        {
            while (theSolver.IterationCount < theSolver.IterationLimit)
            {
                //foreach (var series in theChart.Series)
                //{
                //    series.Points.Clear();
                //}

                richTextBoxbestSol.Clear();
                richTextBoxShortestLength.Clear();

                theSolver.RunOneIteration();


                string bestsol  = "";
                for (int i = 0; i < theSolver.SoFarTheBestSolution.Length; i++) bestsol += $"{theSolver.SoFarTheBestSolution[i]} ";
                
                
                richTextBoxbestSol.Text = Environment.NewLine + bestsol;

                richTextBoxShortestLength.Text = Environment.NewLine + theSolver.SoFarTheBestObjective.ToString();
                theChart.Update();

                //spcfourth.Panel2.Refresh();
                tabPageShow.Refresh();

                if (checkBoxSol.Checked == true)
                {
                    richTextBoxShowSolution.Clear();
                    UpdaterichTextBoxSol();
                    richTextBoxShowSolution.Update();
                }
                if (checkBoxPheromone.Checked == true)
                {
                    richTextBoxPheromoneMap.Clear();
                    UpdaterichTextBoxPheromoneMap();
                    richTextBoxPheromoneMap.Update();
                    
                }

                }

        }

        private void UpdaterichTextBoxSol()
        {
            string s = "";
            for(int r = 0; r < theSolver.NumberOfAnts; r++)
            {
                richTextBoxShowSolution.AppendText($"Sol {r.ToString("D3")}: ");
                for (int c = 0; c < theSolver.NumberOfCities; c++)
                {
                    s +=  $"{theSolver.Solutions[r][c]} ";
                    
                }
                //s += Environment.NewLine;
                richTextBoxShowSolution.AppendText(s + Environment.NewLine);
                s = "";
                


            }

        }

        private void tabPageShow_Paint(object sender, PaintEventArgs e)
        {
            TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, tabPageShow.Width, tabPageShow.Height, null);
            if (theSolver != null)
                TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics,tabPageShow.Width, tabPageShow.Height,
                     theSolver.SoFarTheBestSolution);
        }

        private void UpdaterichTextBoxPheromoneMap()
        {
            string s = "";

            for (int r =0; r < theSolver.NumberOfCities;r++)
            {
                for(int c =0;c < theSolver.NumberOfCities; c++)
                {
                    s += Convert.ToString($"{ theSolver.PheromoneMap[r, c]} ");
                }
                s += Environment.NewLine;
            }

            richTextBoxPheromoneMap.Text = s;
            

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void theChart_Click(object sender, EventArgs e)
        {

        }
    }
}

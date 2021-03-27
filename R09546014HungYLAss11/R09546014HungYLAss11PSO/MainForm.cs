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
using COP;

namespace R09546014HungYLAss11PSO
{
    public partial class MainForm : Form
    {
        ParticleSwarmOptimizationSolver theSolver;
        COPBenchmark theProblem;

        public MainForm()
        {
            InitializeComponent();
            theProblem = new COPBenchmark();

            btnCreatePSOsolver.Enabled = false;
            buttonReset.Enabled = false;
            buttonRunOneIteration.Enabled = false;
            buttonRunToEnd.Enabled = false;

           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
         

            theProblem = COPBenchmark.LoadAProblemFromAFile();
            theProblem.DisplayOnPanel(splitContainerMain.Panel1);
            theProblem.DisplayObjectiveGraphics(splitContainer2.Panel2);
            btnCreatePSOsolver.Enabled = true;

            //if (theSolver != null)
            //{

            //    theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
            //}

        }

        private void btnNewProblem_Click(object sender, EventArgs e)
        {
            COPBenchmark newProblem = COPBenchmark.CreateANewProblemAndShowEditor();

        }

        private void btnCreatePSOsolver_Click(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;
            theChart.ChartAreas.Clear();
            theChart.Series.Clear();

            OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                OptimizationType.Minimization : OptimizationType.Maximization;
            theSolver = new ParticleSwarmOptimizationSolver(theProblem.Dimension, type, theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
            
            propertyGridPSOsetting.SelectedObject = theSolver;
            theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);



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










        }





        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonRunOneIteration.Enabled = true;
            buttonRunToEnd.Enabled = true;
            theSolver.Reset();
            foreach (var series in theChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void buttonRunOneIteration_Click(object sender, EventArgs e)
        {
            theSolver.RunOneIteration();
            theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);


        }

        private void buttonRunToEnd_Click(object sender, EventArgs e)
        {

            while(theSolver.IterationCount < theSolver.IterationLimit)
            {
                theSolver.IterationCount++;
                theSolver.RunOneIteration();
                theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
                splitContainer2.Refresh();



            }
        }
    }
}

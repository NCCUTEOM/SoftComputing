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
using GeneticAlgorithmLibrary;

namespace JobAssignmnetGAsolver
{
    public partial class MainForm : Form
    {
        JobAssignmentProblem theProblem;
        PermutationGAsolver thePermutationGAsolver;
        BinaryGASolver theBinaryGAsolver;




        public MainForm()
        {
            InitializeComponent();

            theChart.ChartAreas.Clear();
            theChart.Series.Clear();



            theProblem = new JobAssignmentProblem();

            txtPenalty.Text = theProblem.Penalty.ToString();
            //txtItrlimit.Text = theProblem.Iterationlimit.ToString();

            //txtboxMutateRate.Text = thePermutationGAsolver.MutationRate.ToString();
            //txtboxPSize.Text = thePermutationGAsolver.PopulationSize.ToString();

            




        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            theProblem.OpenFile(dlg.FileName);//要先讀完檔才可以選擇用甚麼 GAsolver
            FillAssignmentable();
            thePermutationGAsolver = new PermutationGAsolver(theProblem.NumberOfJobs, OptimizationType.Minimization, theProblem.GetObjectiveValue);
            //thebinarygasolver = = new binarygasolver(theproblem.numberofjobs, optimizationtype.minimization, theproblem.gettotalsetuptimeforanassignment);

            theBinaryGAsolver = new BinaryGASolver(theProblem.NumberOfJobs * theProblem.NumberOfJobs, OptimizationType.Minimization, theProblem.GetObjectiveValueByte);

            if (radiobtnBinary.Checked == true)//default
            {
                propertyGridGAsolver.SelectedObject = theBinaryGAsolver;
                cbxPointCut.SelectedIndex = 1;//default two point-cut

                cbxPermutationXover.SelectedIndex = 1;
                cbxPermutationMutation.SelectedIndex = 0;
            }
            else if (radiobtnPermutation.Checked == true)
            {
                propertyGridGAsolver.SelectedObject = thePermutationGAsolver;
                cbxPermutationXover.SelectedIndex = 1;
                cbxPermutationMutation.SelectedIndex = 0;

            }


        }




        private void FillAssignmentable()
        {
            DataTable AssTable = new DataTable("Assignment Table");

            //AssTable.Rows.Clear();
            //AssTable.Columns.Clear();

            dgvAssTable.Columns.Clear();
            dgvAssTable.Rows.Clear();



            for (int i = 0; i < theProblem.NumberOfJobs; i++)
            {
                dgvAssTable.Columns.Add($"M{i}", $"M{i}");
            }
            for (int j = 0; j < theProblem.NumberOfJobs; j++)
            {
                dgvAssTable.Rows.Add();
                dgvAssTable.Rows[j].HeaderCell.Value = $"Job{j}";

                // iterate over all columns to fill the row
                for (int i = 0; i < theProblem.NumberOfJobs; i++)
                {
                    dgvAssTable.Rows[j].Cells[i].Value = theProblem.SetupTimes[j, i];
                }


            }



        }

        //private void btnCreateGA_Click(object sender, EventArgs e)
        //{

        //    thePermutationGAsolver = new PermutationGAsolver(theProblem.NumberOfJobs, OptimizationType.Minimization, theProblem.GetObjectiveValue);
        //    //thebinarygasolver = = new binarygasolver(theproblem.numberofjobs, optimizationtype.minimization, theproblem.gettotalsetuptimeforanassignment);
        //    propertyGrid1.SelectedObject = thePermutationGAsolver;

        //    theBinaryGAsolver = new BinaryGASolver(theProblem.NumberOfJobs * theProblem.NumberOfJobs, OptimizationType.Minimization,theProblem.GetObjectiveValueByte );
        //    propertyGrid1.SelectedObject = theBinaryGAsolver;

        //}

        private void textPenalty_TextChanged(object sender, EventArgs e)
        {
            theProblem.Penalty = Convert.ToDouble(txtPenalty.Text);
        }

        //private void txtboxPSize_TextChanged(object sender, EventArgs e)
        //{
        //    theBinaryGAsolver.PopulationSize = Convert.ToInt32(txtboxPSize);
        //    thePermutationGAsolver.PopulationSize = Convert.ToInt32(txtboxPSize);
        //}

        //private void txtboxXRate_TextChanged(object sender, EventArgs e)
        //{
        //    thePermutationGAsolver.CrossoverRate = Convert.ToInt32(txtboxXRate);
        //    theBinaryGAsolver.CrossoverRate = Convert.ToInt32(txtboxXRate);

        //}

        //private void txtboxMutateRate_TextChanged(object sender, EventArgs e)
        //{
        //    theBinaryGAsolver.MutationRate = Convert.ToInt32(txtboxMutateRate);
        //    thePermutationGAsolver.MutationRate = Convert.ToInt32(txtboxMutateRate);

        //}

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void btnReset_Click(object sender, EventArgs e)
        {
            //theProblem.Iterationlimit = Convert.ToInt32(txtItrlimit.Text);

            foreach (var series in theChart.Series)
            {
                series.Points.Clear();
            }
            theChart.Series.Clear();

            theChart.ChartAreas.Clear();

            string s = "Iteration";
            ChartArea theArea = new ChartArea(s);


            theChart.ChartAreas.Add(theArea);
            //theChart.Legends[0].





            if (radiobtnBinary.Checked)
            {
                theBinaryGAsolver.Reset();

                theBinaryGAsolver.Average.ChartArea = theArea.Name;
                theBinaryGAsolver.Average.ChartType = SeriesChartType.Line;
                //add the series to Chart.Series
                theChart.Series.Add(theBinaryGAsolver.Average);

                theBinaryGAsolver.ItrBest.ChartArea = theArea.Name;
                theBinaryGAsolver.ItrBest.ChartType = SeriesChartType.Line;
                theChart.Series.Add(theBinaryGAsolver.ItrBest);

                theBinaryGAsolver.SofarTheBest.ChartArea = theArea.Name;
                theBinaryGAsolver.SofarTheBest.ChartType = SeriesChartType.Line;
                theChart.Series.Add(theBinaryGAsolver.SofarTheBest);



                //UpdateChartArea(theBinaryGAsolver.Average,theBinaryGAsolver.ItrBest,theBinaryGAsolver.SofarTheBest);







                txtboxBestObjValue.Text = theBinaryGAsolver.SoFarTheBestObjectiveValue.ToString();



                string ans = "";
                int count = 0;

                foreach (byte job in theBinaryGAsolver.SoFarTheBestSolution)
                {
                    ans += $"{job} ";
                    count += 1;

                    if (count % Math.Sqrt(theBinaryGAsolver.SoFarTheBestSolution.Length) == 0)
                    {
                        richtextboxBestAns.AppendText($"{ans}\n");
                        ans = "";
                    }


                }

                string population = "";
                count = 0;

                foreach (byte[] chro in theBinaryGAsolver.Chromosomes)
                {
                    string c = "";
                    foreach (byte b in chro) c += $"{b} ";
                    richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                    count += 1;
                    if (count == theBinaryGAsolver.PopulationSize) return;
                }





            }
            else if (radiobtnPermutation.Checked)
            {
                thePermutationGAsolver.Reset();


               thePermutationGAsolver.Average.ChartArea = theArea.Name;
               thePermutationGAsolver.Average.ChartType = SeriesChartType.Line;
                //add the series to Chart.Series
                theChart.Series.Add(thePermutationGAsolver.Average);

               thePermutationGAsolver.ItrBest.ChartArea = theArea.Name;
               thePermutationGAsolver.ItrBest.ChartType = SeriesChartType.Line;
                theChart.Series.Add(thePermutationGAsolver.ItrBest);

               thePermutationGAsolver.SofarTheBest.ChartArea = theArea.Name;
               thePermutationGAsolver.SofarTheBest.ChartType = SeriesChartType.Line;
                theChart.Series.Add(thePermutationGAsolver.SofarTheBest);







                //UpdateChartArea(thePermutationGAsolver.Average, thePermutationGAsolver.ItrBest, thePermutationGAsolver.SofarTheBest);







                txtboxBestObjValue.Text = thePermutationGAsolver.SoFarTheBestObjectiveValue.ToString();

                string ans = "";

                foreach (int job in thePermutationGAsolver.SoFarTheBestSolution) ans += $"{job} ";
                richtextboxBestAns.AppendText($"{ans}\n");



                int count = 0;

                foreach (int[] chro in thePermutationGAsolver.Chromosomes)
                {
                    string c = "";
                    foreach (int i in chro) c += $"{i} ";
                    richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                    count += 1;
                    if (count == theBinaryGAsolver.PopulationSize) return;
                }










                richtextboxBestAns.AppendText(ans);

            }









        }

        private void radiobtnBinary_Click(object sender, EventArgs e)
        {
            //theBinaryGAsolver = new BinaryGASolver(dgvAssTable.Columns.Count*dgvAssTable.Columns.Count, OptimizationType.Minimization,theProblem.GetObjectiveValueByte );
            propertyGridGAsolver.SelectedObject = theBinaryGAsolver;
        }

        private void radiobtnPermutation_CheckedChanged(object sender, EventArgs e)
        {
            //hePermutationGAsolver = new PermutationGAsolver(dgvAssTable.Columns.Count, OptimizationType.Minimization, theProblem.GetObjectiveValue);
            propertyGridGAsolver.SelectedObject = thePermutationGAsolver;


        }

        private void radiobtnBinary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPageGAsettings_Click(object sender, EventArgs e)
        {

        }

        private void btnOneiteration_Click(object sender, EventArgs e)
        {
            
            richTextBoxPopulation.Clear();
            richtextboxBestAns.Clear();
            richTextBoxViolation.Clear();

            if (radiobtnBinary.Checked)
            {
                theBinaryGAsolver.RunOneIteration();
                txtboxBestObjValue.Text = theBinaryGAsolver.SoFarTheBestObjectiveValue.ToString();
                txtboxBestObjValue.Text = theBinaryGAsolver.SoFarTheBestObjectiveValue.ToString();

                string ans = "";

                //foreach (byte job in theBinaryGAsolver.SoFarTheBestSolution) ans += $"{job} ";
                //richtextboxBestAns.AppendText($"{ans}\n");
                for (int l = 1; l <= theBinaryGAsolver.SoFarTheBestSolution.Length; l++)
                {
                    ans += $"{theBinaryGAsolver.SoFarTheBestSolution[l - 1]} ";

                    if (l % theProblem.NumberOfJobs == 0)
                    {
                        richtextboxBestAns.AppendText($"{ans}\n");
                        ans = "";
                    }
                }


                //violation row-wised check
                for (int i = 0; i < theProblem.NumberOfJobs; i++)
                {
                    double violation = 0.0;
                    for (int j = 0; j < theProblem.NumberOfJobs; j++)
                    {
                        if (theBinaryGAsolver.SoFarTheBestSolution[i * theProblem.NumberOfJobs + j] == 1) violation += 1;
                    }
                    if (violation > 1) richTextBoxViolation.AppendText($"Row{i + 1}:{(violation - 1).ToString("F2")}\n");
                    else
                    {
                        richTextBoxViolation.AppendText($"Row{i + 1}:{0.ToString("F2")}\n");
                    }

                }

                //violation column-wised check
                for (int j = 0; j < theProblem.NumberOfJobs; j++)
                {
                    double violation = 0.0;
                    for (int i = 0; i < theProblem.NumberOfJobs; i++)
                    {
                        if (theBinaryGAsolver.SoFarTheBestSolution[i * theProblem.NumberOfJobs + j] == 1) violation += 1;
                    }
                    if (violation > 1) richTextBoxViolation.AppendText($"Col{j + 1}:{(violation - 1).ToString("F2")}\n");
                    else
                    {
                        richTextBoxViolation.AppendText($"Col{j + 1}:{0.ToString("F2")}\n");


                    }
                }


                //int limit = theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren + theBinaryGAsolver.NumberOfMutatedChildren;
                int count = 0;
                foreach (byte[] chro in theBinaryGAsolver.Chromosomes)
                {
                    if (count < theBinaryGAsolver.PopulationSize)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }

                    else if (theBinaryGAsolver.PopulationSize <= count && count < theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"C{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                    else if (theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren <= count && count < theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren + theBinaryGAsolver.NumberOfMutatedChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"M{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                }

                theBinaryGAsolver.Average.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.IterationAverageObjective);
                theBinaryGAsolver.ItrBest.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.IterationBestObjective);
                theBinaryGAsolver.SofarTheBest.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.SoFarTheBestObjectiveValue);



                












            }


            else if (radiobtnPermutation.Checked)
            {
                thePermutationGAsolver.RunOneIteration();
                txtboxBestObjValue.Text = thePermutationGAsolver.SoFarTheBestObjectiveValue.ToString();

                string ans = "";

                foreach (int job in thePermutationGAsolver.SoFarTheBestSolution) ans += $"{job} ";
                richtextboxBestAns.AppendText($"{ans}\n");

                int count = 0;
                foreach (int[] chro in thePermutationGAsolver.Chromosomes)
                {
                    if (count < thePermutationGAsolver.PopulationSize)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }

                    else if (thePermutationGAsolver.PopulationSize <= count && count < thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"C{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                    else if (thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren <= count && count < thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren + thePermutationGAsolver.NumberOfMutatedChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"M{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                }
                thePermutationGAsolver.Average.Points.AddXY(thePermutationGAsolver.IterationCount, thePermutationGAsolver.IterationAverageObjective);
                thePermutationGAsolver.ItrBest.Points.AddXY(thePermutationGAsolver.IterationCount, thePermutationGAsolver.IterationBestObjective);
                thePermutationGAsolver.SofarTheBest.Points.AddXY(thePermutationGAsolver.IterationCount, thePermutationGAsolver.SoFarTheBestObjectiveValue);


            }




        }

        private void cbxPermutationXover_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPermutationXover.SelectedIndex)
            {
                case 0:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.PMX;
                    break;
                case 1:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.OX;
                    break;
                case 2:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.PositionbasedX;
                    break;
                case 3:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.OrderBasedX;
                    break;
                case 4:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.CX;
                    break;
                case 5:
                    thePermutationGAsolver.CrossoverOperator = CrossoverType.SubtourExcahngeX;
                    break;

            }
        }

        private void cbxPointCut_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPointCut.SelectedIndex)
            {
                case 0:
                    theBinaryGAsolver.CrossoverOperator = BinaryGASolver.CrossoverType.OnepointCut;
                    break;

                case 1:
                    theBinaryGAsolver.CrossoverOperator = BinaryGASolver.CrossoverType.TwoPointCut;
                    break;
            }
        }

        private void cbxPermutationMutation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPermutationMutation.SelectedIndex)
            {
                case 0:
                    thePermutationGAsolver.MutationOperator = Mutationtype.Swap;
                    break;
                case 1:
                    thePermutationGAsolver.MutationOperator = Mutationtype.Inversion;

                    break;
                case 2:
                    thePermutationGAsolver.MutationOperator = Mutationtype.Insertion;

                    break;
                case 3:
                    thePermutationGAsolver.MutationOperator = Mutationtype.Displacemnt;

                    break;
            }
        }

        private void txtboxBestObjValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAssTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
            if (radiobtnBinary.Checked)
            {
                while (theBinaryGAsolver.IterationCount < theProblem.Iterationlimit)
                {
                    richTextBoxPopulation.Clear();
                    richtextboxBestAns.Clear();
                    richTextBoxViolation.Clear();
                    theBinaryGAsolver.RunOneIteration();

                    txtboxBestObjValue.Text = theBinaryGAsolver.SoFarTheBestObjectiveValue.ToString();


                    //violation row-wised check
                    for (int i = 0; i < theProblem.NumberOfJobs; i++)
                    {
                        double violation = 0.0;
                        for (int j = 0; j < theProblem.NumberOfJobs; j++)
                        {
                            if (theBinaryGAsolver.SoFarTheBestSolution[i * theProblem.NumberOfJobs + j] == 1) violation += 1;
                        }
                        if (violation > 1) richTextBoxViolation.AppendText($"Row {i + 1}:{(violation - 1).ToString("F2")}\n");
                        else
                        {
                            richTextBoxViolation.AppendText($"Row {i + 1}:{0.ToString("F2")}\n");
                        }

                    }

                    //violation column-wised check
                    for (int j = 0; j < theProblem.NumberOfJobs; j++)
                    {
                        double violation = 0.0;
                        for (int i = 0; i < theProblem.NumberOfJobs; i++)
                        {
                            if (theBinaryGAsolver.SoFarTheBestSolution[i * theProblem.NumberOfJobs + j] == 1) violation += 1;
                        }
                        if (violation > 1) richTextBoxViolation.AppendText($"Col {j + 1}:{(violation - 1).ToString("F2")}\n");
                        else
                        {
                            richTextBoxViolation.AppendText($"Col {j + 1}:{0.ToString("F2")}\n");


                        }
                    }
                    txtboxBestObjValue.Text = theBinaryGAsolver.SoFarTheBestObjectiveValue.ToString();

                    string ans = "";

                    //foreach (byte job in theBinaryGAsolver.SoFarTheBestSolution) ans += $"{job} ";
                    //richtextboxBestAns.AppendText($"{ans}\n");
                    for (int l = 1; l <= theBinaryGAsolver.SoFarTheBestSolution.Length; l++)
                    {
                        ans += $"{theBinaryGAsolver.SoFarTheBestSolution[l - 1]} ";

                        if (l % theProblem.NumberOfJobs == 0)
                        {
                            richtextboxBestAns.AppendText($"{ans}\n");
                            ans = "";
                        }
                    }

                    //int limit = theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren + theBinaryGAsolver.NumberOfMutatedChildren;
                    int count = 0;
                    foreach (byte[] chro in theBinaryGAsolver.Chromosomes)
                    {
                        if (count < theBinaryGAsolver.PopulationSize)
                        {
                            string c = "";
                            foreach (byte b in chro) c += $"{b} ";
                            richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                            count += 1;
                        }

                        else if (theBinaryGAsolver.PopulationSize <= count && count < theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren)
                        {
                            string c = "";
                            foreach (byte b in chro) c += $"{b} ";
                            richTextBoxPopulation.AppendText($"C{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                            count += 1;
                        }
                        else if (theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren <= count && count < theBinaryGAsolver.PopulationSize + theBinaryGAsolver.NumberOfCrossoveredChildren + theBinaryGAsolver.NumberOfMutatedChildren)
                        {
                            string c = "";
                            foreach (byte b in chro) c += $"{b} ";
                            richTextBoxPopulation.AppendText($"M{(count + 1).ToString("D3")}  {c}  obj:{theBinaryGAsolver.ObjectiveValues[count]}\n");
                            count += 1;
                        }
                    }

                   
                    theBinaryGAsolver.Average.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.IterationAverageObjective);
                    theBinaryGAsolver.ItrBest.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.IterationBestObjective);
                    theBinaryGAsolver.SofarTheBest.Points.AddXY(theBinaryGAsolver.IterationCount, theBinaryGAsolver.SoFarTheBestObjectiveValue);

                    //UpdateChartArea(theBinaryGAsolver.Average, theBinaryGAsolver.ItrBest, theBinaryGAsolver.SofarTheBest);













                }
            }


            else if (radiobtnPermutation.Checked)
            {
                while (theBinaryGAsolver.IterationCount < theProblem.Iterationlimit) {
                richTextBoxPopulation.Clear();
                richtextboxBestAns.Clear();
                richTextBoxViolation.Clear();
                thePermutationGAsolver.RunOneIteration();
                txtboxBestObjValue.Text = thePermutationGAsolver.SoFarTheBestObjectiveValue.ToString();

                string ans = "";

                foreach (int job in thePermutationGAsolver.SoFarTheBestSolution) ans += $"{job} ";
                richtextboxBestAns.AppendText($"{ans}\n");

                int count = 0;
                foreach (int[] chro in thePermutationGAsolver.Chromosomes)
                {
                    if (count < thePermutationGAsolver.PopulationSize)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"P{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }

                    else if (thePermutationGAsolver.PopulationSize <= count && count < thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"C{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                    else if (thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren <= count && count < thePermutationGAsolver.PopulationSize + thePermutationGAsolver.NumberOfCrossoveredChildren + thePermutationGAsolver.NumberOfMutatedChildren)
                    {
                        string c = "";
                        foreach (byte b in chro) c += $"{b} ";
                        richTextBoxPopulation.AppendText($"M{(count + 1).ToString("D3")}  {c}  obj:{thePermutationGAsolver.ObjectiveValues[count]}\n");
                        count += 1;
                    }
                }

                  
                thePermutationGAsolver.Average.Points.AddXY(theBinaryGAsolver.IterationCount, thePermutationGAsolver.IterationAverageObjective);
                thePermutationGAsolver.ItrBest.Points.AddXY(theBinaryGAsolver.IterationCount, thePermutationGAsolver.IterationBestObjective);
                thePermutationGAsolver.SofarTheBest.Points.AddXY(theBinaryGAsolver.IterationCount, thePermutationGAsolver.SoFarTheBestObjectiveValue);

                //UpdateChartArea(thePermutationGAsolver.Average, thePermutationGAsolver.ItrBest, thePermutationGAsolver.SofarTheBest);




            }
            }
            




        }

        //private void txtItrlimit_TextChanged(object sender, EventArgs e)
        //{
        //    theProblem.Iterationlimit = Convert.ToInt32(txtItrlimit.Text);
        //}

        //public void UpdateChartArea(Series avg, Series itrbest, Series sofarbest)
        //{
           
        //    foreach (var series in theChart.Series)
        //    {
        //        series.Points.Clear();
        //    }
            
        //    theChart.Series.

            
        //    theChart.Series.Add(itrbest);

            
        //    theChart.Series.Add(sofarbest);



        //}


        private void radioButtonStochastic_CheckedChanged(object sender, EventArgs e)
        {
            theBinaryGAsolver.SelectionMode = SelectionType.Stochastic;
            thePermutationGAsolver.SelectionMode = SelectionType.Stochastic;
        }

        private void radioButtonDeterministic_CheckedChanged(object sender, EventArgs e)
        {
            thePermutationGAsolver.SelectionMode = SelectionType.Deterministic;
            theBinaryGAsolver.SelectionMode = SelectionType.Deterministic;
        }

        private void theChart_Click(object sender, EventArgs e)
        {

        }
    }
}

using R09546014HungYLAss07.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss07
{
    public partial class Mainform : Form

    {
        


        JobAssignmentProblem theProblem;
        private SoundPlayer player;



        //public event EventHandler assinput;
        //protected void EnableBruteForcebtn()
        //{
        //    if (assinput != null) assinput(this, null);
        //}





        public Mainform()

        {
            InitializeComponent();
            theProblem = new JobAssignmentProblem();
            player = new SoundPlayer(Resources.bubbs);

            toolStripButtonBruteForce.Enabled = false;







        }

       

        

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            toolStripButtonBruteForce.Enabled = true;
            theProblem.OpenFile(dlgOpen.FileName);

            FillAssignmentable();

            
        }

        private void FillAssignmentable()
        {
            DataTable AssTable = new DataTable("Assignment Table");

            //AssTable.Rows.Clear();
            //AssTable.Columns.Clear();

            dgvAssTable.Columns.Clear();
            dgvAssTable.Rows.Clear();


            
            for (int i =0; i < theProblem.NumberOfJobs; i++)
            {
                dgvAssTable.Columns.Add($"M{i}", $"M{i}");
            }
            for (int j = 0; j < theProblem.NumberOfJobs; j++)
            {
                dgvAssTable.Rows.Add();
                dgvAssTable.Rows[j].HeaderCell.Value = $"Job{j}";

                // iterate over all columns to fill the row
                for (int i = 0; i <theProblem.NumberOfJobs ; i++)
                {
                    dgvAssTable.Rows[j].Cells[i].Value = theProblem.SetupTimes[j,i];
                }

               
            }

            

        }

        int[] assignments;
        bool[] flags;

        //private void btnbruteforce_Click(object sender, EventArgs e)
        //{
        //    assignments = new int[theProblem.NumberOfJobs];
        //    flags = new bool[theProblem.NumberOfJobs];

        //    for (int i = 0; i < flags.Length; i++)
        //        flags[i] = false;

        //    DateTime startTime = DateTime.Now;
            
        //    RecursiveMethod(0);
        //    DateTime endTime = DateTime.Now;



        //    TimeSpan delta = endTime - startTime;

        //    tspAnswer.Text = $"The best objective value:{thebestObjectValue} The best answer:{thebestAnswer}"; 

        //    labMessage.Text = $"Start time:{startTime}  End time:{endTime} Takes:{delta.TotalSeconds}";

           





        //}

        //recursive method
        double thebestObjectValue = double.MaxValue;
        string thebestAnswer;

        void RecursiveMethod(int id)
        {
            for(int i =0;i< flags.Length; i++)
            {
                if (flags[i]) continue;
                flags[i] = true;
                assignments[id] = i;

                //如果是最後一個
                if(id == flags.Length - 1)
                {
                    //done for this assignment,evaluate this value
                    string answer = "";

                    foreach (int job in assignments) answer += $"{job} ";

                    double objective = theProblem.GetTotalSetupTimeForAnAssignment(assignments);

                    if (objective < thebestObjectValue)
                    {
                        thebestObjectValue = objective;
                        thebestAnswer = $"{answer} ";
                    }

                    richTextBoxbruteforce.AppendText($"{answer} = {objective}\n");

                }

                //如果不是最後一個
                else
                {
                    RecursiveMethod(id + 1);
                }

                flags[i] = false;

            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabelTime_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStripObjValue_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButtonBruteForce_Click(object sender, EventArgs e)
        {
            assignments = new int[theProblem.NumberOfJobs];
            flags = new bool[theProblem.NumberOfJobs];

            for (int i = 0; i < flags.Length; i++)
                flags[i] = false;

            DateTime startTime = DateTime.Now;

            RecursiveMethod(0);
            DateTime endTime = DateTime.Now;



            TimeSpan delta = endTime - startTime;

            tspAnswer.Text = $"The best objective value:{thebestObjectValue} The best answer:{thebestAnswer}";

            labMessage.Text = $"Start time:{startTime}  End time:{endTime} Takes:{delta.TotalSeconds}";

            player.Play();


        }
    }
}

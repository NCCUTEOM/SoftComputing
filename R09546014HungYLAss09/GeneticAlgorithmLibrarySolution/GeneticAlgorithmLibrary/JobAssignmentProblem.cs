using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss07
{
    public class JobAssignmentProblem
    {


        int numberOfJobs;

        //代表2-dim array 與 c語言array不一樣
        double[,] SetupTimes;

        string fileName;

        public int NumberOfJobs { get => numberOfJobs; set => numberOfJobs = value; }

        public void OpenFile(string path)
        {
            fileName = path;
            StreamReader sr = new StreamReader(fileName);

            string str;
            string[] items;
            char[] sep = new char[1] { ' ' };
            str = sr.ReadLine();
            numberOfJobs = Convert.ToInt32(str);
            SetupTimes = new double[numberOfJobs, numberOfJobs];
            for(int r =0;r< numberOfJobs; r++)
            {
                str = sr.ReadLine();
                items = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < numberOfJobs; c++)
                {
                    SetupTimes[r, c] = Convert.ToDouble(items[c]);
                }
            }



            sr.Close();

        }

        public double GetTotalSetupTimeForAnAssignment(int[] ass)
        {
            //防錯
            if (ass.Length != numberOfJobs) return double.NaN;


            double total = 0;
            for(int j=0;j< numberOfJobs; j++)
            {
                total += SetupTimes[ass[j], j];
            
            }
            return total;
        }
    }
}

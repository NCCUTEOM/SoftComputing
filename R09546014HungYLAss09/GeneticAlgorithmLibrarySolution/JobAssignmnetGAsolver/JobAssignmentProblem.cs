using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JobAssignmnetGAsolver
{
    class JobAssignmentProblem
    {


        int numberOfJobs;

        //代表2-dim array 與 c語言array不一樣
        double[,] setupTimes;

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
            setupTimes = new double[numberOfJobs, numberOfJobs];
            for(int r =0;r< numberOfJobs; r++)
            {
                str = sr.ReadLine();
                items = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < numberOfJobs; c++)
                {
                    setupTimes[r, c] = Convert.ToDouble(items[c]);
                }
            }




            sr.Close();


    }
        public double Penalty { get; set; } = 100;
        public int Iterationlimit { get; set; } = 100;
        public double[,] SetupTimes { get => setupTimes; set => setupTimes = value; }



        //For brute force method and PermutationGA
        public double GetObjectiveValue(int[] ass)
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


        
        public double GetObjectiveValueByte(byte[] ass)
        {
          

            double total = 0;
            


            //Setuptimes
            for(int i = 0; i < numberOfJobs; i++)
            {
                for(int j = 0; j < numberOfJobs; j++)
                {
                    total += SetupTimes[i, j] * ass[i * numberOfJobs + j];
                    //total += SetupTimes[i, j] * ass[ j];

                }
            }

            //Penalty

            //column-wised
            double columnwisePenalty = 0;

            for (int j = 0; j < numberOfJobs; j++)
            {
                double sumCol = 0;

                for (int i = 0; i < numberOfJobs; i++)
                {
                    sumCol += ass[j + numberOfJobs * i];
                    //total += SetupTimes[i, j] * ass[ j];


                }

                columnwisePenalty += Math.Abs(sumCol - 1);

            }

            //row-wised
            double rowwisePenalty = 0;


            for (int i = 0; i < numberOfJobs; i++)
            {
                double sumRow = 0;

                for (int j = 0; j < numberOfJobs; j++)
                {
                    sumRow += ass[i * numberOfJobs + j];
                    //sumRow += ass[ j];

                }

                rowwisePenalty += Math.Abs(sumRow - 1);

            }

            total += Penalty * (rowwisePenalty + columnwisePenalty);









            return total;
        }
    }
}

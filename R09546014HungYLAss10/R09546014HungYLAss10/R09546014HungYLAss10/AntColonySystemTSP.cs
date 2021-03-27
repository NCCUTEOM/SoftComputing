using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014HungYLAss10
{

    delegate double ObjectiveFunction(int[] s);
    class AntColonySystemTSP
    {
        
        private int numberOfAnts = 50;
        private double iterationBestSolution;
        double deterministicThresh = 0.8;//a threshold for either use deterministic or AS selection method (stochastic), 

        int[][] solutions;
        double[,] pheromoneMap;
        double[,] heuristicValues;
        double[,] ObjectiveValues;

        double evaporationRate = 0.1;
        double iterationAverage;
        double iterationBest;
        int numberOfCities;



        private double pheromoneDropAmount = 0.001;
       

        [Browsable(false)]
        public int IterationCount { set; get; } = 0;


        double pheromonefactor = 3;
        double heuristicfactor = 1;



        double soFarTheBestObjective = double.MaxValue;
        int[] soFarTheBestSolution;
        Random randomizer = new Random();
        bool[] cityAvailable;
        
        int[] availableCityIDs;
        double[] fitness;
        public AntColonySystemTSP(int numberOfCities,ObjectiveFunction obj,double[,] fromToDistance) {
            this.numberOfCities = numberOfCities;
            soFarTheBestSolution = new int[this.numberOfCities];
            pheromoneMap = new double[numberOfCities, numberOfCities];
            heuristicValues = new double[numberOfCities, numberOfCities];
            for (int r = 0; r < numberOfCities; r++)
            {
                for (int c = 0; c < numberOfCities ; c++){
                    if (r == c) heuristicValues[r, c] = 1e10;//把關，不能自己走到自己 
                    else heuristicValues[r, c] = fromToDistance[r, c];//from to distance

                }       


            }
            cityAvailable = new bool[numberOfCities];
            availableCityIDs = new int[numberOfCities];
            fitness = new double[numberOfCities];

           

        }
        [CategoryAttribute("Execution"), DescriptionAttribute("演化代次上限")]

        public int IterationLimit { get; set; } = 500;

        [CategoryAttribute("ACO Setting")]

        public int NumberOfAnts
        {
            get => numberOfAnts;
            set { if (value > 0 && value <= 100) numberOfAnts = value; }//防錯

        }



        [CategoryAttribute("ACO Setting")]

        public double InitialPheromoneValue { set; get; } = 0.01;


        [Browsable(false)]
        public double SoFarTheBestObjective { get => soFarTheBestObjective; }

        [Browsable(false)]

        public int[] SoFarTheBestSolution { get => soFarTheBestSolution; set { value = soFarTheBestSolution; } }
        [CategoryAttribute("ACO Setting")]


        public double Pheromonefactor { get => pheromonefactor; set => pheromonefactor = value; }
        [CategoryAttribute("ACO Setting")]

        public double Heuristicfactor
        {
            get => heuristicfactor;
            set
            {
                if (value > 0) heuristicfactor = value;
            }
        }

        [CategoryAttribute("ACO Setting")]

        public double DeterministicThresh { 
            get => deterministicThresh; 
            set { if(value>=0 && value <=1)deterministicThresh = value; } 
        }

        [CategoryAttribute("ACO Setting")]
        public double EvaporationRate
        {
            get => evaporationRate;
            set
            {
                if (value >= 0 && value < 1) evaporationRate = value;
            }
        }

        [CategoryAttribute("ACO Setting")]

        public PheromoneUpdateType PheromoneDropMode { get => pheromoneDropMode; set => pheromoneDropMode = value; }


        [CategoryAttribute("ACO Setting")]

        public double PheromoneDropAmount { get => pheromoneDropAmount; set { if(value>0 && value< 1)pheromoneDropAmount = value; } }
        [CategoryAttribute("ACO Setting")]

        //public double InitialPheromone { get; set; } = 0.001;
        internal void Reset()
        {
            solutions = new int[NumberOfAnts][];
            for (int i = 0; i < numberOfAnts; i++)
                solutions[i] = new int[numberOfCities];

            //randomly initialize pheromone table
            for (int r =0;r< numberOfCities; r++)
            {
                for(int c = 0; c < numberOfCities; c++)
                {
                    pheromoneMap[r, c] = InitialPheromoneValue; ;
                }
            }

            //randomly initialize solutions
            for (int i = 0; i < NumberOfAnts; i++)
            {
                for(int c = 0; c < numberOfCities; c++)
                {
                    solutions[i][c] = c;
                }
                ShuffleIntegerArray(solutions[i]);
            }
            IterationCount = 0;
            soFarTheBestObjective = double.MaxValue;
        }

        internal void RunOneIteration()
        {
            
            EachAntConstructItsSolution();
            ComputeObjectiveValueAndSoFarTheBest();
            if (pheromoneDropMode == PheromoneUpdateType.eliteWise)UpdatePheromoneMap();
            EvaporatePheromone();
            average.Points.AddXY(IterationCount, iterationAverage);
            itrBest.Points.AddXY(IterationCount,iterationBest);
            sofarTheBest.Points.AddXY(IterationCount, soFarTheBestObjective);

            
            IterationCount++;
            
        }

        private void EvaporatePheromone()
        {
            for (int r = 0; r < numberOfCities; r++)
            {
                for (int c = 0; c < numberOfCities; c++)
                {
                    pheromoneMap[r, c] *= (1 - evaporationRate);
                }
            }
        }

        private void UpdatePheromoneMap()
        {//這邊要改

            //update so far the best solution pheromone
            int fid, tid;
            fid = SoFarTheBestSolution[0];

            for (int i = 1; i < numberOfCities; i++)
            {
                tid = SoFarTheBestSolution[i];
                pheromoneMap[fid, tid] += InitialPheromoneValue;
                fid = tid;
            }
           
        }

        private void ComputeObjectiveValueAndSoFarTheBest()
        {
            iterationBest = double.MaxValue;
            iterationAverage = 0;

            for (int i = 0; i < numberOfAnts; i++)
            {
                double resultforAnAnt = TSPBenchmark.TSPBenchmarkProblem.ComputeObjectiveValue(solutions[i]);
                iterationAverage += resultforAnAnt;
                if( resultforAnAnt < iterationBest)
                {
                    iterationBest = resultforAnAnt;
                    
                    if(iterationBest < soFarTheBestObjective)
                    {
                        soFarTheBestObjective = iterationBest;
                        Array.Copy(solutions[i], soFarTheBestSolution, numberOfCities);
                    }
                }
            }
            iterationAverage /= numberOfAnts;
        }


        private void EachAntConstructItsSolution()
        {
           
            int numberCandidate = numberOfCities;
            int currentCityID ;
            for(int i = 0; i < NumberOfAnts; i++)
            {
                numberCandidate = numberOfCities;


                //for(int j=0;j<numberOfCities;j++)cityAvailable[j] = true;

                for (int j=0;j<numberOfCities;j++)availableCityIDs[j] = j;//initialize

                int pos = randomizer.Next(numberOfCities);
                currentCityID = availableCityIDs[pos];
                availableCityIDs[pos] = availableCityIDs[numberCandidate-1];

                solutions[i][0] = currentCityID;

                //step count
                for (int s = 1; s < numberOfCities; s++)
                {

                    numberCandidate--;
                    pos = -1;


                    double maxFit = double.MinValue;
                    
                        for (int j = 0; j < numberCandidate; j++)
                        {
                            //compute relative probability for each candidate

                            int candidateID = availableCityIDs[j];
                        fitness[j] = Math.Pow(pheromoneMap[currentCityID, candidateID], pheromonefactor) * Math.Pow(1/ heuristicValues[currentCityID, candidateID], heuristicfactor);//這邊待確認


                            if (fitness[j] > maxFit)
                            {
                                pos = j;
                                maxFit = fitness[j];
                            }


                        }
                    

                    double r = randomizer.NextDouble();
                    int nextCityId = -1;

                    if(r>= DeterministicThresh)
                    {
                        //stochastic
                        double sumOfFitness = 0;
                        for (int k = 0; k < numberCandidate; k++) sumOfFitness += fitness[k];

                        //射飛鏢
                        double target = randomizer.Next((int)(sumOfFitness/1.0));

                        sumOfFitness = 0;
                        int selectedIndex = 0;

                        
                        sumOfFitness += fitness[selectedIndex];
                        
                        while (sumOfFitness < target)
                        {
                            selectedIndex += 1;
                            sumOfFitness += fitness[selectedIndex];
                        }

                        nextCityId = availableCityIDs[selectedIndex];

                        solutions[i][s] = nextCityId;
                        availableCityIDs[selectedIndex] = availableCityIDs[numberCandidate - 1];




                    }
                    else
                    {
                        //deterministic
                        nextCityId = availableCityIDs[pos];

                        solutions[i][s] = nextCityId;
                        availableCityIDs[pos] = availableCityIDs[numberCandidate - 1];

                        

                    }
                    //if (currentCityID == nextCityId) break;//已經走完一圈了
                    //add pheromone if segment pheromone dropping is enabled

                    //step-wise

                    if (pheromoneDropMode == PheromoneUpdateType.stepWise)
                    {
                        pheromoneMap[currentCityID, nextCityId] += PheromoneDropAmount;
                        pheromoneMap[nextCityId, currentCityID] += PheromoneDropAmount;
                    }

                        currentCityID = nextCityId;//進入下一個階段

                }
                // //add phromone if segment phromone dropping is enabled.
                if (pheromoneDropMode == PheromoneUpdateType.trailWise)
                {
                    for (int j = 0; j < numberOfCities - 1; j++) pheromoneMap[Solutions[i][j], Solutions[i][j + 1]] += PheromoneDropAmount;

                    for (int j = numberOfCities-1; j > 0; j--) pheromoneMap[Solutions[i][j], Solutions[i][j -1]] += PheromoneDropAmount;






                }

            }
            
        }

        private void ShuffleIntegerArray(int[] vs)
        {
            //自己寫哦

            for (int c = vs.Length - 1; c > 1; c--)
            {
                int pos = randomizer.Next(c + 1);
                int temp = vs[c];
                vs[c] = vs[pos];
                vs[pos] = temp;
            }
        }
        
        private Series average = new Series("Iteration Average");
        private Series itrBest = new Series("Iteration Best");
        private Series sofarTheBest = new Series("So Far The Best");

        public enum PheromoneUpdateType { stepWise, trailWise, eliteWise };

        PheromoneUpdateType pheromoneDropMode = PheromoneUpdateType.stepWise;

        [Browsable(false)]
        public Series Average { get => average; set => average = value; }

        [Browsable(false)]
        public Series ItrBest { get => itrBest; set => itrBest = value; }

        [Browsable(false)]
        public Series SofarTheBest { get => sofarTheBest; set => sofarTheBest = value; }
        [Browsable(false)]
        public double[,] PheromoneMap { get => pheromoneMap; set => pheromoneMap = value; }

        [Browsable(false)]
        public int NumberOfCities { get => numberOfCities; set => numberOfCities = value; }

        [Browsable(false)]
        public int[][] Solutions { get => solutions; set => solutions = value; }
       


        //public double IterationBestSolution { get => iterationBestSolution; set => iterationBestSolution = value; }
    }
}

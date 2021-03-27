using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using COP;

namespace R09546014HungYLAss11PSO
{
    public enum OptimizationType { Minimization, Maximization };
    public delegate double ObjectiveFunction(double[] solution);

    class ParticleSwarmOptimizationSolver
    {
        Random randomizer = new Random();
        //data fields
        private int numberOfParticles = 10;
        private double iterationBestSolution;
        private double cognitionFactor = 0.5;
        private double socialFactor = 0.5;
        private int numberOfVariables;
        double[] soFarTheBestSolution;
        OptimizationType optimizationmode;
        private double soFarTheBestObjectiveValue;
        private double[] lowerBounds;
        private double[] upperBounds;
        private double[][] localBestSolution;
        private double[] localBestObjectiveValue;
        ObjectiveFunction objfunction;
        private int iterationCount = 0;

        double iterationAverage;
        double iterationBest;


        private Series average = new Series("Iteration Average");
        private Series itrBest = new Series("Iteration Best");
        private Series sofarTheBest = new Series("So Far The Best");

        //properties

        [Category("Execution")]

        public int IterationLimit { get; set; } = 100;


        [Browsable(false)]

        public double[][] Solutions { get; }

        [Category("PSO Setting")]

        public int NumberOfParticles
        {
            get => numberOfParticles;
            set
            {
                if (value > 1 && value < 1000) numberOfParticles = value;
            }
        }

        [Browsable(false)]

        public int IterationCount
        {
            get => iterationCount;
            set { iterationCount = value; }
        }


        [Browsable(false)]
        public Series Average { get => average; set => average = value; }
        [Browsable(false)]
        public Series ItrBest { get => itrBest; set => itrBest = value; }
        [Browsable(false)]
        public Series SofarTheBest { get => sofarTheBest; set => sofarTheBest = value; }
        [Category("PSO Setting")]
        public double SocialFactor { get => socialFactor; set => socialFactor = value; }
        [Category("PSO Setting")]
        public double CognitionFactor { get => cognitionFactor; set => cognitionFactor = value; }

        public ParticleSwarmOptimizationSolver(int numberOfVariables, OptimizationType optimizationType, double[] lowerBounds, double[] upperBounds, ObjectiveFunction objectiveFunction)
        {
            this.lowerBounds = new double[numberOfVariables];
            this.upperBounds = new double[numberOfVariables];
            Array.Copy(lowerBounds, this.lowerBounds, numberOfVariables);
            Array.Copy(upperBounds, this.upperBounds, numberOfVariables);

            soFarTheBestSolution = new double[numberOfVariables];

            localBestSolution = new double[numberOfParticles][];
            for (int j = 0; j < numberOfParticles; j++) localBestSolution[j] = new double[numberOfVariables];

            Solutions = new double[numberOfParticles][];
            for (int j = 0; j < numberOfParticles; j++) Solutions[j] = new double[numberOfVariables];


            localBestObjectiveValue = new double[numberOfParticles];



            this.numberOfVariables = numberOfVariables;




            optimizationmode = optimizationType;
            objfunction = objectiveFunction;




        }

        internal void Reset()
        {
            iterationCount = 0;//iteration 歸零

            for (int r = 0; r < numberOfParticles; r++)
            {
                for (int c = 0; c < numberOfVariables; c++)
                {
                    //randomly initialize solution
                    Solutions[r][c] = lowerBounds[c] + (upperBounds[c] - lowerBounds[c]) * randomizer.NextDouble();

                    //record the initial position as the local best solution for each particle
                    localBestSolution[r][c] = Solutions[r][c];
                    



                }
                localBestObjectiveValue[r] = objfunction(Solutions[r]);
            }

            //Find the best solution from the local best solution of the particles and assign it as the best solution so far
            if (optimizationmode == OptimizationType.Maximization)
            {
                soFarTheBestObjectiveValue = double.MinValue;

                for (int r = 0; r < numberOfParticles; r++)
                {
                    if (objfunction(localBestSolution[r]) > soFarTheBestObjectiveValue) Array.Copy(localBestSolution[r], soFarTheBestSolution, numberOfVariables);
                }
            }

            if (optimizationmode == OptimizationType.Minimization)
            {
                soFarTheBestObjectiveValue = double.MaxValue;
                for (int r = 0; r < numberOfParticles; r++)
                {
                    if (objfunction(localBestSolution[r]) < soFarTheBestObjectiveValue) Array.Copy(localBestSolution[r], soFarTheBestSolution, numberOfVariables);
                }
            }



        }

        internal void RunOneIteration()
        {

            MoveParticlesToNewPositions();

            UpdateForEachParticle();

            average.Points.AddXY(IterationCount, iterationAverage);
            itrBest.Points.AddXY(IterationCount, iterationBest);
            sofarTheBest.Points.AddXY(IterationCount, soFarTheBestObjectiveValue);

        }

        

        private void MoveParticlesToNewPositions()
        {
            double velocity = 0.0;
            for (int j = 0; j < numberOfParticles; j++)
            {
                double alpha = cognitionFactor * randomizer.NextDouble();
                double beta = socialFactor * randomizer.NextDouble();

                for (int i = 0; i < numberOfVariables; i++)
                {
                    velocity = alpha * (localBestSolution[j][i] - Solutions[j][i]) + beta * (soFarTheBestSolution[i] - Solutions[j][i]);
                    Solutions[j][i] = Solutions[j][i] + velocity;

                    if (Solutions[j][i] > upperBounds[i]) Solutions[j][i] = upperBounds[i];
                    else if (Solutions[j][i] < lowerBounds[i]) Solutions[j][i] = lowerBounds[i];

                }
            }
        }

        private void UpdateForEachParticle()
        {

            if (optimizationmode == OptimizationType.Maximization)
            {
                iterationAverage = 0;
                iterationBest = double.MinValue;
                for (int j = 0; j < numberOfParticles; j++)
                {
                    
                    if (objfunction(Solutions[j]) > localBestObjectiveValue[j])
                    {
                        localBestObjectiveValue[j] = objfunction(Solutions[j]);
                        Array.Copy(Solutions[j], localBestSolution[j], numberOfVariables);

                        if (localBestObjectiveValue[j] > soFarTheBestObjectiveValue)
                        {
                            soFarTheBestObjectiveValue = localBestObjectiveValue[j];
                            Array.Copy(localBestSolution[j], soFarTheBestSolution, numberOfVariables);
                        }
                        
                    }
                    iterationAverage += objfunction(Solutions[j]);

                    if (iterationBest < objfunction(Solutions[j])) iterationBest = objfunction(Solutions[j]);
                }
                iterationAverage /= numberOfParticles;
            }

            else if(optimizationmode == OptimizationType.Minimization)
            {
                iterationAverage = 0;
                iterationBest = double.MaxValue;

                for (int j = 0; j < numberOfParticles; j++)
                {
                    if (objfunction(Solutions[j]) < localBestObjectiveValue[j])
                    {
                        localBestObjectiveValue[j] = objfunction(Solutions[j]);
                        Array.Copy(Solutions[j], localBestSolution[j], numberOfVariables);

                        if (localBestObjectiveValue[j] < soFarTheBestObjectiveValue)
                        {
                            soFarTheBestObjectiveValue = localBestObjectiveValue[j];
                            Array.Copy(localBestSolution[j], soFarTheBestSolution, numberOfVariables);
                        }
                    }

                    iterationAverage += objfunction(Solutions[j]);

                    if (iterationBest > objfunction(Solutions[j])) iterationBest = objfunction(Solutions[j]);
                }
                iterationAverage /= numberOfParticles;
            }


        }
      

    }
}

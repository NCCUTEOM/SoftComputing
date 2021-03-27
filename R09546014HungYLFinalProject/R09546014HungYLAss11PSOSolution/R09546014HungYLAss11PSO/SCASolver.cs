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
   

    class SCAsolver:ParticleSwarmOptimizationSolver
    {
       
        //private double[] BestSolution;
        //private double BestObjectiveValue;
      

        private double r1;
        private double snRatio;
        private double a = 2.0;
        private bool withadaptiver1 = true;


        ////properties

        [Browsable(false)]
        public double[] objvaluesForEachAgents { get => localBestObjectiveValue; set => localBestObjectiveValue = value; }

        [Category("SCA Setting")]
        public double A { get => a; set => a = value; }


        [Browsable(false)]
        public double SocialFactor { get => socialFactor; set => socialFactor = value; }
        [Browsable(false)]
        public double CognitionFactor { get => cognitionFactor; set => cognitionFactor = value; }

        [Browsable(false)]
        public double SnRatio { get => snRatio; set => snRatio = value; }


        [Category("SCA Setting")]

        public bool WithAdaptive_r1 { get => withadaptiver1; set => withadaptiver1 = value; }
        [Category("SCA Setting")]
        public int NumberOfParticles
        {
            get => numberOfParticles;
            set
            {
                if (value > 1 && value < 1000) numberOfParticles = value;
            }
        }
   

      

        
        

        public SCAsolver(int numberOfVariables, OptimizationType optimizationType, double[] lowerBounds, double[] upperBounds, ObjectiveFunction objectiveFunction) 
            : base( numberOfVariables, optimizationType, lowerBounds, upperBounds, objectiveFunction)

        {
            this.lowerBounds = new double[numberOfVariables];
            this.upperBounds = new double[numberOfVariables];
            Array.Copy(lowerBounds, this.lowerBounds, numberOfVariables);
            Array.Copy(upperBounds, this.upperBounds, numberOfVariables);

            soFarTheBestSolution = new double[numberOfVariables];

            //localBestSolution = new double[numberOfParticles][];
            //for (int j = 0; j < numberOfParticles; j++) localBestSolution[j] = new double[numberOfVariables];

            soFarTheBestSolution = new double[numberOfVariables];

            Solutions = new double[numberOfParticles][];
            for (int j = 0; j < numberOfParticles; j++) Solutions[j] = new double[numberOfVariables];


            objvaluesForEachAgents = new double[numberOfParticles];



            this.numberOfVariables = numberOfVariables;




            optimizationmode = optimizationType;

            if(optimizationmode == OptimizationType.Maximization)
            {
                soFarTheBestObjectiveValue = double.MinValue;
            }
            else
            {
                soFarTheBestObjectiveValue = double.MaxValue;
            }

            objfunction = objectiveFunction;




        }

        public override void Reset()
        {
            //double SampleMean = 0.0;
            double sumofsquare = 0.0;
            r1 = a - iterationCount * a / IterationLimit;

            iterationCount = 0;//iteration 歸零

            soFarTheBestSolution = new double[numberOfVariables];

            

        

            Solutions = new double[numberOfParticles][];
            for (int j = 0; j < numberOfParticles; j++) Solutions[j] = new double[numberOfVariables];


            objvaluesForEachAgents = new double[numberOfParticles];





            for (int r = 0; r < numberOfParticles; r++)
            {
                for (int c = 0; c < numberOfVariables; c++)
                {
                    //randomly initialize solution
                    Solutions[r][c] = lowerBounds[c] + (upperBounds[c] - lowerBounds[c]) * randomizer.NextDouble();




                }
                objvaluesForEachAgents[r] = objfunction(Solutions[r]);
                //SampleMean += objvaluesForEachAgents[r];
                sumofsquare += objvaluesForEachAgents[r] * objvaluesForEachAgents[r];
            }
            //SampleMean /= numberOfParticles;

            

            

            //Find the best solution from the local best solution of the particles and assign it as the best solution so far
            if (optimizationmode == OptimizationType.Maximization)
            {
                soFarTheBestObjectiveValue = double.MinValue;

                for (int r = 0; r < numberOfParticles; r++)
                {
                    if (objvaluesForEachAgents[r] > soFarTheBestObjectiveValue) Array.Copy(Solutions[r],soFarTheBestSolution, numberOfVariables);
                }

                //Aim at maximizing SN Ratio
                //snRatio = 10 * Math.Log10(SampleMean * SampleMean / GetSampleStd(SampleMean));
                snRatio = -10 * Math.Log10(sumofsquare / numberOfParticles);


            }

            if (optimizationmode == OptimizationType.Minimization)
            {
                soFarTheBestObjectiveValue = double.MaxValue;

                for (int r = 0; r < numberOfParticles; r++)
                {
                    if (objvaluesForEachAgents[r] < soFarTheBestObjectiveValue) Array.Copy(Solutions[r], soFarTheBestSolution, numberOfVariables);
                }

                //Aim at maximizing SN Ratio
                snRatio = -10 * Math.Log10(1 / sumofsquare / numberOfParticles);

                //snRatio = -10 * Math.Log10(SampleMean * SampleMean / GetSampleStd(SampleMean));
            }



        }

        public override void RunOneIteration()
        {
            if (withadaptiver1 == true)
            {

                //As snRatio increase, we have much confident that the whole search agents move closely to the global optimum,thus shrinking the search area quickly,and vise versa.
                if (snRatio < 1) r1 = a - iterationCount * a / IterationLimit;

                else if (snRatio >= 1)
                {
                    r1 = a - iterationCount * a / IterationLimit / snRatio;
                }
            }
            else
            {
                r1 = a - iterationCount * a / IterationLimit;
            }
            
            


            MoveParticlesToNewPositions();

            UpdateForEachParticle();

            average.Points.AddXY(IterationCount, iterationAverage);
            itrBest.Points.AddXY(IterationCount, iterationBest);
            sofarTheBest.Points.AddXY(IterationCount, soFarTheBestObjectiveValue);

        }



        public override void MoveParticlesToNewPositions()
        {
            double r2 = double.NaN;
            double r3 = double.NaN;
            double r4 = double.NaN;
            for (int j = 0; j < numberOfParticles; j++)
            {

              
                



                    for (int i = 0; i < numberOfVariables; i++)
                    {
                        r2 = 2 * Math.PI * randomizer.NextDouble();
                        r3 = 2 * randomizer.NextDouble();
                        r4 = randomizer.NextDouble();
                    if (r4 < 0.5)
                    {

                        Solutions[j][i] = Solutions[j][i] + r1 * Math.Sin(r2) * Math.Abs(r3 * soFarTheBestSolution[i] - Solutions[j][i]);

                        if (Solutions[j][i] > upperBounds[i]) Solutions[j][i] = upperBounds[i];
                        else if (Solutions[j][i] < lowerBounds[i]) Solutions[j][i] = lowerBounds[i];
                    }

                    else
                    {

                        Solutions[j][i] = Solutions[j][i] + r1 * Math.Cos(r2) * Math.Abs(r3 * soFarTheBestSolution[i] - Solutions[j][i]);

                        if (Solutions[j][i] > upperBounds[i]) Solutions[j][i] = upperBounds[i];
                        else if (Solutions[j][i] < lowerBounds[i]) Solutions[j][i] = lowerBounds[i];
                    }
                    }
                
            }
        }

        public override void UpdateForEachParticle() //i.e.update destinatiobn
        {
            double sumofsquare = 0.0;

            if (optimizationmode == OptimizationType.Maximization)
            {
                iterationAverage = 0;
                iterationBest = double.MinValue;
                for (int j = 0; j < numberOfParticles; j++)
                {

                    if (objfunction(Solutions[j]) > soFarTheBestObjectiveValue)
                    {
                        soFarTheBestObjectiveValue = objfunction(Solutions[j]);
                        Array.Copy(Solutions[j], soFarTheBestSolution, numberOfVariables);

                       

                    }
                    sumofsquare += (objfunction(Solutions[j]) * objfunction(Solutions[j]));
                    iterationAverage += objfunction(Solutions[j]);

                    if (iterationBest < objfunction(Solutions[j])) iterationBest = objfunction(Solutions[j]);
                }
                iterationAverage /= numberOfParticles;


                //Aim at maximizing SN Ratio
                snRatio = -10 * Math.Log10(1/sumofsquare/numberOfParticles );


            }

            else if (optimizationmode == OptimizationType.Minimization)
            {
                iterationAverage = 0;
                iterationBest = double.MaxValue;
                for (int j = 0; j < numberOfParticles; j++)
                {

                    if (objfunction(Solutions[j]) < soFarTheBestObjectiveValue)
                    {
                        soFarTheBestObjectiveValue = objfunction(Solutions[j]);
                        Array.Copy(Solutions[j], soFarTheBestSolution, numberOfVariables);



                    }
                    sumofsquare += (objfunction(Solutions[j]) * objfunction(Solutions[j]));
                    iterationAverage += objfunction(Solutions[j]);

                    if (iterationBest > objfunction(Solutions[j])) iterationBest = objfunction(Solutions[j]);
                }
                iterationAverage /= numberOfParticles;

                //Aim at maximizing SN Ratio
                //snRatio = -10 * Math.Log10(iterationAverage * iterationAverage / GetSampleStd(iterationAverage));
                snRatio = -10 * Math.Log10(sumofsquare /numberOfParticles);





            }


        }

        private double GetSampleStd(double mean)
        {
            double variance = 0.0;
            for(int i=0;i< numberOfParticles; i++) variance += ((objvaluesForEachAgents[i] - mean) * (objvaluesForEachAgents[i] - mean));
            double denominator = objvaluesForEachAgents.Length - 1;
            return denominator > 0.0 ? Math.Sqrt(variance / denominator) : -1;
        }


    }
}

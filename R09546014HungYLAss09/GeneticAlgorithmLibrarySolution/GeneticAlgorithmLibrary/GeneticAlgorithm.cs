using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithmLibrary
{
    public enum OptimizationType { Minimization, Maximization };
    public enum SelectionType { Deterministic, Stochastic, Hybrid };

    //tempary delegate
    public delegate double ObjectiveFunction<S>(S[] solution);


    public class GeneticAlgorithm<T> //T repr as a type
    {
        protected OptimizationType optimizationtype = OptimizationType.Minimization;
        protected SelectionType selecyiontype = SelectionType.Deterministic;


       
        protected Random randomizer = new Random();
        private T[][] chromosomes;
        private double[] objectiveValues;//目標函式值
        protected double[] fitnessValue;
        private T[] soFarTheBestSolution;
        private double soFarTheBestObjectiveValue;

        private Series average = new Series("Average");
        
        
        private Series itrBest = new Series("IterationBest");
        private Series sofarTheBest = new Series("SofarTHeBest");



        int iterationCount;





        private int populationSize = 100;
        protected double crossoverRate = 0.8;
        private int iterationlimit = 100;


        //gene-based  chromosone-based

        //gene-based:算出所有基因數目:number of chromosone * number of gene in a chromosone,亂數去選gene做mutate
        //chromosone-based:亂數去選要mutate的chromosone

        protected bool isGeneBasedMutation = false;

        protected bool isMinimization = true;
        private double mutationRate = 0.05;
        protected int numberOfGenes;//number of genes in a chromosome
        private int numberOfCrossoveredChildren;
        private int numberOfMutatedChildren;
        protected int[] indices;
        protected int[] mutatedPositions;



        protected T[][] selectedChromosomes; //暫存mutate、crossover、與population gene 中最好的obj value對應的chromosomes,最後再覆蓋原始population genes產生新世代
        protected double[] selectedObjectives;

        protected ObjectiveFunction<T> theObjectiveEvaluationMethod;


        public GeneticAlgorithm(int numberOfVariables, OptimizationType type, ObjectiveFunction<T> theMethod)
        {
            optimizationtype = type;
            numberOfGenes = numberOfVariables;

            //不會重新被reset
            soFarTheBestSolution = new T[numberOfGenes];

            theObjectiveEvaluationMethod = theMethod;
            mutatedPositions = new int[numberOfGenes];

        }

        public SelectionType SelectionMode { set; get; } = SelectionType.Deterministic;
        public int PopulationSize
        {
            //lambda operator
            get => populationSize;
            set
            {
                if (value >= 2)
                {
                    populationSize = value;
                }
            }
        }

        public double CrossoverRate
        {
            get => crossoverRate;

            set
            {
                if (value > 1.0)
                {
                    crossoverRate = 1.0;
                }
                else if (value > 0)
                    crossoverRate = value;
            }
        }

        protected int Iterationlimit
        {
            get => iterationlimit;
            set
            {
                if (value > 0)
                    iterationlimit = value;
            }
        }
        [Browsable(false)]
        public int IterationCount { get => iterationCount; }
        double iterationBestObjective, iterationAverageObjective;
        public double IterationBestObjective { get => iterationBestObjective; }
        public double IterationAverageObjective { get => iterationAverageObjective; }
        public T[] SoFarTheBestSolution { get => soFarTheBestSolution; set => soFarTheBestSolution = value; }
        public double SoFarTheBestObjectiveValue { get => soFarTheBestObjectiveValue; }
        public double MutationRate { get => mutationRate; set => mutationRate = value; }
        public double[] ObjectiveValues { get => objectiveValues;}
        public T[][] Chromosomes { get => chromosomes; set => chromosomes = value; }
        public int NumberOfCrossoveredChildren { get => numberOfCrossoveredChildren; set => numberOfCrossoveredChildren = value; }
        public int NumberOfMutatedChildren { get => numberOfMutatedChildren; set => numberOfMutatedChildren = value; }
        public Series Average { get => average; set => average = value; }
        public Series ItrBest { get => itrBest; set => itrBest = value; }
        public Series SofarTheBest { get => sofarTheBest; set => sofarTheBest = value; }


        #region Public Methods

        public bool Reset()
        {
            //allocate memory

            chromosomes = new T[populationSize * 3][];
            for (int i = 0; i < chromosomes.Length; i++)
            {
                chromosomes[i] = new T[numberOfGenes];
            }

            objectiveValues = new double[populationSize * 3];
            fitnessValue = new double[populationSize * 3];


            selectedChromosomes = new T[populationSize][];

            for (int i = 0; i < selectedChromosomes.Length; i++)
            {
                selectedChromosomes[i] = new T[numberOfGenes];
            }

            selectedObjectives = new double[populationSize];

            indices = new int[populationSize * 3];

            //randomly assign initial gene values
            initializePopulation();

            // compute objective value
            for (int r = 0; r < populationSize; r++)
            {
                //r-th chromosomes ojected value arrsign to objectiveValues[r]
                objectiveValues[r] = theObjectiveEvaluationMethod(chromosomes[r]);//suppose 解 n*n assignment job ，一條chromosome裡面有n*n個 gene，所以傳入byte[n*n] array。
            }
            

            if (optimizationtype == OptimizationType.Maximization)
            {
                soFarTheBestObjectiveValue = double.MinValue;

                for (int s = 0; s < populationSize; s++)
                {



                    if (objectiveValues[s] > soFarTheBestObjectiveValue)
                    {
                        soFarTheBestObjectiveValue = objectiveValues[s];
                        Array.Copy(chromosomes[s], soFarTheBestSolution, numberOfGenes);

                    }
                }
            }

            else if (optimizationtype == OptimizationType.Minimization)
            {
                soFarTheBestObjectiveValue = double.MaxValue;

                for (int s = 0; s < populationSize; s++)
                {



                    if (objectiveValues[s] < soFarTheBestObjectiveValue)
                    {
                        soFarTheBestObjectiveValue = objectiveValues[s];
                        Array.Copy(chromosomes[s], soFarTheBestSolution, numberOfGenes);

                    }
                }
            }
            //if (objectiveValues[s] > best)
            //{
            //    best = objectiveValues[s];
            //    Array.Copy(chromosomes[s], soFarTheBestSolution, numberOfGenes);

            //}
        
    




    //...剩餘的也要initialize
                iterationCount = 0;



        

            return true;
        }

        public virtual bool initializePopulation()
        {
            throw new NotImplementedException();
        }

        public bool RunOneIteration()
        {

            performCrossoverOperation();
            performMutationOperation();
            updateSoFarTheBestObjectiveAndSolution();

            performSelectionOperation();

            iterationCount += 1;


            return true;
        }

        private void updateSoFarTheBestObjectiveAndSolution()
        {
            iterationAverageObjective = 0.0;
            iterationBestObjective = optimizationtype == OptimizationType.Maximization ? double.MinValue : double.MaxValue;
            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            //check objectives,calculate average,iteration best
            for (int i = 0; i < limit; i++)
            {
                //加總iterationObjective
                iterationAverageObjective += objectiveValues[i];


                //找 iterationBestObjective

                if (optimizationtype == OptimizationType.Maximization)
                {//往大
                    if (iterationBestObjective < objectiveValues[i])
                    {
                        iterationBestObjective = objectiveValues[i];
                    }

                    //if new soFattheBestSolution happens
                    //gene-wise copy the chromosome value to soFartheBestSolution
                    if (soFarTheBestObjectiveValue < iterationBestObjective)
                    {
                        soFarTheBestObjectiveValue = iterationBestObjective;
                        for (int c = 0; c < numberOfGenes; c++)
                        {
                            soFarTheBestSolution[c] = chromosomes[i][c];
                        }
                    }
                }
                //if (optimizationtype == OptimizationType.Maximization)
                //{
                //    if (iterationBestObjective < objectiveValues[i])
                //    {
                //        iterationBestObjective = objectiveValues[i];


                //        //if new soFartheBestSolution happens
                //        //gene-wise copy the chromosome value to soFartheBestSolution

                //        for (int c = 0; c < numberOfGenes; c++)
                //        {
                //            soFarTheBestSolution[c] = chromosomes[i][c];
                //        }


                //    }
                //}

                if (optimizationtype == OptimizationType.Minimization)
                {//往小
                    if (iterationBestObjective > objectiveValues[i])
                    {
                        iterationBestObjective = objectiveValues[i];
                    }

                    //if new soFattheBestSolution happens
                    //gene-wise copy the chromosome value to soFartheBestSolution
                    if (soFarTheBestObjectiveValue > iterationBestObjective)
                    {
                        soFarTheBestObjectiveValue = iterationBestObjective;
                        for (int c = 0; c < numberOfGenes; c++)
                        {
                            soFarTheBestSolution[c] = chromosomes[i][c];
                        }
                    }
                }

                       
                        
                       
                    

            }

            //算 iterationAverageObjective
            iterationAverageObjective /= limit;

            


          
            
            //如果是deterministic:當世代最好的不會比上一代差 i.e.當世代最好的至少是上一代最好的
            //如果是stochastic:當世代最好值可能比sofarthebest差
            
        }

        private void performSelectionOperation() //先copy到selection 再覆蓋原本的population
        {

            //calculate fitness

            setFitnessFromObjectives();

            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            switch (SelectionMode)
            {
                case SelectionType.Deterministic://越大的排越前面
                    for (int i = 0; i < limit; i ++)
                        indices[i] = i;
                    Array.Sort(fitnessValue, indices, 0, limit);//依照fitness來排序indices(using quick sort)

                    Array.Reverse(indices, 0, limit);
                   
                    break;
                case SelectionType.Stochastic:
                    double fitnessTotal = 0;
                    for(int i = 0; i < limit; i++)
                    {
                        fitnessTotal += fitnessValue[i];
                    }
                    int s = 0;//for indicies arr


                    while (s < populationSize)
                    {

                        double randomselect = randomizer.Next((int)(fitnessTotal / 1));
                        fitnessTotal = 0;

                        for (int j = 0; j < limit; j++)
                        {
                            
                            fitnessTotal += fitnessValue[j];
                           
                            if(randomselect <= fitnessTotal)
                            {
                                indices[s] = j;
                                s += 1;

                                break;
                            }
                            
                           
                        }
                    }
                    //fitness value as the properties

                    break;
            }
            //gene-wised copy selected chromosomes to selected chromosomes
            for(int r = 0; r < populationSize; r++)
            {
                selectedObjectives[r] = objectiveValues[indices[r]];
                for (int c = 0; c < numberOfGenes; c++)
                    selectedChromosomes[r][c] = chromosomes[indices[r]][c];
            }

            //copy back to parent chromosomes for next generation

            for (int r = 0; r < populationSize; r++)
            {
                objectiveValues[r] = selectedObjectives[r];
                for (int c = 0; c < numberOfGenes; c++)
                    chromosomes[r][c] = selectedChromosomes[r][c];
            }
        }
        

        

        

        private void setFitnessFromObjectives()
        {//要自己回去處理,用小考的公式
            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            for (int i = 0; i < limit ; i++)
                fitnessValue[i] = objectiveValues[i];

            double objectiveValueMax = double.MinValue;
            double objectiveValueMin = double.MaxValue;

            double b;//minimum fitness
            double alpha = randomizer.Next(0,5)+1e-10; //傳回介於(0,5)的隨機浮點數
            for(int i = 0; i < limit; i++)
            {
                if(objectiveValueMin > objectiveValues[i]) objectiveValueMin = objectiveValues[i];

                if (objectiveValueMax < objectiveValues[i]) objectiveValueMax = objectiveValues[i];
                
            }

            if (alpha * (objectiveValueMax - objectiveValueMin) > 1e-5) b = alpha * (objectiveValueMax - objectiveValueMin);
            else { b = 1e-5; }

            for (int i = 0; i < limit; i++)
            {
                if(optimizationtype == OptimizationType.Maximization)                
                    fitnessValue[i] = b + objectiveValues[i] - objectiveValueMin;

                
                else
                    fitnessValue[i] = b + objectiveValueMax - objectiveValues[i];
               
            }





        }

        private void performMutationOperation()
        {
            ////Gene-based
            if (isGeneBasedMutation)

            {

                //preprocessing
                int pid = 0, cid = 0;
                int numberOfPositions = 0;
                //...
                MutateAChild(pid, cid,mutatedPositions,numberOfPositions);

            }

            else
            {

                //chromosome-based

                numberOfMutatedChildren = (int)(populationSize * mutationRate);
                if (numberOfMutatedChildren > populationSize) numberOfMutatedChildren = populationSize;

                ShuffleAnIntegerArray(indices, PopulationSize);

                int ChildIdx = populationSize + numberOfCrossoveredChildren;
                for (int i = 0; i < numberOfMutatedChildren; i++)
                {
                    MutateAChild(indices[i], ChildIdx);
                    objectiveValues[ChildIdx] = theObjectiveEvaluationMethod(chromosomes[ChildIdx]);
                    ChildIdx++;
                }
            }
        }
        
        //parentIdx:父親 geneLocation:哪幾個要突變 再寫進 childidx
        public virtual void MutateAChild(int pareantIdx, int childIdx,int[] geneLocation, int numberOfLocations)
        {
            
        }

        public virtual void MutateAChild(int pareantIdx, int childIdx)
        {

        }
        private void performCrossoverOperation()
        {
            ShuffleAnIntegerArray(indices, PopulationSize);
            numberOfCrossoveredChildren = (int)(populationSize * crossoverRate);

            //需成對出現 
            if (numberOfCrossoveredChildren % 2 == 1) numberOfCrossoveredChildren--;


            int child1IDx = populationSize;
            int child2IDx = populationSize + 1;



            for (int p = 0; p < numberOfCrossoveredChildren / 2; p++)
            {

                CrossoverApairOfChildren(indices[p], indices[p + 1], child1IDx, child2IDx);//此時indices[]已經洗牌過了
                objectiveValues[child1IDx] = theObjectiveEvaluationMethod(chromosomes[child1IDx]);
                objectiveValues[child2IDx] = theObjectiveEvaluationMethod(chromosomes[child2IDx]);
                child1IDx += 2;
                child2IDx += 2;



            }
        }

        public virtual void CrossoverApairOfChildren(int fartherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            throw new NotImplementedException();
        }

        bool RunToEnd()
        {
            return true;
        }
        #endregion

        private void ShuffleAnIntegerArray(int[] a, int len)
        {
            if (a.Length < len) throw new Exception("Length is not match!");
            for (int i = 0; i < len; i++) a[i] = i;
            for (int c = len - 1; c > 1; c--)
            {
                int pos = randomizer.Next(c + 1);
                int temp = a[c];
                a[c] = a[pos];
                a[pos] = temp;
            }
        }

    }
}

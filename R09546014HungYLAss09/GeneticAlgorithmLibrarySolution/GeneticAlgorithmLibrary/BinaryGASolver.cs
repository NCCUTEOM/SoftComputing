using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public class BinaryGASolver:GeneticAlgorithm<byte>
    {
        public enum CrossoverType { TwoPointCut,OnepointCut,}
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.TwoPointCut;    
    /// <summary>
    /// This is the constructor of creating a binary-coded GA solver
    /// </summary>
    /// <param name="numberOfVariables"> Number of variables in the Optimization problem</param>
    /// <param name="type">Optimizationt type maximization or minimization</param>
    /// <param name="theMethod">The objective function delegate</param>
        public BinaryGASolver(int numberOfVariables, OptimizationType type,ObjectiveFunction<byte> theMethod) 
            : base(numberOfVariables,type, theMethod)
        {
           

        }

        public override void CrossoverApairOfChildren(int fatherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            int cutPosition1 = randomizer.Next(numberOfGenes); //挑隨機一個間隔點切下去

            for (int i = 0; i < numberOfGenes; i++)
            {
              Chromosomes[child1Idx][i] =Chromosomes[fatherIdx][i];
               Chromosomes[child2Idx][i] =Chromosomes[motherIdx][i];

            }

            if (CrossoverOperator == CrossoverType.OnepointCut)
            {
                byte[] temp = new byte[numberOfGenes -cutPosition1];

              
                for(int i = cutPosition1; i < numberOfGenes ; i++)
                {
                    temp[i- cutPosition1] =Chromosomes[child2Idx][i];
                }
                for (int i = cutPosition1; i < numberOfGenes; i++)
                {
                   Chromosomes[child2Idx][i] =Chromosomes[child1Idx][i];
                }
                for (int i = cutPosition1; i < numberOfGenes; i++)
                {
                   Chromosomes[child1Idx][i] = temp[i- cutPosition1];
                }

            }

            else
            {
               
                int cutPosition2 = randomizer.Next(numberOfGenes); //從點切下去
                
                while(cutPosition1 == cutPosition2) cutPosition2 = randomizer.Next(numberOfGenes);

                if (cutPosition1 > cutPosition2)
                {
                    //swap without third variable
                    cutPosition1 = cutPosition1 + cutPosition2;      
                    cutPosition2 = cutPosition1 - cutPosition2;       
                    cutPosition1 = cutPosition1 - cutPosition2;
                }

                byte[] temp = new byte[cutPosition2 -cutPosition1];

                
                for (int i = cutPosition1; i < cutPosition2; i++)
                {
                    temp[i- cutPosition1] =Chromosomes[child2Idx][i];
                }
                for (int i = cutPosition1; i < cutPosition2;  i++)
                {
                   Chromosomes[child2Idx][i] =Chromosomes[child1Idx][i];
                }
                for (int i = cutPosition1; i < cutPosition2; i++)
                {
                   Chromosomes[child1Idx][i] = temp[i- cutPosition1];
                }


            }
        }


        public override void MutateAChild(int parentIdx, int childIdx, int[] geneLocation, int numberOfLocations)
        {
           for(int i =0;i< numberOfGenes; i++)
            {
               Chromosomes[childIdx][i] =Chromosomes[parentIdx][i];
            }

           for(int i = 0; i < numberOfLocations; i++)
            {
                if (Chromosomes[childIdx][geneLocation[i]] == 1)Chromosomes[childIdx][geneLocation[i]] = 0;
                else {Chromosomes[childIdx][geneLocation[i]] = 1; }
            }
        }
        public override bool initializePopulation()
        {
            for(int r = 0; r < PopulationSize; r++)
            {
                //for(int c = 0; c < numberOfGenes; c++) //一條chromosome裡有 n*n個 genes
                for (int c = 0; c < numberOfGenes; c++)

                {
                   Chromosomes[r][c] = (byte)randomizer.Next(2);
                }
            }
            return true;


        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public enum CrossoverType { PMX, OX, PositionbasedX,CX, OrderBasedX , SubtourExcahngeX } //待修改


    public enum Mutationtype { Swap, Inversion,Insertion,Displacemnt }
    public class PermutationGAsolver:GeneticAlgorithm<int>
    {

        int[] temp; //跟numberOfvariable有關
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.OX;
        public Mutationtype MutationOperator { set; get; } = Mutationtype.Swap;

        public PermutationGAsolver(int numberOfVariables, OptimizationType type, ObjectiveFunction<int> theMethod)
            : base(numberOfVariables, type, theMethod)
        {
            temp = new int[numberOfVariables];
        }

        public override bool initializePopulation()
        {
            for (int r = 0; r < PopulationSize; r++)
            {
                for (int c = 0; c < numberOfGenes; c++)
                {
                    Chromosomes[r][c] = c;
                }

                for (int c = numberOfGenes - 1; c > 1; c--)
                {
                    int pos = randomizer.Next(c + 1);
                    int temp = Chromosomes[r][c];
                    Chromosomes[r][c] = Chromosomes[r][pos];
                    Chromosomes[r][pos] = temp;
                }


                //for (int i = 0; i < len; i++) a[i] = i;
                //for (int c = len - 1; c > 1; c--)
                //{
                //    int pos = randomizer.Next(c + 1);
                //    int temp = a[c];
                //    a[c] = a[pos];
                //    a[pos] = temp;
                //}


            }
            return true;
        }

        public override void CrossoverApairOfChildren(int fartherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            int i1 = randomizer.Next(numberOfGenes);
            int i2 = randomizer.Next(numberOfGenes);


            while (i1 == i2)
            {
                i2 = randomizer.Next(numberOfGenes);
            }

            if (i1 > i2)
            {
                //swap without third variable
                i1 = i1 + i2;
                i2 = i1 - i2;
                i1 = i1 - i2;
            }



            //要自己補哦哦哦哦哦哦
            for (int i = 0; i < numberOfGenes; i++)
            {
                Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                Chromosomes[child2Idx][i] = Chromosomes[motherIdx][i];
            }
            switch (CrossoverOperator)
            {
                case CrossoverType.PMX:
                    int[] m = new int[numberOfGenes];//partial map

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        m[i] = -1;
                    }

                    for (int i = i1; i < i2; i++)
                    {
                        if (Chromosomes[fartherIdx][i] == Chromosomes[motherIdx][i]) continue; //no mapping

                        if (m[Chromosomes[fartherIdx][i]] == -1 && m[Chromosomes[fartherIdx][i]] == -1)
                        {
                            m[Chromosomes[fartherIdx][i]] = Chromosomes[motherIdx][i];
                            m[Chromosomes[motherIdx][i]] = Chromosomes[fartherIdx][i];
                        }

                        else if (m[Chromosomes[fartherIdx][i]] == -1)
                        {
                            //m[p1[i]] = m[p2[i]]; m[m[p2[i]]] = p1[i]; m[p2[i]] = -2
                            m[Chromosomes[fartherIdx][i]] = m[Chromosomes[motherIdx][i]];
                            m[m[Chromosomes[motherIdx][i]]] = Chromosomes[fartherIdx][i];
                            m[Chromosomes[motherIdx][i]] = -2;

                        }

                        else if (m[Chromosomes[motherIdx][i]] == -1)
                        {
                            //m[p2[i]] =m[p1[i]]; m[m[p1[i]]] =p2[i]; m[p1[i]] = -2
                            m[Chromosomes[motherIdx][i]] = m[Chromosomes[fartherIdx][i]];
                            m[m[Chromosomes[fartherIdx][i]]] = Chromosomes[motherIdx][i];
                            m[Chromosomes[fartherIdx][i]] = -2;



                        }

                        else
                        {

                            //m[m[p2[i]]] = m[p1[i]]; 
                            //m[m[p1[i]]] = m[p2[i]]
                            //m[p1[i]] = -3; m[p2[i]] =  -3

                            m[m[Chromosomes[motherIdx][i]]] = m[Chromosomes[fartherIdx][i]];
                            m[m[Chromosomes[fartherIdx][i]]] = m[Chromosomes[motherIdx][i]];
                            m[Chromosomes[fartherIdx][i]] = -3;
                            m[Chromosomes[motherIdx][i]] = -3;

                        }


                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i1 <= i && i < i2)
                        {
                            Chromosomes[child1Idx][i] = Chromosomes[motherIdx][i];
                            Chromosomes[child2Idx][i] = Chromosomes[fartherIdx][i];
                        }

                        else
                        {
                            if (m[Chromosomes[fartherIdx][i]] < 0) Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                            else
                                Chromosomes[child1Idx][i] = m[Chromosomes[fartherIdx][i]];

                            if (m[Chromosomes[motherIdx][i]] < 0) Chromosomes[child2Idx][i] = Chromosomes[motherIdx][i];
                            else
                                Chromosomes[child2Idx][i] = m[Chromosomes[motherIdx][i]];


                        }
                    }


                    break;
                case CrossoverType.OX:
                    //i1,i2 cut locations
                    //temp[] existing array,temp[i] => to record which number is already assigned in proto-child

                    //child1
                    for (int i = 0; i < numberOfGenes; i++) temp[i] = 0;

                    for (int i = i1; i < i2; i++)
                    {
                        Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                        temp[Chromosomes[fartherIdx][i]] = -1;
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i1 <= i && i < i2) continue;
                        else
                        {
                            int k = 0;
                            while (temp[Chromosomes[motherIdx][k]] == -1) k += 1;
                            Chromosomes[child1Idx][i] = Chromosomes[motherIdx][k];
                            temp[Chromosomes[motherIdx][k]] = -1;
                        }
                    }

                    //child2
                    for (int i = 0; i < numberOfGenes; i++) temp[i] = 0;

                    for (int i = i1; i < i2; i++)
                    {
                        Chromosomes[child2Idx][i] = Chromosomes[motherIdx][i];
                        temp[Chromosomes[motherIdx][i]] = -1;
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i1 <= i && i < i2) continue;
                        else
                        {
                            int k = 0;
                            while (temp[Chromosomes[fartherIdx][k]] == -1) k += 1;
                            Chromosomes[child2Idx][i] = Chromosomes[fartherIdx][k];
                            temp[Chromosomes[fartherIdx][k]] = -1;
                        }
                    }

                    break;

                case CrossoverType.PositionbasedX:
                    int numOfpos = randomizer.Next(numberOfGenes);

                    //child1
                    int numOfposchild1 = numOfpos;
                    for (int i = 0; i < numberOfGenes; i++) temp[i] = 0;
                    int pos;


                    while (numOfposchild1 != 0)
                    {
                        do
                        {
                            pos = randomizer.Next(numberOfGenes);
                        } while (temp[Chromosomes[fartherIdx][pos]] == -1);

                        Chromosomes[child1Idx][pos] = Chromosomes[fartherIdx][pos];
                        temp[Chromosomes[fartherIdx][pos]] = -1;
                        numOfposchild1 -= 1;

                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp[Chromosomes[motherIdx][i]] != -1) Chromosomes[child1Idx][i] = Chromosomes[motherIdx][i];

                    }

                    //child2
                    int numOfposchild2 = numOfpos;

                    for (int i = 0; i < numberOfGenes; i++) temp[i] = 0;

                    while (numOfposchild2 != 0)
                    {

                        do
                        {
                            pos = randomizer.Next(numberOfGenes);
                        } while (temp[Chromosomes[motherIdx][pos]] == -1);

                        Chromosomes[child2Idx][pos] = Chromosomes[motherIdx][pos];
                        temp[Chromosomes[motherIdx][pos]] = -1;
                        numOfposchild2 -= 1;

                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp[Chromosomes[fartherIdx][i]] != -1) Chromosomes[child2Idx][i] = Chromosomes[fartherIdx][i];

                    }

                    break;


                case CrossoverType.OrderBasedX:
                    pos = -1;

                    numOfpos = randomizer.Next(numberOfGenes);

                    for (int i = 0; i < numberOfGenes; i++) temp[i] = 0;



                    while (numOfpos != 0)
                    {
                        do
                        {
                            pos = randomizer.Next(numberOfGenes);
                        } while (temp[pos] == -1);
                    }

                    temp[pos] = Chromosomes[fartherIdx][pos];
                    numOfpos -= 1;

                    int incidence = 0;
                    for (int i = 0; i < numOfpos; i++)
                    {
                        if (temp[i] != -1)
                        {
                            int index = -1;
                            for (int s = 0; s < numberOfGenes; s++)
                            {
                                if (temp[s] != -1)
                                {
                                    index = findposition(temp[s], Chromosomes[fartherIdx], incidence);
                                    incidence += 1;
                                }
                            }
                            Chromosomes[child2Idx][i] = Chromosomes[motherIdx][index];

                        }
                        else
                        {
                            Chromosomes[child2Idx][i] = Chromosomes[fartherIdx][i];

                        }
                    }

                    incidence = 0;

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp[i] != -1)
                        {
                            int index = -1;
                            for (int s = 0; s < numberOfGenes; s++)
                            {
                                if (temp[s] != -1)
                                {
                                    index = findposition(temp[s], Chromosomes[motherIdx], incidence);
                                    incidence += 1;
                                }
                            }
                            Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][index];

                        }
                        else
                        {
                            Chromosomes[child1Idx][i] = Chromosomes[motherIdx][i];

                        }

                    }




                    break;

                case CrossoverType.CX:
                    //temp[] existing array,to record a cycle,temp[i]=>the next element for element i

                    for (int i = 0; i < numberOfGenes; i++) { temp[i] = -1; }

                    int start = Chromosomes[fartherIdx][0];//紀錄cycle1 的 搜尋起點


                    int j = 0;
                    temp[j] = Chromosomes[fartherIdx][j];
                    temp[temp[j]] = Chromosomes[fartherIdx][temp[j]];

                    if (temp[temp[j]] != start)
                    {
                        do
                        {
                            j = temp[temp[j]];
                            temp[j] = Chromosomes[fartherIdx][j];
                        }
                        while (temp[j] != start);
                    }

                    //child2
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp[i] != -1) Chromosomes[child2Idx][i] = Chromosomes[fartherIdx][i];
                        else { Chromosomes[child2Idx][i] = temp[i]; }
                    }

                    //child1
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp[i] != -1) Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                        else { Chromosomes[child1Idx][i] = Chromosomes[motherIdx][i]; }
                    }

                    break;

                case CrossoverType.SubtourExcahngeX:
                    int Length = 4;
                    if (SubtourExchange(fartherIdx, motherIdx, child1Idx, child2Idx, Length)) return;
                    else
                    {
                        Length -= 1;
                        SubtourExchange(fartherIdx, motherIdx, child1Idx, child2Idx, Length);
                    }

                    break;




                    //int Length = 4;
                    //List<int> Subtour1 = new List<int> { };
                    //List<int> Subtour2 = new List<int> { };

                        //for(int i = 0; i < numberOfGenes -Length; i++)
                        //{
                        //    Subtour1 = RefillingSubtour(i, Length,Chromosomes[fartherIdx]);

                        //    for(j = 0; j < numberOfGenes - Length; j++)
                        //    {
                        //        Subtour2 = RefillingSubtour(j, Length, Chromosomes[motherIdx]);

                        //        if (Subtour1.Equals( Subtour2))
                        //        {
                        //            int s = 0;

                        //            //child1
                        //            while (s < numberOfGenes)
                        //            {
                        //                if (s != i) {
                        //                    Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                        //                    s += 1;

                        //                }
                        //                else
                        //                {
                        //                    for(int t = 0; t < Length ; t++)
                        //                    {
                        //                        Chromosomes[child1Idx][i] = Subtour2[t];
                        //                        s += 1;

                        //                    }
                        //                }

                        //            }

                        //            //child2
                        //            s = 0;

                        //            while (s < numberOfGenes)
                        //            {
                        //                if (s != j)
                        //                {
                        //                    Chromosomes[child2Idx][i] = Chromosomes[motherIdx][i];
                        //                    s += 1;

                        //                }
                        //                else
                        //                {
                        //                    for (int t = 0; t < Length ; t++)
                        //                    {
                        //                        Chromosomes[child2Idx][i] = Subtour1[t];
                        //                        s += 1;

                        //                    }
                        //                }

                        //            }

                        //            return;
                        //        }

                        //    }
                        //}














                    }
        }

        private List<int> RefillingSubtour(int start, int length, int[] p1)
        {
            List<int> S = new List<int> { };
            for(int k = 0; k < length; k++)
            {
                S.Append(p1[start]);
            }
            return S;
        }


        private int findposition(int s, int[] p, int incidence)
        {
            int start = 0;
            for(int j = 0; j < p.Length; j++)
            {
                if (p[j] == s && start == incidence) return incidence;
                else
                {
                    start += 1;
                }
            }
            return -1;
        }

        private bool SubtourExchange(int fartherIdx, int motherIdx, int child1Idx, int child2Idx,int Length)
        {
            
            List<int> Subtour1 = new List<int> { };
            List<int> Subtour2 = new List<int> { };

            for (int i = 0; i < numberOfGenes - Length; i++)
            {
                Subtour1 = RefillingSubtour(i, Length, Chromosomes[fartherIdx]);

                for (int j = 0; j < numberOfGenes - Length; j++)
                {
                    Subtour2 = RefillingSubtour(j, Length, Chromosomes[motherIdx]);

                    if (Subtour1.Equals(Subtour2))
                    {
                        int s = 0;

                        //child1
                        while (s < numberOfGenes)
                        {
                            if (s != i)
                            {
                                Chromosomes[child1Idx][i] = Chromosomes[fartherIdx][i];
                                s += 1;

                            }
                            else
                            {
                                for (int t = 0; t < Length; t++)
                                {
                                    Chromosomes[child1Idx][i] = Subtour2[t];
                                    s += 1;

                                }
                            }

                        }

                        //child2
                        s = 0;

                        while (s < numberOfGenes)
                        {
                            if (s != j)
                            {
                                Chromosomes[child2Idx][i] = Chromosomes[motherIdx][i];
                                s += 1;

                            }
                            else
                            {
                                for (int t = 0; t < Length; t++)
                                {
                                    Chromosomes[child2Idx][i] = Subtour1[t];
                                    s += 1;

                                }
                            }

                        }

                        return true;//找到Subtour
                    }

                }
            }
            return false;//找不到Subtour
        }

        public override void MutateAChild(int parentIdx, int childIdx)
        {
            for (int i = 0; i < numberOfGenes; i++)
            {//gene-wised copy
                Chromosomes[childIdx][i] = Chromosomes[parentIdx][i];
            }

            switch (MutationOperator)
            {
                case Mutationtype.Swap:
                    int pos1 = randomizer.Next(numberOfGenes);
                    int pos2;
                    do 
                    { //確保index不同
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos2 == pos1);

                    int tmp = Chromosomes[childIdx][pos1];
                    Chromosomes[childIdx][pos1] = Chromosomes[childIdx][pos2];
                    Chromosomes[childIdx][pos2] = tmp;

                    break;

                case Mutationtype.Inversion:
                    pos1 = randomizer.Next(numberOfGenes);
                    
                    do
                    { //確保index不同
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos2 == pos1);

                    if (pos1 > pos2)
                    {
                        //swap without third variable
                        pos1 = pos1 + pos2;
                        pos2 = pos1 - pos2;
                        pos1 = pos1 - pos2;
                    }


                    int[] substring = new int[pos2 - pos1+1];
                    substring.Reverse();
                    for(int i = 0; i < numberOfGenes; i++)
                    {
                        if(i<pos1 || i>pos2) Chromosomes[childIdx][i] = Chromosomes[parentIdx][i];
                        else
                        {
                            for(int s = 0; s <pos2 - pos1 + 1;s+=1)
                            {
                                Chromosomes[childIdx][i+s] = substring[s];
                            }
                            i += pos2 - pos1 + 1;
                        }


                    }
                    break;

                case Mutationtype.Insertion:

                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);

                    int j = 0;
                    for(int i= 0; i < numberOfGenes; i++)
                    {

                        if (i != pos1)
                        {
                            Chromosomes[childIdx][i] = Chromosomes[parentIdx][j];
                            j += 1;
                        }
                        else
                        {
                            j += 2;
                            Chromosomes[childIdx][i] = Chromosomes[parentIdx][j];
                        }
                        if (j == pos2)
                        {
                            Chromosomes[childIdx][j] = Chromosomes[parentIdx][pos1];
                        }
                    }
                    break;

                case Mutationtype.Displacemnt:
                    pos1 = randomizer.Next(numberOfGenes);

                    do
                    { //確保index不同
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos2 == pos1);

                    int insertpos = randomizer.Next(numberOfGenes);
                    bool skipped = false;
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        Chromosomes[childIdx][i] = -1;
                        temp[i] = -1;
                        

                    }
                    
                    
                    
                    int start = pos2 - pos1;
                    while (start >= 0) { 
                        Chromosomes[childIdx][insertpos+start] = Chromosomes[parentIdx][pos1+start];
                        temp[pos1 + start] = 0;
                        start -= 1;
                    }

                    int k = 0;
                    for(int i = 0;i<numberOfGenes;i++)
                    {
                        if (Chromosomes[childIdx][i] == -1)
                        {
                            if (temp[k] != 0) {
                                Chromosomes[childIdx][i] = Chromosomes[parentIdx][i];
                                k+=1; }


                            else
                            {
                                k += pos2 - pos1 + 1;
                                Chromosomes[childIdx][i] = Chromosomes[parentIdx][i];
                                k += 1;

                            }
                        }
                    }
                    break;



           

                    


                        //if (i < insertpos && (i<pos1 || i>pos2 ))
                        //{
                        //    Chromosomes[childIdx][i] = Chromosomes[parentIdx][k];
                        //    k += 1;
                        //}
                        //else if(i < insertpos )
                        //{
                        //    if (i >= pos1 || i < pos2 && !skipped)
                        //    {
                        //        k += pos2 - pos1 + 1;
                        //        skipped = true;
                        //    }
                        //    Chromosomes[childIdx][i] = Chromosomes[parentIdx][k];

                        //    k += 1;


                        //}

                        //{
                        //    j += pos2 - pos1 + 1;
                        //    Chromosomes[childIdx][i] = Chromosomes[parentIdx][j];
                        //}
                        //if (j == pos2)
                        //{
                        //    Chromosomes[childIdx][j] = Chromosomes[parentIdx][pos1];
                        //}
                    }
                   















            }
        }

    }


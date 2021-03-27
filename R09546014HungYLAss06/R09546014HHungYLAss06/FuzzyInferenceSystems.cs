using Steema.TeeChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    [Category("Inferencing Parameter")]
    public enum DefuzzificationType { COA, BOA, /*MOM,*/ SOM, LOM }

    


    public interface IFuzzyInferencing
    {
        void Construct(DataGridView dgv);
        double CrispInCrispOutInferencing(double[] conditions);

        


        bool IsWeightedaverage { get; set; }

        
        

    }


    class MamdaniFuzzySystem : IFuzzyInferencing

        
    {


        

        //Mainform mainform = (Mainform)Application.OpenForms[1];

        IfThenFuzzyRule[] rules;

        

        //default Centroid
        DefuzzificationType defuzzification = DefuzzificationType.COA;

        [Category("Inferencing Parameter")]

        public bool IsCut { get; set; }





        public DefuzzificationType DefuzzificationType { get => defuzzification; set => defuzzification = value; }

        [Browsable(false)]
        public bool IsWeightedaverage { get; set; }

        public void Construct(DataGridView dgv)
        {
            rules = new IfThenFuzzyRule[dgv.Rows.Count];   //取得所有rules
            FuzzySet output = null;
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgv.Columns.Count - 1];

                for (int c = 0; c < dgv.Columns.Count - 1; c++)
                {
                    {
                        inputs[c] = (FuzzySet)dgv.Rows[r].Cells[c].Value;


                    }

                    if(!(dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value is FuzzySet)) { MessageBox.Show("Conclusion need to be a fuzzyset!"); return; }
                    output = (FuzzySet)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value;
                    rules[r] = new IfThenFuzzyRule(inputs, output);
                }

            }
        }



        public double CrispInCrispOutInferencing(double[] conditions)
        {
            
            FuzzySet resultFS = null;
            foreach (IfThenFuzzyRule ifr in rules)
            {
                if (resultFS == null)
                {
                    //resultFS = ifr.CrispInFuzzyOutInferencing(conditions, mainform.CheckBoxCut);
                    resultFS = ifr.CrispInFuzzyOutInferencing(conditions, IsCut);
                }

                else
                {

                    resultFS = resultFS | ifr.CrispInFuzzyOutInferencing(conditions, IsCut);
                }
                    //resultFS = resultFS | ifr.CrispInFuzzyOutInferencing(conditions);



            }

            DefuzzificationType = /*(DefuzzificationType)mainform.CbxMcripseValue;*/DefuzzificationType.COA;

            switch (defuzzification)
            {
                case DefuzzificationType.BOA:
                    return resultFS.BOACrispValue;


                case DefuzzificationType.COA:
                    

                    return resultFS.COACrispValue;

                //case DefuzzificationType.MOM:
                //    //return resultFS.MOMCrispValue;
                //    return 0.0;

                case DefuzzificationType.LOM:
                    return resultFS.LOMCrispValue;

                case DefuzzificationType.SOM:
                    return resultFS.SOMCrispValue;
            }

            return 0.0;



        }


    }

    class TsukamotoFuzzySystem : IFuzzyInferencing
    {
        IfThenFuzzyRule[] rules;
        //Mainform mainform = (Mainform)Application.OpenForms[0];

        //default Centroid
        DefuzzificationType defuzzification = DefuzzificationType.COA;

        [Category("Inferencing Parameter")]

        public bool IsWeightedaverage { get; set; } = false;

        public void Construct(DataGridView dgv)
        {
            rules = new IfThenFuzzyRule[dgv.Rows.Count];   //取得所有rules
            FuzzySet output = null;
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgv.Columns.Count - 1]; //最後一個是conclusion

                for (int c = 0; c < dgv.Columns.Count - 1; c++)
                {
                    {

                        inputs[c] = (FuzzySet)dgv.Rows[r].Cells[c].Value;


                    }

                    if (!(dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value is FuzzySet))
                    {
                        MessageBox.Show("Conclusion need to be an fuzzyset"); return;
                    }
                    if (((FuzzySet)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value).Monotonic == false)
                    {
                        MessageBox.Show("Plz select monotonic FuzzySet for concliusion");
                        return;
                    }


                    output = (FuzzySet)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value;
                    rules[r] = new IfThenFuzzyRule(inputs, output);
                }

            }
            
        }

        

        public double CrispInCrispOutInferencing(double[] conditions)
        {
            double resultZup = 0, resultZdown = 0;



            //FuzzySet resultFS = null;
            //foreach (IfThenFuzzyRule ifr in rules)
            //{
            //    if (resultFS == null)
            //        resultFS = ifr.CrispinCrispOutInferencing(conditions);



            //    else
            //        //把推理結果聯集
            //        resultFS = resultFS | ifr.CrispinCrispOutInferencing(conditions);



            //}

            foreach (IfThenFuzzyRule ifr in rules)
            {
                double Wvalue = ifr.CrispInCrispOutGetInferencingW(conditions);//find firing strength in Input universe

                Console.WriteLine($"Wvalue = { Wvalue}");
                //去output universe找intersection 所對應的 universe value

                double intersection = Wvalue;

                double deltaj = (ifr.Conclusion.TheUniverse.Maximum - ifr.Conclusion.TheUniverse.Minimum) / (ifr.Conclusion.TheUniverse.Resolution*100 - 1);

                double start = double.NaN;

                for (double j= ifr.Conclusion.TheUniverse.Minimum; j< ifr.Conclusion.TheUniverse.Maximum; j += deltaj)
                {

                    //Console.WriteLine($"FiringStrength = {intersection}, currentM(output) = {ifr.Conclusion.GetMembershipDegree(j)}");

                    if (Math.Abs(intersection - ifr.Conclusion.GetMembershipDegree(j))<0.0005)
                    {
                        start = j;
                        intersection = ifr.Conclusion.GetMembershipDegree(j);


                        while (start < ifr.Conclusion.TheUniverse.Maximum && ifr.Conclusion.GetMembershipDegree(start) == intersection)
                        {
                            start += deltaj; 
                            



                            double previous = ifr.Conclusion.GetMembershipDegree(start - deltaj);
                            double current = ifr.Conclusion.GetMembershipDegree(start);
                            double next = ifr.Conclusion.GetMembershipDegree(start + deltaj);



                            if (previous < current)
                            {
                                start = (start - 2 * deltaj + start) / 2;
                                break;
                            }
                            else if (current > next)
                            {
                                start = (start + start - deltaj) / 2;
                                break;
                            }
                            
                        }
                        break;
                    }

                   
                }
                //resultZup = resultZup + ifr.GetOutputValueZ(conditions) * ifr.CrispInCrispOutGetInferencingW(conditions);
                Console.WriteLine($"y = { start}");

                resultZup += start * Wvalue;

                resultZdown += Wvalue;
            }
            if (IsWeightedaverage)
            {
                return (resultZup / resultZdown);
            }
            else
            {
                return resultZup ;
            }





        }





    }
    class SugenoFuzzySystem : IFuzzyInferencing
    {
        SugenoIfThenRule[] rules;

        [Category("Inferencing Parameter")]
        public bool IsWeightedaverage { get; set; } = false;

        public void Construct(DataGridView dgv)
        {

            rules = new SugenoIfThenRule[dgv.Rows.Count];   //取得所有rules
            int output = 0;
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgv.Columns.Count - 1]; //最後一個是conclusion

                for (int c = 0; c < dgv.Columns.Count - 1; c++)
                {
                    {
                        inputs[c] = (FuzzySet)dgv.Rows[r].Cells[c].Value;
                        if(inputs[c] == null) { MessageBox.Show("Lack of input");return; }


                    }

                    if (!(dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value is int)) { MessageBox.Show("Conclusion need to be an equation"); return; }


                    output = (int)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Tag;
                    rules[r] = new SugenoIfThenRule(inputs, output);
                }

            }
        }


        public double CrispInCrispOutInferencing(double[] conditions)
        {
            double resultZup = 0, resultZdown = 0;



            foreach (SugenoIfThenRule sgr in rules)
            {
                resultZup = resultZup + sgr.GetOutputValueZ(conditions) * sgr.CrispInCrispOutGetInferencingW(conditions);

                resultZdown += sgr.CrispInCrispOutGetInferencingW(conditions);
            }

            //if (weightedSum < 0)
            //    weightedSum = sgr.CrispInFuzzyOutInferencing(conditions);

            //else
            //    //把推理結果聯集
            //    weightedSum = resultFS | ifr.CrispInFuzzyOutInferencing(conditions);

            if (IsWeightedaverage)
            {
                return (resultZup / resultZdown);
            }
            
            
            else
            {

                return resultZup;
            }

            }
            







        

    }
}
   


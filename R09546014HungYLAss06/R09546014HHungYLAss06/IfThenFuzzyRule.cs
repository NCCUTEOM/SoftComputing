using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class IfThenFuzzyRule
    {
        FuzzySet[] antecedents;
        FuzzySet conclusion;
        //for weighted average requirement
        public double FiringStrength { get; set; } = double.MaxValue;

        internal FuzzySet Conclusion { get => conclusion; set => conclusion = value; }

        public IfThenFuzzyRule(FuzzySet[] input, FuzzySet output)
        {
            antecedents = input;
            conclusion = output;



        }

        //Mandani
        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditions, bool isCut = true) //false: scale
        {
            //fault-proof
            if (antecedents.Length != conditions.Length) return null;

            //double fireValue = double.MaxValue;

            //loop through each antecedent
            for (int i = 0; i < antecedents.Length; i++)
            {
                FiringStrength = double.MaxValue;

                double maxDegree;
                if (antecedents[i].TheUniverse != conditions[i].TheUniverse)
                {
                    return null;
                }
                maxDegree = (antecedents[i] & conditions[i]).MaxDegree;
                if (maxDegree < FiringStrength) FiringStrength = maxDegree;
            }

            if (isCut)
                return FiringStrength - conclusion;
            else
                return FiringStrength * conclusion;


        }
        public double FuzzyInCrispOutTsuInferencing(FuzzySet[] conditions,bool isweighted)
        {
            if (!conclusion.Monotonic)
            {
                MessageBox.Show("Conclusion Fuzzy Set isn't monotonic!");
                return double.NaN;
            }
            if (antecedents.Length != conditions.Length) return double.NaN;

            //loop through each antecedent
            for (int i = 0; i < antecedents.Length; i++)
            {
                FiringStrength = double.MaxValue;

                double maxDegree;
                if (antecedents[i].TheUniverse != conditions[i].TheUniverse)
                {
                    return double.NaN;
                }


                maxDegree = antecedents[i].GetMembershipDegree((conditions[i].COACrispValue));
                if (maxDegree < FiringStrength) FiringStrength = maxDegree;
            }

            return conclusion.GetUniverseValueforADegree(FiringStrength,isweighted);

            
        }

        internal FuzzySet CrispInFuzzyOutInferencing(double[] conditions, bool isCut)
        {
            

            FiringStrength = double.MaxValue;
            ////fault-proof
            //if((antecedents.Length -1) != conditions.Length) return null;

            //loop through each antecedent
            for (int i = 0; i < antecedents.Length; i++)
            {

                
                if (FiringStrength > antecedents[i].GetMembershipDegree(conditions[i])) FiringStrength = antecedents[i].GetMembershipDegree(conditions[i]);

            }
            if (isCut)
                return FiringStrength - conclusion;
            else
                return FiringStrength * conclusion;

            
        }

        internal FuzzySet CrispinCrispOutInferencing(double[] conditions)
        {
            return null; 
        }


        
        public double CrispInCrispOutGetInferencingW(double[] conditions)
        {
            FiringStrength = double.MaxValue;
            for (int i = 0; i < antecedents.Length; i++)
            {
                double wvalue;
                wvalue = antecedents[i].GetMembershipDegree(conditions[i]);
                if (wvalue < FiringStrength) FiringStrength = wvalue;


            }
            return FiringStrength;
        }

        
    }
}

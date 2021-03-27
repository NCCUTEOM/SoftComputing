using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss05
{
    class IfThenFuzzyRule
    {
        FuzzySet[] antecedents;
        FuzzySet conclusion;

        public IfThenFuzzyRule(FuzzySet[] input,FuzzySet output)
        {
            antecedents = input;
            conclusion = output;


        }
        
        
        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditions,bool isCut = true) //false: scale
        {
            //fault-proof
            if (antecedents.Length != conditions.Length) return null;
            
            double fireValue = double.MaxValue;

            //loop through each antecedent
            for(int i =0;i< antecedents.Length; i++)
            {
                double maxDegree;
                if(antecedents[i].TheUniverse != conditions[i].TheUniverse)
                {
                    return null;
                }
                maxDegree = (antecedents[i] & conditions[i]).MaxDegree;
                if (maxDegree < fireValue) fireValue = maxDegree;
            }

            if (isCut) 
                return fireValue - conclusion;
            else 
                return fireValue *conclusion; 

            
        }
    }
}

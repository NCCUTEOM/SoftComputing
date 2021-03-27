using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss05
{
    class IfThenFuzzyRules
    {
        FuzzySet[] antecendents;
        FuzzySet conclusion;

        public IfThenFuzzyRules(FuzzySet[] input,FuzzySet output)
        {
            antecendents = input;
            conclusion = output;


        }
        
        
        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditions,bool isCut = true)
        {
            //fault-proof
            //
            double fireValue = double.MaxValue;
            //loop through each antecedent
            for(int i =0;i< antecendents.Length; i++)
            {
                double maxDegree;
                if(antecendents[i].TheUniverse != conditions[i].TheUniverse)
                {
                    return null;
                }
                maxDegree = (antecendents[i] & conditions[i]).MaxDegree;
                if (maxDegree < fireValue) fireValue = maxDegree;
            }

            if (isCut) return fireValue - conclusion;
            else { return fireValue *conclusion; }

            
        }
    }
}

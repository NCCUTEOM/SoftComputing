using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace R09546014HungYLAss06
{
    class SugenoIfThenRule
    
    {
        FuzzySet[] antecedents;
        int conclusion;
        public double FiringStrength { get; set; } = double.MaxValue;


        public SugenoIfThenRule(FuzzySet[] input,int output)
        {
            antecedents = input;
            conclusion = output;


        }

        
        public double CrispInCrispOutGetInferencingW(double[] conditions)
        {
            FiringStrength  = double.MaxValue;
            for(int i= 0; i < antecedents.Length; i++)
            {
                double wvalue;
                wvalue = antecedents[i].GetMembershipDegree(conditions[i]);
                if (wvalue < FiringStrength) FiringStrength = wvalue;

                
            }
            return FiringStrength;
        }
        
        public double[] FuzzyInCrispOutInferencing(FuzzySet[] conditions)
        {

            //fault-proof
            if (antecedents.Length != conditions.Length) return null;

            //double fireValue = double.MaxValue;
            double[] outputs = new double[this.antecedents.Length];

            //loop through each antecedent 
            for (int i = 0; i < antecedents.Length; i++)
            {

                double maxDegree;
                //if (antecedents[i].TheUniverse != conditions[i].TheUniverse)
                //{
                //    return null;
                //}
                //FuzzySet tmp = antecedents[i] & conditions[i];


                //maxDegree = tmp.MaxDegree;

                maxDegree = antecedents[i].GetMembershipDegree((conditions[i].COACrispValue));
                


                if (maxDegree < FiringStrength) FiringStrength = maxDegree;





                
                outputs.Append(conditions[i].COACrispValue);
                

                

                //double deltaX = (antecedents[i].TheUniverse.Maximum - antecedents[i].TheUniverse.Minimum) / antecedents[i].TheUniverse.Resolution;
                //for(double x = antecedents[i].TheUniverse.Minimum;x< antecedents[i].TheUniverse.Maximum; x += deltaX)
                //{
                //    double intersection = 0;
                //    if (tmp.GetMembershipDegree(x) >= fireValue)
                //    {
                //        intersection = x;
                //        outputs.Append(intersection);

                //        break;
                //    }

                //}

            }
                //outputs.Append(FiringStrength);
                

            


            // 紀錄每個(anticedantFs & condtionFs).Maxdegree的 x
            //[x1 x2 ... xn weight]
            return outputs;
            

        }

        public double GetOutputValueZ(double[] inputs)
        {

            switch (conclusion)
            {
                case 0: // Z = -X +Y+1
                    return (-inputs[0] + inputs[1] + 1);
                  
                case 1: // Z =-Y+3
                    return (-inputs[1] + 3);

                case 2://Z = -X +3
                    return (-inputs[0] + 3);
                case 3://Z = X+Y+2
                    return (inputs[0] + inputs[1] + 2);
                default:
                    return 0.0;

            }


        }
        

        internal FuzzySet CrispInFuzzyOutInferencing(double[] conditions, object isCut)
        {
            throw new NotImplementedException();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public class RealnumberGAsolver:GeneticAlgorithm<double>
    {
        double[] LowerBounds;
        double[] UpperBounds;
        public RealnumberGAsolver(int numberOfVariables, OptimizationType type,double lowerBounds,double[] upperBounds,ObjectiveFunction<double> theMethod)
            : base(numberOfVariables, type,theMethod)
        {

        }

    }
}

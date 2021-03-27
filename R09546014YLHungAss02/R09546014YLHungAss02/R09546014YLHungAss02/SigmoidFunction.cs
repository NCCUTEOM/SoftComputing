using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014YLHungAss02
{
    class SigmoidFunction
    {
        private double[] parameters; //[0]a [1]c
        static public string[] parameterNames = new string[2] { "a", "c" };

        public SigmoidFunction(double a, double c)
        {
            parameters = new double[2];
            parameters[0] = a;
            parameters[1] = c;
        }

        public double GetFunctionValue(double x)
        {
            double y = 1 / ( 1+ Math.Exp(-parameters[0]*(x- parameters[1])));
            return y;
        }
    }
}

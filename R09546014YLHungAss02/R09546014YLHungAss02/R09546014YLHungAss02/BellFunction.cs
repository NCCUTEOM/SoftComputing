using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014YLHungAss02
{
    class BellFunction
    {
        private double[] parameters; //[0]a [1]b [2]c
        static public string[] parameterNames = new string[3] { "a", "b", "c" };
        public BellFunction(double a, double b, double c)
        {
            parameters = new double[3];
            parameters[0] = a;
            parameters[1] = b;
            parameters[2] = c;
        }
        public double GetFunctionValue(double x)
        {
            return 1 / (1 + Math.Pow(Math.Abs((x - parameters[2]) / parameters[0]),2));
        }
    }
}

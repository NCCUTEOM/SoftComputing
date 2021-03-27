using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014YLHungAss02
{
    class GaussianFunction
    {
        private double[] parameters; //[0]center [1]std
        static public string[] parameterNames = new string[2] { "center", "std" };

        public GaussianFunction(double c, double std) {
            parameters = new double[2];
            parameters[0] = c;
            parameters[1] = std;
        }

         public double GetFunctionValue(double x)
        {
            double y = Math.Exp(-(Math.Pow(x - parameters[0],2) * 0.5 / Math.Pow(parameters[1],2.0)));
            return y;
        }

       
    }
}

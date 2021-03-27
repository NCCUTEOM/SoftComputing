using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014YLHungAss02
{
    class TriangleFunction
    {
        private double[] parameters; //[0]Left [1]Peak [2]Right
        static public string[] parameterNames = new string[3] { "left", "peak", "right" };
        public TriangleFunction(double left, double peak, double right)
        {
            parameters = new double[3];
            parameters[0] = left;
            parameters[1] = peak;
            parameters[2] = right;
        }
        public double GetFunctionValue(double x)
        {
            double y = 0;
            if (x <= parameters[0]) return y;

            else if (parameters[0] <= x && x <= parameters[1])
            {
                return (x - parameters[0]) / (parameters[1] - parameters[0]);
            }

            else if (parameters[1] <= x && x <= parameters[2])
            {
                return (parameters[2] - x) / (parameters[2] - parameters[1]);
            }
            else { return y; }

        }
    }
}

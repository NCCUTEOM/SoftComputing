using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss06
{
    class minusSigmoidFuzzySet : FuzzySet
    {
        static int count;
        double y;
        //public override double MaxDegree => 1.0;

        [Category("memberFunctionParameter"), Description("this parameter controls the width of the transition area"), DisplayName("控制函數變化率")]
        public double A
        {
            set
            {
                parameters[0] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[0];
            }
        }

        [Category("memberFunctionParameter"), Description("The location of the center of the transition area"), DisplayName("中心點")]
        public double Center
        {
            set
            {
                parameters[1] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[1];
            }
        }

        public override string Core => $"{theUniverse.Title}={parameters[1]}";

        public minusSigmoidFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = randomizer.NextDouble() * (u.Maximum - u.Minimum); ;
            parameters[1] = u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum);

            title = $"minusSigmoid FS{++count}";

        }

        public override double GetMembershipDegree(double x)
        {
            y = 1- 1 / (1 + Math.Exp(-parameters[0] * (x - parameters[1])));
            return y;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class SFuzzySet:FuzzySet
    {
        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute


        public override bool Monotonic { get; } = true;

        [Category("MemberFunctionParameter"), Description("basept")]


        public double basept
        {
            set
            {
                if (value < parameters[1])
                {
                    parameters[0] = value;
                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();

                }
                else
                {
                    MessageBox.Show("Set base left than right");
                }
            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("shoulder")]

        public double Shoulder
        {
            set
            {

                if (value > parameters[0])
                {
                    parameters[1] = value;

                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();

                }
                else
                {
                    MessageBox.Show("Set shoulder right left ");
                }

            }
            get
            { return parameters[1]; }
        }

        ////改寫父親的Core
        public override string Core => $"{theUniverse.Title} >= {parameters[0]}";


        public SFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = -2;
            parameters[1] = 2;

            

            title = $"S FS {++count}";




           
        }

       

        public override double GetMembershipDegree(double x)
        {
            if (x <= parameters[0]) { return 0; }
            else if (parameters[0] < x  && x <= (parameters[0] + parameters[1]) / 2)
            {
                return 2 * (x - parameters[0]) / (parameters[1] - parameters[0]) * (x - parameters[0]) / (parameters[1] - parameters[0]);
            }
            else if (((parameters[0] + parameters[1]) / 2) < x && x <= parameters[1])
            {
                return 1 - 2 * (parameters[1] - x) / (parameters[1] - parameters[0]) * (parameters[1] - x) / (parameters[1] - parameters[0]);
            }
            else { return 1; }
        }

    }
}



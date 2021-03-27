using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss04
{
    class ZFuzzySet:FuzzySet
    {
        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute

        [Category("MemberFunctionParameter"), Description("Left")]


        public double Left
        {
            set
            {
                if (parameters[0] < parameters[1])
                {
                    parameters[0] = value;
                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();
                }
                else
                {
                    MessageBox.Show("Set left less than right");
                }
            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("Right")]

        public double Right
        {
            set
            {

                if (parameters[1] > parameters[0])
                {
                    parameters[1] = value;

                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();
                }
                else
                {
                    MessageBox.Show("Set right more than left");
                }

            }
            get
            { return parameters[1]; }
        }

        ////改寫父親的Core
        public override string Core => $"{theUniverse.Title} <= {parameters[0]}";


        public ZFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = u.Minimum;
            parameters[1] = u.Maximum;



            title = $"Z FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {
            if (x <= parameters[0]) { return 1; }
            else if (parameters[0] < x  && x <= (parameters[0] + parameters[1]) / 2)
            {
                return 1- 2 * (x - parameters[0]) / (parameters[1] - parameters[0]) * (x - parameters[0]) / (parameters[1] - parameters[0]);
            }
            else if (((parameters[0] + parameters[1]) / 2) < x && x <= parameters[1])
            {
                return  2 * (parameters[1] - x) / (parameters[1] - parameters[0]) * (parameters[1] - x) / (parameters[1] - parameters[0]);
            }
            else { return 0; }
        }
    }
}

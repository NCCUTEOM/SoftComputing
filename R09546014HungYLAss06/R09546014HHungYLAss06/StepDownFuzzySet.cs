using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class StepDownFuzzySet : FuzzySet
    {

        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute

        public override bool Monotonic { get; } = true;


        [Category("MemberFunctionParameter"), System.ComponentModel.Description("")]


        public double shoulder
        {
            set
            {
                if (value > parameters[1])
                {
                    MessageBox.Show("Let shoulder on the left of basept");
                    return;
                }


                parameters[0] = value;
                //UpdateSeriesDataPoints();

                FireParameterChangedEvent();



            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("")]

        public double basept
        {
            set
            {

                if (value < parameters[0])
                {
                    MessageBox.Show("Let basept on the right of shoulder");
                    return;
                }
                
                parameters[1] = value;

                //UpdateSeriesDataPoints();

                FireParameterChangedEvent();



            }
            get
            { return parameters[1]; }
        }

        [Category("MemberFunctionParameter"), Description("center")]

        

        //改寫父親的Core


        public StepDownFuzzySet(Universe u) : base(u)
        {

            parameters = new double[2];
            parameters[0] = 4;
            parameters[1] = 6;


            title = $" StepDown FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {
            if (x <= parameters[0]) return 1;
            else if (parameters[0] <= x && x <= parameters[1]) return 1 - (x - parameters[0])/(parameters[1]-parameters[0]);/*x - 1/(parameters[1] - parameters[0])*(x-parameters[0]);*/
            else { return 0; }
        }

    }
}


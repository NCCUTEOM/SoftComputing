using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class StepUpFuzzySet : FuzzySet
    {

        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute
        public override bool Monotonic { get; } = true;

        [Category("MemberFunctionParameter"), System.ComponentModel.Description("")]


        public double basept { 
            set
            {
                if (value < parameters[1]) parameters[0] = value;
                else { 
                    MessageBox.Show("Let basept. on the left of the shoulder");
                    return;
                }

                //UpdateSeriesDataPoints();
                UpdateSeriesDataPoints();

                FireParameterChangedEvent();



            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("")]

        public double shoulder
        {
            set
            {

                if(parameters[0]<value) parameters[1] = value;
                else { MessageBox.Show("Let the shoulder on the left side of basept."); return; }


                //UpdateSeriesDataPoints();
                UpdateSeriesDataPoints();

                FireParameterChangedEvent();



            }
            get
            { return parameters[1]; }
        }

        [Category("MemberFunctionParameter"), Description("center")]



        //改寫父親的Core


        public StepUpFuzzySet(Universe u) : base(u)
        {

            parameters = new double[2];
            parameters[0] = 0;
            parameters[1] = 2;


            title = $" StepUp FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {
            if (x <= parameters[0]) return 0;
            else if (parameters[0] <= x && x <= parameters[1]) return 1/(parameters[1] - parameters[0])*(x-parameters[0]);
            else { return 1; }
        }

       

    }
}



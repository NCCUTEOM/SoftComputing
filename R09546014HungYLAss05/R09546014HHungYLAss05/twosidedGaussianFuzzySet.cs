using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss05
{
    class twosidedGaussianFuzzySet:FuzzySet
    {
        static int count = 0; //紀錄有幾個GaussianFuzzySet


            //properties
            //Attribute

            [Category("MemberFunctionParameter"), Description("")]


            public double LeftCenter
            {
                set
                {
                if (parameters[0] < parameters[2])
                {
                    parameters[0] = value;
                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();
                }
                else
                {
                    MessageBox.Show("Set left center <right center");
                }
                }
                get
                { return parameters[0]; }
            }

            [Category("MemberFunctionParameter"), Description("")]

            public double LeftSigma
            {
                set
                {

                    if (parameters[1] > 0)
                    {
                        parameters[1] = value;
                    //UpdateSeriesDataPoints();
                        FireParameterChangedEvent();
                    }
                    else
                    {
                        MessageBox.Show("Set sigma > 0");
                    }

                }
                get
                { return parameters[1]; }
            }
        [Category("MemberFunctionParameter"), Description("")]

        public double RightCenter
            {
                set
                {

                    if (parameters[2] > parameters[0])
                    {
                        parameters[2] = value;
                    //UpdateSeriesDataPoints();
                        FireParameterChangedEvent();
                    }
                    else
                    {
                        MessageBox.Show("Set Right center > Left center");
                    }

                }
                get
                { return parameters[2]; }
            }
        [Category("MemberFunctionParameter"), Description("")]

        public double RightSigma
            {
                set
                {

                    if (parameters[3] > 0)
                    {
                        parameters[3] = value;
                        //UpdateSeriesDataPoints();
                        FireParameterChangedEvent();

                   

                }
                    else
                    {
                    MessageBox.Show("Set sigma > 0 ");
                    }

                }
                get
                { return parameters[3]; }
            }

            //改寫父親的Core

            public override string Core => $"{theUniverse.Title} = {parameters[0]}";


            public twosidedGaussianFuzzySet(Universe u) : base(u)
            {

                parameters = new double[4];
                parameters[0] = (theUniverse.Maximum ) / 4;
                parameters[1] = randomizer.NextDouble() * 2 ;
                parameters[2] = (theUniverse.Maximum ) * 3/ 4;
                parameters[3] = randomizer.NextDouble() * 2;




            title = $"TwoSidedGaussian FS {++count}";





            }

            public override double GetMembershipDegree(double x)
            {
                double y;
                if (x <= parameters[0])
                {
                    y = Math.Exp(- (x-parameters[0])/parameters[1] * (x - parameters[0]) / parameters[1] / 2);
                return y;
                }
                else if( parameters[0] <x && x < parameters[1])
                {
                return 1;
                }
                else
                {
                    y = Math.Exp(-(x - parameters[2]) / parameters[3] * (x - parameters[2]) / parameters[3] / 2);
                return y;

                }
        }
        }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class twosidedPiFuzzySet : FuzzySet
    {
        static int count = 0; //紀錄有幾個GaussianFuzzySet


        //properties
        //Attribute

        [Category("MemberFunctionParameter"), Description("parameters")]


        public double A
        {
            set
            {
                
                parameters[0] = value;
                //UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("parameters")]

        public double B
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
                    MessageBox.Show("Follow the rule a < b < c < d");
                }

            }
            get
            { return parameters[1]; }
        }
        [Category("MemberFunctionParameter"), Description("parameters")]

        public double C
        {
            set
            {

                if (parameters[2] > parameters[1])
                {
                    parameters[2] = value;
                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();
                }
                else
                {
                    MessageBox.Show("Follow the rule a < b < c < d");
                }

            }
            get
            { return parameters[2]; }
        }
        [Category("MemberFunctionParameter"), Description("parameters")]

        public double D
        {
            set
            {

                if (parameters[3] > parameters[0])
                {
                    parameters[3] = value;
                    //UpdateSeriesDataPoints();
                    FireParameterChangedEvent();
                }
                else
                {
                    MessageBox.Show("Follow the rule a < b < c < d");
                }

            }
            get
            { return parameters[3]; }
        }

        //改寫父親的Core

        //public override string Core => $"{theUniverse.Title} = {parameters[0]}";


        public twosidedPiFuzzySet(Universe u) : base(u)
        {
           
            parameters = new double[4];
            parameters[0] = parameters[0] + 2.0;
            parameters[1] = parameters[0] + 2.0;
            parameters[2] = parameters[1] + 2.0;
            parameters[3] = parameters[2] + 2.0; ;




            title = $"TwoSidedPi FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {

            if (x <= parameters[0]) return 0;
            else if (parameters[0] < x && x < parameters[1])
            {
                if (parameters[0] < x && x <= (parameters[0] + parameters[1]) / 2)
                {
                    return 2 * (x - parameters[0]) / (parameters[1] - parameters[0]) * (x - parameters[0]) / (parameters[1] - parameters[0]);
                }
                else if (((parameters[0] + parameters[1]) / 2) < x && x <= parameters[1])
                {
                    return 1 - 2 * (parameters[1] - x) / (parameters[1] - parameters[0]) * (parameters[1] - x) / (parameters[1] - parameters[0]);
                }
                else { return 1; }
            }
            else if (parameters[1] <= x && x <= parameters[2]){ return 1; }



            else if (parameters[2] < x && x < parameters[3])
            {
                if (parameters[2] < x && x <= (parameters[2] + parameters[3]) / 2)
                {
                    return 1 - 2 * (x - parameters[2]) / (parameters[3] - parameters[2]) * (x - parameters[2]) / (parameters[3] - parameters[2]);
                }
                else if (((parameters[2] + parameters[3]) / 2) < x && x <= parameters[3])
                {
                    return 2 * (parameters[3] - x) / (parameters[3] - parameters[2]) * (parameters[3] - x) / (parameters[3] - parameters[2]);
                }
                else { return 0; }

            }
            else { return 0; }
        }


    }





}

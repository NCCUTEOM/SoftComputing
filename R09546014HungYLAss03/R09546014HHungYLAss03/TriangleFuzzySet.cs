using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HHungYLAss03
{
    class TriangleFuzzySet:Fuzzyset
    {

        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute

        [Category("MemberFunctionParameter"), System.ComponentModel.Description("left base point")]


        public double leftBP
        {
            set
            {
                if (value < parameters[1])
                {
                    parameters[0] = value;
                    UpdateSeriesDataPoints();
                }
                else
                {
                    MessageBox.Show("Please follow the rules:leftBP < Peak < rightBP");

                }

            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("peak")]

        public double Peak
        {
            set
            {
                if (value > parameters[0] && value < parameters[1])
                {


                    parameters[1] = value;

                    UpdateSeriesDataPoints();
                }
                else
                {
                    MessageBox.Show("Please follow the rules:leftBP < Peak < rightBP");
                }


            }
            get
            { return parameters[1]; }
        }

        [Category("MemberFunctionParameter"), Description("right base point")]

        public double rightBP
        {
            set
            {

                if (value > parameters[1])
                {
                    parameters[2] = value;

                    UpdateSeriesDataPoints();
                }
                else
                {
                    MessageBox.Show("Please follow the rules:leftBP < Peak < rightBP");
                }


            }
            get
            { return parameters[2]; }
        }

        //改寫父親的Core
        public override string Core => $"{theUniverse.Title} = {parameters[1]}";


        public TriangleFuzzySet(Universe u) : base(u)
        {

            parameters = new double[3];
            parameters[0] = randomizer.NextDouble() * (-10);
            parameters[1] = 0;
            parameters[2] = -parameters[0];


            title = $"Triangle FS {++count}";





        }

        public override double GetMembershipDegree(double x)
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

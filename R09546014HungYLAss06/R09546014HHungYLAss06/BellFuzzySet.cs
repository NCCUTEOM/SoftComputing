using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    class BellFuzzySet:FuzzySet
    {

        static int count = 0; //紀錄有幾個SFuzzySet


        //properties
        //Attribute

        [Category("MemberFunctionParameter"), System.ComponentModel.Description("width")]


        public double Width
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

        [Category("MemberFunctionParameter"), Description("the shape of the curve")]

        public double Shape
        {
            set
            {

                
                parameters[1] = value;

                //UpdateSeriesDataPoints();
                FireParameterChangedEvent();



            }
            get
            { return parameters[1]; }
        }

        [Category("MemberFunctionParameter"), Description("center")]

        public double center
        {
            set
            {


                parameters[2] = value;

                //UpdateSeriesDataPoints();
                FireParameterChangedEvent();



            }
            get
            { return parameters[2]; }
        }

        //改寫父親的Core
        public override string Core => $"{theUniverse.Title} = {parameters[2]}";


        public BellFuzzySet(Universe u) : base(u)
        {

            parameters = new double[3];
            parameters[0] = randomizer.NextDouble()*5;
            parameters[1] = randomizer.NextDouble();
            parameters[2] = (u.Maximum + u.Minimum) / 2;



            title = $"Bell FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {
            return 1 / (1 + Math.Pow(Math.Abs((x - parameters[2]) / parameters[0]),2*parameters[1]));
        }

    }
}


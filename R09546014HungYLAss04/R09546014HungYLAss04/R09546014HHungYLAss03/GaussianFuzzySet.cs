using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014HungYLAss04
{
    class GaussianFuzzySet : FuzzySet
    {
        static int count = 0; //紀錄有幾個GaussianFuzzySet


        //properties
        //Attribute

        [Category("MemberFunctionParameter"),Description("對稱點的位置")]


        public double Center
        {
            set
            {
                parameters[0] = value;
                FireParameterChangedEvent();
            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("Set std >0")]

        public double Std
        {
            set
            {

                if(parameters[1]>0)parameters[1] = value;
                //UpdateSeriesDataPoints();
                FireParameterChangedEvent();


            }
            get
            { return parameters[1]; }
        }

        //改寫父親的Core

        public override string Core => $"{theUniverse.Title} = {parameters[0]}";


        public GaussianFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = (u.Maximum +  u.Minimum) /2;
            parameters[1] = Math.Max(1, randomizer.NextDouble() * 20);

            

            title = $"Gaussian FS {++count}";




            
        }

            public override double GetMembershipDegree(double x)
            {
            return Math.Exp(- (x - parameters[0]) * (x - parameters[0]) / parameters[1] / parameters[1] /2.0 );
            }


    }




       
}
    
    


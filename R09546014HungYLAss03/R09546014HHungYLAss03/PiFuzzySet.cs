using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HHungYLAss03
{
    class PiFuzzySet:Fuzzyset
    {
        static int count = 0; //紀錄有幾個GaussianFuzzySet

        [Category("MemberFunctionParameter"), Description("Center")]


        public double Center
        {
            set
            {
                
                    parameters[0] = value;
                    UpdateSeriesDataPoints();
               
            }
            get
            { return parameters[0]; }
        }

        [Category("MemberFunctionParameter"), Description("lengthtobasepoint")]

        public double lengthtobasepoint
        {
            set
            {

                if (value > 0)
                {
                    parameters[1] = value;

                    UpdateSeriesDataPoints();
                }
                else
                {
                    MessageBox.Show("Please follow the rules:Length to basepoint > 0");

                }


            }
            get
            { return parameters[1]; }
        }

        ////改寫父親的Core
        [Browsable(false)]

        public override string Core => $"{theUniverse.Title} = {parameters[0]}";


        public PiFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = (u.Minimum+ u.Maximum) /2;
            parameters[1] = u.Maximum;



            title = $"Pi FS {++count}";





        }

        public override double GetMembershipDegree(double x)
        {
            double para0, para1;
            if (x <= parameters[0])
            {
                para0 = parameters[0] - parameters[1];
                para1 = parameters[0];


                if (x <= para0) { return 0; }
                else if (para0 < x && x <= (para0 + para1) / 2)
                {
                    return 2 * (x - para0) / (para1 - para0) * (x - para0) / (para1 - para0);
                }
                else if (((para0 + para1) / 2) < x && x <= para1)
                {
                    return 1 - 2 * (para1 - x) / (para1 - para0) * (para1 - x) / (para1 - para0);
                }
                else { return 1; }
            }
            else
            {
                para0 = parameters[0];
                para1 = parameters[0] + parameters[1];

                if (x <= para0) { return 1; }
                else if (para0 < x && x <= (para0 + para1) / 2)
                {
                    return 1 - 2 * (x - para0) / (para1 - para0) * (x - para0) / (para1 - para0);
                }
                else if (((para0 + para1) / 2) < x && x <= para1)
                {
                    return 2 * (para1 - x) / (para1 - para0) * (para1 - x) / (para1 - para0);
                }
                else { return 0; }
            }
        }
    }
}


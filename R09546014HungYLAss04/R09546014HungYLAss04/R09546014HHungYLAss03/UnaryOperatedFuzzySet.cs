using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss04
{
    class UnaryOperatedFuzzySet:FuzzySet
    {
        static int count = 0;
        UnaryFSOperator theOperator;
        FuzzySet theFS;
        public UnaryOperatedFuzzySet(FuzzySet fs,UnaryFSOperator op) : base(fs.TheUniverse)
        {
            theFS = fs;
            theOperator = op;
            title = op.Title + fs.Title + $"{count}";

            //subscribe events
            theFS.ParameterChanged += TheFS_ParameterChanged;
        }
        //假設FuzzSet的參數變更，需要做甚麼
        private void TheFS_ParameterChanged(object sender, EventArgs e)
        {
            if (ShowSeries)
            {

                //Fire event
                FireParameterChangedEvent();
            }
        }

        public override double GetMembershipDegree(double x)
        {
            double a = theFS.GetMembershipDegree(x);
            return theOperator.Evaluate(a);
        }
    }
}

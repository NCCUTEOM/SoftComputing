using R09546014HungYLAss04.R09546014HungYLAss04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss04
{
    class BinaryOperatedFuzzySet : FuzzySet
    {
       
            static int count = 0;
            BinaryFSOperator theOperator;
            FuzzySet theleftFS,therightFS;
            public BinaryOperatedFuzzySet(FuzzySet lfs, FuzzySet rfs,BinaryFSOperator op) : base(lfs.TheUniverse)
            {
                theleftFS = lfs;
                therightFS = rfs;
                theOperator = op;
                title = lfs.Title + ' ' + op.Title + ' ' + rfs.Title + ' ' + $"{count}";

                //subscribe events
                theleftFS.ParameterChanged += TheFS_ParameterChanged;
                therightFS.ParameterChanged += TheFS_ParameterChanged;
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

            double a = theleftFS.GetMembershipDegree(x);
            double b = therightFS.GetMembershipDegree(x);
            return theOperator.Evaluate(a, b);
        }
    }
}


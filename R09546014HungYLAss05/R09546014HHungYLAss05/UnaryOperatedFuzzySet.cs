using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss05
{
    class UnaryOperatedFuzzySet:FuzzySet
    {
        static int count = 0;
        UnaryFSOperator theOperator;
        FuzzySet theFS;


        [TypeConverter(typeof(ExpandableObjectConverter))]
        public UnaryFSOperator TheOperator { get => theOperator;}
        public FuzzySet TheBaseFS { get => theFS; set { theFS = value; } }

        public UnaryOperatedFuzzySet(FuzzySet fs,UnaryFSOperator op) : base(fs.TheUniverse)
        {
            theFS = fs;
            theOperator = op;
            title = op.Title + fs.Title + $"{count}";

            //subscribe events
            theFS.ParameterChanged += TheFS_ParameterChanged;//fuzzyset parameter變更
            TheOperator.ParameterChanged += TheFS_ParameterChanged;//operator parameter變更
        }

       

        //假設參數變更，需要做甚麼
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

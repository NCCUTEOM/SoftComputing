using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R09546014HungYLAss05
{
    namespace R09546014HungYLAss04
    {
        abstract class BinaryFSOperator

        {

            //properties
            public virtual string Title { get => ""; }

            //data
            protected double[] parameters;

            //events　
            public event EventHandler ParameterChanged;


            protected void FireParameterChangedEvent()
            {
                if (ParameterChanged != null) ParameterChanged(this, null);
            }

            public abstract double Evaluate(double a,double b);

        }
        class MinimumOperator : BinaryFSOperator
        {
            public MinimumOperator() { }

            public override string Title => "Minimum Intersect";
            public override double Evaluate(double a, double b)
            {
                if (a > b)
                    return b;
                else
                    return a;
            }
        }

        class IntersectionOperator : BinaryFSOperator
        {
            public override string Title => "Intersect";

            public IntersectionOperator()
            {
                
            }
            public override double Evaluate(double a,double b)
            {
                return a > b ? b : a;
            }

        }

        class UnionOperator : BinaryFSOperator
        {
            public override string Title => "Union";

            public UnionOperator()
            {

            }
            public override double Evaluate(double a, double b)
            {
                return a > b ? a : b;
            }
        }

        class TapOperator : BinaryFSOperator
        {
            public override string Title => "Algebraic product";

            public TapOperator()
            {

            }
            public override double Evaluate(double a, double b)
            {
                return a * b;
            }
        }

    }

}

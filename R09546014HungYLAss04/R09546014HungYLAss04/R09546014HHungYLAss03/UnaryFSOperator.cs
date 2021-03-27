using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss04
{
    abstract class UnaryFSOperator

    {
        
        //properties
        public virtual string Title { get => ""; }

        //data
        protected double[] parameters;

       
        //events　
        public event EventHandler ParameterChanged;

        public abstract double Evaluate(double a);

        protected void FireParameterChangedEvent()
        {
            if (ParameterChanged != null) ParameterChanged(this, null);
        }
        

    }
    class NegateOperator : UnaryFSOperator
    {
        public override string Title => "Not";
        public override double Evaluate(double a)
        {
            return 1.0 - a;
        }
    }

    class ValueCutOperator : UnaryFSOperator
    {
        public override string Title => "Cut";
       
        

        public ValueCutOperator()
        {
            parameters = new double[1];
            parameters[0] = 0.5;
        }
        public override double Evaluate(double a)
        {
            return a >= parameters[0] ? parameters[0]:a;
        }



        public double Cutvalues
        {
            get => parameters[0];
            set
            {
                if (value >= 0 && value <= 1.0)
                {
                    parameters[0] = value;
                    FireParameterChangedEvent();
                }
            }

        }
       

    }


    class ConcentrateOperator : UnaryFSOperator
    {
        public ConcentrateOperator() { }

        public override string Title => "Concentrate";
        public override double Evaluate(double a)
        {
            return a * a;
        }
    }
    class DilateOperator : UnaryFSOperator
    {
        public DilateOperator() { }
        public override string Title => "Dilate";
        public override double Evaluate(double a)
        {
            return Math.Sqrt(a);
        }
    }

    class IntensificateOperator : UnaryFSOperator
    {
        public IntensificateOperator() { }
        public override string Title => "Intensify";
        public override double Evaluate(double a)
        {
            if (a <= 0.5)
            {
                return 2 * a * a;
            }
            else
            {
                return -2 * (-a) * (-a);
            }
        }
    }

    class DiminishOperator : UnaryFSOperator
    {
        public DiminishOperator() { }

        public override string Title => "Diminish";
        public override double Evaluate(double a)
        {
            if (a <= 0.5)
            {
                return Math.Sqrt(a / 2);

            }
            else
            {
                return -Math.Sqrt(-a / 2);
            }
        }
    }
        class SugenoNegateOperator : UnaryFSOperator
        {
            public SugenoNegateOperator() {
                parameters = new double[1];
                parameters[0] = -0.2;

            }

            public double Curve
            {
                get => parameters[0];
                set
                {
                    if (value > -1)
                    {
                        parameters[0] = value;
                        FireParameterChangedEvent();
                    }
                }

            }

            public override string Title => "Not(Sugeno's)";
            
            public override double Evaluate(double a)
            {
                return (1-a)/(1 + parameters[0] *a);
            }
        }
    }


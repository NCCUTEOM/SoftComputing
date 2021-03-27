using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace R09546014HungYLAss06
{
    abstract class UnaryFSOperator

    {
        
        //properties
        public virtual string Title { get => ""; }

        public override string ToString()
        {
           
                return Title;
            
        }

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

    class ScaleOperator : UnaryFSOperator
    {
        public override string Title => "Scale";

        public ScaleOperator()
        {
            parameters = new double[1];
            parameters[0] = 0.8;
        }
        public override double Evaluate(double a)
        {
            //Console.WriteLine($"Scale value :{parameters[0]}");
            return parameters[0] * a;
        }

        public double Scalevalues
        {
            get => parameters[0];
            set
            {
                if (value >= 0 && value <= 1.0)
                {
                    //Console.WriteLine($"Scale value:{value}");
                    parameters[0] = value;
                    FireParameterChangedEvent();
                }
            }



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

            public double Convexity
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

    class YagerNegateOperator : UnaryFSOperator
    {
        public override string Title => "Not(Yager's)";



        public YagerNegateOperator()
        {
            parameters = new double[1];
            parameters[0] = 2;
        }
        public override double Evaluate(double a)
        {
            return Math.Pow((1 - Math.Pow(a, parameters[0])), 1 / parameters[0]);
        }


        [Description("Set concavity >0")]

        public double concavity
        {
            get => parameters[0];
            set
            {
                if (value > 0)
                {
                    parameters[0] = value;
                    FireParameterChangedEvent();
                }
            }

        }
    }
    }


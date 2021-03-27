using R09546014HungYLAss06.R09546014HungYLAss04;
using Steema.TeeChart.Functions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace R09546014HungYLAss06
{
    class FuzzySet
    {
        //operator overloaded
        public static FuzzySet operator !(FuzzySet fs)
        {
            UnaryFSOperator op = new NegateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator ~(FuzzySet fs)
        {
            UnaryFSOperator op = new DiminishOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }
        public static FuzzySet operator --(FuzzySet fs)
        {
            UnaryFSOperator op = new DilateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator +(FuzzySet fs)
        {
            UnaryFSOperator op = new ConcentrateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator -(double cutvalue, FuzzySet fs)
        {
            //子物件可以參與父類別的演出
            ValueCutOperator op = new ValueCutOperator();
            op.Cutvalues = cutvalue;
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator *(double scalevalue, FuzzySet fs)
        {
            ScaleOperator op = new ScaleOperator();
            op.Scalevalues = scalevalue;
            
            return new UnaryOperatedFuzzySet(fs, op);
        }


        //cut:uniary operator for C#

        public static FuzzySet operator -(FuzzySet fs)
        {
            UnaryFSOperator op = new ValueCutOperator();


            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator ++(FuzzySet fs)
        {
            UnaryFSOperator op = new IntensificateOperator();


            return new UnaryOperatedFuzzySet(fs, op);
        }
        public static FuzzySet operator +(double a, FuzzySet fs)
        {
            UnaryFSOperator op = new SugenoNegateOperator();


            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator /(double a, FuzzySet fs)
        {
            UnaryFSOperator op = new YagerNegateOperator();


            return new UnaryOperatedFuzzySet(fs, op);
        }





        //for intersection binary operator
        public static FuzzySet operator &(FuzzySet leftFs, FuzzySet rightFs)
        {
            BinaryFSOperator op = new IntersectionOperator();


            return new BinaryOperatedFuzzySet(leftFs, rightFs, op);
        }

        //for union binary operator


        public static FuzzySet operator |(FuzzySet leftFs, FuzzySet rightFs)
        {
            BinaryFSOperator op = new UnionOperator();


            return new BinaryOperatedFuzzySet(leftFs, rightFs, op);
        }

        public static FuzzySet operator ^(FuzzySet leftFs, FuzzySet rightFs)
        {
            BinaryFSOperator op = new MinimumOperator();


            return new BinaryOperatedFuzzySet(leftFs, rightFs, op);
        }

        public static FuzzySet operator +(FuzzySet leftFs, FuzzySet rightFs)
        {
            BinaryFSOperator op = new TapOperator();


            return new BinaryOperatedFuzzySet(leftFs, rightFs, op);
        }



        #region DataMembers
        protected double[] parameters;//protected 家族內可用
        protected string title;
        static protected Random randomizer = new Random();

        protected Universe theUniverse;
        private Series theSeries;
        public event EventHandler ParameterChanged;
        protected void FireParameterChangedEvent()
        {
            if (ParameterChanged != null) ParameterChanged(this, null);
        }

        #endregion
        public virtual void Savefile(StreamWriter sw)
        {
            sw.WriteLine($"FuzzySetType:{this.GetType().Name}");
            sw.WriteLine($"Originalhashcode:{this.GetHashCode()}");

            sw.WriteLine($"Title:{title}");
            sw.WriteLine($"NumberOfParameters:{parameters.Length}");
            int c = 0;
            foreach(double p in parameters)
            {
                sw.WriteLine($"Par{c}:{parameters[c++]}");
            }


        }

        public virtual void Readfile(StreamReader sr)
        {
            string[] items;

            //sw.WriteLine()($"FuzzySetType:{this.GetType().Name}");
            items = sr.ReadLine().Split(':');
            Title = items[1];

            //sw.WriteLine($"Originalhashcode:{this.GetHashCode()}");
            int num;
            items = sr.ReadLine().Split(':');
            num = Convert.ToInt32(items[1]);
            parameters = new double[num];
            for(int i = 0; i < num; i++)
            {
                items = sr.ReadLine().Split(':');
                parameters[i] = Convert.ToDouble(items[1]);
            }





            //sw.WriteLine($"Title:{title}");
            //sw.WriteLine($"NumberOfParameters:{parameters.Length}");
            //int c = 0;
            //foreach (double p in parameters)
            //{
            //    sw.WriteLine($"Par{c}:{parameters[c++]}");
            //}

        }
        [Category("MemberFunctionParameter"), Description("Crisp value")]

        public virtual double BOACrispValue{
            get{
                double area = 0;
                double areaHalf = 0;
                double BOA = 0;
                double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);


                for (double x = theUniverse.Minimum;x<=theUniverse.Maximum; x+= deltaX)
                {
                    area += GetMembershipDegree(x) * deltaX;
                }

                area /= 2;

                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                {

                    areaHalf += GetMembershipDegree(x) * deltaX;

                    if (areaHalf > area)
                    {
                        BOA = x;
                        break;
                    }
                }
                return BOA;
            }
        }

        [Category("MemberFunctionParameter"), Description("Crisp value")]

        public virtual double COACrispValue
        {
            get
            {
                double expectedValue = 0;
              
                double COA = 0;
                double totaldegree = 0;
                double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);


                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                {
                    expectedValue += GetMembershipDegree(x)*x * deltaX;
                }

                

                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                {

                    totaldegree += GetMembershipDegree(x)* deltaX;

                    
                }
                COA = expectedValue / totaldegree;
                return COA;
            }
        }

        //[Category("MemberFunctionParameter"), Description("Crisp value")]

        //public virtual double MOMCrispValue
        //{
        //    get
        //    {


        //        double[] lstOfmax = new double[theUniverse.Resolution];
                
        //        double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);


        //        for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
        //        {
        //            if (GetMembershipDegree(x) == MaxDegree)
        //            {
        //                lstOfmax.Append(x);
        //            }

        //        }



        //        return lstOfmax.Average();
        //    }
        //}

        [Category("MemberFunctionParameter"), Description("Crisp value")]

        public virtual double LOMCrispValue
        {
            get
            {

                double max = theUniverse.Maximum;
                double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);


                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                {
                    if (GetMembershipDegree(x) == MaxDegree)
                    {
                        max = x;
                        
                    }

                }

                return max;

            }
        }
        [Category("MemberFunctionParameter"), Description("Crisp value")]

        public virtual double SOMCrispValue
        {
            get
            {
                double min = theUniverse.Minimum;
                double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);


                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                {
                    if (GetMembershipDegree(x) == MaxDegree)
                    {
                        min = x;
                        break;
                    }

                }

                return min;



            }
        }


        public virtual double MaxDegree
        {
            get
            {
                double maxDegree = 0.0;
                if(theSeries == null)
                {
                    //traverse the range of universe to get the maximum degree

                    double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);

                    for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
                    {

                        double y = GetMembershipDegree(x);

                        if(y > maxDegree)
                        {
                            maxDegree = y;
                        }

                    }

                    
                }
                else
                {
                    //traverse each DataPoint of the series
                    for (int i = 0; i < theSeries.Points.Count; i++)
                    {
                        if (theSeries.Points[i].YValues[0] > maxDegree)
                            maxDegree = theSeries.Points[i].YValues[0];
                    }
                }
                return maxDegree;
            }
        }



        public Universe TheUniverse
        {
            get => theUniverse;
        }

        public override string ToString()
        {
            return title;
        }

        [Category("Property")]

        public string Title { get => title; set => title = value; }
        [Category("Property")]
        public virtual string Core { get => ""; }


        [Category("Visualization"), Description("")]

        public virtual bool Monotonic
        {
            get;
        } = false;
        public bool ShowSeries
        {
            set
            {
                
                if(value)
                {
                    if(theSeries == null)
                    {
                        theSeries = new Series(Title);

                                                
                        theSeries.ChartType = SeriesChartType.Line;

                       
                        UpdateSeriesDataPoints(); 

                        

                        // Add this series to chart via universe
                        theUniverse.AddASeriesOfFuzzySet(theSeries);
                        
                    }
                }
                else 
                {
                    if (theSeries != null)
                    {
                        theUniverse.RemoveSeriesOfFuzzySet(theSeries);
                        theSeries = null;
                    }
                    
                    


                }
            }

            get
            {
                return theSeries == null?false:true;
            }

        }

        public Series TheSeries { get => theSeries; }
        protected void UpdateSeriesDataPoints()
        {
            if (theSeries == null) return;
            theSeries.Points.Clear();
            double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);

            for(double x =theUniverse.Minimum;x<=theUniverse.Maximum;x += deltaX)
            {
                
                double y = GetMembershipDegree(x);
                theSeries.Points.AddXY(x, y);
            }
        }

        //support Tsukamoto Inferencing
        public virtual double GetUniverseValueforADegree(double degree,bool isweighted) {

            double resultZup = 0;
            double resultZdown = 0;
            double x = double.NaN;//no intersection

            //traverse universe value
            //double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);
            //for(double i = theUniverse.Minimum;i< theUniverse.Maximum;i+= deltaX)
            //{
            //    if (Math.Abs(GetMembershipDegree(i) - degree) < 0.001)
            //    {
            //        x = GetMembershipDegree(i);
            //        return GetMembershipDegree(i);
            //    }



            //    }
            //return x;

            double intersection = degree;

            double deltaj = (TheUniverse.Maximum - TheUniverse.Minimum) / (TheUniverse.Resolution * 100 - 1);

            double start = double.NaN;

            for (double j =TheUniverse.Minimum; j < TheUniverse.Maximum; j += deltaj)
            {

                //Console.WriteLine($"FiringStrength = {intersection}, currentM(output) = {ifr.Conclusion.GetMembershipDegree(j)}");

                if (Math.Abs(intersection - GetMembershipDegree(j)) < 0.0005)
                {
                    start = j;
                    intersection = GetMembershipDegree(j);


                    while (start < TheUniverse.Maximum && GetMembershipDegree(start) == intersection)
                    {
                        start += deltaj;




                        double previous = GetMembershipDegree(start - deltaj);
                        double current = GetMembershipDegree(start);
                        double next = GetMembershipDegree(start + deltaj);



                        if (previous < current)
                        {
                            start = (start - 2 * deltaj + start) / 2;
                            break;
                        }
                        else if (current > next)
                        {
                            start = (start + start - deltaj) / 2;
                            break;
                        }

                    }
                    break;
                }


            }
            //resultZup = resultZup + ifr.GetOutputValueZ(conditions) * ifr.CrispInCrispOutGetInferencingW(conditions);
            Console.WriteLine($"y = { start}");

            resultZup += start * degree;

            resultZdown += degree;

            if(isweighted)
            {
                return resultZup / resultZdown;
            }
            else
            {
                return resultZup;
            }


        }


        



        protected void UpdateBinarySeriesDataPoints()
        {
            if (theSeries == null) return;
            theSeries.Points.Clear();
            double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);
            for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x += deltaX)
            {

                double y = GetMembershipDegree(x);
                theSeries.Points.AddXY(x, y);
            }
        }



        public virtual double GetMembershipDegree(double x)
            
        {
            throw new NotFiniteNumberException();

        }

        //public virtual double GetMembershipDegree(double x,double y)

        //{
        //    throw new NotFiniteNumberException();
        //}




        public FuzzySet(Universe u)
        {
            theUniverse = u;
            //subscribe ParameterChanged Event
            u.Parameterchanged += Universe_Parameterchanged;
            this.ParameterChanged += Universe_Parameterchanged;

            //u.Parameterchanged += FuzzySet_Parameterchanged;

        }
        private void Universe_Parameterchanged(object sender, EventArgs e)
        {
                if (ShowSeries) UpdateSeriesDataPoints();
        }

        




        public Series getseries()
        {
            return this.theSeries;
        }

        
    }
    }


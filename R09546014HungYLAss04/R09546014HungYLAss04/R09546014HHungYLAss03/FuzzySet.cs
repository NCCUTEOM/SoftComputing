using R09546014HungYLAss04.R09546014HungYLAss04;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014HungYLAss04
{
    class FuzzySet
    {
        //operator overloaded
        public static FuzzySet operator!(FuzzySet fs)
        {
            UnaryFSOperator op = new NegateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator -(FuzzySet fs)
        {
            UnaryFSOperator op = new ValueCutOperator();
          
            
            return new UnaryOperatedFuzzySet(fs, op);
        }

        


        //for intersection binary operator
        public static FuzzySet operator*(FuzzySet leftFs,FuzzySet rightFs)
        {
            BinaryFSOperator op = new IntersectionOperator();

            
            return new BinaryOperatedFuzzySet(leftFs, rightFs, op);
        }

        #region DataMembers
        protected double[] parameters;//protected 家族內可用
        protected string title;
        static protected Random randomizer = new Random();

        protected Universe theUniverse;
        protected Series theSeries;
        public event EventHandler ParameterChanged;
        protected void FireParameterChangedEvent()
        {
            if (ParameterChanged != null) ParameterChanged(this, null);
        }

        #endregion

        [Browsable(false)]

        public Universe TheUniverse
        {
            get => theUniverse;
        }



        [Category("Property")]

        public string Title { get => title; set => title = value; }
        [Category("Property")]
        public virtual string Core { get => ""; }


        [Category("Visualization"), Description("")]

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

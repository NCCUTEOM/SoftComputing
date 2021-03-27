using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R09546014HHungYLAss03
{
    class Fuzzyset
    {
        protected double[] parameters;//protected 家族內可用
        protected string title;
        static protected Random randomizer = new Random();

        protected Universe theUniverse;
        protected Series theSeries;





        [Category("Property")]

        public string Title { get => title; set => title = value; }
        [Category("Property")]
        public virtual string Core { get => ""; }



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
                    if (theSeries != null) theSeries = null;
                    
                    


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

        public virtual double GetMembershipDegree(double x)
            
        {
            throw new NotFiniteNumberException();
        }

        


        public Fuzzyset(Universe u)
        {
            theUniverse = u;
            //subscribe ParameterChanged Event
            u.Parameterchanged += U_Parameterchanged;

        }
        private void U_Parameterchanged(object sender, EventArgs e)
        {
                if (ShowSeries) UpdateSeriesDataPoints();
        }




        public Series getseries()
        {
            return this.theSeries;
        }


    }
}

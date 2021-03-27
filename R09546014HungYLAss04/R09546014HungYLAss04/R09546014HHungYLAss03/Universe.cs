using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.ComponentModel;

namespace R09546014HungYLAss04
{
    class Universe
    {
        public static int count = 0; //紀錄有幾個Universe
        //data
        //double minimum = -10.0;
        //double maximum = 10.0;

        
        int resolution = 100;//要畫幾個點
        //string title;
        ChartArea theArea = new ChartArea();
        Chart theChart;
        //public void SetTitle(string s)
        //{
        //    title = s;
        //}

        //public string GetTitle()
        //{
        //    return title;
        //}
        //event 
        public event EventHandler Parameterchanged;
        //propetry

        [Category("UniverseParameter"), System.ComponentModel.Description("")]

        public string Title
        {
            get 
            {
                return theArea.AxisX.Title;
            }
            set 
            {
                theArea.AxisX.Title = value; //check validity if value
            } 
        }

        [Category("UniverseParameter"), System.ComponentModel.Description("最小值")]

        public double Minimum { 
            get => theArea.AxisX.Minimum;
            set
            {
                if (value < theArea.AxisX.Maximum)
                {
                    theArea.AxisX.Minimum = value;

                    if (Parameterchanged != null)
                    {
                        Parameterchanged(this, null);

                    }

                }
            }
        }

        //internal void ShowSeriesOfFuzzySet(Series aSeries)
        //{
        //    theChart.Series[aSeries.Name].Enabled = true;
        //}

        internal void HideASeriesOfFuzzySet(Series aSeries)
        {
            ////register the series to the chartarea,透過Name綁定此Series要畫到哪個ChartArea上頭
            //aSeries.ChartArea = theArea.Name;

            //Hide the series from Chart
            theChart.Series[aSeries.Name].Enabled = false;
            aSeries = null;
        }

        [Category("UniverseParameter"), System.ComponentModel.Description("最大值")]

        public double Maximum
        {
            get => theArea.AxisX.Maximum;
            set
            {
                if (value > theArea.AxisX.Minimum)
                {
                    theArea.AxisX.Maximum = value;

                }
                if (Parameterchanged != null)
                {
                    Parameterchanged(this, null);
                }

            }
        }

        public void AddASeriesOfFuzzySet(Series aSeries)
        {
            //register the series to the chartarea,透過Name綁定此Series要畫到哪個ChartArea上頭
            aSeries.ChartArea = theArea.Name;

            //// Assign the legend to Series1.
            //aSeries.Legend = theArea.Name;
            //aSeries.IsVisibleInLegend = true;

            //add the series to Chart.Series
            theChart.Series.Add(aSeries);
            aSeries.Legend = theArea.Name;
            
            

            

            

        }

        public void RemoveSeriesOfFuzzySet(Series aSeries)
        {
            theChart.Series.Remove(aSeries);

        }






        [Category("Visualization"),Description("Resolution must equal or greater than 50")]
        public int Resolution
        {
            get => resolution;
            set
            {
                if (value >= 50) { resolution = value; }

                if (Parameterchanged != null)
                {
                    Parameterchanged(this, null);
                }
            }

    }



        //constructor
        public Universe(Chart theMainChart)
        {
            string s  = $"Universe{++count}"; //列印之前先++
            theArea = new ChartArea(s);

            theArea.AxisX.Title = s;
            theArea.AxisY.Title = "Membership Degree";
            theArea.AxisX.Enabled = AxisEnabled.True;
            theArea.AxisY.Enabled = AxisEnabled.True;

            theArea.AxisX.Minimum = -10;
            theArea.AxisX.Maximum = 10;
            theArea.AxisY.Minimum = 0;
            theChart = theMainChart;
            //try
            //{
            //    theChart.Legends.Add(new Legend($"Legend{count}"));
            //}
            //catch (System.ArgumentException)
            //{

            //}
            //theChart.Legends[$"Legend{count}"].DockedToChartArea = "true";
            
            theChart.Legends.Add(new Legend(theArea.Name));



            theChart.ChartAreas.Add(theArea);
            theChart.Legends[theArea.Name].DockedToChartArea = theArea.Name;
            theChart.Legends[theArea.Name].IsDockedInsideChartArea = false;


        }

    }
}

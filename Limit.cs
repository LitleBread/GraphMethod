using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphMethod
{
    public class Limit
    {
        public enum SignEnum { Equals, More, Less}
        public double A1 { get; set; }
        public double A2 { get; set; }
        public double B { get; set; }
        public SignEnum Sign { get; set; }
        public Chart Chart { get; set; }
        public Series Series { get; set; }

        public Limit(Chart chart, double a1, double a2, double b, SignEnum sign)
        {
            Chart = chart;
            A1 = a1;
            A2 = a2;
            B = b;
            Sign = sign;

            CreateSeries();
            Draw();
        }

        private Limit(double a1, double a2, double b, SignEnum sign)
        {
            A1 = a1;
            A2 = a2;
            B = b;
            Sign = sign;
        }

        public void CreateSeries()
        {
            Series = new Series();
            Chart.Series.Add(Series);
            Series.BorderWidth = 5;

            Series.Color = Color.Red;
            Series.ChartType = SeriesChartType.Line;
        }

        public void Draw()
        {
            double minX1 = Chart.ChartAreas[0].AxisX.Minimum;
            double maxX1 = Chart.ChartAreas[0].AxisX.Maximum;
            double minX2 = Chart.ChartAreas[0].AxisY.Minimum;
            double maxX2 = Chart.ChartAreas[0].AxisY.Maximum;

            List<Limit> areaLimits = new List<Limit>() {
                new Limit(1, 0, minX1, SignEnum.Equals),
                new Limit(1, 0, maxX1, SignEnum.Equals),
                new Limit(0, 1, minX2, SignEnum.Equals),
                new Limit(0, 1, maxX2, SignEnum.Equals)
            };

            List<Point> points = new List<Point>();
            foreach(Limit l in areaLimits)
            {
                Point p = Math.Cramer(l, this);
                if (p != null)
                {
                    points.Add(p);
                }
                
            }

            points.Sort((p1,p2)=>)



        }
    }
}

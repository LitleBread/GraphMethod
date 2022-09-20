using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Shapes;
using System.Drawing;

namespace TestChart
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            chart.ChartAreas.Add(new ChartArea("Default"));

            // Добавим линию, и назначим ее в ранее созданную область "Default"
            chart.Series.Add(new Series("Series1"));
            chart.Series["Series1"].ChartArea = "Default";
            chart.Series["Series1"].BorderWidth = 5;

            chart.Series["Series1"].Color = Color.Red;
            chart.Series["Series1"].ChartType = SeriesChartType.Line;

            // добавим данные линии
            double[] axisXData = new double[] { 0, 20};
            double[] axisYData = new double[] { 10, 10};
            chart.Series["Series1"].Points.DataBindXY(axisXData, axisYData);


            chart.Series.Add(new Series("Series2"));
            chart.Series["Series2"].ChartArea = "Default";
            chart.Series["Series2"].BorderWidth = 5;

            chart.Series["Series2"].Color = Color.Green;
            chart.Series["Series2"].ChartType = SeriesChartType.Line;

            // добавим данные линии
            double[] axisXData2 = new double[] { 0, 20 };
            double[] axisYData2 = new double[] { -20, 20 };
            chart.Series["Series2"].Points.DataBindXY(axisXData2, axisYData2);

        }
    }
}

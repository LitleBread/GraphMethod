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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using GraphMethod;

namespace GraphicalMethod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChartArea chartArea = new ChartArea("Default");
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.Minimum = -10;
            chartArea.AxisX.Maximum = 10;
            chartArea.AxisY.Minimum = -10;
            chartArea.AxisY.Maximum = 10;

            Limit limit = new Limit(chart, 1, 1, 1, Limit.SignEnum.Less);
        }
    }
}

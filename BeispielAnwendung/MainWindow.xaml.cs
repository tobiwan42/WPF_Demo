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
using OxyPlot.Series;

namespace BeispielAnwendung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            viewModel = new MainViewModel();
            DataContext = viewModel;

            InitializeComponent();
        }

        void ListViewClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(DataList.SelectedItem.ToString());
            ItemsSeries graph = null;
            Function selectedFunction = (Function) DataList.SelectedIndex;

            switch (selectedFunction)
            {
                case Function.Sin:
                    graph = new FunctionSeries(Math.Sin, -5, 5, 0.1, "sin(x)");
                    break;
                case Function.Cos:
                    graph = new FunctionSeries(Math.Cos, -5, 5, 0.1, "cos(x)");
                    break;
                case Function.Tan:
                    graph = new FunctionSeries(Math.Tan, -5, 5, 0.1, "tan(x)");
                    break;
            }

            viewModel.SetGraph(graph);
        }
    }

    enum Function
    {
        Sin,
        Cos,
        Tan
    }
}

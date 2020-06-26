namespace BeispielAnwendung
{
    using System;
    using System.Windows.Media.Animation;
    using OxyPlot;
    using OxyPlot.Series;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            ItemsSeries sinus = new FunctionSeries(Math.Cos, -5, 5, 0.1, "cos(x)");
            ItemsSeries cosinus = new FunctionSeries(Math.Sin, -5, 5, 0.1, "sin(x)");
            this.MyModel.Series.Add(sinus);
            this.MyModel.Series.Add(cosinus);
            //this.MyModel.Series.Clear();
        }

        public void SetGraph(ItemsSeries series)
        {
            this.MyModel.Series.Clear();
            this.MyModel.Series.Add(series);
            this.MyModel.InvalidatePlot(true);
        }

        public PlotModel MyModel { get; private set; }
    }
}


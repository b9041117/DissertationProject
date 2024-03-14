using Avalonia.Controls;
using ScottPlot.Avalonia;
using F_Library;

namespace DevelopmentProject.Views.Graphs_Views
{
    public partial class RiverSpeedGraphView : UserControl
    {
        public RiverSpeedGraphView()
        {
            InitializeComponent();
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };


            AvaPlot avaPlot1 = this.Find<AvaPlot>("RSPlot");
            avaPlot1.Plot.Add.Scatter(dataX, dataY);
            avaPlot1.Refresh();

            for (int i = 0; i < dataX.Length; i++)
            {
                dataX[i] = f.math((int)dataX[i]);
            }

            avaPlot1.Refresh();
        }

    }
}

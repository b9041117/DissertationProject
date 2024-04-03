using Avalonia.Controls;
using ScottPlot.Avalonia;
using F_Library;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            UpdateGraphWithDerivValues(avaPlot1, dataX, dataY);
        }

        public void UpdateGraphWithDerivValues(AvaPlot avaPlotToUpdate, double[] X, double[] Y)
        {
            for (int i = 0; i < X.Length; i++)
            {
                double val = func.deriv(X[i]);

                X[i] = val;
            }

            for (int i = 0; i < Y.Length; i++)
            {
                double val = func.deriv(Y[i]);

                Y[i] = val;
            }

            avaPlotToUpdate.Refresh();
        }

    }
}

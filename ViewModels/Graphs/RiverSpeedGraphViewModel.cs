using Avalonia.Media;
using ReactiveUI;
using ScottPlot.Avalonia;

namespace DevelopmentProject.ViewModels.Graphs
{
    public class RiverSpeedGraphViewModel : ViewModelBase
    {
        public RiverSpeedGraphViewModel()
        {
            RiverSpeedPlot = new AvaPlot();
            CreateNewGraph();
        }

        //private AvaPlot _riverSpeedPlot;

        //public AvaPlot RiverSpeedPlot
        //{
        //    get => _riverSpeedPlot;
        //    set => this.RaiseAndSetIfChanged(ref _riverSpeedPlot, value);
        //}

        //Create GraphItem and custom graph handler to allow many ViewModels
        //to allow viewModels to send data to graphs from F# Model layer

        public AvaPlot RiverSpeedPlot { get; set; }

        public void CreateNewGraph()
        {
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            //Scatter Not as Per formant as Signal Plot for Larger Data Sets
            RiverSpeedPlot.Plot.Add.Scatter(dataX, dataY);
            //RiverSpeedPlot.Render();
        }
    }
}

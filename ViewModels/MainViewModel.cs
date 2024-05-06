using DevelopmentProject.ViewModels.Graphs;
using DevelopmentProject.ViewModels.RiverModel;
using DevelopmentProject.Views.RiverModelView;
using F_Library;
using ReactiveUI;
using ScottPlot.Avalonia;

namespace DevelopmentProject.ViewModels;

public class MainViewModel : ViewModelBase
{
    public RiverViewModel riverViewModel{ get; set; }
    public GraphsViewModel graphsViewModel { get; set; }
   
    public MainViewModel()
    {
        riverViewModel = new RiverViewModel();
        graphsViewModel = new GraphsViewModel();
    }
}

using DevelopmentProject.ViewModels.Graphs;
using DevelopmentProject.ViewModels.RiverModel;
using DevelopmentProject.Views.RiverModelView;

namespace DevelopmentProject.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public RiverViewModel riverViewModel{ get; set; }
    public GraphsViewModel graphsViewModel { get; set; }

    public MainViewModel()
    {
        riverViewModel = new RiverViewModel();
        graphsViewModel = new GraphsViewModel();
    }
}

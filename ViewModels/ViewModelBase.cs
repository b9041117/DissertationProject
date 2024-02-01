using ReactiveUI;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevelopmentProject.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

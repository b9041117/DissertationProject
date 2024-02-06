using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;

namespace DevelopmentProject.ViewModels.RiverModel
{
    public class RiverViewModel : ViewModelBase
    {
        public ICommand riverSpeedCommand { get; }
        public RiverViewModel()
        {
            _selectedRiverSpeed = 0;
        }

        private int _selectedRiverSpeed;

        public int SelectedRiverSpeed
        {
            get => _selectedRiverSpeed;
            set => this.RaiseAndSetIfChanged(ref _selectedRiverSpeed, value);
        }
    }
}

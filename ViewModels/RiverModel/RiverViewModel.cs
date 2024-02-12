using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevelopmentProject.ViewModels.Interfaces;
using ReactiveUI;

namespace DevelopmentProject.ViewModels.RiverModel
{
    public class RiverViewModel : ViewModelBase, IRiverViewModel 
    {
        public ICommand riverSpeedCommand { get; }
        public RiverViewModel()
        {
            _selectedRiverSpeed = 0;
            _selectedRiverDepth = 50;
        }

        private int _selectedRiverSpeed;
        private int _selectedRiverDepth;

        public int SelectedRiverSpeed
        {
            get => _selectedRiverSpeed;
            set => this.RaiseAndSetIfChanged(ref _selectedRiverSpeed, value);
        }

        public int SelectedRiverDepth
        {
            get => _selectedRiverDepth;
            set => this.RaiseAndSetIfChanged(ref _selectedRiverDepth, value);
        }
    }
}

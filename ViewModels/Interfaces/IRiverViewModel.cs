using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevelopmentProject.ViewModels.Interfaces
{
    public interface IRiverViewModel
    { 
        ICommand riverSpeedCommand { get; }

        int SelectedRiverSpeed { get; set; }
        int SelectedRiverDepth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentProject.ViewModels.Graphs
{
    public class GraphsViewModel : ViewModelBase
    {
        public GraphsViewModel()
        {
            riverSpeedGraphViewModel = new RiverSpeedGraphViewModel();
            riverDepthGraphViewModel = new RiverDepthGraphViewModel();
        }

        public RiverSpeedGraphViewModel riverSpeedGraphViewModel { get; set; }

        public RiverDepthGraphViewModel riverDepthGraphViewModel { get; set; }
    }
}

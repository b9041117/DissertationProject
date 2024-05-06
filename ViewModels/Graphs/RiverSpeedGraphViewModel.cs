using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using ReactiveUI;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using F_Library;
using DynamicData;

namespace DevelopmentProject.ViewModels.Graphs
{
    public class RiverSpeedGraphViewModel : ViewModelBase
    {

        private ICommand _getRiverDepth;
        public ICommand GetRiverDepth => _getRiverDepth ??= new RelayCommand(ChangeRiverDepth);

        public ObservableCollection<double> ValueCollection;

        public RiverSpeedGraphViewModel()
        {
            ValueCollection = new ObservableCollection<double>();



            RiverSpeedPlot = new LineSeries<double>
            {
                Values = ValueCollection,
                Fill = null,
                 
            };

            Series = new ISeries[] 
            {
                RiverSpeedPlot
            };
        }


        private LineSeries<double> _riverSpeedPlot;

        public LineSeries<double> RiverSpeedPlot
        {
            get => _riverSpeedPlot;
            set
            {
                this.RaiseAndSetIfChanged(ref _riverSpeedPlot, value);
            }
        }

        public ISeries[] Series { get; set; }

        public Axis[] XAxes { get; set; } =
        {
            new Axis
            {
                Name = "River Depth in cm",
                // Use the labels property for named or static labels 
                //Labels = new string[] { "Sergio", "Lando", "Lewis" },
                //LabelsRotation = 15,
            }
        };

        public Axis[] YAxes { get; set; } =
        {
            new Axis
            {
                Name = "River Speed in m/s",
                NamePadding = new LiveChartsCore.Drawing.Padding(0, 15),
            }
        };

        public LabelVisual Title { get; set; } = new LabelVisual
        {
            Text = "River Speed Graph for Poiseuille Flow",
            TextSize = 25,
            Padding = new LiveChartsCore.Drawing.Padding(15),
            Paint = new SolidColorPaint(SKColors.DarkSlateGray),
        };

        private double _selectedRiverSpeed;

        public double SelectedRiverSpeed
        {
            get => _selectedRiverSpeed;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedRiverSpeed, value);
               
            }
        }

        private double _pressureDiff;   
        public double PressureDiff
        {
            get => _pressureDiff;
            set => this.RaiseAndSetIfChanged(ref _pressureDiff, value);
        }

        private double _selectedRiverDepth;
        public double SelectedRiverDepth
        {
            get => _selectedRiverDepth;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedRiverDepth, value);
            }
        }
        public void ChangeRiverDepth()
        {
            if (ValueCollection.Count > 0)
            {
               ValueCollection.Clear();
            }

            ValueCollection.Add(0);
            ValueCollection.AddRange(func.loopVx(SelectedRiverDepth));
            ValueCollection.Add(0);
        }
    }
}

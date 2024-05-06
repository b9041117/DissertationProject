using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentProject.ViewModels.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevelopmentProject.Tests.ViewModelTests
{
    [TestClass]
    public class RiverSpeedGraphViewModelTests
    {
        private RiverSpeedGraphViewModel viewModel;

        [TestInitialize]
        public void testInitialize()
        {
            viewModel = new RiverSpeedGraphViewModel();
        }

        [TestMethod]
        public void ChangesRiverSpeedMethodTest()
        {
            viewModel.SelectedRiverDepth = 5;
            viewModel.ChangeRiverDepth();

            Assert.IsTrue(viewModel.ValueCollection is not null);
        }
    }
}

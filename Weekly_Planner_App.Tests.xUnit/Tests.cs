using System;

using Caliburn.Micro;

using Moq;

using Weekly_Planner_App.Services;
using Weekly_Planner_App.ViewModels;

using Xunit;

namespace Weekly_Planner_App.Tests.XUnit
{
    // TODO WTS: Add appropriate tests
    public class Tests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        // TODO WTS: Add tests for functionality you add to ContentGridViewModel.
        [Fact]
        public void TestContentGridViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var mockNavService = new Mock<INavigationService>();
            var mockAnimationService = new Mock<IConnectedAnimationService>();
            var vm = new ContentGridViewModel(mockNavService.Object, mockAnimationService.Object);
            Assert.NotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to DataGridViewModel.
        [Fact]
        public void TestDataGridViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new DataGridViewModel();
            Assert.NotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to ListDetailsViewModel.
        [Fact]
        public void TestListDetailsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new ListDetailsViewModel();
            Assert.NotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to MainViewModel.
        [Fact]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.NotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to SettingsViewModel.
        [Fact]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.NotNull(vm);
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;

using Weekly_Planner_App.Core.Services;

using Xunit;

namespace Weekly_Planner_App.Core.Tests.XUnit
{
    // TODO WTS: Add appropriate unit tests.
    public class Tests
    {
        [Fact]
        public void Test1()
        {
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsContentGridDataAsync()
        {
            var actual = await SampleDataService.GetContentGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsGridDataAsync()
        {
            var actual = await SampleDataService.GetGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsListDetailsDataAsync()
        {
            var actual = await SampleDataService.GetListDetailsDataAsync();

            Assert.NotEmpty(actual);
        }
    }
}

using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Caliburn.Micro;

using Weekly_Planner_App.Core.Models;
using Weekly_Planner_App.Core.Services;
using Weekly_Planner_App.Helpers;

namespace Weekly_Planner_App.ViewModels
{
    public class DataGridViewModel : Screen
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}

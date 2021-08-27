using System;
using System.Linq;
using System.Threading.Tasks;

using Caliburn.Micro;

using Weekly_Planner_App.Core.Services;
using Weekly_Planner_App.Helpers;

namespace Weekly_Planner_App.ViewModels
{
    public class ListDetailsViewModel : Conductor<ListDetailsDetailViewModel>.Collection.OneActive
    {
        protected override async void OnInitialize()
        {
            base.OnInitialize();

            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            Items.Clear();

            var data = await SampleDataService.GetListDetailsDataAsync();

            Items.AddRange(data.Select(d => new ListDetailsDetailViewModel(d)));
        }
    }
}

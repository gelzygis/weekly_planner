using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Caliburn.Micro;

using Weekly_Planner_App.Core.Models;
using Weekly_Planner_App.Core.Services;
using Weekly_Planner_App.Helpers;
using Weekly_Planner_App.Services;
using Weekly_Planner_App.Views;

namespace Weekly_Planner_App.ViewModels
{
    public class ContentGridViewModel : Screen
    {
        private readonly INavigationService _navigationService;
        private readonly IConnectedAnimationService _connectedAnimationService;

        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public ContentGridViewModel(INavigationService navigationService, IConnectedAnimationService connectedAnimationService)
        {
            _navigationService = navigationService;
            _connectedAnimationService = connectedAnimationService;
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await SampleDataService.GetContentGridDataAsync();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnItemSelected(SampleOrder clickedItem)
        {
            if (clickedItem != null)
            {
                _connectedAnimationService.SetListDataItemForNextConnectedAnimation(clickedItem);
                _navigationService.Navigate(typeof(ContentGridDetailPage), clickedItem.OrderID);
            }
        }
    }
}

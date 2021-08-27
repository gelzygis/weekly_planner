using System;

using Microsoft.Toolkit.Uwp.UI.Animations;

using Weekly_Planner_App.Core.Models;
using Weekly_Planner_App.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Weekly_Planner_App.Views
{
    public sealed partial class ContentGridDetailPage : Page
    {
        public ContentGridDetailPage()
        {
            InitializeComponent();
        }

        private ContentGridDetailViewModel ViewModel
        {
            get { return DataContext as ContentGridDetailViewModel; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
            if (e.Parameter is long orderID)
            {
                await ViewModel.InitializeAsync(orderID);
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                ViewModel.SetListDataItemForNextConnectedAnimation();
            }
        }
    }
}

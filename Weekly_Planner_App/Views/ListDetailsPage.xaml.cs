using System;
using System.Linq;

using Microsoft.Toolkit.Uwp.UI.Controls;

using Weekly_Planner_App.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Weekly_Planner_App.Views
{
    public sealed partial class ListDetailsPage : Page
    {
        public ListDetailsPage()
        {
            InitializeComponent();
        }

        private ListDetailsViewModel ViewModel
        {
            get { return DataContext as ListDetailsViewModel; }
        }

        private void ListDetailsViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListDetailsViewControl.ViewState == ListDetailsViewState.Both)
            {
                ViewModel.ActiveItem = ViewModel.Items.FirstOrDefault();
            }
        }
    }
}

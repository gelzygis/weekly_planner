using System;

using Weekly_Planner_App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Weekly_Planner_App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }
    }
}

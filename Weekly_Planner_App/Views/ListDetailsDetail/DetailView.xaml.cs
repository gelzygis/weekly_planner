using System;

using Weekly_Planner_App.ViewModels;

namespace Weekly_Planner_App.Views.ListDetailsDetail
{
    public sealed partial class DetailView
    {
        public DetailView()
        {
            InitializeComponent();
        }

        public ListDetailsDetailViewModel ViewModel => DataContext as ListDetailsDetailViewModel;
    }
}

using System;

using Caliburn.Micro;

using Weekly_Planner_App.Core.Models;

namespace Weekly_Planner_App.ViewModels
{
    public class ListDetailsDetailViewModel : Screen
    {
        public ListDetailsDetailViewModel(SampleOrder item)
        {
            Item = item;
        }

        public SampleOrder Item { get; }
    }
}

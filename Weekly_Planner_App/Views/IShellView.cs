﻿using System;

using Caliburn.Micro;

using Windows.UI.Xaml.Controls;

using WinUI = Microsoft.UI.Xaml.Controls;

namespace Weekly_Planner_App.Views
{
    public interface IShellView
    {
        INavigationService CreateNavigationService(WinRTContainer container);

        WinUI.NavigationView GetNavigationView();

        Frame GetFrame();
    }
}

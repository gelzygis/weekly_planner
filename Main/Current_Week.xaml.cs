using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Current_Week : Page
    {
        public Current_Week()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private static int click; // counts the amount of clicks

        public bool True { get; private set; }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            click = click + 1;
            progressbar.Value = click;
            if (click >= progressbar.Maximum) { 
                click = 0;
            }
        }

        private void Monday_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Monday_Page));
        }

        private void Tuesday_Button_Click(object sender, RoutedEventArgs e)
        {
            Monday_Button.IsEnabled = true;
        }

        private void Wednesday_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Thursday_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Friday_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Saturday_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sunday_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

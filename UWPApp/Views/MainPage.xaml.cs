using System;

using UWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPApp.Views
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

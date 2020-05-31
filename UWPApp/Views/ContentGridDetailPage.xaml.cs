using System;

using Microsoft.Toolkit.Uwp.UI.Animations;

using UWPApp.Core.Models;
using UWPApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWPApp.Views
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

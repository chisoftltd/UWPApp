using System;
using System.Threading.Tasks;

using UWPApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWPApp.Views
{
    public sealed partial class ContentGridPage : Page
    {
        public ContentGridPage()
        {
            InitializeComponent();
        }

        private ContentGridViewModel ViewModel
        {
            get { return DataContext as ContentGridViewModel; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}

using System;

using UWPApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWPApp.Views
{
    public sealed partial class DataGridPage : Page
    {
        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on DataGridPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public DataGridPage()
        {
            InitializeComponent();
        }

        private DataGridViewModel ViewModel
        {
            get { return DataContext as DataGridViewModel; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}

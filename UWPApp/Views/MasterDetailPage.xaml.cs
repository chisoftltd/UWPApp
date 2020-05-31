using System;
using System.Linq;

using Microsoft.Toolkit.Uwp.UI.Controls;

using UWPApp.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPApp.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        public MasterDetailPage()
        {
            InitializeComponent();
        }

        private MasterDetailViewModel ViewModel
        {
            get { return DataContext as MasterDetailViewModel; }
        }

        private void MasterDetailsViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (MasterDetailsViewControl.ViewState == MasterDetailsViewState.Both)
            {
                ViewModel.ActiveItem = ViewModel.Items.FirstOrDefault();
            }
        }
    }
}

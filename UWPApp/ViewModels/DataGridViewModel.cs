using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Caliburn.Micro;

using UWPApp.Core.Models;
using UWPApp.Core.Services;
using UWPApp.Helpers;

namespace UWPApp.ViewModels
{
    public class DataGridViewModel : Screen
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}

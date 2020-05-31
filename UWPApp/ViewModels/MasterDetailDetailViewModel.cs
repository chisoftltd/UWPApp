using System;

using Caliburn.Micro;

using UWPApp.Core.Models;

namespace UWPApp.ViewModels
{
    public class MasterDetailDetailViewModel : Screen
    {
        public MasterDetailDetailViewModel(SampleOrder item)
        {
            Item = item;
        }

        public SampleOrder Item { get; }
    }
}

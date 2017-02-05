using System;
using MvvmCross.Core.ViewModels;

namespace XabluApp.Core
{
    public class BaseViewModel : MvxViewModel
    {
        public string Title { get; set; }

        public BaseViewModel()
        {
        }
    }
}

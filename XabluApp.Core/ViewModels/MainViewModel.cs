using System;
using MvvmCross.Core.ViewModels;

namespace XabluApp.Core
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
        }

        public void ShowDrawerLayout()
        {
            ShowViewModel<DrawerViewModel>();
        }
    }
}

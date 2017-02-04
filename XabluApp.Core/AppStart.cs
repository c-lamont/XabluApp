using System;
using MvvmCross.Core.ViewModels;

namespace XabluApp.Core
{
    public class AppStart: MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<EmployeesViewModel>();
        }
    }
}

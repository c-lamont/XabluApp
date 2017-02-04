using System;
using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("xabluapp.droid.fragments.EmployeesFragment")]
    public class EmployeesFragment : BaseFragment<EmployeesViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_employees_layout;
    }
}

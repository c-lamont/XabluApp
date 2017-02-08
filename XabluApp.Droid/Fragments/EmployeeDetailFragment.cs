using System;
using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("xabluapp.droid.fragments.EmployeeDetailFragment")]
    public class EmployeeDetailFragment : BaseFragment<EmployeeDetailViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_employee_detail_layout;
    }
}

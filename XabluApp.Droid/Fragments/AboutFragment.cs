using System;
using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("xabluapp.droid.fragments.AboutFragment")]
    public class AboutFragment : BaseFragment<AboutViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_about_layout;
    }
}

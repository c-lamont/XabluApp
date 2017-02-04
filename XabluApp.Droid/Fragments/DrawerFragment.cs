using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.left_drawer, true)]
    [Register("globalportalapp.droid.fragments.DrawerFragment")]
    public class DrawerFragment : BaseFragment<DrawerViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_drawer_layout;
    }
}
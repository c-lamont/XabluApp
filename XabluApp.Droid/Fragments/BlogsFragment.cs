using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("xabluapp.droid.fragments.BlogsFragment")]
    public class BlogsFragment : BaseFragment<BlogsViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_blogs_layout;
    }
}

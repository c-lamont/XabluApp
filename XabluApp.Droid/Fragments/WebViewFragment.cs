using System;
using Android.Runtime;
using Android.Webkit;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("xabluapp.droid.fragments.WebViewFragment")]
    public class WebViewFragment: BaseFragment<WebViewViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_webview_layout;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            var webView = view.FindViewById<WebView>(Resource.Id.webview);
            webView.LoadUrl(ViewModel.WebUrl);
            return view;
        }
    }
}

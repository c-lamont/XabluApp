﻿using System;
using Android.Runtime;
using Android.Webkit;
using MvvmCross.Droid.Shared.Attributes;
using XabluApp.Core;

namespace XabluApp.Droid
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("xabluapp.droid.fragments.AboutFragment")]
    public class AboutFragment : BaseFragment<AboutViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_about_layout;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            var webView = view.FindViewById<WebView>(Resource.Id.webview);
            webView.LoadUrl("https://www.xablu.com/about/");
            return view;
        }
    }
}

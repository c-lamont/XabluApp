﻿using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using XabluApp.Core;
using XabluApp.Droid.Activities;

namespace XabluApp.Droid
{

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : class, IMvxViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }

    public abstract class BaseFragment : MvxFragment
    {
        protected abstract int FragmentId { get; }
        protected virtual string Title => ((BaseViewModel)ViewModel).Title;
        public View MainView;
        public bool InitializeDrawerLayout;
        public Toolbar _toolbar;

        public MvxCachingFragmentCompatActivity ParentActivity
        {
            get
            {
                return ((MvxCachingFragmentCompatActivity)Activity);
            }
        }

        protected BaseFragment()
        {
            this.RetainInstance = true;
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            var baseViewModel = ViewModel as BaseViewModel;
            if (baseViewModel != null) baseViewModel.PropertyChanged -= BaseViewModel_PropertyChanged;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            MainView = this.BindingInflate(FragmentId, null);

            _toolbar = MainView.FindViewById<Toolbar>(Resource.Id.toolbar);
            if (_toolbar != null)
            {
                ParentActivity.SetSupportActionBar(_toolbar);
                if (!string.IsNullOrEmpty(Title))
                {
                    ParentActivity.SupportActionBar.Title = Title;
                    var baseViewModel = ViewModel as BaseViewModel;
                    if (baseViewModel != null) baseViewModel.PropertyChanged += BaseViewModel_PropertyChanged;
                }
            }

            if (InitializeDrawerLayout)
            {
                InitializeMainActivityDrawerLayout();
            }

            return MainView;
        }

        private void BaseViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var baseViewModel = (BaseViewModel)ViewModel;
            if (e.PropertyName == nameof(baseViewModel.Title))
            {
                ParentActivity.SupportActionBar.Title = Title;
            }
        }

        public void InitializeMainActivityDrawerLayout()
        {
            HasOptionsMenu = true;
            var mainActivity = ParentActivity as MainActivity;
            mainActivity?.SetDrawerLayout();
        }
    }
}

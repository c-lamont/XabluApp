using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using XabluApp.Core;

namespace XabluApp.Droid.Activities
{
    [Activity(
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "xabluapp.droid.activities.MainActivity",
        ScreenOrientation = ScreenOrientation.Portrait,
        WindowSoftInputMode = SoftInput.AdjustResize
    )]
    public class MainActivity : BaseActivity<MainViewModel>
    {
        protected override int LayoutID => Resource.Layout.activity_main_layout;
        private Toolbar _toolbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ViewModel.ShowDrawerLayout();
            SetToolbar();
            SetDrawerLayout();
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            if (SupportFragmentManager.BackStackEntryCount == 0)
            {
                this.Finish();
            }
        }

        private void SetToolbar()
        {
            _toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (_toolbar != null)
            {
                this.SetSupportActionBar(_toolbar);
            }
        }

        private MvxActionBarDrawerToggle drawerToggle;
        private DrawerLayout drawerLayout;
        public void SetDrawerLayout()
        {
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawerToggle = new MvxActionBarDrawerToggle(
                this,
                drawerLayout,
                Resource.String.drawer_open,
                Resource.String.drawer_close);

            drawerToggle.DrawerClosed += (sender, e) => this.SupportInvalidateOptionsMenu();
            drawerToggle.DrawerOpened += (sender, e) => this.SupportInvalidateOptionsMenu();
            drawerToggle.DrawerIndicatorEnabled = true;
            drawerToggle.SyncState();
            drawerLayout.AddDrawerListener(drawerToggle);

            this.SupportActionBar?.SetDisplayHomeAsUpEnabled(true);
            this.SupportActionBar?.SetHomeButtonEnabled(true);
        }


        internal void CloseDrawerMenu()
        {
            drawerLayout?.CloseDrawers();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (drawerToggle.OnOptionsItemSelected(item))
                return true;
            return base.OnOptionsItemSelected(item);
        }

        public override bool Close(IMvxViewModel viewModel)
        {
            var success = base.Close(viewModel);

            if (SupportFragmentManager.BackStackEntryCount == 0) Finish();

            return success;
        }
    }
}

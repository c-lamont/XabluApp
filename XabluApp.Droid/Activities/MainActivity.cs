using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MvvmCross.Core.ViewModels;
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
        protected override int FragmentId => Resource.Layout.activity_main_layout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            if (SupportFragmentManager.BackStackEntryCount == 0)
            {
                this.Finish();
            }
        }

        public override bool Close(IMvxViewModel viewModel)
        {
            var success = base.Close(viewModel);

            if (SupportFragmentManager.BackStackEntryCount == 0) Finish();

            return success;
        }

        public void SetDrawerLayout()
        {
        }
    }
}

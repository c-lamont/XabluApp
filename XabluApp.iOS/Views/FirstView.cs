using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using XabluApp.Core;

namespace XabluApp.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, EmployeesViewModel>();
            set.Apply();
        }
    }
}

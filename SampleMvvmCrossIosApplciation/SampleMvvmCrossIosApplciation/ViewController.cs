using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using SampleMvvmCrossIosApplciation.MvvmCross;
using System;

namespace SampleMvvmCrossIosApplciation
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class ViewController : MvxViewController<HelloViewModel>
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<ViewController, HelloViewModel>();
            set.Bind(lblHello).To(vm => vm.Text);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

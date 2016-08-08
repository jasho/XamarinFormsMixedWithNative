
using System;
using UIKit;
using Xamarin.Forms;
using XamarinFormsMixedWithNative.Pages;

namespace XamarinFormsMixedWithNative.iOS.Pages
{
    public partial class Page2ViewController : UIViewController
    {
        public Page2ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }


        partial void NavigateToFormsPage3ButtonDown(UIKit.UIButton sender)
        {
            NavigationController.PushViewController(new Page3Forms().CreateViewController(), true);
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}
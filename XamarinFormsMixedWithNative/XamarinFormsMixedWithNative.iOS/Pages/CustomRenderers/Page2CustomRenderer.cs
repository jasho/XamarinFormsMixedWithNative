using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsMixedWithNative.iOS.Pages.CustomRenderers;
using XamarinFormsMixedWithNative.Pages;

[assembly: ExportRenderer(typeof(Page2), typeof(Page2CustomRenderer))]
namespace XamarinFormsMixedWithNative.iOS.Pages.CustomRenderers
{

    public class Page2CustomRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            UIViewController hostViewController = ViewController;

            Page2ViewController viewController = (Page2ViewController)AppDelegate.Storyboard.InstantiateViewController("Page2ViewController");
            hostViewController.AddChildViewController(viewController);
            hostViewController.View.Add(viewController.View);

            viewController.DidMoveToParentViewController(hostViewController);

            base.OnElementChanged(e);
        }
    }
}

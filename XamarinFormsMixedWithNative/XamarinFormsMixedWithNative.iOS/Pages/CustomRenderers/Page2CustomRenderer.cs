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
            base.OnElementChanged(e);
        }
    }
}

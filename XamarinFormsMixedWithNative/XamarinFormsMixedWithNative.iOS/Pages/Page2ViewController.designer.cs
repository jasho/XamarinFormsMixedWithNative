// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinFormsMixedWithNative.iOS.Pages
{
    [Register ("Page2ViewController")]
    partial class Page2ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NavigateToFormsPage3Button { get; set; }

        [Action ("NavigateToFormsPage3ButtonDown:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NavigateToFormsPage3ButtonDown (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (NavigateToFormsPage3Button != null) {
                NavigateToFormsPage3Button.Dispose ();
                NavigateToFormsPage3Button = null;
            }
        }
    }
}
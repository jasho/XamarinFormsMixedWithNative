using System;

using Xamarin.Forms;

namespace XamarinFormsMixedWithNative.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToPage2Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}

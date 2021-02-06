using System;
using Xamarin.Forms;

namespace Xamarin.Sample.PageLoadedEvent
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            Device.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new TargetPage());
            });
        }
    }
}

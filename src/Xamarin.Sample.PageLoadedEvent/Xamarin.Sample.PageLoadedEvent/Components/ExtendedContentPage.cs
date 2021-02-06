using System;
using Xamarin.Forms;

namespace Xamarin.Sample.PageLoadedEvent.Components
{
    public class ExtendedContentPage : ContentPage
    {
        public event EventHandler PageLoaded;

        public ExtendedContentPage()
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                SubscribeToViewLoadedMessage();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Device.RuntimePlatform == Device.iOS)
            {
                SubscribeToViewLoadedMessage();
            }
        }

        private void SubscribeToViewLoadedMessage()
        {
            MessagingCenter.Subscribe<ExtendedContentPage>(this, "PageLoaded", (sender) =>
            {
                PageLoaded?.Invoke(sender, EventArgs.Empty);
            });
        }
    }
}

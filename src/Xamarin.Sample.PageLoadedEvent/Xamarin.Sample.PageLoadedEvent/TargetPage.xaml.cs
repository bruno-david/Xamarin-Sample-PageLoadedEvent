using System;
using Xamarin.Forms;
using Xamarin.Sample.PageLoadedEvent.Components;

namespace Xamarin.Sample.PageLoadedEvent
{
    public partial class TargetPage : ExtendedContentPage
    {
        public TargetPage()
        {
            InitializeComponent();

            PageLoaded += TargetPage_PageLoaded;
        }

        private void TargetPage_PageLoaded(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Information", "Page Loaded", "Cancel");
            });
        }
    }
}

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Sample.PageLoadedEvent.Components;
using Xamarin.Sample.PageLoadedEvent.iOS.Renderers;

[assembly: ExportRenderer(typeof(ExtendedContentPage), typeof(ExtendedContentPageRenderer))]
namespace Xamarin.Sample.PageLoadedEvent.iOS.Renderers
{
    public class ExtendedContentPageRenderer : PageRenderer
    {
        private ExtendedContentPage _extendedContentPage;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            if (e.NewElement is ExtendedContentPage extendedContentPage)
            {
                _extendedContentPage = extendedContentPage;
            }
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (_extendedContentPage != null)
            {
                MessagingCenter.Send(_extendedContentPage, "PageLoaded");
            }
        }
    }
}

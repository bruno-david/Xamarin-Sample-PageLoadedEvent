using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Sample.PageLoadedEvent.Components;
using Xamarin.Sample.PageLoadedEvent.Droid.Renderers;

[assembly: ExportRenderer(typeof(ExtendedContentPage), typeof(ExtendedContentPageRenderer))]

namespace Xamarin.Sample.PageLoadedEvent.Droid.Renderers
{
    public class ExtendedContentPageRenderer : PageRenderer
    {
        private ExtendedContentPage _extendedContentPage;

        public ExtendedContentPageRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
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

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            if (_extendedContentPage != null)
            {
                MessagingCenter.Send(_extendedContentPage, "PageLoaded");
            }
        }
    }
}

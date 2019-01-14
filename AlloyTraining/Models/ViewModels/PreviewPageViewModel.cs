using AlloyTraining.Models.Pages;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class PreviewPageViewModel : PageViewModel<SitePageData>
    {
        public ContentArea PreviewArea { get; set; }

        public PreviewPageViewModel(SitePageData currentPage, IContent contentToPreview)
            : base(currentPage)
        {
            PreviewArea = new ContentArea();
            PreviewArea.Items.Add(new ContentAreaItem { ContentLink = contentToPreview.ContentLink });
        }
    }
}
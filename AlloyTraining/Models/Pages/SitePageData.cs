using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public ContentReference PageImage { get; set; }
    }
}
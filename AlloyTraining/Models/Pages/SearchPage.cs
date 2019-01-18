using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Search",
        GroupName = SiteGroupNames.Specialized, Order = 30,
        GUID = "044d7070-a9fa-4efb-822a-882435a29a09",
        Description = "Use this to enable visitors to search for pages and media on the site.")]
    [SitePageIcon]
    public class SearchPage : SitePageData
    {
    }
}
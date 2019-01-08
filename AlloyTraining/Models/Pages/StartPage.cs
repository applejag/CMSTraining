using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Start",
        GroupName = SiteGroupNames.Specialized, Order = 10,
        GUID = "0b3b2063-1cbd-4fd5-bd52-7dc3eed4371c",
        Description = "The home page for a website with an area for blocks and partial pages.")]
    [SitePageIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Primary heading on the page. If the heading is not set, it will fallback to using it's name instead.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
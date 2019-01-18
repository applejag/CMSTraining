using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "News Landing", 
        GUID = "5914bc4a-0301-4323-9359-06d94626e3ed",
        Description = "Use this as a landing page for a list of news articles.",
        GroupName = SiteGroupNames.News)]
    [SitePageIcon]
    public class NewsLandingPage : StandardPage
    {
        [Display(Name = "News listing",
            Order = 315,
            GroupName = SystemTabNames.Content)]
        public virtual ListingBlock NewsListing { get; set; }
    }
}
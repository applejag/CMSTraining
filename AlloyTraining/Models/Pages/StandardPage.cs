using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GUID = "6f437a1e-661f-48ed-abb2-b42f5e808254",
        Description = "Use this page type unless you need a more specialized one.",
        GroupName = SiteGroupNames.Common)]
    [SitePageIcon]
    [AvailableContentTypes(
        Include = new[] { typeof(StandardPage) },
        Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Page author",
            Description = "The employee who created this page. Drag in an employee block from the Assets menu.",
            GroupName = SystemTabNames.Content,
            Order = 160)]
        public virtual EmployeeBlock Author { get; set; }

    }
}
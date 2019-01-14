using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Product Page",
        GUID = "93db5a1a-2eaa-43cf-84b1-66c852dd4279",
        Description = "Use this for software products that Alloy sells.",
        GroupName = SiteGroupNames.Specialized)]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(Name = "Color theme",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Required]
        [Display(Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [Display(Name = "Main content area",
            Description = "Drag and drop pages and content with partial themes.",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Name = "Related content area",
            Description = "Drag and drop pages and content with partial themes.",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea RelatedContentArea { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Theme = "theme1";
        }
    }
}
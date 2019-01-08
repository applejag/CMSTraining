﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(Name = "Meta title",
            GroupName = SiteTabNames.SEO,
            Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        [CultureSpecific]
        public string MetaTitle { get; set; }

        [Display(Name = "Meta keywords",
            GroupName = SiteTabNames.SEO,
            Order = 200)]
        [CultureSpecific]
        public string MetaKeywords { get; set; }

        [Display(Name = "Meta description",
            GroupName = SiteTabNames.SEO,
            Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public string MetaDescription { get; set; }

        [Display(Name = "Page thumbnail image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public ContentReference PageImage { get; set; }
    }
}
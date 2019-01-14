using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full },
        AvailableWithoutTag = true)]
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide },
        AvailableWithoutTag = false)]
    public class TeaserBlockWideController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow },
        AvailableWithoutTag = false)]
    public class TeaserBlockNarrowController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }
}

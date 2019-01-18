using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        private readonly IContentLoader _loader;

        public ListingBlockController(IContentLoader loader)
        {
            _loader = loader;
        }

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var viewModel = new ListingBlockViewModel
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> allChildren = _loader.GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);
                IEnumerable<IContent> filteredChildren = FilterForVisitor.Filter(allChildren);

                viewModel.Pages = filteredChildren.Cast<PageData>()
                    .Where(p => p.VisibleInMenu);
            }

            return PartialView(viewModel);
        }
    }
}

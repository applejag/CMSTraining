using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        AvailableWithoutTag = false)]
    public class PreviewPageController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        private readonly IContentLoader _loader;

        public PreviewPageController(IContentLoader loader)
        {
            _loader = loader;
        }

        public ActionResult Index(IContent currentContent)
        {
            var startPage = _loader.Get<StartPage>(ContentReference.StartPage);
            var model = new PreviewPageViewModel(startPage, currentContent);
            return View(model);
        }
    }
}
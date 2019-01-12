using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ProductPageController : PageControllerBase<ProductPage>
    {
        public ProductPageController(IContentLoader loader) : base(loader)
        { }

        public ActionResult Index(ProductPage currentPage)
        {
            return View(currentPage);
        }
    }
}
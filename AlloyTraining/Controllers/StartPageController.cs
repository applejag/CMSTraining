﻿using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}
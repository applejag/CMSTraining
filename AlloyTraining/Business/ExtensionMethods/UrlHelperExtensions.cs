using System;
using System.Reflection;
using System.Web.Mvc;
using AlloyTraining.Controllers;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;

namespace AlloyTraining.Business.ExtensionMethods
{
    public static class UrlHelperExtensions
    {
        public static string Action(this UrlHelper url, ContentReference contentLink, string action = "index")
        {
            var resolver = ServiceLocator.Current.GetInstance<UrlResolver>();

            return resolver.GetUrl(contentLink, null, new VirtualPathArguments
            {
                Action = action
            });
        }
    }
}
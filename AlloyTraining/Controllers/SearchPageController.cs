using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AlloyTraining.Business.ExtensionMethods;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Search;
using EPiServer.Search.Queries.Lucene;
using EPiServer.Security;
using EPiServer.Shell.Search;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private readonly SearchHandler _searchHandler;

        public SearchPageController(IContentLoader loader, SearchHandler searchHandler) : base(loader)
        {
            _searchHandler = searchHandler;
        }

        public ActionResult Index(SearchPage currentPage, string q)
        {
            var viewModel = new SearchPageViewModel(currentPage)
            {
                StartPage = Loader.Get<StartPage>(ContentReference.StartPage),
                MenuPages = FilterForVisitor
                    .Filter(Loader.GetChildren<SitePageData>(ContentReference.StartPage))
                    .Cast<SitePageData>()
                    .Where(p => p.VisibleInMenu),
                Section = currentPage.ContentLink.GetSection()
            };

            if (string.IsNullOrWhiteSpace(q))
                return View(viewModel);

            // 1. only pages
            var onlyPages = new ContentQuery<SitePageData>();

            // 2. free-text query
            var freeText = new FieldQuery(q);

            // 3. only what current user can read
            var readAccess = new AccessControlListQuery();
            readAccess.AddAclForUser(PrincipalInfo.Current, HttpContext);

            // 4. only under start page (ignore trash bin)
            var underStart = new VirtualPathQuery();
            underStart.AddContentNodes(ContentReference.StartPage);

            // build query
            var query = new GroupQuery(LuceneOperator.AND);
            query.QueryExpressions.Add(onlyPages);
            query.QueryExpressions.Add(freeText);
            query.QueryExpressions.Add(readAccess);
            query.QueryExpressions.Add(underStart);

            // get result
            SearchResults results = _searchHandler.GetSearchResults(query, 1, 10);

            viewModel.SearchText = q;
            viewModel.SearchResults = results.IndexResponseItems
                .Select(item => new Result
                {
                    Title = item.Title,
                    Description = item.DisplayText?.TruncateAtWord(20),
                    Url = ConvertToUri(item).ToString()
                }).ToList();

            return View(viewModel);
        }

        private Uri ConvertToUri(IndexItemBase item)
        {
            try
            {
                var url = new UrlBuilder(item.Uri);
                Global.UrlRewriteProvider.ConvertToExternal(url, item, Encoding.UTF8);
                return url.Uri;
            }
            catch
            {
                return default(Uri);
            }
        }

    }
}
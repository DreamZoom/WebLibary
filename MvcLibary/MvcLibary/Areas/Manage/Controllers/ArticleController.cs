using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLibrary;
using WebLibrary.Article;

namespace MvcLibary.Areas.Manage.Controllers
{
    public class ArticleController : WebLibrary.ManageBase<Article>
    {

        protected override BLLService<Article> getService()
        {
            return new BLLService<Article>(new ArticleContext());
        }
        //
        // GET: /Manage/Article/

        public ActionResult Index()
        {
            return View();
        }

    }
}

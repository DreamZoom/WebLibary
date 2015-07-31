using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Article
{
    public class ArticleCategoryService : BLLService<ArticleCategory>
    {
        public ArticleCategoryService()
            :base(new ArticleContext())
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Article
{
    public class ArticleService : BLLService<Article>
    {
        public ArticleService()
            : base(new ArticleContext())
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebLibrary.Article
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
            : base("name=Article_ConnectionString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 文章列表
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// 分类列表
        /// </summary>
        public DbSet<ArticleCategory> ArticleCategorys { get; set; }
    }
}

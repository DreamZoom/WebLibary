using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace WebLibrary.Article
{
    /// <summary>
    /// 文章分类
    /// </summary>
    public class ArticleCategory
    {
        [Display(Name="编号")]
        public int ID { get; set; }


        /// <summary>
        /// 父类ID
        /// </summary>
        [Display(Name = "上级编号")]
        public int ParentID { get; set; }


        [Display(Name = "分类名称")]
        public string CateName { get; set; }


        [Display(Name = "分类描述")]
        public string CateDiscript { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}

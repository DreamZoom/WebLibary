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
    public class Article
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name = "文章编号")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [Display(Name="标题")]
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        [Display(Name = "内容")]
        [Required]
        public string Body { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [Display(Name = "发布时间")]
        [Required]
        public DateTime PostTime { get; set; }


        /// <summary>
        /// 阅读次数
        /// </summary>
        [Display(Name = "阅读次数")]
        public int Reads { get; set; }

        /// <summary>
        /// 获取摘要
        /// </summary>
         [Display(Name = "摘要")]
        public string Summary
        {
            get
            {
               return  Regex.Replace(Body, "<[^>]+>", "");
            }
        }

         public virtual ArticleCategory Category { get; set; }

    }
}

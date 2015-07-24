using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebLibrary.Auth
{
    /// <summary>
    /// 角色 
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 编号,主键,递增列
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int ID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Display(Name="角色")]
        public string RoleName { get; set; }

        /// <summary>
        /// 是否为系统角色，如果是则不能删除.
        /// </summary>
        [Display(Name="系统角色")]
        public bool IsSystem { get; set; }

        /// <summary>
        /// 角色所拥有的权限
        /// </summary>
        public virtual ICollection<Auth> Auths { get; set; }
    }
}

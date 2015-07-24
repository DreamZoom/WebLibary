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
    /// 权限模型
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        [Display(Name = "权限名称")]
        public string AuthName { get; set; }

        /// <summary>
        /// 控制器名称
        /// </summary>     
        [Key,Column(Order=1)]
        [Display(Name = "控制器名称")]
        public string ControllerName { get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [Key, Column(Order = 2)]
        [Display(Name = "方法名称")]
        public string ActionName { get; set; }

        /// <summary>
        /// 权限所属角色多个
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }

    }
}

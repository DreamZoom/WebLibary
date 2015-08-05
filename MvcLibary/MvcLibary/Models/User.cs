using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcLibary.Models
{

    public enum UserType{
        普通,
        高级
    }
    public class User
    {
        public UserType uType { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public DateTime RegTime { get; set; }
    }
}
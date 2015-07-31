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
        [UIHint("Enum")]
        public UserType uType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebLibrary.Account.Models
{
    public class Account
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string NickName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Email { get; set; }

        public string Tell { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                if (BirthDay == null) return 0;
                return Math.Abs(DateTime.Now.Year - BirthDay.Year);
            }
        }
    }
}

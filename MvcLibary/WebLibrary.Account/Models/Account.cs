using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Edm;

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

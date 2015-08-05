using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebLibrary.Account
{
    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("name=Account_ConnectionString")
        {
        }
    }
}

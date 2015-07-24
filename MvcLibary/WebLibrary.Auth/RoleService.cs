using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Auth
{
    public class RoleService : BLLService<Auth>
    {
        public RoleService()
            :base(new AuthContext())
        {

        }
    }
}

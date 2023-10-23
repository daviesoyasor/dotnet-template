using Monapp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monapp.Service.Implementation
{
    public sealed class Auth: IAuth
    {
        public APIResponse Login(string username, string password)
        {
            return new APIResponse(null, 200, "Login successful");

        }
    }
}

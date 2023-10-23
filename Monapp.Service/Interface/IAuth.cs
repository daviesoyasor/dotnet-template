using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monapp.Service.Interface
{
    public interface IAuth
    {
        APIResponse Login(string username, string password);
    }
}

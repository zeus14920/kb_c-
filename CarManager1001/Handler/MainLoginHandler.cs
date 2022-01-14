using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Handler
{
    class MainLoginHandler
    {
        public bool loginCheck(string id, string passwd)
        {
            if (id.Equals("guest") && passwd.Equals("1234"))
            {
                return true;
            }
            return false;
        }
    }
}

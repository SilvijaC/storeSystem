using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeSystem
{
    class SetUserNameDisplay
    {
        static string UserName;
        public static string username
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
    }
}

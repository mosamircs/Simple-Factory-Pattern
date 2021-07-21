using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
{
    class UsernameFactory
    {
        public UserName GetUserName(string name)
        {
            if (name.Contains(",")) return new LastNameFirst(name);

            return new FirstNameFirst(name);
        }
    }
}

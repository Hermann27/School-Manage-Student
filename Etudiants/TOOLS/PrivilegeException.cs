using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class PrivilegeException:Exception 
    {
        public PrivilegeException()
            : base()
        {

        }

        public PrivilegeException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public PrivilegeException(string msg)
            : base(msg)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class GroupeException:Exception 
    {
       public GroupeException()
            : base()
        {

        }

        public GroupeException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public GroupeException(string msg)
            : base(msg)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class DomaineException:System.Exception 
    {
        public DomaineException()
            : base()
        {

        }

        public DomaineException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public DomaineException(string msg)
            : base(msg)
        {

        }
    }
}

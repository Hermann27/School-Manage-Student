using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class PretException:System.Exception 
    {
        public PretException()
            : base()
        {
            
        }

        public PretException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public PretException(string msg)
            : base(msg)
        {

        }
    }
}

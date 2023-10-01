using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class ClasseException:Exception 
    {
        public ClasseException()
            : base()
        {

        }

        public ClasseException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public ClasseException(string msg)
            : base(msg)
        {

        }
        
    }
}

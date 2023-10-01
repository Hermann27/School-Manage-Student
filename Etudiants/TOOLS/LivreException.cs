using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class LivreException:System.Exception 
    {
        public LivreException()
            : base()
        {

        }

        public LivreException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public LivreException(string msg)
            : base(msg)
        {

        }
    }
}

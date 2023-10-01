using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class EntreeLivreException:Exception 
    {
        public EntreeLivreException()
            : base()
        {

        }

        public EntreeLivreException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public EntreeLivreException(string msg)
            : base(msg)
        {

        }
    }
}

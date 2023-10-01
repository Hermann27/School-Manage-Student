using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class Groupe_PrivException:Exception 
    {
         public Groupe_PrivException()
            : base()
        {

        }

        public Groupe_PrivException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public Groupe_PrivException(string msg)
            : base(msg)
        {

        }
    }
}

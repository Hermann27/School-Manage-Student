using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
   public class UtilisateurException:Exception 
    {
        public UtilisateurException()
            : base()
        {

        }

        public UtilisateurException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public UtilisateurException(string msg)
            : base(msg)
        {

        }
    }
}

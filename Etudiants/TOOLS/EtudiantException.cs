using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOOLS
{
    public class EtudiantException:System.Exception
    {
        public EtudiantException()
            : base()
        {

        }

        public EtudiantException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public EtudiantException(string msg)
            : base(msg)
        {

        }
    }
}

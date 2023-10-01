using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class EntreeException:Exception 
    {
        
        public EntreeException()
            : base()
        {

        }

        public EntreeException(string msg,Exception exval)
            : base(msg,exval)
        {

        }

        public EntreeException(string msg)
            : base(msg)
        {

        }
    }
}

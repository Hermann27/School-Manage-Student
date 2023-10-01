using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Groupe_Privilege
    {
        public Groupe groupe { get; set; }
        public Privilege privilege { get; set; }
        public byte Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }

        public Groupe_Privilege(Groupe grp, Privilege  priv, 
                          byte  st, DateTime dtecre,DateTime dteup, Utilisateur usrUp, Utilisateur usrCrea)
       {
           
           this.groupe  =grp ;
           this.privilege  = priv;
           this.Status  = st;
           this.DateCreate = dtecre;
           this.DateUpdate = dteup;
           this.UserCreate = usrCrea;
           this.UserUpdate = usrUp;

       }

        public Groupe_Privilege(Groupe grp, Privilege priv)
       {
           this.groupe  = grp;
           this.privilege = priv;
       }

        public static List<Groupe_Privilege> operator +(List<Groupe_Privilege> liste, Groupe_Privilege grp_priv)
        {
            liste.Add(grp_priv);
            return liste;
        }
    }
}

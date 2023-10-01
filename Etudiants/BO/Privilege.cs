using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Privilege
    {
        public int Identifiant { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
        public string Intitule { get; set; }

        public Privilege(int id, string Intitule, 
                          DateTime dteCreat, DateTime dteUpdat, Utilisateur usrUp, Utilisateur usrCrea)
       {
           
           this.Identifiant = id;
           this.Intitule = Intitule;
           this.DateCreate = dteCreat;
           this.DateUpdate = dteUpdat;
           this.UserCreate = usrCrea;
           this.UserUpdate = usrUp;

       }

        public Privilege(int id)
       {
           this.Identifiant = id;
       }
        override
        public string ToString()
        {
            return this.Intitule;
        }

        public static List<Privilege> operator +(List<Privilege> liste, Privilege priv)
        {
            liste.Add(priv);
            return liste;
        }
    }
}

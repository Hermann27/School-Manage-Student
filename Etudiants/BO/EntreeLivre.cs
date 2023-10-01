using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EntreeLivre
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
        public Entree entree { get; set; }
        public Livre livre { get; set; }
        public int QteEntree { get; set; }
        public double PuEntree { get; set; }

        public EntreeLivre(Entree entree,Livre livre, int qteentree, double puentree)
        {
            this.entree   = entree ;
            this.livre   = livre  ;
            this.QteEntree  = qteentree ;
            this.PuEntree=puentree ;
        }

        public EntreeLivre(Entree entree,Livre livre)
        {
            this.entree = entree;
            this.livre = livre;
        }
        public static List<EntreeLivre> operator +(List<EntreeLivre> liste, EntreeLivre entreelivre)
        {
            liste.Add(entreelivre);
            return liste;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
    public class Entree
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
        [DisplayName("Numero Bordereau")]
        public int NumBord { get; set; }
        [DisplayName("Date Bordereau")]
        public DateTime DateBord { get; set; }
        [DisplayName("Nom Fournisseur")]
        public string NomFsseur { get; set; }

        public Entree( int numbord, DateTime datebord,string nomfsseur)
        {
            this.NumBord  = numbord ;
            this.DateBord  = datebord ;
            this.NomFsseur = nomfsseur;
        }

        public Entree(int numbord)
        {
            this.NumBord = numbord;
        }
        public static List<Entree> operator +(List<Entree> liste, Entree entree)
        {
            liste.Add(entree);
            return liste;
        }
    }
}

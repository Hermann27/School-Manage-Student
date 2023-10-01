using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
    public class Domaine
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
        [DisplayName("Numero Domaine")]
        public int NumDom { get; set; }
        [DisplayName("Nom Domaine")]
        public string   NomDom { get; set; }

        public Domaine(int NumDom, string NomDom)
        {
            this.NumDom = NumDom;
            this.NomDom = NomDom;
        }

        public Domaine(int NumDom)
        {
            this.NumDom = NumDom;
        }
        public Domaine(string NomDom)
        {
            this.NomDom = NomDom;
        }
        public static List<Domaine > operator +(List<Domaine > liste, Domaine Dom)
        {
            liste.Add(Dom);
            return liste;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
   public  class Livre
    {
        [DisplayName("Domaine")]
        public Domaine domaine { get; set; }
        [DisplayName("Code")]
        public int CodeLivre { get; set; }
        [DisplayName("ISBN")]
        public string ISBN { get; set; }
        [DisplayName("Intitulé")]
        public string Intitule { get; set; }
        [DisplayName("Auteur")]
        public string Auteur { get; set; }
        public string Editeur { get; set; }
        public int Stock { get; set; }
        [DisplayName("Prix unitaire")]
        public double  Pu { get; set; }
        public string Extension { get; set; }
        public string CheminCouv { get; set; }

        public Livre(Domaine Dom, int CodeLiv, string ISBN, 
            string Intitule, string Auteur, string Editeur, int Stock, double  Pu,string extension,string cheminCouv)
        {
            this.domaine  = Dom ;
            this.CodeLivre = CodeLiv;
            this.ISBN = ISBN;
            this.Intitule = Intitule;
            this.Auteur = Auteur;
            this.Editeur = Editeur;
            this.Stock = Stock;
            this.Pu = Pu;
            this.Extension=extension ;
            this.CheminCouv=cheminCouv ;
        }

        public Livre(int CodeLiv)
        {
           
            this.CodeLivre = CodeLiv ;
          
        }

        public static List<Livre> operator +(List<Livre> liste, Livre  liv)
        {
            liste.Add(liv);
            return liste;
        }
    }
}

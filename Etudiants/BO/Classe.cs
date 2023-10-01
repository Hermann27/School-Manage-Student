using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BO
{
  
   public  class Classe
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
       [DisplayName("Code")]
       public String CodeClasse { get; set; }
       [DisplayName("Libellé")]
       public string Libele { get; set; }

       public Classe(string  code, string libele)
       {

           this.CodeClasse = code;
           this.Libele = libele;
       }

       public Classe(string code)
       {

           this.CodeClasse = code;
       }

       override
        public string ToString()
       {
           return this.CodeClasse;
       }

       public static List<Classe > operator +(List<Classe > liste, Classe classe)
       {
           liste.Add(classe);
           return liste;
       }

    }

}

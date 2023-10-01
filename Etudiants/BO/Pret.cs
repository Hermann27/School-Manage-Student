using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
    public class Pret
    {
        [DisplayName("Nom Etudiant")]
       public Etudiant etudiant { get; set; }
        [DisplayName("Titre livre")]
        public Livre livre { get; set; }
        [DisplayName("Numero du prêt")]
        public int NumPret { get; set; }
        [DisplayName("Date prêt")]
        public DateTime DatePret { get; set; }
        [DisplayName("Date Echéance")]
        public DateTime EcheancePret { get; set; }
        [DisplayName("Date Retour")]
        public DateTime DateRetour { get; set; }
        [DisplayName("Retourner")]
        public string RetourPret { get; set; }

        public Pret(Etudiant etud, Livre livre, int numpret, DateTime datepret,
            DateTime echeancepret, DateTime dateretour, string retourpret)
        {
            this.etudiant = etud;
            this.livre = livre;
            this.NumPret = numpret;
            this.DatePret = datepret;
            this.EcheancePret = echeancepret;
            this.DateRetour = dateretour;
            this.RetourPret = retourpret;
        }

        public Pret(int numpret)
        {
            this.NumPret = numpret;
        }
        public static List<Pret> operator +(List<Pret> liste, Pret pret)
        {
            liste.Add(pret);
            return liste;
        }
    }
}

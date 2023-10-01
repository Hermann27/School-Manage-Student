using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
   
    public class Etudiant
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }
        [DisplayName("classe")]
        public Classe classe { get; set; }
        [DisplayName("Filière")]
        public string  Code { get; set; }
        [DisplayName("Matricule")]
        public string Matricule { get; set; }
        [DisplayName("Nom")]
        public string NomEtud { get; set; }
        [DisplayName("Sexe")]
        public string SexeEtud { get; set; }
        [DisplayName("Téléphone")]
        public string TelEtud { get; set; }
        [DisplayName("Est à la cité")]
        public string cite { get; set; }
        [DisplayName("Date de naissance")]
        public DateTime DateNaiss { get; set; }
        [DisplayName("Lieu de naissance")]
        public string Lieu { get; set; }
        [DisplayName("Extension photo")]
        public string  ExtPhoto { get; set; }
        [DisplayName("Chemin Photo")]
        public string CheminPhoto { get; set; }

        public Etudiant(Classe classe, string matricule, string NomEtud, 
            string SexeEtud, string TelEtud, string cite, string Lieu, DateTime DateNaiss,string extphoto,
            string cheminphoto,DateTime datecreate,DateTime dateupdate,Utilisateur usercreate,Utilisateur userupdate)
        {
            this.classe = classe;
            this.Matricule = matricule;
            this.NomEtud = NomEtud;
            this.SexeEtud = SexeEtud;
            this.TelEtud = TelEtud;
            this.cite = cite;
            this.Lieu = Lieu;
            this.DateNaiss = DateNaiss;
            this.ExtPhoto = extphoto;
            this.CheminPhoto = cheminphoto;
            this.DateCreate = datecreate;
            this.DateUpdate = dateupdate;
            this.UserCreate = usercreate;
            this.UserUpdate = userupdate;
        }

        public Etudiant(Classe classe, string matricule, string NomEtud,
           string SexeEtud, string TelEtud, string cite, string Lieu, DateTime DateNaiss, string extphoto,
           string cheminphoto, DateTime datecreate, DateTime dateupdate)
        {
            this.classe = classe;
            this.Matricule = matricule;
            this.NomEtud = NomEtud;
            this.SexeEtud = SexeEtud;
            this.TelEtud = TelEtud;
            this.cite = cite;
            this.Lieu = Lieu;
            this.DateNaiss = DateNaiss;
            this.ExtPhoto = extphoto;
            this.CheminPhoto = cheminphoto;
            this.DateCreate = datecreate;
            this.DateUpdate = dateupdate;
        }
        public Etudiant(string matricule)
        {
           
            this.Matricule = matricule;
          
        }

        public static List<Etudiant > operator +(List<Etudiant > liste, Etudiant Etud)
        {
            liste.Add(Etud);
            return liste;
        }
    }
}

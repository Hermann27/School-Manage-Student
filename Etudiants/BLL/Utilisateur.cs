using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Utilisateur
    {
       public int Identifiant { get; set; }
       public Groupe Groupe { get; set; }
       public string Login { get; set; }
       public string PasseWord { get; set; }
       public string Nom { get; set; }
       public DateTime  DateLastConn { get; set; }
       public string Telephone { get; set; }
       public byte  Status { get; set; }
       public string Email { get; set; }
       public string Extension { get; set; }
       public string Photo { get; set; }
       public DateTime DateCreate { get; set; }
       public DateTime DateUpdate { get; set; }
       public Utilisateur  UserUpdate { get; set; }
       public Utilisateur  UserCreate { get; set; }
       public static Utilisateur connecte;
       public Utilisateur(int id, Groupe grp, string log, string passw, string nom, DateTime dlstCon, string tel, byte stat, string email,
                          string ext, string photo, DateTime dteCreat, DateTime dteUpdat, Utilisateur usrUp, Utilisateur usrCrea)
       {
           this.Groupe = grp;
           this.Identifiant = id;
           this.Login = log;
           this.Nom = nom;
           this.PasseWord = passw;
           this.Photo = photo;
           this.Status = stat;
           this.Telephone = tel;
           this.DateCreate = dteCreat;
           this.DateLastConn = dlstCon;
           this.DateUpdate = dteUpdat;
           this.UserCreate = usrCrea;
           this.UserUpdate = usrUp;
           this.Email = email;
           this.Extension = ext;

       }

       public Utilisateur(int id)
       {
           this.Identifiant = id;
       }

       override
        public string ToString()
       {
           return this.Nom;
       }
    }
}

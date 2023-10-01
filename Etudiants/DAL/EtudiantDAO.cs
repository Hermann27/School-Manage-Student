using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;
using TOOLS;
namespace DAL
{
    public class EtudiantDAO
    {
        public static string Add(Etudiant Etudiant)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("MAT", Etudiant.Matricule));
            parametres.Add(new MySQLParameter("NOM", Etudiant.NomEtud));
            parametres.Add(new MySQLParameter("SEXE", Etudiant.SexeEtud==null?(object)DBNull.Value:Etudiant.SexeEtud ));
            parametres.Add(new MySQLParameter("TEL", Etudiant.TelEtud==null?(object)DBNull.Value:Etudiant.TelEtud ));
            parametres.Add(new MySQLParameter("CIT", Etudiant.cite==null?(object)DBNull.Value:Etudiant.cite ));
            parametres.Add(new MySQLParameter("CODECL", Etudiant.classe.CodeClasse));
            parametres.Add(new MySQLParameter("DATEN", Etudiant.DateNaiss == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateNaiss));
            parametres.Add(new MySQLParameter("LIEUN", Etudiant.Lieu==null?(object)DBNull.Value:Etudiant.Lieu ));
            parametres.Add(new MySQLParameter("EXTN", Etudiant.ExtPhoto ==null?(object)DBNull.Value:Etudiant.ExtPhoto ));
            parametres.Add(new MySQLParameter("CHEN", Etudiant.CheminPhoto==null?(object)DBNull.Value:Etudiant.CheminPhoto ));
            parametres.Add(new MySQLParameter("idcre", Etudiant.UserCreate.Identifiant ));
            parametres.Add(new MySQLParameter("idup", Etudiant.UserUpdate.Identifiant));
            try
            {
                MyCon.Execute("SP_ETUDIANT_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new EtudiantException(ex.Message);
            }


        }

        public static string Edit(Etudiant OldEtudiant, Etudiant Etudiant)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("OLDMAT", OldEtudiant.Matricule));
            parametres.Add(new MySQLParameter("MAT", Etudiant.Matricule));
            parametres.Add(new MySQLParameter("NOM", Etudiant.NomEtud));
            parametres.Add(new MySQLParameter("SEXE", Etudiant.SexeEtud == null ? (object)DBNull.Value : Etudiant.SexeEtud));
            parametres.Add(new MySQLParameter("TEL", Etudiant.TelEtud == null ? (object)DBNull.Value : Etudiant.TelEtud));
            parametres.Add(new MySQLParameter("CIT", Etudiant.cite == null ? (object)DBNull.Value : Etudiant.cite));
            parametres.Add(new MySQLParameter("CODECL", Etudiant.classe.CodeClasse));
            parametres.Add(new MySQLParameter("DATEN", Etudiant.DateNaiss == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateNaiss));
            parametres.Add(new MySQLParameter("LIEUN", Etudiant.Lieu == null ? (object)DBNull.Value : Etudiant.Lieu));
            parametres.Add(new MySQLParameter("EXTN", Etudiant.ExtPhoto == null ? (object)DBNull.Value : Etudiant.ExtPhoto));
            parametres.Add(new MySQLParameter("CHEN", Etudiant.CheminPhoto == null ? (object)DBNull.Value : Etudiant.CheminPhoto));
            parametres.Add(new MySQLParameter("idcre", Etudiant.UserCreate.Identifiant ));
            parametres.Add(new MySQLParameter("idup", Etudiant.UserUpdate.Identifiant));
          
            try
            {
                MyCon.Execute("SP_ETUDIANT_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new EtudiantException(ex.Message);
            }


        }
        public static string Delete(Etudiant Etudiant)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("MAT", Etudiant.Matricule));
            try
            {
                MyCon.Execute("SP_ETUDIANT_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new EtudiantException(ex.Message);
            }


        }

        public static List<Etudiant> Find(Etudiant Etudiant)
        {
            MySQL MyCon = new MySQL("localhost","root","biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            
                parametres.Add(new MySQLParameter("MAT", Etudiant.Matricule!=null?Etudiant.Matricule:(object)DBNull.Value));
                parametres.Add(new MySQLParameter("NOM", Etudiant.NomEtud != null ? Etudiant.NomEtud  : (object)DBNull.Value));
                parametres.Add(new MySQLParameter("SEXE", Etudiant.SexeEtud != null ? Etudiant.SexeEtud  : (object)DBNull.Value));
                parametres.Add(new MySQLParameter("TEL", Etudiant.TelEtud != null ? Etudiant.TelEtud  : (object)DBNull.Value));
                parametres.Add(new MySQLParameter("CIT", Etudiant.cite != null ? Etudiant.cite  : (object)DBNull.Value));
                parametres.Add(new MySQLParameter("CODECL", (Etudiant.classe!=null && Etudiant.classe.CodeClasse!=null)?Etudiant.classe.CodeClasse:(object)DBNull.Value ));
                parametres.Add(new MySQLParameter("DATEN", Etudiant.DateNaiss==Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value  : Etudiant.DateNaiss));
                parametres.Add(new MySQLParameter("LIEUN", Etudiant.Lieu!=null?Etudiant.Lieu:(object)DBNull.Value));
                parametres.Add(new MySQLParameter("idcre", (Etudiant.UserCreate!=null && Etudiant.UserCreate.Identifiant!=0)?Etudiant.UserCreate.Identifiant:(object)DBNull.Value));
                parametres.Add(new MySQLParameter("idup", (Etudiant.UserUpdate!=null && Etudiant.UserUpdate.Identifiant!=0)?Etudiant.UserUpdate.Identifiant:(object)DBNull.Value ));
                parametres.Add(new MySQLParameter("dtcre", Etudiant.DateCreate ==Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value  : Etudiant.DateCreate ));
                parametres.Add(new MySQLParameter("dtup", Etudiant.DateUpdate == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateUpdate ));

            try
            {
                List<Etudiant> listeCl = new List<Etudiant>();
                var reader = MyCon.GetReader("SP_ETUDIANT_SELECT", parametres);
                while (reader.Read())
                {
                    Etudiant cl = null;
                     cl = new Etudiant(ClasseDAO.Find(new Classe(Convert.ToString(reader["codeClasse"]), null)).FirstOrDefault(),
                    Convert.ToString(reader["matricule"]), Convert.ToString(reader["nomEtud"]),
                    Convert.ToString(reader["sexeEtud"]), Convert.ToString(reader["telEtud"]),
                    Convert.ToString(reader["cite"]), reader["Lieu"] == DBNull.Value ? "" : Convert.ToString(reader["Lieu"]),
                    reader["DateNaiss"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["DateNaiss"]), Convert.ToString(reader["ExtPhoto"]), Convert.ToString(reader["CheminPhoto"]), DateTime.Now, DateTime.Now);
                    cl.UserCreate=UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdCreateur"])));
                    cl.UserUpdate= UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdModificateur"])));
                    listeCl = listeCl + cl;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new EtudiantException(ex.Message);
            }


        }

        public static DataSet FindDataSet(Etudiant Etudiant)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();

            parametres.Add(new MySQLParameter("MAT", Etudiant.Matricule != null ? Etudiant.Matricule : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("NOM", Etudiant.NomEtud != null ? Etudiant.NomEtud : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("SEXE", Etudiant.SexeEtud != null ? Etudiant.SexeEtud : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("TEL", Etudiant.TelEtud != null ? Etudiant.TelEtud : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("CIT", Etudiant.cite != null ? Etudiant.cite : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("CODECL", (Etudiant.classe != null && Etudiant.classe.CodeClasse != null) ? Etudiant.classe.CodeClasse : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("DATEN", Etudiant.DateNaiss == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateNaiss));
            parametres.Add(new MySQLParameter("LIEUN", Etudiant.Lieu != null ? Etudiant.Lieu : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idcre", (Etudiant.UserCreate != null && Etudiant.UserCreate.Identifiant != 0) ? Etudiant.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (Etudiant.UserUpdate != null && Etudiant.UserUpdate.Identifiant != 0) ? Etudiant.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("dtcre", Etudiant.DateCreate == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateCreate));
            parametres.Add(new MySQLParameter("dtup", Etudiant.DateUpdate == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : Etudiant.DateUpdate));

            try
            {
                List<Etudiant> listeCl = new List<Etudiant>();
               
                return MyCon.GetDataSet("SP_ETUDIANT_SELECT", parametres,"Etudiant");
            }
            catch (Exception ex)
            {
                throw new EtudiantException(ex.Message);
            }


        }
    }
}

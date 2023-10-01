using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
   public class UtilisateurDAO
    {
        public static string Add(Utilisateur  user)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", user.Groupe.Identifiant ));
            parametres.Add(new MySQLParameter("log", user.Login));
            parametres.Add(new MySQLParameter("passw", user.PasseWord));
            parametres.Add(new MySQLParameter("nomu", user.Nom));
            parametres.Add(new MySQLParameter("dateder", user.DateLastConn != Convert.ToDateTime("01/01/0001 00:00:00") ? user.DateLastConn  : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("telu", user.Telephone==null?(object)DBNull.Value:user.Telephone ));
            parametres.Add(new MySQLParameter("statu", user.Status ));
            parametres.Add(new MySQLParameter("emailu", user.Email  == null ? (object)DBNull.Value : user.Email ));
            parametres.Add(new MySQLParameter("datecre", user.DateCreate ));
            parametres.Add(new MySQLParameter("dateup", user.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", user.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", user.UserUpdate.Identifiant));
            parametres.Add(new MySQLParameter("phot", user.Photo == null ? (object)DBNull.Value : user.Photo ));
            parametres.Add(new MySQLParameter("extp", user.Extension  == null ? (object)DBNull.Value : user.Extension ));
            try
            {
                MyCon.Execute("SP_USER_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new UtilisateurException(ex.Message);
            }


        }

        public static string Edit(Utilisateur user)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idu", user.Identifiant ));
            parametres.Add(new MySQLParameter("idg", user.Groupe.Identifiant));
            parametres.Add(new MySQLParameter("log", user.Login));
            parametres.Add(new MySQLParameter("passw", user.PasseWord));
            parametres.Add(new MySQLParameter("nomu", user.Nom));
            parametres.Add(new MySQLParameter("dateder", user.DateLastConn != Convert.ToDateTime("01/01/0001 00:00:00") ? user.DateLastConn : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("telu", user.Telephone == null ? (object)DBNull.Value : user.Telephone));
            parametres.Add(new MySQLParameter("statu", user.Status));
            parametres.Add(new MySQLParameter("emailu", user.Email == null ? (object)DBNull.Value : user.Email));
            parametres.Add(new MySQLParameter("datecre", user.DateCreate));
            parametres.Add(new MySQLParameter("dateup", user.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", user.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", user.UserUpdate.Identifiant));
            parametres.Add(new MySQLParameter("phot", user.Photo == null ? (object)DBNull.Value : user.Photo));
            parametres.Add(new MySQLParameter("extp", user.Extension == null ? (object)DBNull.Value : user.Extension));

            try
            {
                MyCon.Execute("SP_USER_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new UtilisateurException(ex.Message);
            }


        }
        public static string Delete(Utilisateur  user)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idu", user.Identifiant));
            parametres.Add(new MySQLParameter("idDel", 1));
            try
            {
                MyCon.Execute("SP_USER_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new UtilisateurException(ex.Message);
            }


        }

        public static List<Utilisateur > Find(Utilisateur  user)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();

            parametres.Add(new MySQLParameter("idu", user.Identifiant!=0?user.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idg",(user.Groupe!=null && user.Groupe.Identifiant!=0)?user.Groupe.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("log", user.Login!=null?user.Login:(object)DBNull.Value));
            parametres.Add(new MySQLParameter("passw", user.PasseWord!=null?user.PasseWord:(object)DBNull.Value));
            parametres.Add(new MySQLParameter("nomu", user.Nom!=null?user.Nom:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("dateder", user.DateLastConn != Convert.ToDateTime("01/01/0001 00:00:00") ? user.DateLastConn : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("telu", user.Telephone == null ? (object)DBNull.Value : user.Telephone));
            parametres.Add(new MySQLParameter("statu", user.Status!=0?user.Status:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("emailu", user.Email == null ? (object)DBNull.Value : user.Email));
            parametres.Add(new MySQLParameter("datecre", user.DateCreate != Convert.ToDateTime("01/01/0001 00:00:00")?user.DateCreate:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("dateup", user.DateUpdate != Convert.ToDateTime("01/01/0001 00:00:00")?user.DateUpdate:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idcre", (user.UserCreate!=null  && user.UserCreate.Identifiant!=0)?user.UserCreate.Identifiant:(object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (user.UserUpdate != null && user.UserUpdate.Identifiant != 0) ? user.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("phot", user.Photo == null ? (object)DBNull.Value : user.Photo));
            parametres.Add(new MySQLParameter("extp", user.Extension == null ? (object)DBNull.Value : user.Extension));

            try
            {
                List<Utilisateur> listeCl = new List<Utilisateur>();
                var reader = MyCon.GetReader("SP_USER_SELECT", parametres);
                while (reader.Read())
                {
                    object t = reader["Photo"];
                    Utilisateur use = null;
                    use = new Utilisateur(Convert.ToInt32(reader["Id"]), GroupeDAO.Find(new Groupe(Convert.ToInt32(reader["IdGroupe"]))).FirstOrDefault(), Convert.ToString(reader["Compte"]),
                                           Convert.ToString(reader["Passe"]), Convert.ToString(reader["Nom"]),reader["DateDernierConnexion"].Equals(DBNull.Value)?Convert.ToDateTime(null): Convert.ToDateTime(reader["DateDernierConnexion"]),
                                           Convert.ToString(reader["Telephone"]), Convert.ToByte(reader["Statut"]), Convert.ToString(reader["Email"]),
                                           reader["PhotoExtension"].Equals(DBNull.Value)?null:Convert.ToString(reader["PhotoExtension"]),reader["Photo"].Equals(DBNull.Value)?null: Convert.ToString(reader["Photo"]), Convert.ToDateTime(reader["DateCreation"]), Convert.ToDateTime(reader["DateModification"]));
                    listeCl = listeCl + use;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new UtilisateurException(ex.Message);
            }


        }


        public static Utilisateur GetUser(Utilisateur user)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");

            try
            {

                var reader = MyCon.GetReader("SELECT * FROM Utilisateur WHERE Id=" + user.Identifiant);
                
                Utilisateur use = null;
                while (reader.Read())
                {
                    
                    use = new Utilisateur(Convert.ToInt32(reader["Id"]), GroupeDAO.Find(new Groupe(Convert.ToInt32(reader["IdGroupe"]))).FirstOrDefault(), Convert.ToString(reader["Compte"]),
                                           Convert.ToString(reader["Passe"]), Convert.ToString(reader["Nom"]),reader["DateDernierConnexion"]==null?Convert.ToDateTime(null): Convert.ToDateTime(reader["DateDernierConnexion"]),
                                           Convert.ToString(reader["Telephone"]), Convert.ToByte(reader["Statut"]), Convert.ToString(reader["Email"]),
                                           reader["PhotoExtension"].Equals(DBNull.Value)?null:Convert .ToString(reader["PhotoExtension"]),reader["Photo"].Equals(DBNull.Value)?null: Convert.ToString(reader["Photo"]), reader["DateCreation"] == null ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["DateCreation"]),reader["DateModification"]==null?Convert.ToDateTime(null): Convert.ToDateTime(reader["DateModification"]));
                }
                return use;
            }
            catch (Exception ex)
            {
                throw new UtilisateurException(ex.Message);
            }


        }
    }
}

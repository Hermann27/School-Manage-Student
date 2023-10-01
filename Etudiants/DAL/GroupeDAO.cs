using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class GroupeDAO
    {
        public static string Add(Groupe groupe)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("intig", groupe.Intitule ));
            parametres.Add(new MySQLParameter("datecre", groupe.DateCreate));
            parametres.Add(new MySQLParameter("dateup", groupe.DateUpdate ));
            parametres.Add(new MySQLParameter("idcre", (groupe.UserCreate != null && groupe.UserCreate.Identifiant != 0) ? groupe.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (groupe.UserUpdate != null && groupe.UserUpdate.Identifiant != 0) ? groupe.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("statu", groupe.Status));
           
            try
            {
                MyCon.Execute("SP_GROUPE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new GroupeException(ex.Message);
            }


        }

        public static string Edit(Groupe  groupe)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", groupe.Identifiant ));
            parametres.Add(new MySQLParameter("intig", groupe.Intitule));
            parametres.Add(new MySQLParameter("datecre", groupe.DateCreate));
            parametres.Add(new MySQLParameter("dateup", groupe.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", (groupe.UserCreate != null && groupe.UserCreate.Identifiant != 0) ? groupe.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (groupe.UserUpdate != null && groupe.UserUpdate.Identifiant != 0) ? groupe.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("statu", groupe.Status));

            try
            {
                MyCon.Execute("SP_GROUPE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new GroupeException(ex.Message);
            }


        }
        public static string Delete(Groupe  groupe)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", groupe.Identifiant ));
            try
            {
                MyCon.Execute("SP_GROUPE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new GroupeException(ex.Message);
            }


        }

        public static List<Groupe> Find(Groupe  groupe)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", groupe.Identifiant!=0?groupe.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("intig", groupe.Intitule != null ? groupe.Intitule : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("datecre", groupe.DateCreate != Convert.ToDateTime("01-01-0001 00:00:00") ? groupe.DateCreate : (object)DBNull.Value ));
            parametres.Add(new MySQLParameter("dateup", groupe.DateUpdate != Convert.ToDateTime("01-01-0001 00:00:00")?groupe.DateUpdate:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idcre", (groupe.UserCreate != null && groupe.UserCreate.Identifiant != 0) ? groupe.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (groupe.UserUpdate != null && groupe.UserUpdate.Identifiant != 0) ? groupe.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("statu", groupe.Status!=0?groupe.Status:(object)DBNull.Value));

            try
            {
                List<Groupe> listeCl = new List<Groupe>();
                var reader = MyCon.GetReader("SP_GROUPE_SELECT", parametres);
                while (reader.Read())
                {
                    Groupe grp = null;
                    grp = new Groupe(Convert.ToInt32(reader["Id"]),Convert.ToString(reader["Intitule"]),Convert.ToByte(reader["Statut"]),Convert.ToDateTime(reader["DateCreation"]),
                                    Convert.ToDateTime(reader["DateModification"]));
                   // grp.UserCreate = UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdCreateur"])));
                   //grp.UserUpdate = UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdModificateur"])));
                    listeCl = listeCl + grp;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new GroupeException(ex.Message);
            }


        }


        public static List<Groupe> FindUs(Groupe groupe)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", groupe.Identifiant != 0 ? groupe.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("intig", groupe.Intitule != null ? groupe.Intitule : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("datecre", groupe.DateCreate != Convert.ToDateTime("01-01-0001 00:00:00") ? groupe.DateCreate : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("dateup", groupe.DateUpdate != Convert.ToDateTime("01-01-0001 00:00:00") ? groupe.DateUpdate : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idcre", (groupe.UserCreate != null && groupe.UserCreate.Identifiant != 0) ? groupe.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (groupe.UserUpdate != null && groupe.UserUpdate.Identifiant != 0) ? groupe.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("statu", groupe.Status != 0 ? groupe.Status : (object)DBNull.Value));

            try
            {
                List<Groupe> listeCl = new List<Groupe>();
                var reader = MyCon.GetReader("SP_GROUPE_SELECT", parametres);
                while (reader.Read())
                {
                    Groupe grp = null;
                    grp = new Groupe(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Intitule"]), Convert.ToByte(reader["Statut"]), Convert.ToDateTime(reader["DateCreation"]),
                                    Convert.ToDateTime(reader["DateModification"]), UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdModificateur"]))),
                                    UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdCreateur"]))));
                    listeCl = listeCl + grp;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new GroupeException(ex.Message);
            }


        }
    }
}

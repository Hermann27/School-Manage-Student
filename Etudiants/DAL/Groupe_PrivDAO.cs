using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class Groupe_PrivDAO
    {
        public static string Add(Groupe_Privilege  gr_priv)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg",gr_priv.groupe.Identifiant ));
            parametres.Add(new MySQLParameter("idm", gr_priv.privilege.Identifiant));
            parametres.Add(new MySQLParameter("statu", gr_priv.Status));
            parametres.Add(new MySQLParameter("datecre", gr_priv.DateCreate));
            parametres.Add(new MySQLParameter("dateup", gr_priv.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", gr_priv.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", gr_priv.UserUpdate.Identifiant));

            try
            {
                MyCon.Execute("SP_GROUPE_PRIVILEGE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new Groupe_PrivException(ex.Message);
            }


        }

        public static string Edit(Groupe_Privilege gr_priv, Groupe_Privilege oldgr_priv)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("oldidg", oldgr_priv.groupe.Identifiant));
            parametres.Add(new MySQLParameter("oldidm", oldgr_priv.privilege.Identifiant));
            parametres.Add(new MySQLParameter("idg", gr_priv.groupe.Identifiant));
            parametres.Add(new MySQLParameter("idm", gr_priv.privilege.Identifiant));
            parametres.Add(new MySQLParameter("statu", gr_priv.Status));
            parametres.Add(new MySQLParameter("datecre", gr_priv.DateCreate));
            parametres.Add(new MySQLParameter("dateup", gr_priv.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", gr_priv.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", gr_priv.UserUpdate.Identifiant));

            try
            {
                MyCon.Execute("SP_GROUPE_PRIVILEGE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new Groupe_PrivException(ex.Message);
            }


        }
        public static string Delete(Groupe_Privilege gr_priv)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", gr_priv.groupe.Identifiant));
            parametres.Add(new MySQLParameter("idm", gr_priv.privilege.Identifiant));
            try
            {
                MyCon.Execute("SP_GROUPE_PRIVILEGE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new Groupe_PrivException(ex.Message);
            }


        }

        public static List<Groupe_Privilege> Find(Groupe_Privilege grp_priv)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("idg", (grp_priv.groupe!=null && grp_priv.groupe.Identifiant!=0)?grp_priv.groupe.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idm", (grp_priv.privilege != null && grp_priv.privilege.Identifiant!=0)?grp_priv.privilege.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("datecre", grp_priv.DateCreate != Convert.ToDateTime("01-01-0001 00:00:00") ? grp_priv.DateCreate : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("dateup", grp_priv.DateUpdate != Convert.ToDateTime("01-01-0001 00:00:00") ? grp_priv.DateUpdate : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idcre", (grp_priv.UserCreate != null && grp_priv.UserCreate.Identifiant != 0) ? grp_priv.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (grp_priv.UserUpdate != null && grp_priv.UserUpdate.Identifiant != 0) ? grp_priv.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("statu", grp_priv.Status != 0 ? grp_priv.Status : (object)DBNull.Value));

            try
            {
                List<Groupe_Privilege> listeCl = new List<Groupe_Privilege>();
                var reader = MyCon.GetReader("SP_GROUPE_PRIVILEGE_SELECT", parametres);
                while (reader.Read())
                {
                    Groupe_Privilege grp_p = null;
                    grp_p = new Groupe_Privilege(GroupeDAO.Find(new Groupe(Convert.ToInt32(reader["IdGroupe"]))).FirstOrDefault(),PrivilegeDAO.Find(new Privilege(Convert.ToInt32(reader["IdMenu"]))).FirstOrDefault(),
                                               Convert.ToByte(reader["Statut"]),Convert.ToDateTime(reader["DateCreation"]),Convert.ToDateTime(reader["DateModification"]),
                                               UtilisateurDAO.Find(new Utilisateur(Convert.ToInt32(reader["IdModificateur"]))).FirstOrDefault(),
                                               UtilisateurDAO.Find(new Utilisateur(Convert.ToInt32(reader["IdModificateur"]))).FirstOrDefault());
                    listeCl = listeCl + grp_p;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new Groupe_PrivException(ex.Message);
            }


        }
    }
}

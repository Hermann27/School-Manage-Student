using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class PrivilegeDAO
    {
        public static string Add(Privilege  privileg)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("intipriv", privileg.Intitule ));
            parametres.Add(new MySQLParameter("datecre", privileg.DateCreate ));
            parametres.Add(new MySQLParameter("dateup", privileg.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", privileg.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", privileg.UserUpdate.Identifiant));
            try
            {
                MyCon.Execute("SP_PRIVILEGE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PrivilegeException(ex.Message);
            }


        }

        public static string Edit( Privilege  privileg)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("Id", privileg.Identifiant));
            parametres.Add(new MySQLParameter("intipriv", privileg.Intitule));
            parametres.Add(new MySQLParameter("datecre", privileg.DateCreate));
            parametres.Add(new MySQLParameter("dateup", privileg.DateUpdate));
            parametres.Add(new MySQLParameter("idcre", privileg.UserCreate.Identifiant));
            parametres.Add(new MySQLParameter("idup", privileg.UserUpdate.Identifiant));

            try
            {
                MyCon.Execute("SP_PRIVILEGE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PrivilegeException(ex.Message);
            }


        }
        public static string Delete(Privilege  privileg)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("Id", privileg.Identifiant));
            try
            {
                MyCon.Execute("SP_PRIVILEGE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PrivilegeException(ex.Message);
            }


        }

        public static List<Privilege> Find(Privilege  privileg)
        {
            MySQL MyCon = new MySQL("localhost", "root", "biblio");
            List<MySQLParameter> parametres = new List<MySQLParameter>();

            parametres.Add(new MySQLParameter("Id", privileg.Identifiant!=0?privileg.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("intipriv", privileg.Intitule!=null?privileg.Intitule:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("datecre", privileg.DateCreate != Convert.ToDateTime("01/01/0001 00:00:00")?privileg.DateCreate : (object)DBNull.Value ));
            parametres.Add(new MySQLParameter("dateup", privileg.DateUpdate != Convert.ToDateTime("01/01/0001 00:00:00")?privileg.DateUpdate:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idcre", privileg.UserCreate.Identifiant!=0?privileg.UserCreate.Identifiant:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("idup", privileg.UserUpdate.Identifiant!=0?privileg.UserUpdate.Identifiant:(object)DBNull.Value ));

            try
            {
                List<Privilege > listeCl = new List<Privilege >();
                var reader = MyCon.GetReader("SP_PRIVILEGE_SELECT", parametres);
                while (reader.Read())
                {
                    Privilege  cl = null;
                    cl = new Privilege (Convert.ToInt32(reader["Id"]),Convert.ToString(reader["Intitule"]),Convert.ToDateTime(reader["DateCreation"]),
                                        Convert.ToDateTime(reader["DateModification"]),UtilisateurDAO.Find(new Utilisateur(Convert.ToInt32(reader["IdModificateur"]))).FirstOrDefault(),
                                        UtilisateurDAO.Find(new Utilisateur(Convert.ToInt32(reader["IdCreateur"]))).FirstOrDefault());
                    listeCl = listeCl + cl;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new PrivilegeException(ex.Message);
            }


        }
    }
}

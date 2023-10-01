using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class PretDAO
    {
        public static string Add(Pret Pret)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumP", Pret.NumPret));
            parametres.Add(new MySQLParameter("DateP", Pret.DatePret));
            parametres.Add(new MySQLParameter("EcheanP", Pret.EcheancePret));
            parametres.Add(new MySQLParameter("RetourP", Pret.RetourPret==null?(object)DBNull.Value:Pret.RetourPret ));
            parametres.Add(new MySQLParameter("DateRP", Pret.DateRetour == Convert.ToDateTime("01/01/0001 00:00:00")?(object)DBNull.Value:Pret.DateRetour ));
            parametres.Add(new MySQLParameter("Mat", Pret.etudiant.Matricule));
            parametres.Add(new MySQLParameter("CodeLivre", Pret.livre.CodeLivre));
            try
            {
                MyCon.Execute("SP_PRET_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PretException(ex.Message);
            }


        }

        public static string Edit(Pret OldPret, Pret Pret)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumP", Pret.NumPret));
            parametres.Add(new MySQLParameter("OLDNumP", OldPret.NumPret));
            parametres.Add(new MySQLParameter("DateP", Pret.DatePret));
            parametres.Add(new MySQLParameter("EcheanP", Pret.EcheancePret));
            parametres.Add(new MySQLParameter("RetourP", Pret.RetourPret == null ? (object)DBNull.Value : Pret.RetourPret));
            parametres.Add(new MySQLParameter("DateRP", Pret.DateRetour == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : Pret.DateRetour));
            parametres.Add(new MySQLParameter("Mat", Pret.etudiant.Matricule));
            parametres.Add(new MySQLParameter("CodeLivre", Pret.livre.CodeLivre));
            try
            {
                MyCon.Execute("SP_PRET_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PretException(ex.Message);
            }


        }
        public static string Delete(Pret Pret)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumP", Pret.NumPret));
            try
            {
                MyCon.Execute("SP_PRET_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new PretException(ex.Message);
            }


        }

        public static List<Pret> Find(Pret Pret)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumP", Pret.NumPret!=0?Pret.NumPret : (object)DBNull.Value ));
            parametres.Add(new MySQLParameter("DateP", Pret.DatePret.Equals(DBNull.Value) ? (object)DBNull.Value : Pret.DatePret));
            parametres.Add(new MySQLParameter("EcheanP", Pret.EcheancePret.Equals(DBNull.Value) ? (object)DBNull.Value : Pret.EcheancePret));
            parametres.Add(new MySQLParameter("RetourP", Pret.RetourPret!=null?Pret.RetourPret:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("DateRP", Pret.DateRetour.Equals(DBNull.Value) ? (object)DBNull.Value : Pret.DateRetour));
            parametres.Add(new MySQLParameter("Mat", (Pret.etudiant!=null && Pret.etudiant.Matricule!=null)?Pret.etudiant.Matricule:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("CodeLivreL", (Pret.livre != null && Pret.livre.CodeLivre != 0) ? Pret.livre.CodeLivre : (object)DBNull.Value));
            try
            {
                List<Pret> listeCl = new List<Pret>();
                var reader = MyCon.GetReader("SP_PRET_SELECT", parametres);
                while (reader.Read())
                {
                    
                   
                    Pret cl = new Pret(EtudiantDAO.Find(new Etudiant(Convert.ToString(reader["Matricule"]))).FirstOrDefault(),
                                                                     LivreDAO.Find(new Livre(Convert.ToInt32(reader["CodeLivre"]))).FirstOrDefault(),
                                                                     Convert.ToInt16(reader["numPret"]), Convert.ToDateTime(reader["datePret"]),
                                                                     Convert.ToDateTime(reader["EcheancePret"]), (reader["dateRetour"]).Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["dateRetour"]), Convert.ToString(reader["retour"]));

                    listeCl = listeCl + cl;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new PretException(ex.Message);
            }


        }

       
    }
}

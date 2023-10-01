using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class EntreeLivreDAO
    {
        public static string Add(EntreeLivre  entreelivre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NUMB", entreelivre.entree.NumBord));
            parametres.Add(new MySQLParameter("CodeL", entreelivre.livre.CodeLivre));
            parametres.Add(new MySQLParameter("QTE",entreelivre.QteEntree ));
            parametres.Add(new MySQLParameter("PU", entreelivre.PuEntree));
            
            try
            {
                MyCon.Execute("SP_ENTREES_LIVRE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static string Edit(EntreeLivre  Oldentreelivre, EntreeLivre  entreelivre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("OLDNUMB",  Oldentreelivre.entree.NumBord ));
            parametres.Add(new MySQLParameter("NUMB", entreelivre.entree.NumBord));
            parametres.Add(new MySQLParameter("CodeL", entreelivre.livre.CodeLivre));
            parametres.Add(new MySQLParameter("OLDCodeL", Oldentreelivre.livre.CodeLivre));
            parametres.Add(new MySQLParameter("QTE", entreelivre.QteEntree));
            parametres.Add(new MySQLParameter("PU",entreelivre.PuEntree));
            try
            {
                MyCon.Execute("SP_ENTREES_LIVRE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }
        public static string Delete(EntreeLivre  entreelivre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NUMB", entreelivre.entree.NumBord ));
            parametres.Add(new MySQLParameter("CodeL", entreelivre.livre.CodeLivre));
            try
            {
                MyCon.Execute("SP_ENTREES_LIVRE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static List<EntreeLivre > Find(EntreeLivre  entreelivre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NUMB", (entreelivre.entree != null && entreelivre.entree.NumBord != 0) ? entreelivre.entree.NumBord : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("CodeL", (entreelivre.livre != null && entreelivre.livre.CodeLivre != 0) ? entreelivre.livre.CodeLivre : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("QTE", entreelivre.QteEntree != 0 ? entreelivre.QteEntree : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("PU", entreelivre.PuEntree != 0 ? entreelivre.PuEntree : (object)DBNull.Value));
            try
            {
                List<EntreeLivre> listeentl = new List<EntreeLivre>();
                var reader = MyCon.GetReader("SP_ENTREES_LIVRE_SELECT", parametres);
                while (reader.Read())
                {
                    EntreeLivre cl = new EntreeLivre(EntreeDAO.Find(new Entree(Convert.ToInt32(reader["NumBord"]))).FirstOrDefault(), 
                        LivreDAO.Find(new Livre(Convert.ToInt32(reader["NumBord"]))).FirstOrDefault(), 
                        Convert.ToInt32(reader["PuEntree"]), Convert.ToInt32(reader["QteEntree"]));
                    listeentl = listeentl + cl;
                }
                return listeentl;
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

      
    }
}

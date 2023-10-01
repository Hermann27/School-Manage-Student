using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class LivreDAO
    {
        public static string Add(Livre Livre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("codeLivre", Livre.CodeLivre));
            parametres.Add(new MySQLParameter("ISBN", Livre.ISBN==null?(object)DBNull.Value:Livre.ISBN));
            parametres.Add(new MySQLParameter("intitule", Livre.Intitule));
            parametres.Add(new MySQLParameter("auteur", Livre.Auteur));
            parametres.Add(new MySQLParameter("editeur", Livre.Editeur));
            parametres.Add(new MySQLParameter("stock", Livre.Stock==0?(object)DBNull.Value:Livre.Stock));
            parametres.Add(new MySQLParameter("pu", Livre.Pu==0?(object)DBNull.Value:Livre.Pu));
            parametres.Add(new MySQLParameter("numDom", Livre.domaine.NumDom));
            parametres.Add(new MySQLParameter("ExtCouverture", Livre.Extension==null?(object)DBNull.Value:Livre.Extension ));
            parametres.Add(new MySQLParameter("CheminCouv", Livre.CheminCouv==null?(object)DBNull.Value:Livre.CheminCouv));
            try
            {
                MyCon.Execute("SP_LIVRE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static string Edit(Livre OldLivre, Livre Livre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("codeLivre", Livre.CodeLivre));
            parametres.Add(new MySQLParameter("OLDCodeLivre", OldLivre.CodeLivre));
            parametres.Add(new MySQLParameter("ISBN", Livre.ISBN == null ? (object)DBNull.Value : Livre.ISBN));
            parametres.Add(new MySQLParameter("intitule", Livre.Intitule));
            parametres.Add(new MySQLParameter("auteur", Livre.Auteur));
            parametres.Add(new MySQLParameter("editeur", Livre.Editeur));
            parametres.Add(new MySQLParameter("stock", Livre.Stock == 0 ? (object)DBNull.Value : Livre.Stock));
            parametres.Add(new MySQLParameter("pu", Livre.Pu == 0 ? (object)DBNull.Value : Livre.Pu));
            parametres.Add(new MySQLParameter("numDom", Livre.domaine.NumDom));
            parametres.Add(new MySQLParameter("ExtCouverture", Livre.Extension == null ? (object)DBNull.Value : Livre.Extension));
            parametres.Add(new MySQLParameter("CheminCouv", Livre.CheminCouv == null ? (object)DBNull.Value : Livre.CheminCouv));
  
            try
            {
                MyCon.Execute("SP_LIVRE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }
        public static string Delete(Livre Livre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("CodeLivre", Livre.CodeLivre));
            try
            {
                MyCon.Execute("SP_LIVRE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static List<Livre> Find(Livre Livre)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("CodeLivreL", Livre.CodeLivre != 0 ? Livre.CodeLivre : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("ISBNL", Livre.ISBN != null ? Livre.ISBN : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("IntituleL", Livre.Intitule != null ? Livre.Intitule : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("AuteurL", Livre.Auteur != null ? Livre.Auteur : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("EditeurL", Livre.Editeur != null ? Livre.Editeur : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("StockL", Livre.Stock != 0 ? Livre.Stock : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("PUL", Livre.Pu != 0 ? Livre.Pu : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("NumDomL", (Livre.domaine != null && Livre.domaine.NumDom != 0) ? Livre.domaine.NumDom : (object)DBNull.Value));
            try
            {
                List<Livre> listeCl = new List<Livre>();
                var reader = MyCon.GetReader("SP_LIVRE_SELECT", parametres);
                while (reader.Read())
                {
                    Livre cl = new Livre(DomaineDAO.Find(new Domaine(Convert.ToInt32(reader["numDom"]), null)).FirstOrDefault(),
                                                                     Convert.ToInt16(reader["codeLivre"]), Convert.ToString(reader["ISBN"]),
                                                                     Convert.ToString(reader["intitule"]), Convert.ToString(reader["auteur"]),
                                                                     Convert.ToString(reader["editeur"]), Convert.ToInt32(reader["stock"]),
                                                                     Convert.ToDouble(reader["pu"]), Convert.ToString(reader["ExtCouverture"]), Convert.ToString(reader["CheminCouv"]));
                    listeCl = listeCl + cl;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

       
    }
}

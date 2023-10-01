using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class DomaineDAO
    {
        public static string Add(Domaine domaine)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumD", domaine.NumDom == 0 ? (object)DBNull.Value : domaine.NumDom));
            parametres.Add(new MySQLParameter("NOM", domaine.NomDom == null ? (object)DBNull.Value : domaine.NomDom));
            try
            {
                MyCon.Execute("SP_DOMAINE_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new DomaineException(ex.Message);
            }


        }

        public static string Edit(Domaine Olddomaine, Domaine domaine)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("OLDNumD", Olddomaine.NumDom));
            parametres.Add(new MySQLParameter("NumD", domaine.NumDom));
            parametres.Add(new MySQLParameter("NOM", domaine.NomDom));
            try
            {
                MyCon.Execute("SP_DOMAINE_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new DomaineException(ex.Message);
            }


        }
        public static string Delete(Domaine domaine)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumD", domaine.NumDom));
            try
            {
                MyCon.Execute("SP_DOMAINE_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new DomaineException(ex.Message);
            }


        }

        public static List<Domaine> Find(Domaine domaine)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumD", domaine.NumDom!=0?domaine.NumDom:(object)DBNull.Value ));
            parametres.Add(new MySQLParameter("NOM", domaine.NomDom!=null?domaine.NomDom:(object)DBNull.Value ));
            try
            {
                List<Domaine> listeCl = new List<Domaine>();
                var reader = MyCon.GetReader("SP_DOMAINE_SELECT", parametres);
                while (reader.Read())
                {
                    Domaine cl = new Domaine(Convert.ToInt32(reader["NumDom"]), Convert.ToString(reader["NomDom"]));
                    listeCl = listeCl + cl;
                }
                return listeCl;
            }
            catch (Exception ex)
            {
                throw new DomaineException(ex.Message);
            }


        }

        
    }
}

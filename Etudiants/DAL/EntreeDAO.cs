using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class EntreeDAO
    {
        public static string Add(Entree  entree)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumB", entree.NumBord == 0 ? (object)DBNull.Value : entree.NumBord));
            parametres.Add(new MySQLParameter("DATEB", entree.DateBord == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : entree.DateBord));
            parametres.Add(new MySQLParameter("NOMF", entree.NomFsseur==null?(object)DBNull.Value:entree.NomFsseur ));
            try
            {
                MyCon.Execute("SP_ENTREES_INSERT", parametres);
                return "Enregistrement Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static string Edit(Entree  Oldentree, Entree  entree)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("OLDNumB", Oldentree.NumBord));
            parametres.Add(new MySQLParameter("NumB", entree.NumBord));
            parametres.Add(new MySQLParameter("DATEB", entree.DateBord == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : entree.DateBord));
            parametres.Add(new MySQLParameter("NOMF", entree.NomFsseur == null ? (object)DBNull.Value : entree.NomFsseur));
            try
            {
                MyCon.Execute("SP_ENTREES_UPDATE", parametres);
                return "Modification Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }
        public static string Delete(Entree  entree)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NUMB", entree.NumBord ));
            try
            {
                MyCon.Execute("SP_ENTREES_DELETE", parametres);
                return "Suppression Effectué Avec succès !";
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        public static List<Entree > Find(Entree  entree)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("NumB", entree.NumBord == 0 ? (object)DBNull.Value : entree.NumBord));
            parametres.Add(new MySQLParameter("DATEB", entree.DateBord == Convert.ToDateTime("01/01/0001 00:00:00") ? (object)DBNull.Value : entree.DateBord));
            parametres.Add(new MySQLParameter("NOMF", entree.NomFsseur == null ? (object)DBNull.Value : entree.NomFsseur));
            try
            {
                List<Entree > listeent = new List<Entree>();
                var reader = MyCon.GetReader("SP_ENTREES_SELECT", parametres);
                while (reader.Read())
                {
                    Entree ent = new Entree (Convert.ToInt32(reader["NumBord"]),Convert.ToDateTime(reader["DateBord"]),Convert.ToString(reader["NomFsseur"]));
                    listeent = listeent + ent;
                }
                return listeent;
            }
            catch (Exception ex)
            {
                throw new LivreException(ex.Message);
            }


        }

        
    }
}

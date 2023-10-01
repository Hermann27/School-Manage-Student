using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using TOOLS;
namespace BLL
{
  public   class DomaineManager
    {
        public static string Add(Domaine  domaine)
        {
            if (domaine.NomDom.Trim().Equals(""))
                throw new ClasseException("Le Nom du domaine est obligatoire !");
            else
            {
                try
                {
                    return DomaineDAO.Add(domaine);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }
            }



        }

        public static string Edit(Domaine  Olddomaine, Domaine  domaine)
        {
            if (domaine.NomDom.Trim().Equals(""))
                throw new ClasseException("Le Nom du domaine est obligatoire !");
            if (Olddomaine.NomDom.Trim().Equals(""))
                throw new ClasseException("Le Nom du domaine ancien est obligatoire !");
            else
            {
                try
                {
                    return DomaineDAO.Edit(Olddomaine, domaine );
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }
            }

        }

        public static string Delete(Domaine  domaine)
        {
            try
            {
                if (domaine != null)
                {
                    return DomaineDAO.Delete(domaine);
                }
                else
                {
                    throw new ClasseException("Le domaine est vide !");
                }

            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static List<Domaine > Find(Domaine  domaine)
        {

            try
            {
                if (domaine == null)
                    throw new DomaineException("Le domaine est vide !");
                else
                return DomaineDAO.Find(domaine);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }
    }
}

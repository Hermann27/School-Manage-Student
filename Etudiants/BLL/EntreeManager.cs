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
    public class EntreeManager
    {

        public static string Add(Entree  entree)
        {
            if (entree.NumBord  == 0)
                throw new EntreeException("Le numero du bordereau est obligatoire !");
            try
            {
                return EntreeDAO.Add(entree);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }



        }

        public static string Edit(Entree  Oldentree, Entree entree)
        {
            if (entree.NumBord == 0)
                throw new EntreeException("Le numero du bordereau est obligatoire !");
            if (Oldentree.NumBord == 0)
                throw new EntreeException("Le numero du bordereau ancien est obligatoire !");

            try
            {
                return EntreeDAO.Edit(Oldentree, entree);
            }
            catch (Exception ex)
            {
                throw new EntreeException(ex.Message);
            }


        }

        public static string Delete(Entree  entre)
        {
            try
            {
                if (entre != null)
                {
                    return EntreeDAO.Delete(entre);
                }
                else
                {
                    throw new EntreeException("Le livre est vide !");
                }

            }
            catch (Exception ex)
            {
                throw new EntreeException(ex.Message);
            }


        }

        public static List<Entree > Find(Entree  entree)
        {

            try
            {
                if (entree == null)
                    throw new DomaineException("L'étudiant est vide !");
                else
                    return EntreeDAO.Find(entree);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }
    }
}

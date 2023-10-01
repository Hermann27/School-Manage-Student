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
    public class EntreeLivreManager
    {
        public static string Add(EntreeLivre  entlivre)
        {
            if (entlivre.PuEntree  == 0)
                throw new EntreeLivreException ("Le prix est obligatoire !");
            if (entlivre.QteEntree ==0)
                throw new EntreeLivreException("La quantité est obligatoire !");
            if (entlivre.entree  == null)
                throw new EntreeLivreException("L'entrée est vide !");
            else
            {

                if (entlivre.entree.NumBord  == 0)
                    throw new EntreeLivreException("Numero bordereau est obligatoire !");
            }
            if (entlivre.livre  == null)
                throw new EntreeLivreException("Le livre est vide !");
            else
            {

                if (entlivre.livre.CodeLivre  == 0)
                    throw new EntreeLivreException("le Livre est obligatoire !");
            }

            try
            {
                return EntreeLivreDAO.Add(entlivre);
            }
            catch (Exception ex)
            {
                throw new EntreeLivreException(ex.Message);
            }



        }

        public static string Edit(EntreeLivre  Oldentlivre, EntreeLivre  entlivre)
        {
            if (entlivre.PuEntree == 0)
                throw new EntreeLivreException("Le prix est obligatoire !");
            if (entlivre.QteEntree == 0)
                throw new EntreeLivreException("La quantité est obligatoire !");
            if (entlivre.entree == null)
                throw new EntreeLivreException("L'entrée est vide !");
            else
            {

                if (entlivre.entree.NumBord == 0)
                    throw new EntreeLivreException("Numero bordereau est obligatoire !");
            }
            if (entlivre.livre == null)
                throw new EntreeLivreException("Le livre est vide !");
            else
            {

                if (entlivre.livre.CodeLivre == 0)
                    throw new EntreeLivreException("le Livre est obligatoire !");
            }

            if (Oldentlivre.PuEntree == 0)
                throw new EntreeLivreException("Le prix ancien est obligatoire !");
            if (Oldentlivre.QteEntree == 0)
                throw new EntreeLivreException("La quantité ancienne est obligatoire !");
            if (Oldentlivre.entree == null)
                throw new EntreeLivreException("L'entrée ancienne est vide !");
            else
            {

                if (Oldentlivre.entree.NumBord == 0)
                    throw new EntreeLivreException("Numero bordereau ancien est obligatoire !");
            }
            if (Oldentlivre.livre == null)
                throw new EntreeLivreException("Le livre ancien est vide !");
            else
            {

                if (Oldentlivre.livre.CodeLivre == 0)
                    throw new EntreeLivreException("le Livre ancien est obligatoire !");
            }


            try
            {
                return EntreeLivreDAO.Edit(Oldentlivre, entlivre);
            }
            catch (Exception ex)
            {
                throw new EntreeLivreException(ex.Message);
            }


        }

        public static string Delete(EntreeLivre entlivre)
        {
            try
            {
                if (entlivre != null)
                {
                    return EntreeLivreDAO.Delete(entlivre);
                }
                else
                {
                    throw new EntreeLivreException("Le livre et l'entrée sont vide !");
                }

            }
            catch (Exception ex)
            {
                throw new EntreeLivreException(ex.Message);
            }


        }

        public static List<EntreeLivre > Find(EntreeLivre  entlivre)
        {

            try
            {
                if (entlivre == null)
                    throw new EntreeLivreException("Le livre et l'entrée est vide !");
                else
                    return EntreeLivreDAO.Find(entlivre);
            }
            catch (Exception ex)
            {
                throw new EntreeLivreException(ex.Message);
            }

        }
    }
}

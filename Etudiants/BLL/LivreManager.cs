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
   public  class LivreManager
    {
        public static string Add(Livre  livre)
        {
            if (livre.CodeLivre==0)
                throw new ClasseException("Le Code du livre est obligatoire !");
            if (livre.Intitule.Trim().Equals(""))
                throw new ClasseException("L'intitulé est obligatoire !");
            if (livre.Editeur .Trim().Equals(""))
                    throw new ClasseException("Nom éditeur obligatoire !");
           
            if (livre.Auteur .Trim().Equals(""))
                throw new ClasseException("Nom de l'auteur est obligatoire !");
            if (livre.domaine == null)
                throw new ClasseException("Le domaine est obligatoire !");
            else
            {

                if (livre.domaine.NumDom==0)
                    throw new ClasseException("Nom de l'auteur est obligatoire !");
            }

            try
            {
                return LivreDAO.Add(livre);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }



        }

        public static string Edit(Livre  Oldlivre, Livre  livre)
        {
            if (livre.CodeLivre == 0)
                throw new ClasseException("Le Code du livre est obligatoire !");
            if (livre.Intitule.Trim().Equals(""))
                throw new ClasseException("L'intitulé est obligatoire !");
            if (livre.Editeur.Trim().Equals(""))
                throw new ClasseException("Nom éditeur obligatoire !");

            if (livre.Auteur.Trim().Equals(""))
                throw new ClasseException("Nom de l'auteur est obligatoire !");
            if (livre.domaine == null)
                throw new ClasseException("Le domaine est vide !");
            else
            {

                if (livre.domaine.NumDom == 0)
                    throw new ClasseException("Nom du domaine est obligatoire !");
            }

            if (Oldlivre.CodeLivre == 0)
                throw new ClasseException("Le Code du livre ancien est obligatoire !");
            if (Oldlivre.Intitule.Trim().Equals(""))
                throw new ClasseException("L'intitulé ancien est obligatoire !");
            if (Oldlivre.Editeur.Trim().Equals(""))
                throw new ClasseException("Nom éditeur ancien obligatoire !");

            if (Oldlivre.Auteur.Trim().Equals(""))
                throw new ClasseException("Nom de l'auteur ancien est obligatoire !");
            if (Oldlivre.domaine == null)
                throw new ClasseException("Le domaine ancien est vide !");
            else
            {

                if (livre.domaine.NumDom == 0)
                    throw new ClasseException("Le numero du domaine ancien est obligatoire !");
            }

            try
            {
                return LivreDAO.Edit(Oldlivre, livre);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static string Delete(Livre  livre)
        {
            try
            {
                if (livre != null)
                {
                    return LivreDAO.Delete(livre);
                }
                else
                {
                    throw new ClasseException("Le livre est vide !");
                }

            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static List<Livre> Find(Livre  livre)
        {

            try
            {
                if (livre == null)
                    throw new DomaineException("L'étudiant est vide !");
                else
                    return LivreDAO.Find(livre);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }
    }
}

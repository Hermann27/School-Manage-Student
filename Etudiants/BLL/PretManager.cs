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
  public   class PretManager
    {
        public static string Add(Pret  pret)
        {
            if (pret.NumPret == 0)
                throw new ClasseException("Le numero du prêt est obligatoire !");
            if (pret.DatePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date du prêt est obligatoire !");
            if (pret.EcheancePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date d'échéance est obligatoire !");
            if (pret.etudiant  == null)
                throw new ClasseException("L'étudiant est vide !");
            else
            {

                if (pret.etudiant.Matricule == null)
                    throw new ClasseException("L'etudiant est obligatoire !");
            }

            if (pret.livre  == null)
                throw new ClasseException("Le livre est vide !");
            else
            {

                if (pret.livre.CodeLivre  == 0)
                    throw new ClasseException("Le livre est obligatoire !");
            }

            try
            {
                return PretDAO.Add(pret);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }



        }

        public static string Edit(Pret  Oldpret, Pret  pret)
        {
            if (pret.NumPret == 0)
                throw new ClasseException("Le numero du prêt est obligatoire !");
            if (pret.DatePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date du prêt est obligatoire !");
            if (pret.EcheancePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date d'échéance est obligatoire !");
            if (pret.etudiant == null)
                throw new ClasseException("L'étudiant est vide !");
            else
            {

                if (pret.etudiant.Matricule == null)
                    throw new ClasseException("L'etudiant est obligatoire !");
            }

            if (pret.livre == null)
                throw new ClasseException("Le livre est vide !");
            else
            {

                if (pret.livre.CodeLivre == 0)
                    throw new ClasseException("Le livre est obligatoire !");
            }

            if (Oldpret .NumPret == 0)
                throw new ClasseException("Le numero du prêt ancien est obligatoire !");
            if (Oldpret.DatePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date du prêt ancien est obligatoire !");
            if (Oldpret.EcheancePret == Convert.ToDateTime("01/01/0001 00:00:00"))
                throw new ClasseException("La date d'échéance ancienne est obligatoire !");
            if (Oldpret.etudiant == null)
                throw new ClasseException("L'étudiant ancien est vide !");
            else
            {

                if (Oldpret.etudiant.Matricule == null)
                    throw new ClasseException("L'etudiant du prêt ancien est obligatoire !");
            }

            if (Oldpret.livre == null)
                throw new ClasseException("Le livre du prêt ancien est vide !");
            else
            {

                if (Oldpret.livre.CodeLivre == 0)
                    throw new ClasseException("Le livre du prêt ancien est obligatoire !");
            }
            try
            {
                return PretDAO.Edit(Oldpret, pret);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static string Delete(Pret  pret)
        {
            try
            {
                if (pret != null)
                {
                    return PretDAO.Delete(pret);
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

        public static List<Pret > Find(Pret  pret)
        {

            try
            {
                if (pret == null)
                    throw new DomaineException("Le prêt est vide !");
                else
                    return PretDAO.Find(pret);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }
    }
}

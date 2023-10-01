using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;
using DAL;
using TOOLS;
namespace BLL
{
    public class EtudiantManager
    {
        public static string Add(Etudiant  etudiant)
        {
            if (etudiant.NomEtud .Trim().Equals(""))
                throw new ClasseException("Le Nom de l'etudiant est obligatoire !");
            if (etudiant.classe == null)
                throw new ClasseException("La classe est vide !");
            else
            {
                if (etudiant.classe.CodeClasse.Trim().Equals(""))
                    throw new ClasseException("choisir la classe de l'etudiant !");
            }
            if (etudiant.Matricule .Trim().Equals(""))
                throw new ClasseException("Le Matricule de l'etudiant est obligatoire !");
            
                try
                {
                    return EtudiantDAO.Add(etudiant);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }



        }

        public static string Edit(Etudiant  Oldetudiant, Etudiant  etudiant)
        {
            if (etudiant.NomEtud.Trim().Equals(""))
                throw new ClasseException("Le Nom de l'etudiant est obligatoire !");
            if (etudiant.classe == null)
                throw new ClasseException("La classe est vide !");
            else
            {
                if (etudiant.classe.CodeClasse.Trim().Equals(""))
                    throw new ClasseException("choisir la classe de l'ancien etudiant !");
            }
            if (Oldetudiant.Matricule.Trim().Equals(""))
                throw new ClasseException("Le Matricule de l' ancien etudiant est obligatoire !");

            if (Oldetudiant .NomEtud.Trim().Equals(""))
                throw new ClasseException("Le Nom de l'ancien etudiant est obligatoire !");
            if (Oldetudiant.classe == null)
                throw new ClasseException("La classe de l'ancien est vide !");
            else
            {
                if (etudiant.classe.CodeClasse.Trim().Equals(""))
                    throw new ClasseException("choisir la classe de l'ancien etudiant !");
            }
            if (etudiant.Matricule.Trim().Equals(""))
                throw new ClasseException("Le Matricule de l'ancien étudiant est obligatoire !");
            
            
            
                try
                {
                    return EtudiantDAO.Edit(Oldetudiant, etudiant);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }
        

        }

        public static string Delete(Etudiant  etudiant)
        {
            try
            {
                if (etudiant != null)
                {
                    return EtudiantDAO.Delete(etudiant);
                }
                else
                {
                    throw new ClasseException("L'étudiant est vide !");
                }

            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static List<Etudiant > Find(Etudiant etudiant)
        {

            try
            {
                if (etudiant == null)
                    throw new DomaineException("L'étudiant est vide !");
                else
                    return EtudiantDAO.Find(etudiant);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }

        public static DataSet  FindDataSet(Etudiant etudiant)
        {

            try
            {
                if (etudiant == null)
                    throw new DomaineException("L'étudiant est vide !");
                else
                    return EtudiantDAO.FindDataSet(etudiant);
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }

        }
    }
}

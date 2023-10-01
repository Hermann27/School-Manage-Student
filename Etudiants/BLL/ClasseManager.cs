using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using TOOLS;
using BLL;
namespace BLL
{
    public class ClasseManager
    {
        public static string Add(Classe classe)
        {
            if (classe.Libele.Trim().Equals(""))
                throw new ClasseException("Le libellé est obligatoire !");
            else if (classe.CodeClasse.Trim().Equals(""))
                throw new ClasseException("Le code de la classe est obligatoire !");
            else
            {
                try
                {
                    return ClasseDAO.Add(classe);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }
            }
            


        }

        public static string Edit(Classe Oldclasse, Classe classe)
        {
            if (classe.Libele.Trim().Equals(""))
                throw new ClasseException("Le libellé est obligatoire !");
            else if (classe.CodeClasse.Trim().Equals(""))
                throw new ClasseException("Le code de la classe est obligatoire !");
            if (Oldclasse.Libele.Trim().Equals(""))
                throw new ClasseException("libellé pour ancienne classe est obligatoire !");
            else if (Oldclasse.CodeClasse.Trim().Equals(""))
                throw new ClasseException("Code pour ancienne classe obligatoire !");
            else
            {
                try
                {
                    return ClasseDAO.Edit(Oldclasse,classe);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }
            }

        }

        public static string Delete(Classe classe)
        {
            MySQL MyCon = new MySQL();
            List<MySQLParameter> parametres = new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("CODECL", classe.CodeClasse));
            try
            {
                if (classe != null)
                {
                    MyCon.Execute("SP_CLASSE_DELETE", parametres);
                    return "Suppression Effectué Avec succès !";
                }
                else
                {
                    throw new ClasseException("La classe est vide !");
                }
                
            }
            catch (Exception ex)
            {
                throw new ClasseException(ex.Message);
            }


        }

        public static List<Classe> Find(Classe classe)
        {
           
                try
                {
                    return ClasseDAO.Find(classe);
                }
                catch (Exception ex)
                {
                    throw new ClasseException(ex.Message);
                }

        }
    }
}

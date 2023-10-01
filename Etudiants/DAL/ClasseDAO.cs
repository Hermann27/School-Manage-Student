using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using TOOLS;
namespace DAL
{
    public class ClasseDAO
    {
        

    public static string  Add(Classe classe)
    {
        MySQL MyCon=new MySQL();
        List<MySQLParameter> parametres=new List<MySQLParameter>();
      parametres.Add(new MySQLParameter ("CODECL",classe.CodeClasse));
      parametres.Add(new MySQLParameter ("LIBCL",classe.Libele));
      parametres.Add(new MySQLParameter("idcre", classe.UserCreate.Identifiant));
      parametres.Add(new MySQLParameter("idup", classe.UserUpdate.Identifiant));
      try
      {
          MyCon.Execute("SP_CLASSE_INSERT", parametres);
          return "Enregistrement Effectué Avec succès !";
      }catch(Exception ex)
      {
          throw new ClasseException(ex.Message);
      }
  
            
    }

    public static string  Edit(Classe Oldclasse,Classe classe)
    {
        MySQL MyCon=new MySQL();
        List<MySQLParameter> parametres=new List<MySQLParameter>();
      parametres.Add(new MySQLParameter ("OLDCODECL",Oldclasse.CodeClasse));
      parametres.Add(new MySQLParameter ("CODECL",classe.CodeClasse));
      parametres.Add(new MySQLParameter ("LIBCL",classe.Libele));
      parametres.Add(new MySQLParameter("idcre", classe.UserCreate.Identifiant));
      parametres.Add(new MySQLParameter("idup", classe.UserUpdate.Identifiant));
      try
      {
          MyCon.Execute("SP_CLASSE_UPDATE", parametres);
          return "Modification Effectué Avec succès !";
      }catch(Exception ex)
      {
          throw new ClasseException(ex.Message);
      }
  
            
    }

    public static string  Delete(Classe classe)
    {
        MySQL MyCon=new MySQL();
        List<MySQLParameter> parametres=new List<MySQLParameter>();
      parametres.Add(new MySQLParameter ("CODECL",classe.CodeClasse));
      try
      {
          MyCon.Execute("SP_CLASSE_DELETE", parametres);
          return "Suppression Effectué Avec succès !";
      }catch(Exception ex)
      {
          throw new ClasseException(ex.Message);
      }
  
            
    }

    public static List<Classe>  Find(Classe classe)
    {
        MySQL MyCon=new MySQL();
        List<MySQLParameter> parametres=new List<MySQLParameter>();
            parametres.Add(new MySQLParameter("CODECL", classe.CodeClasse==null?(object)DBNull.Value:classe.CodeClasse ));
            parametres.Add(new MySQLParameter("LIBCL", classe.Libele == null ? (object)DBNull.Value : classe.Libele));
            parametres.Add(new MySQLParameter("idcre", (classe.UserCreate != null && classe.UserCreate.Identifiant != 0) ? classe.UserCreate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("idup", (classe.UserUpdate != null && classe.UserUpdate.Identifiant != 0) ? classe.UserUpdate.Identifiant : (object)DBNull.Value));
            parametres.Add(new MySQLParameter("dtcre", classe.DateCreate == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : classe.DateCreate));
            parametres.Add(new MySQLParameter("dtup", classe.DateUpdate == Convert.ToDateTime("01-01-0001 00:00:00") ? (object)DBNull.Value : classe.DateUpdate));
      try
      {
          List<Classe> listeCl=new List<Classe>();
         var reader=   MyCon.GetReader("SP_CLASSE_SELECT",parametres);
         while(reader.Read())
         {
             Classe cl=new Classe(Convert.ToString(reader["codeClasse"]),Convert.ToString(reader["libClasse"]));
             cl.UserCreate = UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdCreateur"])));
             cl.UserUpdate = UtilisateurDAO.GetUser(new Utilisateur(Convert.ToInt32(reader["IdModificateur"])));
             listeCl=listeCl+cl;
         }
          return listeCl ;
      }catch(Exception ex)
      {
          throw new ClasseException(ex.Message);
      }
  
            
    }


   
    }
}

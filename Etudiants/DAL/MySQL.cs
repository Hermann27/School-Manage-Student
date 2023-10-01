using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using TOOLS;
namespace DAL
{
    public class MySQL
    {
        string server = "";
        string user = "";
        string password = "";
        string database = "";
        static string ConStr;
        static MySqlConnection cn = null;

        public MySQL(string server, string user, string password, string database)
        {
            this.server = server;
            this.user = user;
            this.password = password;
            this.database = database;
            if(password.Equals(""))
            ConStr = "server=" + server + ";user=" + user + ";password=" + password + ";database=" + database;

            try
            {
                cn = new MySqlConnection(ConStr);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message );
            }
        }

        public MySQL(string server, string user, string database)
        {
            this.server = server;
            this.user = user;
            this.database = database;
            if (password.Equals(""))
                ConStr = "server=" + server + ";user=" + user  + ";database=" + database;

            try
            {
               
                cn = new MySqlConnection(ConStr);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySQL(string server, string user)
        {
            this.server = server;
            this.user = user;
            if (password.Equals(""))
                ConStr = "server=" + server + ";user=" + user;

            try
            {

                cn = new MySqlConnection(ConStr);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MySQL(string user)
        {
            this.server = user;
            ConStr = "server=" + user ;

            try
            {
                cn = new MySqlConnection(ConStr);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySQL()
        {
            if (ConStr==null)
            {
                throw new Exception("Aucune connexion ouverte !");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(ConStr);
                    con.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public MySqlCommand GetCommand(string query)
        {
            MySqlCommand cmd=null;
            try
            {
                 cmd= new MySqlCommand(query, cn);
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlCommand GetCommand(string NomProcedure, List<MySQLParameter> parametres)
        {
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = NomProcedure;
                MySqlConnection conn = new MySqlConnection(ConStr);
                conn.Open();
                cmd.Connection = conn;
                if (parametres != null)
                {
                    foreach (MySQLParameter elt in parametres)
                        cmd.Parameters.Add(new MySqlParameter(elt.name,elt.valeur));
                }
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlDataReader GetReader(string query)
        {
            MySqlCommand cmd = null;
            try
            {
                cmd = GetCommand(query);
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlDataReader GetReader(string NomProcedure, List<MySQLParameter> parametres)
        {
            MySqlCommand cmd = null;
            try
            {
                cmd = GetCommand(NomProcedure,parametres );
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet  GetDataSet(string NomProcedure, List<MySQLParameter> parametres,string NomTable)
        {
            DataSet ds=null;
            try
            {
                ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(GetCommand(NomProcedure, parametres));
                da.Fill(ds, NomTable);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Clone();
            }
        }

        public DataSet GetDataSet(string query, string NomTable)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(GetCommand(query));
                da.Fill(ds, NomTable);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Clone();
            }
        }

        public void  Execute(string ProcedureName, List<MySQLParameter> parametres)
        {
            try{
                GetCommand(ProcedureName,parametres).ExecuteNonQuery();
            }catch(Exception ex){
                throw new Exception(ex.Message);
            }
            finally
            {
                if(cn.State==ConnectionState.Open)
                    cn.Close();
            }
        }

        public void Execute(string query)
        {
            try
            {
                GetCommand(query).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        public DataTable GetDataTable(DataSet ds, string NomTable)
        {
            try
            {
                if (ds != null)
                {
                    return ds.Tables[NomTable];
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Clone();
            }
        }

    }



    public class MySQLParameter
    {
        public object  valeur { get; set; }
        public string  name { get; set; }

        public MySQLParameter(string name, object valeur)
        {
            this.valeur = valeur;
            this.name = name ;
        }
    }
}

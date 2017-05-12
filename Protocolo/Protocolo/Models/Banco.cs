using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Protocolo.Models
{
    public static class Banco
    {
        public static SqlConnection GetConexao()
        {
            SqlConnection Conexao = new SqlConnection("Server=tcp:cartoriojaguarao.database.windows.net,1433;Initial Catalog=BDCARTORIO;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                Conexao.Open();
                return Conexao;

            }
            catch (SqlException e)

            {

                e.ToString();
                return null;


            }
           
            
        }
        public static  SqlCommand GetComando(SqlConnection conexao)
        {
            SqlCommand Comando = conexao.CreateCommand();
            return Comando;
        }

        public static SqlDataReader GetReader(SqlCommand comando)
        {
            SqlDataReader reader = comando.ExecuteReader();
            return reader;

        }
    }
}

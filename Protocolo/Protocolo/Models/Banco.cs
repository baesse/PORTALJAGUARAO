using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Protocolo.Models
{
    public class Banco
    {
        public static Boolean GetConexao()
        {
            SqlConnection conexa = new SqlConnection("Server=tcp:cartoriojaguarao.database.windows.net,1433;Initial Catalog=BDCARTORIO;Persist Security Info=False;User ID=rootacesso;Password=75395146@carbono;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conexa.Open();
                return true;

            }
            catch (SqlException e)

            {
                e.ToString();
                return false;

            }
           
            
        }
    }
}
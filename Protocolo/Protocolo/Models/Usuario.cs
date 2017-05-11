using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Protocolo.Models
{
    public class Usuario
    {
       

        public static string Logar(string usuario,string senha)
        {
            SqlConnection conexao = Models.Banco.GetConexao();
            SqlCommand comando = Models.Banco.GetComando(conexao);

            comando.CommandText = "SELECT NOME FROM USUARIO WHERE USUARIO=@USUARIO AND SENHA=@SENHA";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("senha", senha);
            SqlDataReader READER = comando.ExecuteReader();
            while (READER.Read())
            {
                string nome;
                return  nome = READER.GetString(0);

            }

            return "Usario não encotrado";


        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Protocolo.Models
{
    public  class Protocolo
    {
        public string protocolo { get; set; }
        public string ano { get; set; }
        public String sedex { get; set; }
        public int idvalor { get; set; }

        public Protocolo(string protocolo,string ano,String sedex,int idvalor)
        {
            this.protocolo = protocolo;
            this.ano = ano;
            this.sedex = sedex;
            this.idvalor = idvalor;

        }

        public Protocolo()
        {

        }


        public static Boolean InserirProtocolo(Protocolo protocolo)
        {
            SqlConnection Conexao = Models.Banco.GetConexao();
            SqlCommand comando = Models.Banco.GetComando(Conexao);
            comando.CommandText = "INSERT INTO PROTOCOLO (PROTOCOLO,ANO,SEDEX) VALUES (@PROTOCOLO,@ANO,@SEDEX)";
            comando.Parameters.AddWithValue("@PROTOCOLO", protocolo.protocolo);
            comando.Parameters.AddWithValue("@ANO", protocolo.ano);
            comando.Parameters.AddWithValue("@SEDEX", "sim");
            comando.ExecuteNonQuery();
            Conexao.Close();
            return true;

        }


        public static Boolean BuscarProtocolo(string protocolo,string ano)
        {

            SqlConnection Conexao = Models.Banco.GetConexao();
            SqlCommand comando = Models.Banco.GetComando(Conexao);
            comando.CommandText = "select protocolo,ano,sedex,valor_fk from protocolo where @protocolo=protocolo and @ano=ano";
            comando.Parameters.AddWithValue("@protocolo", protocolo);
            comando.Parameters.AddWithValue("@ano", ano);
            SqlDataReader reader = Models.Banco.GetReader(comando);
            while (reader.Read())
            {
                Conexao.Close();
                return true;
            }
            Conexao.Close();
            return false;

        }
    }
}
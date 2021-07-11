using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login.DAL
{
    public class Conexao
    {
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conexaoBanco"].ConnectionString;

        public static SqlConnection conexao = new SqlConnection(conStr);

        public static void Conectar() 
        {
            if (conexao.State == ConnectionState.Closed)    conexao.Open();
        }

        public static void Desonectar()
        {
            if (conexao.State == ConnectionState.Open)      conexao.Close();
        }
    }
}

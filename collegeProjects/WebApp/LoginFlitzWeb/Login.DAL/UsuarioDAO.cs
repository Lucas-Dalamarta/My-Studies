using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Entities;
using System.Data.SqlClient;

namespace Login.DAL
{
    public class UsuarioDAO
    {
        public Usuario RetornaUsuario(string user, string pwd) {

            try
            {
                var comando = new SqlCommand();
                comando.Connection = Conexao.conexao;

                comando.CommandText = "SELECT * FROM Usuario where nome=@usuario and senha=@senha";

                comando.Parameters.AddWithValue("@usuario", user);
                comando.Parameters.AddWithValue("@senha", pwd);
                
                Conexao.Conectar();

                var reader = comando.ExecuteReader();

                Usuario usuario = null;

                while (reader.Read())
                {
                    usuario = new Usuario();
                    //usuario.user = Convert.ToString(reader["senha"]);
                }
                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                Conexao.Desonectar();
            }
        }
    }
}

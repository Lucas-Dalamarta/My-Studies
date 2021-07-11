using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.DAL;
using Login.Entities;

namespace Login.BLL
{
    public class LoginBO
    {

        private UsuarioDAO _usuarioDao;

        public Usuario VerificaUsuarioExiste(string nome, string senha)
        {
            _usuarioDao = new UsuarioDAO();

            var usuario = _usuarioDao.RetornaUsuario(nome, senha);

            if (usuario == null)
                throw new UsuarioNaoCadastradoException();
            else
                return usuario;
        }
    }

}

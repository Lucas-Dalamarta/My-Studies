using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login.BLL;

namespace LoginFlitzWeb
{
    public partial class Login : System.Web.UI.Page
    {

        private LoginBO _loginBo;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_entrar_Click(object sender, EventArgs e)
        {
            _loginBo = new LoginBO();

            var nomeUsuario = txtbox_user.Text.Trim();
            var senha = txtbox_pwd.Text.Trim();
            lblStatus.Text = "";

            try
            {
                _loginBo.VerificaUsuarioExiste(nomeUsuario, senha);
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Login realizado com sucesso!";
                Response.Redirect("Index.aspx");
                lblStatus.Visible = false;
            }
            catch (UsuarioNaoCadastradoException)
            {
                lblStatus.Visible = true;
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Usuário não cadastrado ou inexistente.";
            }
            catch (Exception)
            {
                lblStatus.Visible = true;
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Erro Inesperado!";

            }
        }
    }
}
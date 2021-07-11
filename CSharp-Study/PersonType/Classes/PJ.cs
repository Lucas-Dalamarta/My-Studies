using System;

namespace Exercicio_0605
{
    class PJ : Pessoa, IComparavel
    {
        private string RazaoSocial;

        public PJ(double x, string z) : base(x)
        {
            this.SetDocumento(x);
            this.SetRazaoSocial(z);
        }

        public void SetRazaoSocial(string x)
        {
            {
                if (!String.IsNullOrEmpty(x)) { RazaoSocial = x; }
            }
        }

        public string GetRazaoSocial()
        {
            return RazaoSocial;
        }

        public int CompararCom(IComparavel obj)
        {
            Pessoa pj = (Pessoa)obj;

            if (this.GetDocumento() > pj.GetDocumento())
                return 1;
            else if (this.GetDocumento() < pj.GetDocumento())
                return -1;
            else
                return 0;
        }

        public override string GetTipo()
        {
            return "Pessoa Juridica";
        }
    }
}

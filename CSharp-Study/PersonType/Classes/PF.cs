using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_0605
{
    class PF : Pessoa, IComparavel
    {
        public int CompararCom(IComparavel obj)
        {
            Pessoa pf = (Pessoa)obj;

            if (this.GetDocumento() > pf.GetDocumento())
                return 1;
            else if (this.GetDocumento() < pf.GetDocumento())
                return -1;
            else
                return 0;
        }
        private string Nome;

        public PF(double x, string z) : base(x)
        {
            this.SetDocumento(x);
            this.SetNome(z);
        }

        public void SetNome(string x)
        {
            {
                if (!String.IsNullOrEmpty(x)) { Nome = x; }
            }
        }

        public string GetNome()
        {
            return Nome;
        }

        public override string GetTipo()
        {
            return "Pessoa Fisica";
        }
    }
}

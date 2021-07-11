using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_0605
{
    abstract class Pessoa
    {
        protected double Documento;

        protected Pessoa(double x)
        {
            SetDocumento(x);
        }

        public void SetDocumento(double x)
        {
            if (x >= 0)
                this.Documento = x;
        }

        public double GetDocumento()
        {
            return Documento;
        }

        public abstract string GetTipo();
    }
}

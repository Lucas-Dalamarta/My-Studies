using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXS_PRODUTO
{
    public class Produto
    {
        protected int       Codigo;
        protected double    Preco;
        protected string    Descri;
        protected string    Fabri;

        public int GetCodigo()
        {
            return this.Codigo;
        }
        public double GetPreco()
        {
            return this.Preco;
        }
        public string GetDescri()
        {
            return this.Descri;
        }
        public string GetFabri()
        {
            return this.Fabri;
        }

        public void SetCodigo(int x)
        {
            if (x > 0)  this.Codigo =   x;
            else        throw new Exception("Código inválido.");
        }

        public void SetPreco(double x)
        {
            if (x > 0)  this.Preco   =   x;
            else        throw new Exception("Preco inválido.");
        }

        public void SetFabri(string x)
        {
            if ((!(String.IsNullOrEmpty(x)) &&  x.Length < 255)) this.Fabri = x;
            else                                                 throw new Exception("Fabricante inválido.");
            
        }

        public void SetDescri(string x)
        {
            if ((!(String.IsNullOrEmpty(x)) && x.Length < 255)) this.Descri = x;
            else                                                throw new Exception("Descrição inválida.");
        }
    }
}

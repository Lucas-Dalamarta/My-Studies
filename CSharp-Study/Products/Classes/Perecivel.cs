using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXS_PRODUTO
{
    public class Perecivel :    Produto
    {
        private DateTime Data_val;
        private DateTime Data_fab;

        public Perecivel(int a, double b, string c, string d, DateTime e, DateTime f)
        {
            base.SetCodigo(a);
            base.SetPreco(b);
            base.SetDescri(c);
            base.SetFabri(d);
            this.SetData_fab(e);
            this.SetData_val(f);
        }

        public DateTime GetData_val()
        {
            return this.Data_val;
        }
        public DateTime GetData_fab()
        {
            return this.Data_fab;
        }

        public void SetData_val(DateTime x)
        {
            if (x <= DateTime.Today)    this.Data_val = x;
            else throw new Exception("Produto Vencido !.");
        }

        public void SetData_fab(DateTime x)
        {
            if (x <= DateTime.Today) this.Data_fab = x;
            else throw new Exception("Data Invalida !.");
        }

        public override string ToString()
        {
            return string.Format(
                "Código: {0}\n"     +
                "Preço: {1}\n"      +
                "Descricao: {2}\n"  +
                "Fabricante: {3}\n" +
                "Validade: {4}\n"   +
                "Fabricacao: {5}\n"
                , this.Codigo, this.Preco, this.Descri, this.Fabri, this.Data_val, this.Data_fab);
        }

    }
}

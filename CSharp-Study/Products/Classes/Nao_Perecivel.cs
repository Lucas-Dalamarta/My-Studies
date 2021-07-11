using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXS_PRODUTO
{

    public class Nao_Perecivel : Produto
    {
        private int Garantia;

        public Nao_Perecivel(int a, double b, string c, string d, int e)
        {
            base.SetCodigo(a);
            base.SetPreco(b);
            base.SetDescri(c);
            base.SetFabri(d);
            this.SetGarantia(e);
        }

        public int GetGarantia()
        {
            return this.Garantia;
        }

        public void SetGarantia(int x)
        {
            if (x >= 2019 && x <= 2999) this.Garantia = x;
            else throw new Exception("Garantia Invalida!.");
        }

        public override string ToString()
        {
            return string.Format(
                "Código: {0}\n"     +
                "Preço: {1}\n"      +
                "Descricao: {2}\n"  +
                "Fabricacao: {3}\n" +
                "Garantia: {4}\n"   
                , this.Codigo, this.Preco, this.Descri, this.Fabri, this.Garantia);
        }
    }
}

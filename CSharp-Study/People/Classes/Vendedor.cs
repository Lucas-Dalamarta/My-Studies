using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{
    public class Vendedor : Empregado
    {
        private double ValorVendas;
        private double Comissao;

        public Vendedor(string A, string B, string C, int D, double E, double F)
            : base(A, B, C, D, E)
        {
            SetValorVendas(F);
            SetComissao(F);
        }
        /* */
        public Vendedor()
        {
            base.SetNome("Obi-Wan");
            base.SetTelefone("77788899911");
            base.SetEndereco("Tatooine");
            base.SetCodigoSetor(1981);
            base.SetSalarioBase(2000.00);
            base.SetImposto(base.GetSalarioBase());
            SetValorVendas(10000.00);
            SetComissao(ValorVendas);
        }

        private void SetValorVendas(double x)
        {
            if (x >= 0 )
            {
                ValorVendas = x;  
            }
        }

        private double GetValorVendas()
        {
            return ValorVendas;
        }

        private void SetComissao(double x)
        {
            if (x >= 0)
            {
                Comissao = x*0.25;
            }
        }

        private double GetComissao()
        {
            return Comissao;
        }
   
        public double calcularSalario()
        {
            return (base.GetSalarioBase() + Comissao) - base.GetImposto();    
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n" +
                                 "Telefone : {1}\n" +
                                 "Endereco : {2}\n" +
                                 "Setor    : {3}\n" +
                                 "Salario B: {4}\n" +
                                 "Imposto  : {5}\n" +
                                 "Vendas   : {6}\n" +
                                 "Comissao : {7}\n" +
                                 "Salario F: {8}\n",
                                 this.GetNome(), this.GetTelefone(), this.GetEndereco(),
                                 this.GetCodigoSetor(), this.GetSalarioBase(), this.GetImposto(),
                                 this.GetValorVendas(), this.GetComissao(), this.calcularSalario());

        }
    }
}

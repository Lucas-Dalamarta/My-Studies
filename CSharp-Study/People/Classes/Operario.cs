using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{

    public class Operario : Empregado
    {
        private double ValorProducao;
        private double Comissao;

        public Operario(string A, string B, string C, int D, double E, double F)
            : base(A, B, C, D, E)
        {
            SetValorProducao(F);
            SetComissao(F);
        }
        /* */
        public Operario()
        {
            base.SetNome("Ben");
            base.SetTelefone("77788899911");
            base.SetEndereco("Bespin");
            base.SetCodigoSetor(2019);
            base.SetSalarioBase(2000.00);
            base.SetImposto(base.GetSalarioBase());
            SetValorProducao(1000.00);
            SetComissao(ValorProducao);
        }

        public void SetValorProducao(double x)
        {
            if (x >= 0 )
            {
                ValorProducao = x;  
            }
        }

        public double GetValorProducao()
        {
            return ValorProducao;
        }

        public void SetComissao(double x)
        {
            if (x >= 0)
            {
                Comissao = x*0.25;
            }
        }

        public double GetComissao()
        {
            return Comissao;
        }
   
        public new double CalcularSalario()
        {
            return (base.GetSalarioBase() - base.GetImposto()) + Comissao;    
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n"+
                                 "Telefone : {1}\n"+
                                 "Endereco : {2}\n"+
                                 "Setor    : {3}\n"+
                                 "Salario B: {4}\n"+
                                 "Imposto  : {5}\n"+
                                 "Produção : {6}\n"+
                                 "Comissao : {7}\n"+
                                 "Salario F: {8}\n",
                                 this.GetNome(),this.GetTelefone(),this.GetEndereco(),
                                 this.GetCodigoSetor(),this.GetSalarioBase(),this.GetImposto(),
                                 this.GetValorProducao(),this.GetComissao(),this.CalcularSalario());
        }
    }
}

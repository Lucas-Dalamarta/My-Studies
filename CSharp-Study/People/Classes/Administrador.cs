using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{

    public class Administrador : Empregado
    {
        private double AjudaDeCusto;

        public Administrador(string A, string B, string C, int D, double E,double F)
            : base(A, B, C, D, E)
        {
            SetAjudaDeCusto(F);
        }

        public Administrador()
        {
            base.SetNome("Finn");
            base.SetTelefone("77788899911");
            base.SetEndereco("FN2187");
            base.SetCodigoSetor(2017);
            base.SetSalarioBase(20000.00);
            base.SetImposto(base.GetSalarioBase());
            SetAjudaDeCusto(2000.00);
        }

        private void SetAjudaDeCusto(double x)
        {
            if (x >= 0 )
            {
                AjudaDeCusto = x;  
            }
        }

        public double GetAjudaDeCusto()
        {
            return AjudaDeCusto;
        }
   
        public new double CalcularSalario()
        {
            return (base.GetSalarioBase() - base.GetImposto()) + AjudaDeCusto;    
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n" +
                                 "Telefone : {1}\n" +
                                 "Endereco : {2}\n" +
                                 "Setor    : {3}\n" +
                                 "Salario B: {4}\n" +
                                 "Imposto  : {5}\n" +
                                 "Custo    : {6}\n" +
                                 "Salario F: {7}\n",
                                 this.GetNome(), this.GetTelefone(), this.GetEndereco(),
                                 this.GetCodigoSetor(), this.GetSalarioBase(), this.GetImposto(),
                                 this.GetAjudaDeCusto(), this.CalcularSalario());
        }
    }
}

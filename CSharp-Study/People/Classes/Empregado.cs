using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{

    public class Empregado : Pessoa
    {
        private int     CodigoSetor ;
        private double  SalarioBase ;
        private double  Imposto     ;

        public Empregado(string A, string B, string C, int D, double E)
            : base(A, B, C)
        {
            SetCodigoSetor(D);        
            SetSalarioBase(E);
            SetImposto(E);
        }
        /* */
        public Empregado()
        {
            base.SetNome("Han");
            base.SetTelefone("77788899911");
            base.SetEndereco("Bespin");
            SetCodigoSetor(2015);
            SetSalarioBase(17000.00);
            SetImposto(SalarioBase);
        }

        public void SetCodigoSetor(int x)
        {
            if (x >= 0) 
            {
                CodigoSetor = x;
            }     
        }

        public int GetCodigoSetor() 
        {
            return CodigoSetor;
        }

        public void SetSalarioBase(double x)
        {
            if (x >= 0)
            {
                SalarioBase = x;
            }
        }

        public double GetSalarioBase()
        {
            return SalarioBase;
        }

        public void SetImposto(double x)
        {
            if (x >= 0)
            {
                Imposto = x*0.10;
            }
        }

        public double GetImposto()
        {
            return Imposto;
        }

        public double CalcularSalario()
        {
            return SalarioBase - Imposto;
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n" +
                                 "Telefone : {1}\n" +
                                 "Endereco : {2}\n" +
                                 "Setor    : {3}\n" +
                                 "Salario B: {4}\n" +
                                 "Imposto  : {5}\n" +
                                 "Salario F: {6}\n" ,
                                 this.GetNome(), this.GetTelefone(), this.GetEndereco(),
                                 this.GetCodigoSetor(), this.GetSalarioBase(), this.GetImposto(),
                                 this.CalcularSalario()
                                 );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{
    public class Pessoa
    {
        private string  Nome    ;
        private string  Telefone;
        private string  Endereco;

        public Pessoa(string A, string B, string C) 
        {
            SetNome(A);
            SetTelefone(B);
            SetEndereco(C);
        }

        public Pessoa()
        {
            SetNome("Lucas");
            SetTelefone("947448176");
            SetEndereco("AV Reserva Do Japi");
        }

        public void SetNome(String x)
        {
            if ((!String.IsNullOrEmpty(x)) && x.Length < 255)
            {
                Nome = x;
            }
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetTelefone(String x)
        {
            if ((!String.IsNullOrEmpty(x)) && x.Length < 11)
            {
                Telefone = x;
            }
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public void SetEndereco(String x)
        {
            if ((!String.IsNullOrEmpty(x)) && x.Length < 255)
            {
                Endereco = x;
            }
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n" +
                                 "Telefone : {1}\n" +
                                 "Endereco : {2}\n" ,
                                 this.GetNome(), this.GetTelefone(), this.GetEndereco()
                                 );
        }
    }
}

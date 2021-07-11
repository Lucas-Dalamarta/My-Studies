namespace Exercicio_29_04
{

    public class Fornecedor : Pessoa
    {
        private double ValorCredito;
        private double ValorDivida;

        public Fornecedor(string A, string B, string C, double D, double E)
            : base(A, B, C)
        {
            SetValorCredito(D);
            SetValorDivida(E);
        }
        /* */
        public Fornecedor()
        {
            base.SetNome("Leia");
            base.SetTelefone("99999999999");
            base.SetEndereco("Alderaan");
            SetValorCredito(100000.00);
            SetValorDivida(10000.00);
        }

        private void SetValorCredito(double x)
        {
            if (x >= 0)
            {
                ValorCredito = x;
            }
        }

        public double GetValorCredito()
        {
            return ValorCredito;
        }

        private void SetValorDivida(double x)
        {
            if (x >= 0)
            {
                ValorDivida = x;
            }
        }

        public double GetValorDivida()
        {
            return ValorDivida;
        }

        public double ObterSaldo()
        {
            return ValorCredito - ValorDivida;
        }

        public override string ToString()
        {
            return string.Format("Nome     : {0}\n" +
                                 "Telefone : {1}\n" +
                                 "Endereco : {2}\n" +
                                 "Credito  : {3}\n" +
                                 "Divida   : {4}\n" +
                                 "Saldo    : {5}\n" ,
                                 this.GetNome(), this.GetTelefone(), this.GetEndereco(),
                                 this.GetValorCredito(), this.GetValorDivida(), this.ObterSaldo()                                 
                                 );                             
        }
    }
}

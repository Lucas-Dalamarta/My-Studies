using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ebank
{
    public class TotalizadorDeContas
    {
        string Auxiliar;

        public string totalizaSaldo(ContaCorrente ContaC , ContaPoupanca ContaP){
            Auxiliar    +=  $"Saldo da Conta Corrente   {ContaC.getSaldo()}\n";
            Auxiliar    +=  $"Saldo da Conta Poupanca   {ContaP.getSaldo()}\n";
            Auxiliar    +=  $"Saldo total das Contas    {ContaP.getSaldo()+ContaC.getSaldo()}\n";
            return Auxiliar;
        }
    }
}
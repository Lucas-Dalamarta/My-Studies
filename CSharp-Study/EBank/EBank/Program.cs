using System;

namespace Ebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaCorr1 = new ContaCorrente();
            ContaCorrente ContaCorr2 = new ContaCorrente();
            ContaPoupanca ContaPoup1 = new ContaPoupanca();
            ContaPoupanca ContaPoup2 = new ContaPoupanca();
            TotalizadorDeContas TotContas   =   new TotalizadorDeContas();

            ContaCorr2.Depositar(548.48);
            Console.WriteLine($"Saldo CC2 {ContaCorr2.getSaldo()}");
            ContaPoup1.Depositar(100.93);
            Console.WriteLine($"Saldo CP1 {ContaPoup1.getSaldo()}");
            ContaCorr2.Transferir(10.47, ContaCorr1);
            Console.WriteLine($"Saldo CC1 {ContaCorr1.getSaldo()}");
            Console.WriteLine($"Saldo CC2 {ContaCorr2.getSaldo()}");
            Console.WriteLine(TotContas.totalizaSaldo(ContaCorr1,ContaPoup1));
            Console.ReadKey();
        }
    }
}
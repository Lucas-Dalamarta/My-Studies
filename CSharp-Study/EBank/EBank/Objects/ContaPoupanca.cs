using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ebank
{
    public class ContaPoupanca :   Conta
    {
        public override bool     Depositar(double deposito)
        {
            if ( deposito > 0 ) { saldo = deposito; }
            return deposito <= 0 ? false : true;
        }


        public   override bool    Sacar(double saque)
        {
            if (saque <= 0 || saque > this.getSaldo()){
                return false;
            }   else    {
                if (saque > 250 && !verificaSeEMaior()) {
                    return false;
                }   else    {
                    this.saldo  =  saque-0.10;
                    return  true;
                }
            }
        }
    }
}
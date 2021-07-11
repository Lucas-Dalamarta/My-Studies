using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ebank
{
    public abstract class Conta
    {
        protected   string  titular =   "";
        protected   double  saldo   =   0;
        protected   int     numero  =   0;
        protected   int     idade   =   0;


        public      string  getTitular()        { return titular;   }
        public      int     getNumero()         { return numero;    }
        public      double  getSaldo()          { return saldo;     }
        public      int     getIdade()          { return idade;     }
        protected   internal bool    verificaSeEMaior()  { return this.getIdade() >= 18 ? true : false; }


        public bool setTitular(string title)
        {
            if (!String.IsNullOrEmpty(title)){ titular = title; }
            return (!String.IsNullOrEmpty(title)) ? true: false;
        }


        public bool SetNumero(int num)  {
            if ( num > 0 ) { numero =   num; }
            return  num > 0 ? true: false;
            }


        public bool SetIdade(int age)
        {
            if ( age > 0 ) { idade = age; }
            return age <= 0 ? false : true;
        }


        public Conta()
        {
            setTitular("Luke Skywalker");
            SetNumero(1975);
            SetIdade(21);
            saldo = 0;
        }


        public Conta(int conta, string titular, int age)
        {
            setTitular(titular);
            SetNumero(conta);
            SetIdade(age);
            saldo = 0;
        }


        public virtual bool     Depositar(double deposito)
        {
            if ( deposito > 0 ) { saldo += deposito; }
            return deposito <= 0 ? false : true;
        }


        public   virtual bool    Sacar(double saque)
        {
            if (saque <= 0 || saque > this.getSaldo()){
                return false;
            }   else    {
                if (saque > 250 && !verificaSeEMaior()) {
                    return false;
                }   else    {
                    this.saldo  -=  saque;
                    return  true;
                }
            }
        }


        public   bool    Transferir(double valorTransf , Conta conta)
        {
            if (valorTransf > this.getSaldo() || valorTransf <= 0 )
            {
                return false;
            }   else    {
                this.Sacar(valorTransf);
                conta.Depositar(valorTransf);
                return true;
            }
        }
    }
}

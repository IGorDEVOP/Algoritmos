using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Conta
    {
        public string titular;
        public double saldo;
        public int numeroDaConta;

        public bool Deposita(double valor)
        {
            if (saldo >= valor)
            {
                this.saldo += valor;
                return true;
            }
            else
                return false;
        }

        public bool Saca(double valor)
        {
            if (saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
                return false;
        }

        class ContaCorrente: Conta
        {

        }
        class ContaPoupanca : Conta
        {
            public ContaPoupanca()
            {

            }
        }
       
    }
}

   

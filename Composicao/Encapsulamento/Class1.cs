using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Conta
    {
        public int numero;
        public double saldo;

        public Cliente titular;

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    }
}

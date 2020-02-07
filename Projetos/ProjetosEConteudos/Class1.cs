using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosEConteudos
{
    class Conta
    {
        public int Numero { get; set; }
        public double saldo  { get;  protected set; }
        public Cliente Titular { get; set; }

        public virtual void Saque(double valor )
        {
            this.saldo -= valor; 
        }
        public void Deposita(double valor)
        {
            this.saldo += valor; 
        }
    }

    class ContaPoupanca : Conta
    {
        public double taxa = 0.10; 
        public override void Saque(double valor)
        {
            base.Saque(valor + taxa);
        }
    }

    public class TotalizadorDeContas
    { 
    }
}

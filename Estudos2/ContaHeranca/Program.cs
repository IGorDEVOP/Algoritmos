using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca c = new ContaPoupanca();
            Conta x = new Conta();
            






            //     bool Save = c.Deposita(200);
            //     if (Save)
            //     Console.WriteLine("Deposito efetuado com Sucesso");
            //     else
            //     Console.WriteLine("Deposito não efetuado")
            //     bool Safe = c.Saca(c.saldo);
            //     if (Safe)
            //     Console.WriteLine("Saque efetuado com sucesso ");
            //     else
            //     Console.WriteLine("Saque nao efetuado");



            Console.WriteLine("numero da Conta:" + c.Numero);
            Console.WriteLine("saldo:" + c.PegaSaldo());  
            Console.ReadLine();
        }

    }
}

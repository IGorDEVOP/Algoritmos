using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosEConteudos
{
    class Heranca
    {
        static void Main(string[] args)
        {
            Conta x = new Conta();

            ContaPoupanca c = new ContaPoupanca();
            
            c.Deposita(100.0);


            Console.WriteLine();








            Console.WriteLine("Esta aplicação se encerrou. tecle enter para sair");
            Console.ReadLine();
        }
    }
}

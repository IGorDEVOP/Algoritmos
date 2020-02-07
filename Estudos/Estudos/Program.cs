using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 50;
            double valorDeSaque = 10.0;

            bool podesacar = (saldo >= valorDeSaque);

            if (podesacar)
            {
               
                saldo -= valorDeSaque;

                Console.WriteLine(saldo);
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("nao pode sacar ");
            }



            
           // Do While let go // 






            Console.WriteLine("Essa execução acabou. tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

           















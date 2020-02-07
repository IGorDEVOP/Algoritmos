using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos2
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 500;

            bool verificação = (saldo <= 0.0); 


            if (verificação)
            {
                Console.WriteLine("Voce esta no negativo");
            }
            else
            {
                Console.WriteLine("voce é um bom cliente");
            }




            Console.WriteLine("Essa aplicação se encerrou. tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

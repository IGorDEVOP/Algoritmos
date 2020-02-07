using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <= 10 )
            {

                contador += 1;

                Console.WriteLine(contador);
                

            }
            Console.WriteLine("Esta aplicação se encerrou. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

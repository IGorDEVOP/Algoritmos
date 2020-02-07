using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 ");

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
          
           
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++ )
                {
                    Console.WriteLine("*");
                    if (contadorColuna >= contadorLinha)
                        break; 
                    
                }
                Console.WriteLine();
            }







            Console.WriteLine("Essa aplicação se encerrou. tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

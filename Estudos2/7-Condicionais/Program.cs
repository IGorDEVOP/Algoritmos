using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;

            int quantidadePessoas = 2;

            bool MaiorouMenor = (idadeJoao >= 18);

            if (MaiorouMenor)
            {
                Console.WriteLine("Joao ele é maior de 18. Pode passar  ");
            }
            else
            {
                Console.WriteLine("Ele é menor de idade. chame seu responsável o de menor  ");
            }







            Console.WriteLine("Essa aplicação acabou. tecle enter para sair . . . .");
            Console.ReadLine();

        }
    }
}

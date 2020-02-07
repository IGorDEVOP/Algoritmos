using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraContinuacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento, voce terá " + valorInvestido);


            Console.WriteLine("Essa aplicação se encerrou. Tecle enter para sair");
            Console.ReadLine();


        }
    }
}

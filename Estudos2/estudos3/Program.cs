using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos3
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("Digite o nome do titular.:\n");
            conta.titular = string.Intern(Console.ReadLine());

            Console.WriteLine("Digite sua Agencia.:\n");
            conta.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Número.:\n");
            conta.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu saldo.:\n");
            conta.saldo = double.Parse(Console.ReadLine());


            Console.WriteLine("\nAgência é: " + conta.agencia);
            Console.WriteLine("\nTitular: " + conta.titular);
            Console.WriteLine("\nNúmero da Conta é: "  + conta.numero);
            Console.WriteLine("\nO seu saldo é: R$ " + conta.saldo);



            Console.WriteLine("esta aplicação se encerrou. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

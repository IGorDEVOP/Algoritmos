using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente igor = new Cliente();
            igor.nome = "IGOR";
            Cliente Douglas = new Cliente();
            Douglas.nome = "douglas";



            Conta duasConta = new Conta();
            duasConta.titular = Douglas;
            duasConta.titular.rg = "987654321-0";
            Conta umaConta = new Conta();
            umaConta.titular = igor;
            umaConta.titular.rg = "12345678-9";














            Console.WriteLine(duasConta.titular.nome);
            Console.WriteLine(duasConta.titular.rg);
            
            Console.WriteLine(umaConta.titular.nome);
            Console.WriteLine(igor.rg);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esta Aplicação se encerrou. Tecle enter para sair . . .");
            Console.ReadLine();

        }
    }
}

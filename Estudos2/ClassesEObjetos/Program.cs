using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        { 

            ContaCorrente contaDaGabriela = new ContaCorrente();
            ContaCorrente contadoIgor = new ContaCorrente();

            contadoIgor.titular = "Igor";
            contadoIgor.agencia = 683;
            contadoIgor.numero = 666999;
            contadoIgor.saldo = 100;

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 683;
            contaDaGabriela.numero = 666999;
            contaDaGabriela.saldo = 100;

            contaDaGabriela = contadoIgor;
           

            Console.WriteLine(contaDaGabriela == contadoIgor);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);




            Console.WriteLine("Essa aplicação se encerrou. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

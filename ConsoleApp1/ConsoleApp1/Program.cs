using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreMenu();
        }

        private static void ArvoreMenu()
        {

            Nodo nodo = new Nodo();
            ArvoreBoloSemanal boloSemanal = new ArvoreBoloSemanal();
            int opcao, dados;
            

            Console.Write(" Digite 1: Para inserir números na Àrvore \n" +
                "Digite 2: Listar dados\n" +
                "Digite 3: Qtd de nós internos");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                        Console.WriteLine("digite um valor para Arvore\n");
                        boloSemanal.insere(Convert.ToInt32(Console.ReadLine()));                   
                    break;

                case 2:
                     boloSemanal.Listagem();
                    break;

                case 3:
                    Console.WriteLine("Quantidade..:" + boloSemanal.qtd_nos_Internos());
                    break;

            }
            Console.ReadLine();
        }
    }
}

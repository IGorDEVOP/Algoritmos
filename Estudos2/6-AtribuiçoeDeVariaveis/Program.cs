using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoeDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        { 
            PessoaJuridica pj = new PessoaJuridica();
            PessoaFisica pf = new PessoaFisica();

            pf.setNome("igor");
            pf.setcpf("032");

            Console.WriteLine(pf.getCpf());
            Console.WriteLine(pf.getNome());
;


            Console.WriteLine("Essa aplicação acabou. Tecle entre para sair . . . ");
            Console.ReadLine();
        }
    }
}

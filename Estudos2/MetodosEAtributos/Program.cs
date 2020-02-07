using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtendo dados do usuário
            EscreveNaTela("Digite o nome do titular");
            var nomeTitular = string.Intern(Console.ReadLine());

            EscreveNaTela("Digite o numero da Conta");
            var numeroConta = int.Parse(Console.ReadLine());

            EscreveNaTela("Digite seu saldo atual...:");
            var saldoInicial = double.Parse(Console.ReadLine());

            //Criar os devidos objetos a serem manipulados
             Cliente  conta = new Cliente{ titular= nomeTitular , numeroDaConta= numeroConta , saldo= saldoInicial };

            EscreveNaTela($"Saldo Atual R${conta.saldo}");
            EscreveNaTela($"Depositando R${conta.saldo}");
            conta.Deposita(conta.saldo);
            EscreveNaTela($"Saldo após depósito R${conta.saldo}");


            EscreveNaTela($"Saque de R${conta.saldo}");
            conta.Saca(conta.saldo);
            EscreveNaTela($"Saldo após saque R${conta.saldo}");


            bool Sucesso = conta.Saca(conta.saldo);

            if (Sucesso)
                EscreveNaTela("Saque realizado com sucesso ");
            else
                EscreveNaTela("Saldo insuficiente");


            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Número Da Conta: " + conta.numeroDaConta);
            Console.WriteLine("Saldo: " + conta.saldo);
            Console.WriteLine("Esta aplicação se encerrou. Tecle enter para sair");
            Console.ReadLine();

        }
        private static void EscreveNaTela(string valor)
        {
            Console.WriteLine();
            Console.WriteLine(valor);
        }
    }
}

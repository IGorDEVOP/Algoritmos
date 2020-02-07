using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ExemploRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informacoes do Cep: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);
                Console.Write($"\n Logradouro: {address.Logradouro}," +
                $" \nBairro: {address.Bairro}," +
                $" \nCidade: {address.Localidade}," +
                $" \nUF: {address.Uf}");
                Console.ReadKey();

            }catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}

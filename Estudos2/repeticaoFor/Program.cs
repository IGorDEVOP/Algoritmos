using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new List<double>();
            salario.AddRange(new List<double>() { 200, 10, 30, 40, 50 });
            foreach (double Busca in salario)
            {
                Console.WriteLine(Busca);
                salario.Remove(Busca);
            }



            Console.WriteLine("Essa aplicação acabou. Tecle enter para ir embora otario . . . ");
            Console.ReadLine();




        }
    }

}

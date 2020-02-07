using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 9;
            
            for (int i=1; i<=50; i++)
            {
                if (i %3 ==0)
                {
                    Console.WriteLine("o numero é divisivel por 3 " + i);
                }
            }





            Console.ReadLine();

        }
    }
}

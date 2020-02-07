using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta shelly = new Conta();
            Conta SuperShock = new Conta();

            SuperShock.saldo = 4000.0;
            SuperShock.titular = "Vardil";
            SuperShock.numeroDaConta = 123456;


            shelly.saldo = 6000.0;
            shelly.titular = "Shelly";
            shelly.numeroDaConta = 321567;








            shelly.Deposita(200.0);
            Console.WriteLine("saldo:" + shelly.saldo);
            shelly.Saca(50.0);
            Console.WriteLine("Saldo.:" + shelly.saldo);

            
            Console.ReadLine();


        }
    }
}

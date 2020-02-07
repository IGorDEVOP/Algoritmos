using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    public class Pessoa 
    {
        public string Nome { get; set; }

        public void escreverNome()
        {
            Console.Write(Nome);
        }
    }
}

namespace heranca
{
    public class juridica : Pessoa
    {

        public string Cnpj { get; set; }

        public Boolean ValidarCnpj()
        {
            return this.Cnpj.Length == 14;

        }
    }




}
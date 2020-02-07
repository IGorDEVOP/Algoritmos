using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDeClasses
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;

        public Cliente titular;
     
    }
    class Conta
    {
        public Cliente titular;
      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDeApi.Models
{
    public class Cliente: IEqualityComparer<Cliente>
    {
        public string Nome { get; set; }
        public Cliente(string texto)
        {
            this.Nome = texto;
        }

        public bool Equals(Cliente x, Cliente y)
        {
           return Nome == x.Nome;
        }
        public int GetHashCode(Cliente obj)
        {
            return 1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExemploDeApi.Models;

namespace ExemploDeApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> ShowListClient()
        {
            return clientes;
        }
        [HttpPost]

        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }
        [HttpDelete]

        public void ExcluirNomeLista(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Equals(new Cliente(nome), new Cliente(nome)))));
        }
    }

}

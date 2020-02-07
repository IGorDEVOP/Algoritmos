using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2_Produtos.Models;

namespace WebApi2_Produtos.Controllers
{
    public class ProdutosController : ApiController
    {
        static readonly IProdutoRepositorio repositorio = new ProdutoRepositorio();

        public IEnumerable<Produto> GetProdutos()
        {
            return repositorio.GetAllProducts();
        }

        public Produto GetProduct(int id)
        {
            Produto item = repositorio.Get(id);
            if (item == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return item;
        }

        public IEnumerable<Produto>GetProductsByCategory(string Categoria)
        {
            //return repositorio.GetAllProducts().Where(p => string.Equals(p.Categoria, Categoria, StringComparison.OrdinalIgnoreCase));
            return repositorio.GetAllProducts().Where(p => p.Categoria.Equals(Categoria));
        }

        public HttpResponseMessage PostProduct(Produto item)
        {
            item = repositorio.Add(item);
            var Response = Request.CreateResponse(HttpStatusCode.Created, item);

            string uri = Url.Link("ProdutoApi", new { id = item.Id });
            Response.Headers.Location = new Uri(uri);
            return Response;
        }

        public void PutProduct(int id, Produto produto)
        {
            produto.Id = id;
            if (!repositorio.Update(produto))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public void DeleteProduto(int id)
        {
            Produto item = repositorio.Get(id);

            if (item == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            repositorio.Remove(id);
        }
    }
}

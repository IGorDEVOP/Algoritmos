using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2_Produtos.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Tarcisio ", Categoria = " Macho Escroto", Preco = 0.00M });
            Add(new Produto { Nome = "Kyrie V", Categoria = "Departamento Esportivo", Preco = 458.00M });
            Add(new Produto { Nome = "Iphone XR", Categoria = " Aparelhos Eletronicos", Preco = 2.900M });
            Add(new Produto { Nome = "Hellmans", Categoria = " Molhos", Preco = 10.00M });
            Add(new Produto { Nome = "Pepsi Cola", Categoria = " Refrigerantes", Preco = 4.59M });
        }

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentException("No item");
            }

            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAllProducts()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
                throw new ArgumentException("No item to Update");

            int index = produtos.FindIndex(p => p.Id == item.Id);

            if (index == -1)
                return false;

            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}
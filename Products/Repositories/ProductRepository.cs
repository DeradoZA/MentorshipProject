using Products.Models;
using Products.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        public IEnumerable<Product> GetAll() => _products;
        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id
       == id);
        public int Add(Product product)
        {
            _products.Add(product);
            return product.Id;
        }
        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
            }
        }
        public void Delete(int id) => _products.Remove(GetById(id));
    }
}

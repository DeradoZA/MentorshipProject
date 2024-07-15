using Products.Models;
using System.Collections.Generic;

namespace Products.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        int Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}

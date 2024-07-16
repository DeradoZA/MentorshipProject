
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Products.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        { }

        public virtual DbSet<Product> Products { get; set; }
    }
}

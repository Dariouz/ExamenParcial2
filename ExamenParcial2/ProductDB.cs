using Microsoft.EntityFrameworkCore;

namespace ExamenParcial2
{
    public class ProductDB : DbContext
    {
        public ProductDB(DbContextOptions<ProductDB> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}

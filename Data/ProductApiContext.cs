using Microsoft.EntityFrameworkCore;

namespace ProductApi.Data
{
    public class ProductApiContext : DbContext
    {
        public ProductApiContext(DbContextOptions<ProductApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProductApi.Model.Product> Product { get; set; } = default!;
    }
}

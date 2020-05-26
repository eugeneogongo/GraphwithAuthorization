using GraphQLWithAuthorization.Data.Entity;
using Microsoft.EntityFrameworkCore;
using SQLite.CodeFirst;


namespace GraphQLWithAuthorization.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
          
 
        }
        public DbSet<Product> Products { get; set; }
    }
}

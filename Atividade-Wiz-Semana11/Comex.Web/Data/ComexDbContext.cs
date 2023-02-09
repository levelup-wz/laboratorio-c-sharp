using Comex.Models;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data
{
    public class ComexDbContext : DbContext
    {
        public ComexDbContext(DbContextOptions<ComexDbContext> options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ComexDbContext.db");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}

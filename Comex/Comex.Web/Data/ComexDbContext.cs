using Comex.Modelos.Produtos;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data
{
    public class ComexDbContext : DbContext
    {
        public ComexDbContext(DbContextOptions<ComexDbContext> opts)
            : base(opts)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}

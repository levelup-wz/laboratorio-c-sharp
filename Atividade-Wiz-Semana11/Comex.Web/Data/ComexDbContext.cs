using Comex.Models;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data
{
    public class ComexDbContext : DbContext
    {
        public ComexDbContext(DbContextOptions<ComexDbContext> options) : base(options) 
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}

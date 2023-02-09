using Comex.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data
{
    public class ComexDbSqliteContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public ComexDbSqliteContext(DbContextOptions<ComexDbSqliteContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Comex.db");
        }

    }
}

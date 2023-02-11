using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Comex.Web.Data
{
    public class ComexDbContext : DbContext
    {
        public ComexDbContext(DbContextOptions<ComexDbContext> opts)
            : base(opts)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);
        }
    }
}

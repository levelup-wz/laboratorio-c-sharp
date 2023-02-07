using Comex.Models;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) 
    {
        options.UseSqlite("Data Source=app.db");
    }
}

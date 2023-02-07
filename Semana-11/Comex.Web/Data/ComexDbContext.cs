using Comex.Models;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Data;

public class ComexDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

	public ComexDbContext(DbContextOptions<ComexDbContext> options): base(options)
	{

	}
}

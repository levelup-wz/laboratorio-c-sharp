using Comex.Modelos.Categorias;

namespace Comex.Web.Data.Dtos;

public class LerProdutoDto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public Categoria Categoria { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}

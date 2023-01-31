using Comex.Modelos.Categorias;

namespace Comex.Web.Data.DTOs;

public class LerProdutoDTO
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public Categoria Categoria { get; set; }
}

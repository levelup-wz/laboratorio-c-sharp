using Comex.Modelos.Categorias;
using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dtos;

public class CriarProdutoDto
{
    [Required(ErrorMessage = "Nome do produto é obrigatório")]
    [MinLength(3, ErrorMessage = "Nome deve ser maior que 3 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Preço obrigatório")]
    [Range(0, double.MaxValue, ErrorMessage = "Preço unitário deve ser maior que 0")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "Estoque obrigatório")]
    [Range(0, double.MaxValue, ErrorMessage = "Quantidade em estoque deve ser maior que 0")]
    public int Estoque { get; set; }

    [Required(ErrorMessage = "Categoria obrigatória")]
    public Categoria Categoria { get; set; }
}

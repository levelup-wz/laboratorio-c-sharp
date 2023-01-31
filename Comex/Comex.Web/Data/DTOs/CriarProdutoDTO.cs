using Comex.Modelos.Categorias;
using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.DTOs;

public class CriarProdutoDTO
{
    [Required(ErrorMessage = "Nome do produto é obrigatório")]
    [MinLength(3, ErrorMessage = "Nome deve ser maior que 3 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Preço obrigatório")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "Estoque obrigatório")]
    public int Estoque { get; set; }

    [Required(ErrorMessage = "Categoria obrigatória")]
    public Categoria Categoria { get; set; }
}

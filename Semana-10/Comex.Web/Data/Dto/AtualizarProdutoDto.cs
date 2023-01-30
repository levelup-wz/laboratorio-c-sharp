using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dto;

public class AtualizarProdutoDto
{
    [MinLength(6, ErrorMessage = "O nome deve ter no mínimo 6 caracteres")]
    public string Nome { get; set; }

    [Range(0.01, double.PositiveInfinity, ErrorMessage = "O preço unitário deve ser maior que 0 ")]
    public double PrecoUnitario { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "A quantidade em estoque deve ser maior que 0 ")]
    public int QuantidadeEmEstoque { get; set; }

    [MinLength(6)]
    public string Categoria { get; set; }
}

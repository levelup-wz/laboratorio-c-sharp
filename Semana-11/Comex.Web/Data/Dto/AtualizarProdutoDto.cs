using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dto;

public class AtualizarProdutoDto
{
    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [MinLength(6, ErrorMessage = "O nome deve ter no mínimo 6 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O preço unitário do produto é obrigatório")]
    [MinLength(6, ErrorMessage = "A descricao deve ter no mínimo 6 caracteres")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O preço unitário do produto é obrigatório")]
    [Range(0.01, double.PositiveInfinity, ErrorMessage = "O preço unitário deve ser maior que 0 ")]
    public double PrecoUnitario { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque do produto é obrigatória")]
    [Range(1, int.MaxValue, ErrorMessage = "A quantidade em estoque deve ser maior que 0 ")]
    public int QuantidadeEmEstoque { get; set; }

    [Required(ErrorMessage = "A categoria do produto é obrigatória")]
    [MinLength(6)]
    public string Categoria { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Models;

public class Produto
{
    [Key]
    [Required]
    public int Id { get; internal set; }

    [Required (ErrorMessage = "O nome do produto deve possuir no mínimo 5 caracteres")]
    [MinLength(5)]
    public string Nome { get; set; }

    [Required (ErrorMessage = "O preço unitário deve ser maior que 0 (zero)")]
    [Range(0.01, double.MaxValue)]
    public double PrecoUnitario { get; set; }

    [Required (ErrorMessage = "A quantidade em estoque deve ser maior que 0 (zero)")]
    [Range(1, int.MaxValue)]
    public int QuantidadeEmEstoque { get; set; }

    [Required (ErrorMessage = "A categoria é obrigatória")]
    public string Categoria { get; set; }
}
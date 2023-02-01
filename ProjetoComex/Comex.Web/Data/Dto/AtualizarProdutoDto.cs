using Comex.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dto
{
    public class AtualizarProdutoDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "O Nome deve ter mais de 5 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Preço Unitário deve ser maior que ZERO")]
        public double PrecoUnitario { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantidade em Estoque deve ser maior que ZERO")]
        public int QuantidadeEstoque { get; set; }

        [Required]
        public string Categoria { get; set; }
    }
}

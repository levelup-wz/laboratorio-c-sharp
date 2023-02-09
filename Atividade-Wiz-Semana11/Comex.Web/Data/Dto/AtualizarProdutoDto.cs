using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dto
{
    public class AtualizarProdutoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigátório")]
        [MinLength(5, ErrorMessage = "O Nome não pode ter menonos de 5 caracteres")]
        public string Nome { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "O Preço Unitário deve ser maior quer 0 (ZERO)")]
        public decimal PrecoUnitario { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "A Quantidade em Estoque deve ser maior quer 0 (ZERO)")]
        public int QuantidadeEmEstoque { get; set; }
        [Required(ErrorMessage = "O campo Categoria é obrigátório")]
        public string Categoria { get; set; }
    }
}

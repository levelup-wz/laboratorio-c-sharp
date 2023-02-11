using System.ComponentModel.DataAnnotations;
using Comex.Models;

namespace Comex.Web.Data.Dto
{
    public class CriarProdutoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome do produto deve ter mais de 5 caracteres")]
        [MinLength(5)]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O valor não pode ser igual a zero")]
        [Range(0.01, double.MaxValue)]
        public double PrecoUnitario { get; set; }

        [Required(ErrorMessage ="O estoque deve ser maior que zero")]
        [Range(1, int.MaxValue)]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="A categoria deve ser preenchida")]
        public string Categoria { get; set; }
        
    }
}

using Comex.Entidades;

namespace Comex.Web.Data.Dto
{
    public class ProdutoDto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEstoque { get; private set; }
        public Categoria Categoria { get; set; }
    }
}

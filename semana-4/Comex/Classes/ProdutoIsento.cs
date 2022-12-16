namespace Comex
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, string descricao, double precoUnitario, int quantidadeEmEstoque, Categoria categoria) : base(nome, descricao, precoUnitario, quantidadeEmEstoque, categoria)
        {
        }

        public override double CalcularImposto()
        {
            return 0;
        }
    }
}

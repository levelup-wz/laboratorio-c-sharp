namespace Comex
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria) : base(nome, precoUnitario, quantidadeEmEstoque, categoria)
        {

        }

        public override double CalculaImposto()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.InformacoesDoProduto();
        }
    }


}

namespace Comex.Models
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, decimal precoUnitario, int quantidadeEmEstoque, string categoria, string atributos) : base(nome, precoUnitario, quantidadeEmEstoque, categoria, atributos)
        {
        }

        public ProdutoIsento(int id, string nome, decimal precoUnitario, int quantidadeEmEstoque, string categoria) : base(nome, precoUnitario, quantidadeEmEstoque, categoria)
        {
        }

        public override decimal CalculaImposto()
        {
            return 0;
        }
    }
}

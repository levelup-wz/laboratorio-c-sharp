namespace Comex.Models
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria, string atributos) : base(nome, preco_Unitario, quantidade_Em_Estoque, categoria, atributos)
        {
        }

        public ProdutoIsento(int id, string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria) : base(id, nome, preco_Unitario, quantidade_Em_Estoque, categoria)
        {
        }

        public override double CalculaImposto()
        {
            return 0;
        }
    }
}

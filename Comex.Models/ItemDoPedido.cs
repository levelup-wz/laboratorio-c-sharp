namespace Comex.Models
{
    public class ItemDoPedido
    {
        public ItemDoPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
        public Produto Produto { get; private set; }

        public int Quantidade { get; set; }

        public decimal Total => this.Produto.PrecoUnitario * Quantidade;
    }
}

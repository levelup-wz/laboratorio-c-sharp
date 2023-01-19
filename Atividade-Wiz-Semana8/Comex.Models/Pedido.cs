namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 1;
        public int Id { get; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; }
        public List<ItemsDoPedido> Items { get; }
        public double QuantidadeVendida { get; }

        public Pedido(Cliente cliente, ItemsDoPedido itemsDoPedido, double quantidadeVendida)
        {
            Id = _id++;
            Cliente = cliente;
            QuantidadeVendida = quantidadeVendida;
            Items = new List<ItemsDoPedido> { itemsDoPedido };
        }

        public int DefineId()
        {
            return Id;
        }

        public virtual double CalculaValorTotal()
        {
            var valorTotal = 0;

            foreach (ItemsDoPedido item in Items)
            {
                valorTotal = valorTotal + (int)item.Total;
            }

            return valorTotal;
        }

        public double CalculaTotalDeImpostos()
        {
            var totalDeImpostos = 0;

            foreach (ItemsDoPedido item in Items)
            {
                totalDeImpostos = totalDeImpostos + (int)(QuantidadeVendida * item.Produto.CalculaImposto());
            }

            return totalDeImpostos;
        }
    }
}

namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 1;
        public int Id { get; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; }
        public List<ItemsDoPedido> Items { get; private set; }
        public int QuantidadeVendida { get; }

        public Pedido(Cliente cliente, List<ItemsDoPedido> itemsDoPedido, int quantidadeVendida)
        {
            Id = _id++;
            Cliente = cliente;
            QuantidadeVendida = quantidadeVendida;

            Items = new List<ItemsDoPedido>();
            Items.AddRange(itemsDoPedido);
        }

        public int DefineId()
        {
            return Id;
        }

        public virtual decimal CalculaValorTotal()
        {
            // (.Sum) Computa a soma de uma sequência de valores numéricos.
            return Items.Sum(x => x.Total);
        }

        public decimal CalculaTotalDeImpostos()
        {
            var totalDeImpostos = 0;

            foreach (ItemsDoPedido item in Items)
            {
                totalDeImpostos = totalDeImpostos + (int)(QuantidadeVendida * item.Produto.CalculaImposto());
            }

            return Items.Sum(x => (int)QuantidadeVendida * x.Produto.CalculaImposto());
        }

        public void RemoverItems(string nome)
        {
            string itemToRemove = nome;
            Items.RemoveAll(x => x.Produto.Nome == itemToRemove);
        }
        public void EditaQuantidadeDeItems(string nome, int quantidade)
        {
            var edita = Items.FirstOrDefault(x => x.Produto.Nome == nome);

            if(edita != null)
                edita.Quantidade = quantidade;
        }

        public void Adicionar(ItemsDoPedido item)
        {
            Items.Add(item);
        }

        public void Modificar(ItemsDoPedido item)
        {
            var edita = Items.FirstOrDefault(x => x.Produto.Nome == item.Produto.Nome);

            if (edita != null)
                edita = item;
        }
    }
}

namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 1;
        public int Id { get; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; }
        public List<ItensDoPedido> Itens { get; private set; }
        public int QuantidadeVendida { get; }

        public Pedido(Cliente cliente, List<ItensDoPedido> itemsDoPedido, int quantidadeVendida)
        {
            Id = _id++;
            Cliente = cliente;
            QuantidadeVendida = quantidadeVendida;

            Itens = new List<ItensDoPedido>();
            Itens.AddRange(itemsDoPedido);
        }

        public int DefineId()
        {
            return Id;
        }

        public virtual decimal CalculaValorTotal()
        {
            // (.Sum) Computa a soma de uma sequência de valores numéricos.
            return Itens.Sum(x => x.Total);
        }

        public decimal CalculaTotalDeImpostos()
        {
            var totalDeImpostos = 0;

            foreach (ItensDoPedido item in Itens)
            {
                totalDeImpostos = totalDeImpostos + (int)(QuantidadeVendida * item.Produto.CalculaImposto());
            }

            return Itens.Sum(x => (int)QuantidadeVendida * x.Produto.CalculaImposto());
        }

        public void RemoverItems(string nome)
        {
            string itemToRemove = nome;
            Itens.RemoveAll(x => x.Produto.Nome == itemToRemove);
        }
        public void EditaQuantidadeDeItems(string nome, int quantidade)
        {
            var edita = Itens.FirstOrDefault(x => x.Produto.Nome == nome);

            if(edita != null)
                edita.Quantidade = quantidade;
        }

        public void Adicionar(ItensDoPedido item)
        {
            Itens.Add(item);
        }

        public void Modificar(ItensDoPedido item)
        {
            var edita = Itens.FirstOrDefault(x => x.Produto.Nome == item.Produto.Nome);

            if (edita != null)
                edita = item;
        }
    }
}

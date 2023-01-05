namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 1;
        public int Id { get; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; }
        public Produto Produto { get; }
        public double QuantidadeVendida { get; }

        public Pedido(Cliente cliente, Produto produto, double quantidade_vendida)
        {
            Id = _id++;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida = quantidade_vendida;
        }

        public int DefineId()
        {
            return Id;
        }

        public virtual double CalculaValorTotal()
        {
            double resultado = Produto.PrecoUnitario * QuantidadeVendida;
            return resultado;
        }

        public double CalculaTotalDeImpostos()
        {
            double resultado = QuantidadeVendida * Produto.CalculaImposto();
            return resultado;
        }
    }
}

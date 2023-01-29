using NumericWordsConversion;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; private set; }
        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
        }

        public override string ToString()
        {
            CurrencyWordsConverter converter = new CurrencyWordsConverter();
            return converter.ToWords((decimal)Pedido.ValorTotal());
        }
    }
}

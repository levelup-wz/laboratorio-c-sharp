using NumericWordsConversion;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal static Pedido? Pedido { get; set; }
        public static string? NumeroExtenso { get; set; }

        public static void RegistraPedido(Pedido pedido)
        {
            NumericWordsConverter numericWordsConverter = new();
            NumeroExtenso = numericWordsConverter.ToWords((decimal)pedido.CalculaValorTotal());

            Console.WriteLine($"Nome do cliente: {pedido.Cliente.NomeCompleto()}"); 
            Console.WriteLine($"Data de compra: {pedido.Data}");
            Console.WriteLine($"Total do pedido: R$ {pedido.CalculaValorTotal():N2} = {NumeroExtenso}"); 
        }
    }
}
using NumericWordsConversion;
using NumerosExtensos;
using NumerosExtensos.Enums;

namespace Comex.Models.Models
{
    public class NotaFiscal
    {
        internal static Pedido? Pedido { get; set; }
        public static string? ExtensoNumero { get; set; }

        public static void RegistraPedido(Pedido pedido)
        {
            NumericWordsConverter numericWordsConverter = new();
            ExtensoNumero = numericWordsConverter.ToWords((decimal)pedido.CalculaValorTotal());
            var meuNumero = pedido.CalculaValorTotal();
            Extenso extenso = new();
            var escrever = extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]);
            var numeroPorExtenso = escrever.Numero(meuNumero.ToString());

            Console.WriteLine($"Nome do cliente: {pedido.Cliente.NomeCompleto()}");
            Console.WriteLine($"Data de compra: {pedido.Data}");
            Console.WriteLine($"Total do pedido: US$ {pedido.CalculaValorTotal()} = {ExtensoNumero}");
            Console.WriteLine($"Total do pedido: R$ {pedido.CalculaValorTotal():N2} = {numeroPorExtenso}");

        }
    }
}
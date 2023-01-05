using NumericWordsConversion;
using NumerosExtensos;
using NumerosExtensos.Enums;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }
        public string ExtensoNumero { get; set; }

        public NotaFiscal(Pedido pedido) 
        {
            Pedido = pedido;
            NumericWordsConverter numericWordsConverter = new();
            ExtensoNumero = numericWordsConverter.ToWords((decimal)pedido.CalculaValorTotal());
        }

        public void RegistraPedido()
        {
            var meuNumero = Pedido.CalculaValorTotal();
            Extenso extenso = new();
            var escrever = extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]);
            var numeroPorExtenso = escrever.Numero(meuNumero.ToString());

            Console.WriteLine($"Nome do cliente: {Pedido.Cliente.NomeCompleto()}"); 
            Console.WriteLine($"Data de compra: {Pedido.Data}");
            Console.WriteLine($"Total do pedido: US$ {Pedido.CalculaValorTotal()} = {ExtensoNumero}");
            Console.WriteLine($"Total do pedido: R$ {Pedido.CalculaValorTotal():N2} = {numeroPorExtenso}");

        }
    }
}
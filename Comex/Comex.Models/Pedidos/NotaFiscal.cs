using NumerosExtensos;
using NumerosExtensos.Enums;
using System;

namespace Comex.Pedidos
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }

        public NotaFiscal(Pedido pedido) 
        {
            Pedido = pedido;
        }

        public string ValorPorExtenso()
        {
            Extenso extenso = new Extenso();
            var valor = extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]);
            return valor.Numero(Pedido.CalculaValorTotal().ToString());
        }

        public string GetNotaFiscal()
        {
            return $"Cliente: {Pedido.Cliente.NomeCompleto()} \nValor: {Pedido.CalculaValorTotal()}" +
                $" - {ValorPorExtenso()} \nData: {Pedido.Data}";
        }
    }
}

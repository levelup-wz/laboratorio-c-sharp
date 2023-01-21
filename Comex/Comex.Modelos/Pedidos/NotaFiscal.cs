using NumerosExtensos;
using NumerosExtensos.Enums;
using System;

namespace Comex.Modelos.Pedidos
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
            return valor.Numero(Pedido.CalculaCustoTotal().ToString());
        }

        public string GetNotaFiscal()
        {
            return $"Cliente: {Pedido.Cliente.NomeCompleto()} \nValor: {Pedido.CalculaCustoTotal()}" +
                $" - {ValorPorExtenso()} \nData: {Pedido.Data}";
        }
    }
}

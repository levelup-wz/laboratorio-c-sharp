using NumerosExtensos;
using NumerosExtensos.Enums;
using System;

namespace Comex.Modelos.Pedidos;

public class NotaFiscal
{
    internal Pedido Pedido { get; private set; }

    public NotaFiscal(Pedido pedido) 
    {
        Pedido = pedido;
    }

    public void AlterarPedido(Pedido pedido)
    {
        Pedido = pedido;
    }

    public string ValorPorExtenso()
    {
        Extenso extenso = new Extenso();
        var valor = extenso.Escrever(OpcoesPredefinidas.Predefinicoes[Predefinicoes.MonetarioBRL]);
        return valor.Numero(Pedido.CalculaCustoTotal().ToString());
    }

    public override string ToString()
    {
        return $"Valor: R${Pedido.CalculaCustoTotal()} \n{ValorPorExtenso()}";
    }
}

using System;
using System.Linq;
using Comex.Modelos.Clientes;

namespace Comex.Modelos.Pedidos;

public class Pedido
{
    public Pedido(string data, Cliente cliente, string cep, params ItensDoPedido[] itens)
    {
        Id = Quantidade++;
        Itens = new List<ItensDoPedido>();
        Itens.AddRange(itens);
        Data = data;
        Cliente = cliente;
        Nota = new NotaFiscal(this);
        Cep = cep;
        FretePedido = Frete.Calcular(cep);
        IndentificarItens();
    }

    public static int Quantidade { get; private set; }
    public int Id { get; private set; }
    public string Cep { get; private set; }
    public string Data { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItensDoPedido> Itens { get; set; }
    public int QuantidadeVendida => Itens.Sum(item => item.Quantidade);
    public NotaFiscal Nota { get; }
    public decimal FretePedido { get; }
    public decimal CalculaValorTotal => Itens.Sum(item => item.Total);
    public decimal CalculaTotalImposto => Itens.Sum(item => item.Item.CalculaImposto * item.Quantidade);
    public decimal CalculaCustoTotal => CalculaValorTotal + CalculaTotalImposto + FretePedido;

    public void RemoverItens(int id)
    {
        Itens.RemoveAll(item => item.Id == id);
        IndentificarItens();
    }

    public void AlterarQuantidade(int id, int quantidade)
    {
        var item = Itens.First(item => item.Id == id);
        item.Quantidade = quantidade;
    }

    private void IndentificarItens()
    {
        for (int i = 0; i < Itens.Count; i++) Itens[i].Id = i + 1;
    }
}

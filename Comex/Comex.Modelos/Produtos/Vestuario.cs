using Comex.Modelos.Categorias;
using Comex.Modelos.Extensions;
using System;

namespace Comex.Modelos.Produtos;

public class Vestuario : Produto
{
    public static new int Quantidade { get; private set; }
    public string Tamanho { get; }
    public string Cor { get; }

    public Vestuario(string nome, string descricao, decimal preco, int estoque, Categoria categoria, string atributos)
        : base(nome, descricao, preco, estoque, categoria)
    {
        Atributos = atributos;

        Tamanho = this.ExtrairTamanho(atributos);
        Cor = this.ExtrairCor(atributos);
    }

    public override string ToString()
    {
        return base.ToString() + $"\nCor: {Cor} - Tamanho: {Tamanho}";
    }
}
